namespace Denics.UserInterface
{
    partial class UserProfile
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
            UserIdtxtb = new TextBox();
            SuspendLayout();
            // 
            // UserIdtxtb
            // 
            UserIdtxtb.Location = new Point(323, 102);
            UserIdtxtb.Name = "UserIdtxtb";
            UserIdtxtb.Size = new Size(100, 23);
            UserIdtxtb.TabIndex = 0;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserIdtxtb);
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserIdtxtb;
    }
}