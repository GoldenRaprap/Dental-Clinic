namespace Denics.Administrator
{
    partial class Registration
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
            boxFName = new TextBox();
            boxLName = new TextBox();
            boxEmail = new TextBox();
            boxNumber = new TextBox();
            boxPassword = new TextBox();
            labelFName = new Label();
            labelLName = new Label();
            labelEmail = new Label();
            Gender_lbl = new Label();
            labelPassword = new Label();
            checkBoxShow = new CheckBox();
            buttonRegister = new Button();
            buttonCancel = new Button();
            checkBox1 = new CheckBox();
            ReEnter_lbl = new Label();
            ReEnterPassword_txtbx = new TextBox();
            label1 = new Label();
            Suffix_lbl = new Label();
            MiddleName_lbl = new Label();
            Suffix_txtbx = new TextBox();
            MiddleName_txtbx = new TextBox();
            birthday_lbl = new Label();
            Birthdate_cldr = new DateTimePicker();
            Address_lbl = new Label();
            textBox1 = new TextBox();
            Male_rdbtn = new RadioButton();
            Female_rdbtn = new RadioButton();
            SuspendLayout();
            // 
            // boxFName
            // 
            boxFName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxFName.Location = new Point(98, 38);
            boxFName.Name = "boxFName";
            boxFName.Size = new Size(224, 25);
            boxFName.TabIndex = 0;
            // 
            // boxLName
            // 
            boxLName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxLName.Location = new Point(99, 86);
            boxLName.Name = "boxLName";
            boxLName.Size = new Size(223, 25);
            boxLName.TabIndex = 1;
            // 
            // boxEmail
            // 
            boxEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxEmail.Location = new Point(166, 284);
            boxEmail.Name = "boxEmail";
            boxEmail.Size = new Size(355, 25);
            boxEmail.TabIndex = 2;
            // 
            // boxNumber
            // 
            boxNumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxNumber.Location = new Point(98, 214);
            boxNumber.Name = "boxNumber";
            boxNumber.Size = new Size(224, 25);
            boxNumber.TabIndex = 3;
            // 
            // boxPassword
            // 
            boxPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boxPassword.Location = new Point(167, 332);
            boxPassword.Name = "boxPassword";
            boxPassword.Size = new Size(240, 25);
            boxPassword.TabIndex = 4;
            // 
            // labelFName
            // 
            labelFName.AutoSize = true;
            labelFName.Font = new Font("Segoe UI", 9.75F);
            labelFName.Location = new Point(98, 18);
            labelFName.Name = "labelFName";
            labelFName.Size = new Size(76, 17);
            labelFName.TabIndex = 5;
            labelFName.Text = "First Name*";
            // 
            // labelLName
            // 
            labelLName.AutoSize = true;
            labelLName.Font = new Font("Segoe UI", 9.75F);
            labelLName.Location = new Point(99, 66);
            labelLName.Name = "labelLName";
            labelLName.Size = new Size(75, 17);
            labelLName.TabIndex = 6;
            labelLName.Text = "Last Name*";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9.75F);
            labelEmail.Location = new Point(167, 264);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 17);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email*";
            // 
            // Gender_lbl
            // 
            Gender_lbl.AutoSize = true;
            Gender_lbl.Font = new Font("Segoe UI", 9.75F);
            Gender_lbl.Location = new Point(98, 148);
            Gender_lbl.Name = "Gender_lbl";
            Gender_lbl.Size = new Size(51, 17);
            Gender_lbl.TabIndex = 8;
            Gender_lbl.Text = "Gender";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F);
            labelPassword.Location = new Point(167, 312);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(69, 17);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password*";
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Location = new Point(413, 336);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(108, 19);
            checkBoxShow.TabIndex = 10;
            checkBoxShow.Text = "Show Password";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(166, 461);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(105, 36);
            buttonRegister.TabIndex = 11;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(416, 461);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(105, 36);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(413, 384);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReEnter_lbl
            // 
            ReEnter_lbl.AutoSize = true;
            ReEnter_lbl.Font = new Font("Segoe UI", 9.75F);
            ReEnter_lbl.Location = new Point(167, 360);
            ReEnter_lbl.Name = "ReEnter_lbl";
            ReEnter_lbl.Size = new Size(63, 17);
            ReEnter_lbl.TabIndex = 14;
            ReEnter_lbl.Text = "Re-enter*";
            // 
            // ReEnterPassword_txtbx
            // 
            ReEnterPassword_txtbx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReEnterPassword_txtbx.Location = new Point(167, 380);
            ReEnterPassword_txtbx.Name = "ReEnterPassword_txtbx";
            ReEnterPassword_txtbx.Size = new Size(240, 25);
            ReEnterPassword_txtbx.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(99, 194);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 17;
            label1.Text = "Contact Number*";
            // 
            // Suffix_lbl
            // 
            Suffix_lbl.AutoSize = true;
            Suffix_lbl.Font = new Font("Segoe UI", 9.75F);
            Suffix_lbl.Location = new Point(329, 66);
            Suffix_lbl.Name = "Suffix_lbl";
            Suffix_lbl.Size = new Size(39, 17);
            Suffix_lbl.TabIndex = 21;
            Suffix_lbl.Text = "Suffix";
            // 
            // MiddleName_lbl
            // 
            MiddleName_lbl.AutoSize = true;
            MiddleName_lbl.Font = new Font("Segoe UI", 9.75F);
            MiddleName_lbl.Location = new Point(328, 18);
            MiddleName_lbl.Name = "MiddleName_lbl";
            MiddleName_lbl.Size = new Size(88, 17);
            MiddleName_lbl.TabIndex = 20;
            MiddleName_lbl.Text = "Middle Name";
            // 
            // Suffix_txtbx
            // 
            Suffix_txtbx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Suffix_txtbx.Location = new Point(329, 86);
            Suffix_txtbx.Name = "Suffix_txtbx";
            Suffix_txtbx.Size = new Size(223, 25);
            Suffix_txtbx.TabIndex = 19;
            // 
            // MiddleName_txtbx
            // 
            MiddleName_txtbx.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MiddleName_txtbx.Location = new Point(328, 38);
            MiddleName_txtbx.Name = "MiddleName_txtbx";
            MiddleName_txtbx.Size = new Size(224, 25);
            MiddleName_txtbx.TabIndex = 18;
            // 
            // birthday_lbl
            // 
            birthday_lbl.AutoSize = true;
            birthday_lbl.Font = new Font("Segoe UI", 9.75F);
            birthday_lbl.Location = new Point(329, 148);
            birthday_lbl.Name = "birthday_lbl";
            birthday_lbl.Size = new Size(60, 17);
            birthday_lbl.TabIndex = 23;
            birthday_lbl.Text = "Birthday*";
            // 
            // Birthdate_cldr
            // 
            Birthdate_cldr.Location = new Point(328, 168);
            Birthdate_cldr.Name = "Birthdate_cldr";
            Birthdate_cldr.Size = new Size(223, 23);
            Birthdate_cldr.TabIndex = 24;
            // 
            // Address_lbl
            // 
            Address_lbl.AutoSize = true;
            Address_lbl.Font = new Font("Segoe UI", 9.75F);
            Address_lbl.Location = new Point(328, 194);
            Address_lbl.Name = "Address_lbl";
            Address_lbl.Size = new Size(61, 17);
            Address_lbl.TabIndex = 26;
            Address_lbl.Text = "Address*";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(327, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 25);
            textBox1.TabIndex = 25;
            // 
            // Male_rdbtn
            // 
            Male_rdbtn.AutoSize = true;
            Male_rdbtn.Location = new Point(99, 168);
            Male_rdbtn.Name = "Male_rdbtn";
            Male_rdbtn.Size = new Size(51, 19);
            Male_rdbtn.TabIndex = 27;
            Male_rdbtn.TabStop = true;
            Male_rdbtn.Text = "Male";
            Male_rdbtn.UseVisualStyleBackColor = true;
            // 
            // Female_rdbtn
            // 
            Female_rdbtn.AutoSize = true;
            Female_rdbtn.Location = new Point(167, 168);
            Female_rdbtn.Name = "Female_rdbtn";
            Female_rdbtn.Size = new Size(63, 19);
            Female_rdbtn.TabIndex = 28;
            Female_rdbtn.TabStop = true;
            Female_rdbtn.Text = "Female";
            Female_rdbtn.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 587);
            Controls.Add(Female_rdbtn);
            Controls.Add(Male_rdbtn);
            Controls.Add(Address_lbl);
            Controls.Add(textBox1);
            Controls.Add(Birthdate_cldr);
            Controls.Add(birthday_lbl);
            Controls.Add(Suffix_lbl);
            Controls.Add(MiddleName_lbl);
            Controls.Add(Suffix_txtbx);
            Controls.Add(MiddleName_txtbx);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(ReEnter_lbl);
            Controls.Add(ReEnterPassword_txtbx);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRegister);
            Controls.Add(checkBoxShow);
            Controls.Add(labelPassword);
            Controls.Add(Gender_lbl);
            Controls.Add(labelEmail);
            Controls.Add(labelLName);
            Controls.Add(labelFName);
            Controls.Add(boxPassword);
            Controls.Add(boxNumber);
            Controls.Add(boxEmail);
            Controls.Add(boxLName);
            Controls.Add(boxFName);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxFName;
        private TextBox boxLName;
        private TextBox boxEmail;
        private TextBox boxNumber;
        private TextBox boxPassword;
        private Label labelFName;
        private Label labelLName;
        private Label labelEmail;
        private Label Gender_lbl;
        private Label labelPassword;
        private CheckBox checkBoxShow;
        private Button buttonRegister;
        private Button buttonCancel;
        private CheckBox checkBox1;
        private Label ReEnter_lbl;
        private TextBox ReEnterPassword_txtbx;
        private Label label1;
        private Label Suffix_lbl;
        private Label MiddleName_lbl;
        private TextBox Suffix_txtbx;
        private TextBox MiddleName_txtbx;
        private Label birthday_lbl;
        private DateTimePicker Birthdate_cldr;
        private Label Address_lbl;
        private TextBox textBox1;
        private RadioButton Male_rdbtn;
        private RadioButton Female_rdbtn;
    }
}