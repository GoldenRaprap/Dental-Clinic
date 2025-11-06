using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Denics.Administrator
{
    public partial class ReportPage : Form
    {
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());

        public ReportPage()
        {
            InitializeComponent();
        }

        private void ReportPage_Load(object sender, EventArgs e)
        {

            cmbReportType.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Custom" });
            cmbReportType.SelectedIndex = 0;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool isCustom = cmbReportType.SelectedItem.ToString() == "Custom";
            dtpStart.Enabled = isCustom;
            dtpEnd.Enabled = isCustom;
        }
        private void GetDateRange(out DateTime startDate, out DateTime endDate)
        {
            string reportType = cmbReportType.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            startDate = today;
            endDate = today.AddDays(1);

            switch (reportType)
            {
                case "Daily":
                    startDate = today;
                    endDate = today.AddDays(1);
                    break;
                case "Weekly":
                    int diff = (7 + (today.DayOfWeek - DayOfWeek.Sunday)) % 7;
                    startDate = today.AddDays(-1 * diff).Date;
                    endDate = startDate.AddDays(7);
                    break;
                case "Monthly":
                    startDate = new DateTime(today.Year, today.Month, 1);
                    endDate = startDate.AddMonths(1);
                    break;
                case "Custom":
                    startDate = dtpStart.Value.Date;
                    endDate = dtpEnd.Value.Date.AddDays(1);
                    if (startDate >= endDate)
                    {
                        MessageBox.Show("Start date must be before end date. Showing last 7 days instead.",
                            "Date Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        startDate = today.AddDays(-7);
                        endDate = today.AddDays(1);
                    }
                    break;
            }
        }

        void LoadAppointments()
        {
            try
            {
                GetDateRange(out DateTime startDate, out DateTime endDate);

                string sql = @"SELECT appointment_id, user_id, doctor_id, service_id, appointment_date, appointment_time, status
                               FROM dbo.Appointments
                               WHERE appointment_date >= @StartDate AND appointment_date < @EndDate
                               ORDER BY appointment_date";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }
        void LoadAppointmentsGraph()
        {
            try
            {
                GetDateRange(out DateTime startDate, out DateTime endDate);

                string sql = @"
                    SELECT CONVERT(date, appointment_date) AS AppointmentDateOnly,
                           COUNT(*) AS Total
                    FROM dbo.Appointments
                    WHERE appointment_date >= @StartDate AND appointment_date < @EndDate
                    GROUP BY CONVERT(date, appointment_date)
                    ORDER BY AppointmentDateOnly";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    chartAppointments.Series.Clear();
                    var series = new Series("Appointments")
                    {
                        XValueMember = "AppointmentDateOnly",
                        YValueMembers = "Total",
                        ChartType = SeriesChartType.Column
                    };

                    chartAppointments.Series.Add(series);
                    chartAppointments.ChartAreas[0].AxisX.Title = "Date";
                    chartAppointments.ChartAreas[0].AxisY.Title = "Total Appointments";
                    chartAppointments.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd";
                    chartAppointments.DataSource = dt;
                    chartAppointments.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
        }

        void LoadStatusPieChart()
        {
            try
            {
                GetDateRange(out DateTime startDate, out DateTime endDate);

                string sql = @"
                    SELECT status, COUNT(*) AS Total
                    FROM dbo.Appointments
                    WHERE appointment_date >= @StartDate AND appointment_date < @EndDate
                    GROUP BY status";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    chartStatus.Series.Clear();
                    Series series = new Series("StatusDistribution")
                    {
                        ChartType = SeriesChartType.Pie
                    };
                    chartStatus.Series.Add(series);


                    double grandTotal = 0;
                    foreach (DataRow row in dt.Rows)
                        grandTotal += Convert.ToDouble(row["Total"]);

                    foreach (DataRow row in dt.Rows)
                    {
                        double value = Convert.ToDouble(row["Total"]);
                        string status = row["status"].ToString();
                        series.Points.AddXY(status, value);
                    }

                    series.IsValueShownAsLabel = true;
                    series.Label = "#PERCENT{P0}";
                    series["PieLabelStyle"] = "Inside";
                    series.LegendText = "#VALX";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pie Chart: " + ex.Message);
            }
        }



        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadAppointmentsGraph();
            LoadStatusPieChart();
            LoadPatientsPerDoctorChart();
            LoadPatientsPerServiceChart();
        }

        private void LoadPatientsPerDoctorChart()
        {
            using (SqlConnection con = new SqlConnection(db.getDatabaseStringName()))
            {
                con.Open();
                string query = @"
            SELECT d.full_name AS DoctorName, COUNT(a.appointment_id) AS TotalPatients
            FROM Appointments a
            JOIN Doctors d ON a.doctor_id = d.doctor_id
            WHERE a.appointment_date BETWEEN @StartDate AND @EndDate
            GROUP BY d.full_name";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value.Date);
                cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chartPatientsPerDoctor.Series["Patients"].Points.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string doctorName = row["DoctorName"].ToString();
                    int totalPatients = Convert.ToInt32(row["TotalPatients"]);

                    int pointIndex = chartPatientsPerDoctor.Series["Patients"].Points.AddXY(doctorName, totalPatients);
                    var point = chartPatientsPerDoctor.Series["Patients"].Points[pointIndex];


                    point.LegendText = $"{doctorName} ({totalPatients})";

                    point.Label = totalPatients.ToString();
                }

            }
        }
        private void LoadPatientsPerServiceChart()
        {
            using (SqlConnection con = new SqlConnection(db.getDatabaseStringName()))
            {
                con.Open();

                string query = @"
            SELECT 
                s.service_name AS ServiceName, 
                COUNT(a.appointment_id) AS TotalPatients
            FROM Appointments a
            JOIN Services s ON a.service_id = s.service_id
            WHERE a.appointment_date BETWEEN @StartDate AND @EndDate
            GROUP BY s.service_name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StartDate", dtpStart.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", dtpEnd.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    chartPatientsPerService.Series["SPatients"].Points.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        string serviceName = row["ServiceName"].ToString();
                        int totalPatients = Convert.ToInt32(row["TotalPatients"]);

                        int pointIndex = chartPatientsPerService.Series["SPatients"].Points.AddXY(serviceName, totalPatients);
                        var point = chartPatientsPerService.Series["SPatients"].Points[pointIndex];

                        
                        point.LegendText = $"{serviceName} ({totalPatients})";
                        point.Label = totalPatients.ToString();
                    }  
                }
            }
        }
    }
}



