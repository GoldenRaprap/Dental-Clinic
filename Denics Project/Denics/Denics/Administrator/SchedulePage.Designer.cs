namespace WinFormsApp1
{
    partial class SchedulePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            UpcommingClosedStore_dtgrd = new DataGridView();
            Close_btn = new Button();
            DateLabel = new Label();
            ReOpen_btn = new Button();
            DorctorLabel = new Label();
            DayPicker = new DateTimePicker();
            btnClear = new Button();
            btnSave = new Button();
            btnView = new Button();
            comboBoxDoctors = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Days = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Timetable = new TableLayoutPanel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            Time = new Label();
            panel2 = new Panel();
            scheduleGrid = new DataGridView();
            SideBarBackground = new Panel();
            NotificationButton = new Panel();
            ReportButton = new Panel();
            HomeButton = new Panel();
            ServicesButton = new Panel();
            AvailabilityButton = new Panel();
            AppointmentButton = new Panel();
            PatientButton = new Panel();
            DoctorButton = new Panel();
            TopHeader = new Panel();
            Top_lbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpcommingClosedStore_dtgrd).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            Days.SuspendLayout();
            Timetable.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleGrid).BeginInit();
            SideBarBackground.SuspendLayout();
            TopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleName = "panelContainer";
            panel1.Controls.Add(UpcommingClosedStore_dtgrd);
            panel1.Controls.Add(Close_btn);
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(ReOpen_btn);
            panel1.Controls.Add(DorctorLabel);
            panel1.Controls.Add(DayPicker);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(comboBoxDoctors);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(18, 112, 18, 15);
            panel1.Size = new Size(884, 561);
            panel1.TabIndex = 0;
            // 
            // UpcommingClosedStore_dtgrd
            // 
            UpcommingClosedStore_dtgrd.AllowUserToAddRows = false;
            UpcommingClosedStore_dtgrd.AllowUserToDeleteRows = false;
            UpcommingClosedStore_dtgrd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpcommingClosedStore_dtgrd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            UpcommingClosedStore_dtgrd.Location = new Point(511, 379);
            UpcommingClosedStore_dtgrd.Name = "UpcommingClosedStore_dtgrd";
            UpcommingClosedStore_dtgrd.ReadOnly = true;
            UpcommingClosedStore_dtgrd.Size = new Size(279, 170);
            UpcommingClosedStore_dtgrd.TabIndex = 12;
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(148, 444);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(127, 23);
            Close_btn.TabIndex = 11;
            Close_btn.Text = "Close";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(148, 397);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(166, 15);
            DateLabel.TabIndex = 10;
            DateLabel.Text = "Select a Day to Close the Store";
            // 
            // ReOpen_btn
            // 
            ReOpen_btn.Location = new Point(281, 444);
            ReOpen_btn.Name = "ReOpen_btn";
            ReOpen_btn.Size = new Size(127, 23);
            ReOpen_btn.TabIndex = 9;
            ReOpen_btn.Text = "Reopen";
            ReOpen_btn.UseVisualStyleBackColor = true;
            ReOpen_btn.Click += ReOpen_btn_Click;
            // 
            // DorctorLabel
            // 
            DorctorLabel.AutoSize = true;
            DorctorLabel.Location = new Point(148, 85);
            DorctorLabel.Name = "DorctorLabel";
            DorctorLabel.Size = new Size(229, 15);
            DorctorLabel.TabIndex = 8;
            DorctorLabel.Text = "Select a Doctor to Create Weekly Schedule";
            // 
            // DayPicker
            // 
            DayPicker.Location = new Point(148, 415);
            DayPicker.Name = "DayPicker";
            DayPicker.Size = new Size(260, 23);
            DayPicker.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(685, 99);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 26);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(571, 99);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 26);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(475, 99);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(63, 26);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.FormattingEnabled = true;
            comboBoxDoctors.Location = new Point(148, 102);
            comboBoxDoctors.Margin = new Padding(3, 2, 3, 2);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(311, 23);
            comboBoxDoctors.TabIndex = 3;
            comboBoxDoctors.Text = "Doctors";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Days, 1, 0);
            tableLayoutPanel1.Controls.Add(Timetable, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Location = new Point(148, 127);
            tableLayoutPanel1.Margin = new Padding(18, 15, 18, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(648, 237);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Days
            // 
            Days.ColumnCount = 7;
            Days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            Days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            Days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            Days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            Days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            Days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            Days.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            Days.Controls.Add(label7, 6, 0);
            Days.Controls.Add(label6, 5, 0);
            Days.Controls.Add(label5, 4, 0);
            Days.Controls.Add(label4, 3, 0);
            Days.Controls.Add(label3, 2, 0);
            Days.Controls.Add(label2, 1, 0);
            Days.Controls.Add(label1, 0, 0);
            Days.Dock = DockStyle.Fill;
            Days.Location = new Point(91, 2);
            Days.Margin = new Padding(3, 2, 3, 2);
            Days.Name = "Days";
            Days.RowCount = 1;
            Days.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Days.Size = new Size(554, 26);
            Days.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(477, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 26);
            label7.TabIndex = 7;
            label7.Text = "Saturday";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(398, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 26);
            label6.TabIndex = 6;
            label6.Text = "Friday";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(319, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 26);
            label5.TabIndex = 5;
            label5.Text = "Thursday";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(240, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 26);
            label4.TabIndex = 4;
            label4.Text = "Wednesday";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(161, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 26);
            label3.TabIndex = 3;
            label3.Text = "Tuesday";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(82, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 26);
            label2.TabIndex = 2;
            label2.Text = "Monday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 26);
            label1.TabIndex = 1;
            label1.Text = "Sunday";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Timetable
            // 
            Timetable.ColumnCount = 1;
            Timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Timetable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            Timetable.Controls.Add(label14, 0, 7);
            Timetable.Controls.Add(label13, 0, 6);
            Timetable.Controls.Add(label12, 0, 5);
            Timetable.Controls.Add(label11, 0, 4);
            Timetable.Controls.Add(label10, 0, 3);
            Timetable.Controls.Add(label9, 0, 2);
            Timetable.Controls.Add(label8, 0, 1);
            Timetable.Controls.Add(Time, 0, 0);
            Timetable.Dock = DockStyle.Fill;
            Timetable.Location = new Point(3, 32);
            Timetable.Margin = new Padding(3, 2, 3, 2);
            Timetable.Name = "Timetable";
            Timetable.RowCount = 8;
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            Timetable.Size = new Size(82, 203);
            Timetable.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(3, 175);
            label14.Name = "label14";
            label14.Size = new Size(76, 28);
            label14.TabIndex = 7;
            label14.Text = "17:00-18:00";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(3, 150);
            label13.Name = "label13";
            label13.Size = new Size(76, 25);
            label13.TabIndex = 6;
            label13.Text = "16:00-17:00";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(3, 125);
            label12.Name = "label12";
            label12.Size = new Size(76, 25);
            label12.TabIndex = 5;
            label12.Text = "15:00-16:00";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 100);
            label11.Name = "label11";
            label11.Size = new Size(76, 25);
            label11.TabIndex = 4;
            label11.Text = "14:00-15:00";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 75);
            label10.Name = "label10";
            label10.Size = new Size(76, 25);
            label10.TabIndex = 3;
            label10.Text = "13:00-14:00";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 50);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 2;
            label9.Text = "12:00-13:00";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 25);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 1;
            label8.Text = "11:00-12:00";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Dock = DockStyle.Fill;
            Time.Location = new Point(3, 0);
            Time.Name = "Time";
            Time.Size = new Size(76, 25);
            Time.TabIndex = 0;
            Time.Text = "9:00-10:00";
            Time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(scheduleGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(91, 32);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 203);
            panel2.TabIndex = 3;
            // 
            // scheduleGrid
            // 
            scheduleGrid.AccessibleName = "scheduleGrid";
            scheduleGrid.AllowUserToResizeColumns = false;
            scheduleGrid.AllowUserToResizeRows = false;
            scheduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleGrid.Dock = DockStyle.Fill;
            scheduleGrid.Location = new Point(0, 0);
            scheduleGrid.Margin = new Padding(18, 15, 18, 15);
            scheduleGrid.Name = "scheduleGrid";
            scheduleGrid.RowHeadersWidth = 51;
            scheduleGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            scheduleGrid.Size = new Size(554, 203);
            scheduleGrid.TabIndex = 0;
            // 
            // SideBarBackground
            // 
            SideBarBackground.BackColor = Color.CornflowerBlue;
            SideBarBackground.Controls.Add(NotificationButton);
            SideBarBackground.Controls.Add(ReportButton);
            SideBarBackground.Controls.Add(HomeButton);
            SideBarBackground.Controls.Add(ServicesButton);
            SideBarBackground.Controls.Add(AvailabilityButton);
            SideBarBackground.Controls.Add(AppointmentButton);
            SideBarBackground.Controls.Add(PatientButton);
            SideBarBackground.Controls.Add(DoctorButton);
            SideBarBackground.Dock = DockStyle.Left;
            SideBarBackground.Location = new Point(0, 0);
            SideBarBackground.Name = "SideBarBackground";
            SideBarBackground.Size = new Size(75, 561);
            SideBarBackground.TabIndex = 16;
            // 
            // NotificationButton
            // 
            NotificationButton.BackgroundImage = Denics.Properties.Resources.Bell;
            NotificationButton.BackgroundImageLayout = ImageLayout.Stretch;
            NotificationButton.Location = new Point(16, 395);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Size = new Size(40, 40);
            NotificationButton.TabIndex = 4;
            NotificationButton.Click += NotificationButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.BackgroundImage = Denics.Properties.Resources.report;
            ReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            ReportButton.Location = new Point(16, 349);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(40, 40);
            ReportButton.TabIndex = 3;
            ReportButton.Click += ReportButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackgroundImage = Denics.Properties.Resources.white_home;
            HomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            HomeButton.Location = new Point(16, 16);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(40, 40);
            HomeButton.TabIndex = 2;
            HomeButton.Click += HomeButton_Click;
            // 
            // ServicesButton
            // 
            ServicesButton.BackgroundImage = Denics.Properties.Resources.service;
            ServicesButton.BackgroundImageLayout = ImageLayout.Stretch;
            ServicesButton.Location = new Point(16, 303);
            ServicesButton.Name = "ServicesButton";
            ServicesButton.Size = new Size(40, 40);
            ServicesButton.TabIndex = 2;
            ServicesButton.Click += ServicesButton_Click;
            // 
            // AvailabilityButton
            // 
            AvailabilityButton.BackgroundImage = Denics.Properties.Resources.calendar;
            AvailabilityButton.BackgroundImageLayout = ImageLayout.Stretch;
            AvailabilityButton.Location = new Point(16, 211);
            AvailabilityButton.Name = "AvailabilityButton";
            AvailabilityButton.Size = new Size(40, 40);
            AvailabilityButton.TabIndex = 2;
            AvailabilityButton.Click += AvailabilityButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.BackgroundImage = Denics.Properties.Resources.Book;
            AppointmentButton.BackgroundImageLayout = ImageLayout.Stretch;
            AppointmentButton.Location = new Point(16, 257);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(40, 40);
            AppointmentButton.TabIndex = 1;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // PatientButton
            // 
            PatientButton.BackgroundImage = Denics.Properties.Resources.patient;
            PatientButton.BackgroundImageLayout = ImageLayout.Stretch;
            PatientButton.Cursor = Cursors.Hand;
            PatientButton.Location = new Point(16, 119);
            PatientButton.Name = "PatientButton";
            PatientButton.Size = new Size(40, 40);
            PatientButton.TabIndex = 1;
            PatientButton.Click += PatientButton_Click;
            // 
            // DoctorButton
            // 
            DoctorButton.BackgroundImage = Denics.Properties.Resources.doctor;
            DoctorButton.BackgroundImageLayout = ImageLayout.Stretch;
            DoctorButton.Location = new Point(16, 165);
            DoctorButton.Name = "DoctorButton";
            DoctorButton.Size = new Size(40, 40);
            DoctorButton.TabIndex = 0;
            DoctorButton.Click += DoctorButton_Click;
            // 
            // TopHeader
            // 
            TopHeader.BackColor = Color.RoyalBlue;
            TopHeader.Controls.Add(Top_lbl);
            TopHeader.Dock = DockStyle.Top;
            TopHeader.Location = new Point(75, 0);
            TopHeader.Name = "TopHeader";
            TopHeader.Size = new Size(809, 65);
            TopHeader.TabIndex = 35;
            // 
            // Top_lbl
            // 
            Top_lbl.AutoSize = true;
            Top_lbl.Font = new Font("Sitka Subheading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Top_lbl.ForeColor = SystemColors.ControlLight;
            Top_lbl.Location = new Point(20, 9);
            Top_lbl.Name = "Top_lbl";
            Top_lbl.Size = new Size(332, 47);
            Top_lbl.TabIndex = 0;
            Top_lbl.Text = "Schedule Management";
            // 
            // SchedulePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(TopHeader);
            Controls.Add(SideBarBackground);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SchedulePage";
            Text = "Schedule Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpcommingClosedStore_dtgrd).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            Days.ResumeLayout(false);
            Days.PerformLayout();
            Timetable.ResumeLayout(false);
            Timetable.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scheduleGrid).EndInit();
            SideBarBackground.ResumeLayout(false);
            TopHeader.ResumeLayout(false);
            TopHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView scheduleGrid;
        private TableLayoutPanel Days;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel Timetable;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label Time;
        private Panel panel2;
        private ComboBox comboBoxDoctors;
        private Button btnSave;
        private Button btnView;
        private Button btnClear;
        private Panel SideBarBackground;
        private Panel NotificationButton;
        private Panel ReportButton;
        private Panel HomeButton;
        private Panel ServicesButton;
        private Panel AvailabilityButton;
        private Panel AppointmentButton;
        private Panel PatientButton;
        private Panel DoctorButton;
        private Label DateLabel;
        private Button ReOpen_btn;
        private Label DorctorLabel;
        private DateTimePicker DayPicker;
        private DataGridView UpcommingClosedStore_dtgrd;
        private Button Close_btn;
        private Panel TopHeader;
        private Label Top_lbl;
    }
}
