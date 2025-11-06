namespace Denics.Administrator
{
    partial class AppointmentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OverallAppointmentTable = new DataGridView();
            PatientNameLabel = new Label();
            DoctorLabel = new Label();
            serviceLabel = new Label();
            dateLabel = new Label();
            TimeLabel = new Label();
            ApprovalLabel = new Label();
            Patienttxtbx = new TextBox();
            Doctortxtbx = new TextBox();
            Servicetxtbx = new TextBox();
            Datedtpicker = new DateTimePicker();
            Timetxtbx = new TextBox();
            ViewApprovalbtn = new Button();
            Statustxtbx = new TextBox();
            StatusLabel = new Label();
            ViewAll_btn = new Button();
            Approvebtn = new Button();
            CancellationBtn = new Button();
            Automation_checkbox = new CheckBox();
            SaveAutomationbtn = new Button();
            ApprovalPanel = new Panel();
            Undobtn = new Button();
            NoShowbtn = new Button();
            Completebtn = new Button();
            ViewCompletionbtn = new Button();
            CompletionLabel = new Label();
            Searchlb = new Label();
            Search_txtbx = new TextBox();
            Add_Appointment_btn = new Button();
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
            ((System.ComponentModel.ISupportInitialize)OverallAppointmentTable).BeginInit();
            ApprovalPanel.SuspendLayout();
            SideBarBackground.SuspendLayout();
            TopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // OverallAppointmentTable
            // 
            OverallAppointmentTable.AllowUserToAddRows = false;
            OverallAppointmentTable.AllowUserToDeleteRows = false;
            OverallAppointmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OverallAppointmentTable.Location = new Point(312, 108);
            OverallAppointmentTable.Name = "OverallAppointmentTable";
            OverallAppointmentTable.ReadOnly = true;
            OverallAppointmentTable.Size = new Size(560, 442);
            OverallAppointmentTable.TabIndex = 1;
            OverallAppointmentTable.CellClick += OverallAppointmentTable_CellClick;
            // 
            // PatientNameLabel
            // 
            PatientNameLabel.AutoSize = true;
            PatientNameLabel.Location = new Point(101, 80);
            PatientNameLabel.Name = "PatientNameLabel";
            PatientNameLabel.Size = new Size(50, 15);
            PatientNameLabel.TabIndex = 3;
            PatientNameLabel.Text = "Patient: ";
            // 
            // DoctorLabel
            // 
            DoctorLabel.AutoSize = true;
            DoctorLabel.Location = new Point(101, 124);
            DoctorLabel.Name = "DoctorLabel";
            DoctorLabel.Size = new Size(49, 15);
            DoctorLabel.TabIndex = 4;
            DoctorLabel.Text = "Doctor: ";
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new Point(101, 168);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(47, 15);
            serviceLabel.TabIndex = 5;
            serviceLabel.Text = "Service:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(101, 212);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(37, 15);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date: ";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(101, 256);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(39, 15);
            TimeLabel.TabIndex = 7;
            TimeLabel.Text = "Time: ";
            // 
            // ApprovalLabel
            // 
            ApprovalLabel.AutoSize = true;
            ApprovalLabel.Location = new Point(9, 58);
            ApprovalLabel.Name = "ApprovalLabel";
            ApprovalLabel.Size = new Size(55, 15);
            ApprovalLabel.TabIndex = 8;
            ApprovalLabel.Text = "Approval";
            // 
            // Patienttxtbx
            // 
            Patienttxtbx.Location = new Point(101, 98);
            Patienttxtbx.Name = "Patienttxtbx";
            Patienttxtbx.Size = new Size(187, 23);
            Patienttxtbx.TabIndex = 10;
            // 
            // Doctortxtbx
            // 
            Doctortxtbx.Location = new Point(101, 142);
            Doctortxtbx.Name = "Doctortxtbx";
            Doctortxtbx.Size = new Size(187, 23);
            Doctortxtbx.TabIndex = 11;
            // 
            // Servicetxtbx
            // 
            Servicetxtbx.Location = new Point(101, 186);
            Servicetxtbx.Name = "Servicetxtbx";
            Servicetxtbx.Size = new Size(187, 23);
            Servicetxtbx.TabIndex = 12;
            // 
            // Datedtpicker
            // 
            Datedtpicker.Location = new Point(101, 230);
            Datedtpicker.Name = "Datedtpicker";
            Datedtpicker.Size = new Size(187, 23);
            Datedtpicker.TabIndex = 13;
            // 
            // Timetxtbx
            // 
            Timetxtbx.Location = new Point(101, 274);
            Timetxtbx.Name = "Timetxtbx";
            Timetxtbx.Size = new Size(187, 23);
            Timetxtbx.TabIndex = 14;
            // 
            // ViewApprovalbtn
            // 
            ViewApprovalbtn.Location = new Point(109, 54);
            ViewApprovalbtn.Name = "ViewApprovalbtn";
            ViewApprovalbtn.Size = new Size(87, 23);
            ViewApprovalbtn.TabIndex = 15;
            ViewApprovalbtn.Text = "View";
            ViewApprovalbtn.UseVisualStyleBackColor = true;
            ViewApprovalbtn.Click += ViewApprovalbtn_Click;
            // 
            // Statustxtbx
            // 
            Statustxtbx.Location = new Point(9, 25);
            Statustxtbx.Name = "Statustxtbx";
            Statustxtbx.ReadOnly = true;
            Statustxtbx.Size = new Size(187, 23);
            Statustxtbx.TabIndex = 16;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(9, 7);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 17;
            StatusLabel.Text = "Status:";
            // 
            // ViewAll_btn
            // 
            ViewAll_btn.Location = new Point(448, 80);
            ViewAll_btn.Name = "ViewAll_btn";
            ViewAll_btn.Size = new Size(75, 23);
            ViewAll_btn.TabIndex = 18;
            ViewAll_btn.Text = "View All";
            ViewAll_btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            ViewAll_btn.UseVisualStyleBackColor = true;
            ViewAll_btn.Click += Refreshbtn_Click;
            // 
            // Approvebtn
            // 
            Approvebtn.Location = new Point(9, 81);
            Approvebtn.Name = "Approvebtn";
            Approvebtn.Size = new Size(87, 23);
            Approvebtn.TabIndex = 19;
            Approvebtn.Text = "Approve";
            Approvebtn.UseVisualStyleBackColor = true;
            Approvebtn.Click += Approvebtn_Click;
            // 
            // CancellationBtn
            // 
            CancellationBtn.Location = new Point(109, 83);
            CancellationBtn.Name = "CancellationBtn";
            CancellationBtn.Size = new Size(87, 23);
            CancellationBtn.TabIndex = 20;
            CancellationBtn.Text = "Deny";
            CancellationBtn.UseVisualStyleBackColor = true;
            CancellationBtn.Click += CancellationBtn_Click;
            // 
            // Automation_checkbox
            // 
            Automation_checkbox.AutoSize = true;
            Automation_checkbox.Location = new Point(9, 116);
            Automation_checkbox.Name = "Automation_checkbox";
            Automation_checkbox.Size = new Size(79, 19);
            Automation_checkbox.TabIndex = 21;
            Automation_checkbox.Text = "Automate";
            Automation_checkbox.UseVisualStyleBackColor = true;
            // 
            // SaveAutomationbtn
            // 
            SaveAutomationbtn.Location = new Point(109, 112);
            SaveAutomationbtn.Name = "SaveAutomationbtn";
            SaveAutomationbtn.Size = new Size(59, 23);
            SaveAutomationbtn.TabIndex = 22;
            SaveAutomationbtn.Text = "Save";
            SaveAutomationbtn.UseVisualStyleBackColor = true;
            SaveAutomationbtn.Click += SaveAutomationbtn_Click;
            // 
            // ApprovalPanel
            // 
            ApprovalPanel.BackColor = Color.LightGray;
            ApprovalPanel.Controls.Add(Undobtn);
            ApprovalPanel.Controls.Add(NoShowbtn);
            ApprovalPanel.Controls.Add(Completebtn);
            ApprovalPanel.Controls.Add(ViewCompletionbtn);
            ApprovalPanel.Controls.Add(CompletionLabel);
            ApprovalPanel.Controls.Add(SaveAutomationbtn);
            ApprovalPanel.Controls.Add(Automation_checkbox);
            ApprovalPanel.Controls.Add(CancellationBtn);
            ApprovalPanel.Controls.Add(Approvebtn);
            ApprovalPanel.Controls.Add(StatusLabel);
            ApprovalPanel.Controls.Add(ViewApprovalbtn);
            ApprovalPanel.Controls.Add(ApprovalLabel);
            ApprovalPanel.Controls.Add(Statustxtbx);
            ApprovalPanel.Location = new Point(92, 311);
            ApprovalPanel.Name = "ApprovalPanel";
            ApprovalPanel.Size = new Size(205, 239);
            ApprovalPanel.TabIndex = 24;
            // 
            // Undobtn
            // 
            Undobtn.Location = new Point(57, 207);
            Undobtn.Name = "Undobtn";
            Undobtn.Size = new Size(87, 23);
            Undobtn.TabIndex = 27;
            Undobtn.Text = "Undo";
            Undobtn.UseVisualStyleBackColor = true;
            Undobtn.Click += Undobtn_Click;
            // 
            // NoShowbtn
            // 
            NoShowbtn.Location = new Point(109, 178);
            NoShowbtn.Name = "NoShowbtn";
            NoShowbtn.Size = new Size(87, 23);
            NoShowbtn.TabIndex = 26;
            NoShowbtn.Text = "No-Show";
            NoShowbtn.UseVisualStyleBackColor = true;
            NoShowbtn.Click += NoShowbtn_Click;
            // 
            // Completebtn
            // 
            Completebtn.Location = new Point(9, 176);
            Completebtn.Name = "Completebtn";
            Completebtn.Size = new Size(87, 23);
            Completebtn.TabIndex = 25;
            Completebtn.Text = "Complete";
            Completebtn.UseVisualStyleBackColor = true;
            Completebtn.Click += Completebtn_Click;
            // 
            // ViewCompletionbtn
            // 
            ViewCompletionbtn.Location = new Point(109, 149);
            ViewCompletionbtn.Name = "ViewCompletionbtn";
            ViewCompletionbtn.Size = new Size(87, 23);
            ViewCompletionbtn.TabIndex = 24;
            ViewCompletionbtn.Text = "View";
            ViewCompletionbtn.UseVisualStyleBackColor = true;
            ViewCompletionbtn.Click += ViewCompletionbtn_Click;
            // 
            // CompletionLabel
            // 
            CompletionLabel.AutoSize = true;
            CompletionLabel.Location = new Point(9, 151);
            CompletionLabel.Name = "CompletionLabel";
            CompletionLabel.Size = new Size(70, 15);
            CompletionLabel.TabIndex = 23;
            CompletionLabel.Text = "Completion";
            // 
            // Searchlb
            // 
            Searchlb.AutoSize = true;
            Searchlb.Location = new Point(529, 83);
            Searchlb.Name = "Searchlb";
            Searchlb.Size = new Size(48, 15);
            Searchlb.TabIndex = 25;
            Searchlb.Text = "Search: ";
            // 
            // Search_txtbx
            // 
            Search_txtbx.Location = new Point(583, 80);
            Search_txtbx.Name = "Search_txtbx";
            Search_txtbx.Size = new Size(289, 23);
            Search_txtbx.TabIndex = 26;
            Search_txtbx.TextChanged += Search_txtbx_TextChanged;
            // 
            // Add_Appointment_btn
            // 
            Add_Appointment_btn.Location = new Point(312, 79);
            Add_Appointment_btn.Name = "Add_Appointment_btn";
            Add_Appointment_btn.Size = new Size(130, 23);
            Add_Appointment_btn.TabIndex = 27;
            Add_Appointment_btn.Text = "Add Appointment";
            Add_Appointment_btn.UseVisualStyleBackColor = true;
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
            SideBarBackground.TabIndex = 28;
            // 
            // NotificationButton
            // 
            NotificationButton.BackgroundImage = Properties.Resources.Bell;
            NotificationButton.BackgroundImageLayout = ImageLayout.Stretch;
            NotificationButton.Location = new Point(16, 395);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Size = new Size(40, 40);
            NotificationButton.TabIndex = 4;
            NotificationButton.Click += NotificationButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.BackgroundImage = Properties.Resources.report;
            ReportButton.BackgroundImageLayout = ImageLayout.Stretch;
            ReportButton.Location = new Point(16, 349);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(40, 40);
            ReportButton.TabIndex = 3;
            ReportButton.Click += ReportButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.BackgroundImage = Properties.Resources.white_home;
            HomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            HomeButton.Location = new Point(16, 16);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(40, 40);
            HomeButton.TabIndex = 2;
            HomeButton.Click += HomeButton_Click;
            // 
            // ServicesButton
            // 
            ServicesButton.BackgroundImage = Properties.Resources.service;
            ServicesButton.BackgroundImageLayout = ImageLayout.Stretch;
            ServicesButton.Location = new Point(16, 303);
            ServicesButton.Name = "ServicesButton";
            ServicesButton.Size = new Size(40, 40);
            ServicesButton.TabIndex = 2;
            ServicesButton.Click += ServicesButton_Click;
            // 
            // AvailabilityButton
            // 
            AvailabilityButton.BackgroundImage = Properties.Resources.calendar;
            AvailabilityButton.BackgroundImageLayout = ImageLayout.Stretch;
            AvailabilityButton.Location = new Point(16, 211);
            AvailabilityButton.Name = "AvailabilityButton";
            AvailabilityButton.Size = new Size(40, 40);
            AvailabilityButton.TabIndex = 2;
            AvailabilityButton.Click += AvailabilityButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.BackgroundImage = Properties.Resources.Book;
            AppointmentButton.BackgroundImageLayout = ImageLayout.Stretch;
            AppointmentButton.Location = new Point(16, 257);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(40, 40);
            AppointmentButton.TabIndex = 1;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // PatientButton
            // 
            PatientButton.BackgroundImage = Properties.Resources.patient;
            PatientButton.BackgroundImageLayout = ImageLayout.Stretch;
            PatientButton.Location = new Point(16, 119);
            PatientButton.Name = "PatientButton";
            PatientButton.Size = new Size(40, 40);
            PatientButton.TabIndex = 1;
            PatientButton.Click += PatientButton_Click;
            // 
            // DoctorButton
            // 
            DoctorButton.BackgroundImage = Properties.Resources.doctor;
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
            TopHeader.TabIndex = 29;
            // 
            // Top_lbl
            // 
            Top_lbl.AutoSize = true;
            Top_lbl.Font = new Font("Sitka Subheading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Top_lbl.ForeColor = SystemColors.ControlLight;
            Top_lbl.Location = new Point(20, 9);
            Top_lbl.Name = "Top_lbl";
            Top_lbl.Size = new Size(389, 47);
            Top_lbl.TabIndex = 0;
            Top_lbl.Text = "Appointment Management";
            // 
            // AppointmentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(TopHeader);
            Controls.Add(SideBarBackground);
            Controls.Add(Add_Appointment_btn);
            Controls.Add(Search_txtbx);
            Controls.Add(Searchlb);
            Controls.Add(ApprovalPanel);
            Controls.Add(ViewAll_btn);
            Controls.Add(Timetxtbx);
            Controls.Add(Datedtpicker);
            Controls.Add(Servicetxtbx);
            Controls.Add(Doctortxtbx);
            Controls.Add(Patienttxtbx);
            Controls.Add(TimeLabel);
            Controls.Add(dateLabel);
            Controls.Add(serviceLabel);
            Controls.Add(DoctorLabel);
            Controls.Add(PatientNameLabel);
            Controls.Add(OverallAppointmentTable);
            Name = "AppointmentPage";
            Text = "Appointment Management";
            Load += AppointmentPage_Load;
            ((System.ComponentModel.ISupportInitialize)OverallAppointmentTable).EndInit();
            ApprovalPanel.ResumeLayout(false);
            ApprovalPanel.PerformLayout();
            SideBarBackground.ResumeLayout(false);
            TopHeader.ResumeLayout(false);
            TopHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DataGridView OverallAppointmentTable;
        private Label PatientNameLabel;
        private Label DoctorLabel;
        private Label serviceLabel;
        private Label dateLabel;
        private Label TimeLabel;
        private Label ApprovalLabel;
        private TextBox Patienttxtbx;
        private TextBox Doctortxtbx;
        private TextBox Servicetxtbx;
        private DateTimePicker Datedtpicker;
        private TextBox Timetxtbx;
        private Button ViewApprovalbtn;
        private TextBox Statustxtbx;
        private Label StatusLabel;
        private Button ViewAll_btn;
        private Button Approvebtn;
        private Button CancellationBtn;
        private CheckBox Automation_checkbox;
        private Button SaveAutomationbtn;
        private Panel ApprovalPanel;
        private Button ViewCompletionbtn;
        private Label CompletionLabel;
        private Button NoShowbtn;
        private Button Completebtn;
        private Button Add_Appointment_btn;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Button Undobtn;
        private Label Searchlb;
        private TextBox Search_txtbx;
        private Panel SideBarBackground;
        private Panel NotificationButton;
        private Panel ReportButton;
        private Panel HomeButton;
        private Panel ServicesButton;
        private Panel AvailabilityButton;
        private Panel AppointmentButton;
        private Panel PatientButton;
        private Panel DoctorButton;
        private Panel TopHeader;
        private Label Top_lbl;
    }
}