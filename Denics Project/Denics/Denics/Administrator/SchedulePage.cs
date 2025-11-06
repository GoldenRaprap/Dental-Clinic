using Denics;
using Denics.Administrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SchedulePage : Form
    {
        // Use CallDatabase instance to retrieve the connection string
        private readonly string _connectionString = new CallDatabase().getDatabaseStringName();

        private readonly string[] _dayNames = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        // Eight rows/hours by default (change as needed)
        private readonly TimeSpan[] _hours = {
            TimeSpan.Parse("09:00"), TimeSpan.Parse("10:00"), TimeSpan.Parse("11:00"), TimeSpan.Parse("12:00"),
            TimeSpan.Parse("13:00"), TimeSpan.Parse("14:00"), TimeSpan.Parse("15:00"), TimeSpan.Parse("16:00")
        };

        private const int MinHeaderHeight = 4;

        public SchedulePage()
        {
            InitializeComponent();
            // center the page on screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Event wiring
            this.Load += SchedulePage_Load;
            btnView.Click += btnView_Click;
            btnSave.Click += btnSave_Click;

            // Ensure single subscription to CellClick
            scheduleGrid.CellClick -= scheduleGrid_CellClick;
            scheduleGrid.CellClick += scheduleGrid_CellClick;

            UpcommingClosedStore_dtgrd.SelectionChanged -= UpcommingClosedStore_dtgrd_SelectionChanged;
            UpcommingClosedStore_dtgrd.SelectionChanged += UpcommingClosedStore_dtgrd_SelectionChanged;
            UpcommingClosedStore_dtgrd.CellClick -= UpcommingClosedStore_dtgrd_CellClick;
            UpcommingClosedStore_dtgrd.CellClick += UpcommingClosedStore_dtgrd_CellClick;
        }

        private void SchedulePage_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureGrid();
                PopulateEmptyGrid();
                LoadDate();

                // hide headers and time column visually but keep model intact
                scheduleGrid.ColumnHeadersVisible = false;
                if (scheduleGrid.Columns.Contains("Time"))
                    scheduleGrid.Columns["Time"].Visible = false;

                // defensive: ensure header height is valid
                scheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                scheduleGrid.ColumnHeadersHeight = Math.Max(MinHeaderHeight, scheduleGrid.ColumnHeadersHeight);

                LoadIntoDoctorsComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            scheduleGrid.AllowUserToAddRows = false;
            scheduleGrid.AutoGenerateColumns = false;
            scheduleGrid.RowHeadersVisible = false;
            scheduleGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            scheduleGrid.MultiSelect = false;
            scheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            scheduleGrid.Columns.Clear();

            // Time column (kept for indexing / hour values — hidden later)
            var timeCol = new DataGridViewTextBoxColumn
            {
                Name = "Time",
                HeaderText = "Time",
                DataPropertyName = "Time",
                ReadOnly = true,
                Width = 80,
                Frozen = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            scheduleGrid.Columns.Add(timeCol);

            // Day columns
            foreach (var d in _dayNames)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    Name = d,
                    HeaderText = d,
                    DataPropertyName = d,
                    ReadOnly = true, // keep read-only so users cannot type; programmatic updates still allowed
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                scheduleGrid.Columns.Add(col);
            }

            scheduleGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            scheduleGrid.Columns["Time"].Resizable = DataGridViewTriState.False;
            scheduleGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        // load Date table to datagrid named UpcommingClosedStore_dtgrd
        private void LoadDate()
        {
            try
            {
                using SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                // Select upcoming dates that are marked "Closed", ordered from nearest to furthest
                string sql = @"
                    SELECT [day], [day_avaialbility]
                    FROM [Date]
                    WHERE [day_avaialbility] = @status
                      AND [day] >= @today
                    ORDER BY [day] ASC";

                using var cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@status", "Closed");
                cmd.Parameters.AddWithValue("@today", DateTime.Today);

                using var sda = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                sda.Fill(dt);

                UpcommingClosedStore_dtgrd.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dates: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateEmptyGrid()
        {
            var dt = new DataTable();
            dt.Columns.Add("Time", typeof(string));
            foreach (var d in _dayNames) dt.Columns.Add(d, typeof(string));

            // Use exactly _hours.Length rows
            foreach (var h in _hours)
            {
                var row = dt.NewRow();
                row["Time"] = h.ToString(@"hh\:mm");
                foreach (var d in _dayNames) row[d] = "";
                dt.Rows.Add(row);
            }

            scheduleGrid.DataSource = dt;

            // style Time column if shown later
            if (scheduleGrid.Columns.Contains("Time"))
            {
                scheduleGrid.Columns["Time"].DefaultCellStyle.BackColor = Color.LightGray;
                scheduleGrid.Columns["Time"].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            }

            InitCellTagsToZero();
            // keep grid read-only for users
            MakeDayColumnsReadOnly();
        }

        private void InitCellTagsToZero()
        {
            if (scheduleGrid.Rows == null) return;
            for (int r = 0; r < scheduleGrid.Rows.Count; r++)
            {
                if (scheduleGrid.Rows[r].IsNewRow) continue;
                for (int c = 0; c < scheduleGrid.Columns.Count; c++)
                    scheduleGrid[c, r].Tag = 0;
            }
        }

        private void MakeDayColumnsReadOnly()
        {
            foreach (DataGridViewColumn col in scheduleGrid.Columns)
                col.ReadOnly = true;
            scheduleGrid.CurrentCell = null;
        }

        private void LoadIntoDoctorsComboBox()
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand("SELECT doctor_id, full_name FROM Doctors ORDER BY full_name", con))
                {
                    var adapter = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    comboBoxDoctors.DataSource = dt;
                    comboBoxDoctors.DisplayMember = "full_name";
                    comboBoxDoctors.ValueMember = "doctor_id";
                    comboBoxDoctors.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load doctors: " + ex.ToString(), "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cell click cycles 0 -> 1 -> 2 -> 3 -> 0
        private void scheduleGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                var col = scheduleGrid.Columns[e.ColumnIndex];
                if (col == null || string.Equals(col.Name, "Time", StringComparison.OrdinalIgnoreCase)) return;

                var cell = scheduleGrid[e.ColumnIndex, e.RowIndex];
                if (cell == null) return;

                int state = 0;
                if (cell.Tag is int si) state = si;
                else if (cell.Tag is string ss && int.TryParse(ss, out var pi)) state = pi;

                state = (state + 1) % 4;

                switch (state)
                {
                    case 1: cell.Value = "Available"; break;
                    case 2: cell.Value = "On Break"; break;
                    case 3: cell.Value = "Not Available"; break;
                    default: cell.Value = ""; break;
                }

                ApplyCellStyleByStatus(cell, cell.Value?.ToString() ?? "");
                cell.Tag = state;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cell click error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyCellStyleByStatus(DataGridViewCell cell, string status)
        {
            switch (status)
            {
                case "Available":
                    cell.Style.BackColor = Color.Green; cell.Style.ForeColor = Color.White; break;
                case "On Break":
                    cell.Style.BackColor = Color.Blue; cell.Style.ForeColor = Color.White; break;
                case "Not Available":
                    cell.Style.BackColor = Color.Red; cell.Style.ForeColor = Color.White; break;
                default:
                    cell.Style.BackColor = Color.White; cell.Style.ForeColor = Color.Black; break;
            }
        }

        // btnView: load DB schedule into grid
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDoctors.SelectedValue == null || comboBoxDoctors.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a doctor first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!int.TryParse(comboBoxDoctors.SelectedValue.ToString(), out int doctorId))
                {
                    MessageBox.Show("Invalid doctor selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var cmdText = "SELECT day_of_week, hour_slot, status, is_blocked FROM Availability WHERE doctor_id = @doctorId";
                var scheduleDict = new Dictionary<(string day, TimeSpan hour), (string status, bool isBlocked)>(new DayTimeComparer());

                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.Add("@doctorId", System.Data.SqlDbType.Int).Value = doctorId;
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var rawDay = rdr.IsDBNull(0) ? "" : rdr.GetString(0);
                            TimeSpan hourSlot = TimeSpan.Zero;
                            if (!rdr.IsDBNull(1))
                            {
                                try { hourSlot = rdr.GetTimeSpan(1); }
                                catch { TimeSpan.TryParse(rdr.GetValue(1).ToString(), out hourSlot); }
                            }
                            var status = rdr.IsDBNull(2) ? "" : rdr.GetString(2);
                            var isBlocked = !rdr.IsDBNull(3) && rdr.GetBoolean(3);

                            var dayNormalized = NormalizeDayName(rawDay);
                            if (dayNormalized == null) continue;
                            scheduleDict[(dayNormalized, hourSlot)] = (status, isBlocked);
                        }
                    }
                }

                // Clear grid and fill based on lookup
                var dt = scheduleGrid.DataSource as DataTable;
                if (dt == null) return;

                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    foreach (var day in _dayNames) dt.Rows[r][day] = "";
                }

                for (int r = 0; r < _hours.Length && r < scheduleGrid.Rows.Count; r++)
                {
                    var hour = _hours[r];
                    for (int c = 0; c < _dayNames.Length; c++)
                    {
                        var colIndex = 1 + c;
                        if (scheduleDict.TryGetValue((_dayNames[c], hour), out var entry))
                        {
                            var statusValue = entry.status ?? "";
                            if (entry.isBlocked && string.IsNullOrWhiteSpace(statusValue)) statusValue = "Not Available";
                            scheduleGrid[colIndex, r].Value = statusValue;
                            ApplyCellStyleByStatus(scheduleGrid[colIndex, r], statusValue);
                            scheduleGrid[colIndex, r].Tag = StatusToClickCount(statusValue);
                        }
                        else
                        {
                            scheduleGrid[colIndex, r].Value = "";
                            scheduleGrid[colIndex, r].Style.BackColor = Color.White;
                            scheduleGrid[colIndex, r].Style.ForeColor = Color.Black;
                            scheduleGrid[colIndex, r].Tag = 0;
                        }
                    }
                }

                // Defensive: reinitialize tags/read-only state
                InitCellTagsToZero();
                MakeDayColumnsReadOnly();
            }
            catch (Exception ex)
            {
                MessageBox.Show("View error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int StatusToClickCount(string status)
        {
            return status switch
            {
                "Available" => 1,
                "On Break" => 2,
                "Not Available" => 3,
                _ => 0,
            };
        }

        // Robust save: uses actual grid rows/columns, skips invalid indexes and new rows
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDoctors.SelectedValue == null || comboBoxDoctors.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a doctor first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!int.TryParse(comboBoxDoctors.SelectedValue.ToString(), out int doctorId))
                {
                    MessageBox.Show("Invalid doctor selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var rowsToSave = new List<(TimeSpan hour, string day, string status, bool isBlocked)>();

                bool hasTimeColumn = scheduleGrid.Columns.Contains("Time");
                int firstDayColIndex = hasTimeColumn ? 1 : 0;

                for (int r = 0; r < scheduleGrid.Rows.Count; r++)
                {
                    var gridRow = scheduleGrid.Rows[r];
                    if (gridRow.IsNewRow) continue;

                    // determine hour for this row
                    TimeSpan hourSlot = TimeSpan.Zero;
                    bool haveHour = false;
                    if (hasTimeColumn)
                    {
                        var timeCell = scheduleGrid["Time", r];
                        if (timeCell != null && timeCell.Value != null)
                        {
                            var tsStr = timeCell.Value.ToString();
                            if (TimeSpan.TryParse(tsStr, out var parsed) || TimeSpan.TryParseExact(tsStr, new[] { @"hh\:mm", @"hh\:mm\:ss" }, null, out parsed))
                            {
                                hourSlot = parsed;
                                haveHour = true;
                            }
                        }
                    }
                    else
                    {
                        if (r < _hours.Length) { hourSlot = _hours[r]; haveHour = true; }
                    }

                    for (int c = firstDayColIndex; c < scheduleGrid.Columns.Count; c++)
                    {
                        var col = scheduleGrid.Columns[c];
                        if (col == null) continue;
                        if (string.Equals(col.Name, "Time", StringComparison.OrdinalIgnoreCase)) continue;
                        if (r < 0 || r >= scheduleGrid.Rows.Count || c < 0 || c >= scheduleGrid.Columns.Count) continue;

                        var cell = scheduleGrid[c, r];
                        if (cell == null) continue;

                        var status = (cell.Value ?? "").ToString().Trim();
                        bool isBlocked = string.Equals(status, "Not Available", StringComparison.OrdinalIgnoreCase);

                        // skip empty cells if you don't want to store them
                        if (string.IsNullOrEmpty(status) && !isBlocked) continue;

                        // if no hour available, derive or skip; here we skip rows without reliable hour
                        if (!haveHour) continue;

                        rowsToSave.Add((hourSlot, col.Name, status, isBlocked));
                    }
                }

                // Save to DB inside a transaction (DELETE then INSERT)
                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var delCmd = new SqlCommand("DELETE FROM Availability WHERE doctor_id = @doc", conn, tran))
                            {
                                delCmd.Parameters.Add("@doc", System.Data.SqlDbType.Int).Value = doctorId;
                                delCmd.ExecuteNonQuery();
                            }

                            using (var ins = new SqlCommand(
                                "INSERT INTO Availability (doctor_id, day_of_week, hour_slot, status, is_blocked) VALUES (@doc, @day, @hour, @status, @isBlocked)",
                                conn, tran))
                            {
                                ins.Parameters.Add(new SqlParameter("@doc", System.Data.SqlDbType.Int));
                                ins.Parameters.Add(new SqlParameter("@day", System.Data.SqlDbType.NVarChar, 50));
                                ins.Parameters.Add(new SqlParameter("@hour", System.Data.SqlDbType.Time));
                                ins.Parameters.Add(new SqlParameter("@status", System.Data.SqlDbType.NVarChar, 200));
                                ins.Parameters.Add(new SqlParameter("@isBlocked", System.Data.SqlDbType.Bit));

                                foreach (var r in rowsToSave)
                                {
                                    ins.Parameters["@doc"].Value = doctorId;
                                    ins.Parameters["@day"].Value = r.day;
                                    ins.Parameters["@hour"].Value = r.hour;
                                    ins.Parameters["@status"].Value = r.status ?? "";
                                    ins.Parameters["@isBlocked"].Value = r.isBlocked ? 1 : 0;
                                    ins.ExecuteNonQuery();
                                }
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Schedule saved to Availability table successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NormalizeDayName(string rawDay)
        {
            if (string.IsNullOrWhiteSpace(rawDay)) return null;
            var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "sun", "Sunday" }, { "sunday", "Sunday" },
                { "mon", "Monday" }, { "monday", "Monday" },
                { "tue", "Tuesday" }, { "tues", "Tuesday" }, { "tuesday", "Tuesday" },
                { "wed", "Wednesday" }, { "wednesday", "Wednesday" },
                { "thu", "Thursday" }, { "thur", "Thursday" }, { "thursday", "Thursday" },
                { "fri", "Friday" }, { "friday", "Friday" },
                { "sat", "Saturday" }, { "saturday", "Saturday" }
            };
            return map.TryGetValue(rawDay.Trim(), out var full) ? full : null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDoctors.SelectedValue == null || comboBoxDoctors.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a doctor first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!int.TryParse(comboBoxDoctors.SelectedValue.ToString(), out int doctorId))
                {
                    MessageBox.Show("Invalid doctor selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show("Clear this doctor's schedule to default and save the change?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                var dt = scheduleGrid.DataSource as DataTable;
                if (dt != null)
                {
                    for (int r = 0; r < dt.Rows.Count && r < scheduleGrid.Rows.Count; r++)
                    {
                        foreach (var day in _dayNames) dt.Rows[r][day] = "";
                    }
                }

                for (int r = 0; r < scheduleGrid.Rows.Count; r++)
                {
                    if (scheduleGrid.Rows[r].IsNewRow) continue;
                    for (int c = 0; c < scheduleGrid.Columns.Count; c++)
                    {
                        var col = scheduleGrid.Columns[c];
                        if (col == null) continue;
                        if (string.Equals(col.Name, "Time", StringComparison.OrdinalIgnoreCase)) continue;

                        var cell = scheduleGrid[c, r];
                        if (cell == null) continue;
                        cell.Value = "";
                        cell.Tag = 0;
                        cell.Style.BackColor = Color.White;
                        cell.Style.ForeColor = Color.Black;
                    }
                }

                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var delCmd = new SqlCommand("DELETE FROM Availability WHERE doctor_id = @doc", conn, tran))
                            {
                                delCmd.Parameters.Add("@doc", System.Data.SqlDbType.Int).Value = doctorId;
                                delCmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Schedule cleared and saved for the selected doctor.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InitCellTagsToZero();
                MakeDayColumnsReadOnly();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clear error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainAdminPage homeButton = new MainAdminPage();
            homeButton.Show();
            this.Hide();
        }

        private void PatientButton_Click(object sender, EventArgs e)
        {
            PatientsPage patientsPage = new PatientsPage();
            patientsPage.Show();
            this.Hide();
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            DoctorPage doctorsPage = new DoctorPage();
            doctorsPage.Show();
            this.Hide();
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            SchedulePage availabilityPage = new SchedulePage();
            availabilityPage.Show();
            this.Hide();
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentPage appointmentPage = new AppointmentPage();
            appointmentPage.Show();
            this.Hide();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            ServicesPage servicesPage = new ServicesPage();
            servicesPage.Show();
            this.Hide();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportPage reportsPage = new ReportPage();
            reportsPage.Show();
            this.Hide();
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            NotificationPage notificationPage = new NotificationPage();
            notificationPage.Show();
            this.Hide();
        }

        // check DayPicker to add closed dates to Date table
        private void Close_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Replace 'DayPicker' with the actual DateTimePicker control name on your form if different.
                DateTime selectedDate = DayPicker?.Value.Date ?? DateTime.Today;

                using (var conn = new SqlConnection(_connectionString))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();

                    // Insert if missing, otherwise update the availability to "Closed"
                    cmd.CommandText = @"
                    IF EXISTS (SELECT 1 FROM [Date] WHERE [day] = @day)
                        UPDATE [Date] SET [day_avaialbility] = @status WHERE [day] = @day;
                    ELSE
                    INSERT INTO [Date] ([day], [day_avaialbility]) VALUES (@day, @status);";

                    cmd.Parameters.AddWithValue("@day", selectedDate);
                    cmd.Parameters.AddWithValue("@status", "Closed");

                    cmd.ExecuteNonQuery();
                }

                // Refresh the grid
                LoadDate();

                MessageBox.Show($"Date {selectedDate:yyyy-MM-dd} marked as Closed.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving closed date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Reopen previously closed existing data from Date table
        private void ReOpen_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect dates from selected rows (or current row if none selected)
                var dates = new HashSet<DateTime>();
                if (UpcommingClosedStore_dtgrd.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in UpcommingClosedStore_dtgrd.SelectedRows)
                    {
                        if (row.IsNewRow) continue;
                        var cellVal = row.Cells["day"]?.Value ?? row.Cells[0]?.Value;
                        if (cellVal != null && DateTime.TryParse(cellVal.ToString(), out var d))
                            dates.Add(d.Date);
                    }
                }
                else if (UpcommingClosedStore_dtgrd.CurrentRow != null)
                {
                    var cellVal = UpcommingClosedStore_dtgrd.CurrentRow.Cells["day"]?.Value ?? UpcommingClosedStore_dtgrd.CurrentRow.Cells[0]?.Value;
                    if (cellVal != null && DateTime.TryParse(cellVal.ToString(), out var d))
                        dates.Add(d.Date);
                }

                if (dates.Count == 0)
                {
                    MessageBox.Show("Please select at least one closed date to reopen.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.Transaction = tran;
                        cmd.CommandText = "UPDATE [Date] SET [day_avaialbility] = @status WHERE [day] = @day";
                        cmd.Parameters.Add(new SqlParameter("@status", System.Data.SqlDbType.NVarChar, 50));
                        cmd.Parameters.Add(new SqlParameter("@day", System.Data.SqlDbType.Date));

                        try
                        {
                            foreach (var d in dates)
                            {
                                cmd.Parameters["@status"].Value = "Open";
                                cmd.Parameters["@day"].Value = d;
                                cmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }

                LoadDate(); // refresh grid
                MessageBox.Show($"Reopened {dates.Count} date(s).", "Reopened", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reopening dates: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpcommingClosedStore_dtgrd_SelectionChanged(object sender, EventArgs e)
        {
            // Prefer selected row(s); fall back to CurrentRow
            if (UpcommingClosedStore_dtgrd.SelectedRows.Count > 0)
            {
                SetDayPickerFromRow(UpcommingClosedStore_dtgrd.SelectedRows[0]);
            }
            else if (UpcommingClosedStore_dtgrd.CurrentRow != null)
            {
                SetDayPickerFromRow(UpcommingClosedStore_dtgrd.CurrentRow);
            }
        }

        private void UpcommingClosedStore_dtgrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = UpcommingClosedStore_dtgrd.Rows[e.RowIndex];
            SetDayPickerFromRow(row);
        }

        private void SetDayPickerFromRow(DataGridViewRow row)
        {
            if (row == null) return;

            // Try column named "day" first, otherwise use first column
            var cellValue = row.Cells["day"]?.Value ?? row.Cells[0]?.Value;
            if (cellValue == null) return;

            if (DateTime.TryParse(cellValue.ToString(), out var date))
            {
                try
                {
                    DayPicker.Value = date.Date;
                }
                catch (ArgumentOutOfRangeException)
                {
                    // If the date is outside DayPicker range, clamp to Min/Max
                    if (date < DayPicker.MinDate) DayPicker.Value = DayPicker.MinDate;
                    else if (date > DayPicker.MaxDate) DayPicker.Value = DayPicker.MaxDate;
                }
            }
        }
    }


    class DayTimeComparer : IEqualityComparer<(string day, TimeSpan hour)>
    {
        public bool Equals((string day, TimeSpan hour) x, (string day, TimeSpan hour) y)
            => string.Equals(x.day, y.day, StringComparison.OrdinalIgnoreCase) && x.hour == y.hour;
        public int GetHashCode((string day, TimeSpan hour) obj)
            => StringComparer.OrdinalIgnoreCase.GetHashCode(obj.day) ^ obj.hour.GetHashCode();
    }
}

