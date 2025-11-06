namespace Denics.Administrator
{
    partial class PatientsPage
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
            ClientsTable = new DataGridView();
            txtboxfName = new TextBox();
            txtboxsurname = new TextBox();
            txtboxemail = new TextBox();
            txtboxcontact = new TextBox();
            txtboxaddress = new TextBox();
            labelfName = new Label();
            labellName = new Label();
            labelemail = new Label();
            labelnum = new Label();
            labeladdress = new Label();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            Password = new Label();
            txtboxpassword = new TextBox();
            Rolelabel = new Label();
            txtboxrole = new ComboBox();
            SideBarBackground = new Panel();
            HomeButton = new Panel();
            DoctorButton = new Panel();
            PatientButton = new Panel();
            AvailabilityButton = new Panel();
            AppointmentButton = new Panel();
            ServicesButton = new Panel();
            ReportButton = new Panel();
            NotificationButton = new Panel();
            TopHeader = new Panel();
            Top_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)ClientsTable).BeginInit();
            SideBarBackground.SuspendLayout();
            TopHeader.SuspendLayout();
            SuspendLayout();
            // 
            // ClientsTable
            // 
            ClientsTable.AllowUserToAddRows = false;
            ClientsTable.AllowUserToDeleteRows = false;
            ClientsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientsTable.Location = new Point(292, 106);
            ClientsTable.Name = "ClientsTable";
            ClientsTable.ReadOnly = true;
            ClientsTable.Size = new Size(580, 443);
            ClientsTable.TabIndex = 0;
            ClientsTable.CellClick += ClientsTable_CellClick;
            // 
            // txtboxfName
            // 
            txtboxfName.Location = new Point(93, 123);
            txtboxfName.Name = "txtboxfName";
            txtboxfName.Size = new Size(182, 23);
            txtboxfName.TabIndex = 1;
            // 
            // txtboxsurname
            // 
            txtboxsurname.Location = new Point(93, 167);
            txtboxsurname.Name = "txtboxsurname";
            txtboxsurname.Size = new Size(182, 23);
            txtboxsurname.TabIndex = 2;
            // 
            // txtboxemail
            // 
            txtboxemail.Location = new Point(93, 211);
            txtboxemail.Name = "txtboxemail";
            txtboxemail.Size = new Size(182, 23);
            txtboxemail.TabIndex = 3;
            // 
            // txtboxcontact
            // 
            txtboxcontact.Location = new Point(93, 256);
            txtboxcontact.Name = "txtboxcontact";
            txtboxcontact.Size = new Size(182, 23);
            txtboxcontact.TabIndex = 4;
            // 
            // txtboxaddress
            // 
            txtboxaddress.Location = new Point(93, 300);
            txtboxaddress.Name = "txtboxaddress";
            txtboxaddress.Size = new Size(182, 23);
            txtboxaddress.TabIndex = 5;
            // 
            // labelfName
            // 
            labelfName.AutoSize = true;
            labelfName.Location = new Point(94, 105);
            labelfName.Name = "labelfName";
            labelfName.Size = new Size(67, 15);
            labelfName.TabIndex = 6;
            labelfName.Text = "First Name:";
            // 
            // labellName
            // 
            labellName.AutoSize = true;
            labellName.Location = new Point(95, 149);
            labellName.Name = "labellName";
            labellName.Size = new Size(66, 15);
            labellName.TabIndex = 7;
            labellName.Text = "Last Name:";
            // 
            // labelemail
            // 
            labelemail.AutoSize = true;
            labelemail.Location = new Point(95, 193);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(39, 15);
            labelemail.TabIndex = 8;
            labelemail.Text = "Email:";
            // 
            // labelnum
            // 
            labelnum.AutoSize = true;
            labelnum.Location = new Point(94, 238);
            labelnum.Name = "labelnum";
            labelnum.Size = new Size(99, 15);
            labelnum.TabIndex = 9;
            labelnum.Text = "Contact Number:";
            // 
            // labeladdress
            // 
            labeladdress.AutoSize = true;
            labeladdress.Location = new Point(93, 282);
            labeladdress.Name = "labeladdress";
            labeladdress.Size = new Size(52, 15);
            labeladdress.TabIndex = 10;
            labeladdress.Text = "Address:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(93, 439);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(182, 21);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(93, 466);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(183, 21);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "EDIT";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(93, 493);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(183, 21);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(94, 326);
            Password.Name = "Password";
            Password.Size = new Size(63, 15);
            Password.TabIndex = 15;
            Password.Text = "Password: ";
            // 
            // txtboxpassword
            // 
            txtboxpassword.Location = new Point(93, 344);
            txtboxpassword.Name = "txtboxpassword";
            txtboxpassword.Size = new Size(182, 23);
            txtboxpassword.TabIndex = 14;
            // 
            // Rolelabel
            // 
            Rolelabel.AutoSize = true;
            Rolelabel.Location = new Point(94, 370);
            Rolelabel.Name = "Rolelabel";
            Rolelabel.Size = new Size(36, 15);
            Rolelabel.TabIndex = 17;
            Rolelabel.Text = "Role: ";
            // 
            // txtboxrole
            // 
            txtboxrole.FormattingEnabled = true;
            txtboxrole.Items.AddRange(new object[] { "patient", "admin" });
            txtboxrole.Location = new Point(93, 388);
            txtboxrole.Name = "txtboxrole";
            txtboxrole.Size = new Size(182, 23);
            txtboxrole.TabIndex = 18;
            // 
            // SideBarBackground
            // 
            SideBarBackground.BackColor = Color.CornflowerBlue;
            SideBarBackground.Controls.Add(HomeButton);
            SideBarBackground.Controls.Add(DoctorButton);
            SideBarBackground.Controls.Add(PatientButton);
            SideBarBackground.Controls.Add(AvailabilityButton);
            SideBarBackground.Controls.Add(AppointmentButton);
            SideBarBackground.Controls.Add(ServicesButton);
            SideBarBackground.Controls.Add(ReportButton);
            SideBarBackground.Controls.Add(NotificationButton);
            SideBarBackground.Dock = DockStyle.Left;
            SideBarBackground.Location = new Point(0, 0);
            SideBarBackground.Name = "SideBarBackground";
            SideBarBackground.Size = new Size(75, 561);
            SideBarBackground.TabIndex = 21;
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
            // TopHeader
            // 
            TopHeader.BackColor = Color.RoyalBlue;
            TopHeader.Controls.Add(Top_lbl);
            TopHeader.Dock = DockStyle.Top;
            TopHeader.Location = new Point(75, 0);
            TopHeader.Name = "TopHeader";
            TopHeader.Size = new Size(809, 65);
            TopHeader.TabIndex = 31;
            // 
            // Top_lbl
            // 
            Top_lbl.AutoSize = true;
            Top_lbl.Font = new Font("Sitka Subheading", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Top_lbl.ForeColor = SystemColors.ControlLight;
            Top_lbl.Location = new Point(20, 9);
            Top_lbl.Name = "Top_lbl";
            Top_lbl.Size = new Size(272, 47);
            Top_lbl.TabIndex = 0;
            Top_lbl.Text = "User Management";
            // 
            // PatientsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(TopHeader);
            Controls.Add(SideBarBackground);
            Controls.Add(txtboxrole);
            Controls.Add(Rolelabel);
            Controls.Add(Password);
            Controls.Add(txtboxpassword);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(labeladdress);
            Controls.Add(labelnum);
            Controls.Add(labelemail);
            Controls.Add(labellName);
            Controls.Add(labelfName);
            Controls.Add(txtboxaddress);
            Controls.Add(txtboxcontact);
            Controls.Add(txtboxemail);
            Controls.Add(txtboxsurname);
            Controls.Add(txtboxfName);
            Controls.Add(ClientsTable);
            Name = "PatientsPage";
            Text = "Patient Mangement";
            Load += PatientsPage_Load;
            ((System.ComponentModel.ISupportInitialize)ClientsTable).EndInit();
            SideBarBackground.ResumeLayout(false);
            TopHeader.ResumeLayout(false);
            TopHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ClientsTable;
        private TextBox txtboxfName;
        private TextBox txtboxsurname;
        private TextBox txtboxemail;
        private TextBox txtboxcontact;
        private TextBox txtboxaddress;
        private Label labelfName;
        private Label labellName;
        private Label labelemail;
        private Label labelnum;
        private Label labeladdress;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Label Password;
        private TextBox txtboxpassword;
        private Label Rolelabel;
        private ComboBox txtboxrole;
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