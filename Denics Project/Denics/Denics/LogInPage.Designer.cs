namespace Denics
{
    partial class LogInPage
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
            Emailtxtb = new TextBox();
            Passwordtxtb = new TextBox();
            LogInbtn = new Button();
            Registerbtn = new Button();
            Emaillable = new Label();
            Passwordlabel = new Label();
            Admin_btn = new Button();
            Temporary = new Label();
            button1 = new Button();
            ShowPassword_chkbx = new CheckBox();
            ForgotPassword_btn = new Label();
            SuspendLayout();
            // 
            // Emailtxtb
            // 
            Emailtxtb.Location = new Point(223, 85);
            Emailtxtb.Name = "Emailtxtb";
            Emailtxtb.Size = new Size(240, 23);
            Emailtxtb.TabIndex = 0;
            // 
            // Passwordtxtb
            // 
            Passwordtxtb.Location = new Point(223, 131);
            Passwordtxtb.Name = "Passwordtxtb";
            Passwordtxtb.Size = new Size(240, 23);
            Passwordtxtb.TabIndex = 1;
            // 
            // LogInbtn
            // 
            LogInbtn.Location = new Point(223, 190);
            LogInbtn.Name = "LogInbtn";
            LogInbtn.Size = new Size(75, 23);
            LogInbtn.TabIndex = 2;
            LogInbtn.Text = "Log In";
            LogInbtn.UseVisualStyleBackColor = true;
            LogInbtn.Click += LogInbtn_Click;
            // 
            // Registerbtn
            // 
            Registerbtn.Location = new Point(388, 190);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(75, 23);
            Registerbtn.TabIndex = 3;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = true;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // Emaillable
            // 
            Emaillable.AutoSize = true;
            Emaillable.Location = new Point(223, 67);
            Emaillable.Name = "Emaillable";
            Emaillable.Size = new Size(42, 15);
            Emaillable.TabIndex = 4;
            Emaillable.Text = "Email: ";
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(223, 113);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(63, 15);
            Passwordlabel.TabIndex = 5;
            Passwordlabel.Text = "Password: ";
            // 
            // Admin_btn
            // 
            Admin_btn.Location = new Point(234, 306);
            Admin_btn.Name = "Admin_btn";
            Admin_btn.Size = new Size(212, 23);
            Admin_btn.TabIndex = 6;
            Admin_btn.Text = "Administrator Interface";
            Admin_btn.UseVisualStyleBackColor = true;
            Admin_btn.Click += Admin_btn_Click;
            // 
            // Temporary
            // 
            Temporary.AutoSize = true;
            Temporary.Location = new Point(234, 288);
            Temporary.Name = "Temporary";
            Temporary.Size = new Size(63, 15);
            Temporary.TabIndex = 7;
            Temporary.Text = "Temporary";
            // 
            // button1
            // 
            button1.Location = new Point(234, 335);
            button1.Name = "button1";
            button1.Size = new Size(212, 23);
            button1.TabIndex = 8;
            button1.Text = "Patient Interface";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ShowPassword_chkbx
            // 
            ShowPassword_chkbx.AutoSize = true;
            ShowPassword_chkbx.Location = new Point(355, 160);
            ShowPassword_chkbx.Name = "ShowPassword_chkbx";
            ShowPassword_chkbx.Size = new Size(108, 19);
            ShowPassword_chkbx.TabIndex = 9;
            ShowPassword_chkbx.Text = "Show Password";
            ShowPassword_chkbx.UseVisualStyleBackColor = true;
            ShowPassword_chkbx.CheckedChanged += ShowPassword_chkbx_CheckedChanged;
            // 
            // ForgotPassword_btn
            // 
            ForgotPassword_btn.AutoSize = true;
            ForgotPassword_btn.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            ForgotPassword_btn.Location = new Point(295, 236);
            ForgotPassword_btn.Name = "ForgotPassword_btn";
            ForgotPassword_btn.Size = new Size(95, 15);
            ForgotPassword_btn.TabIndex = 10;
            ForgotPassword_btn.Text = "Forgot Password";
            // 
            // LogInPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 408);
            Controls.Add(ForgotPassword_btn);
            Controls.Add(ShowPassword_chkbx);
            Controls.Add(button1);
            Controls.Add(Temporary);
            Controls.Add(Admin_btn);
            Controls.Add(Passwordlabel);
            Controls.Add(Emaillable);
            Controls.Add(Registerbtn);
            Controls.Add(LogInbtn);
            Controls.Add(Passwordtxtb);
            Controls.Add(Emailtxtb);
            Name = "LogInPage";
            Text = "LogIn Page";
            Load += LogInPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Emailtxtb;
        private TextBox Passwordtxtb;
        private Button LogInbtn;
        private Button Registerbtn;
        private Label Emaillable;
        private Label Passwordlabel;
        private Button Admin_btn;
        private Label Temporary;
        private Button button1;
        private CheckBox ShowPassword_chkbx;
        private Label ForgotPassword_btn;
    }
}