using Denics.Administrator;
using Denics.UserInterface;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Denics
{
    public partial class LogInPage : Form
    {
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;

        public LogInPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
            Emailtxtb.Text = "";
            Passwordtxtb.Text = "";
            Passwordtxtb.UseSystemPasswordChar = true;
        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Emailtxtb.Text.Trim();
                string password = Passwordtxtb.Text.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both Email and Password.");
                    return;
                }

                con.Open();
                string query = "SELECT [user_id], [role], [password] FROM [Users] WHERE [email] = @Email";
                using (var cmdLocal = new SqlCommand(query, con))
                {
                    cmdLocal.Parameters.AddWithValue("@Email", email);

                    using (var reader = cmdLocal.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Invalid Email or Password. Please try again.");
                            return;
                        }

                        int userId = Convert.ToInt32(reader["user_id"]);
                        string role = reader["role"]?.ToString() ?? "";
                        string storedHash = reader["password"]?.ToString() ?? "";

                        string enteredHash = HashPassword(password);

                        if (!string.Equals(enteredHash, storedHash, StringComparison.Ordinal))
                        {
                            MessageBox.Show("Invalid Email or Password. Please try again.");
                            return;
                        }


                        Denics.UserAccount.SetUserId(userId); // set global current user id

                        if (role == "admin")
                        {
                            var adminPage = new MainAdminPage();
                            adminPage.Show();
                            this.Hide();
                        }
                        else if (role == "patient")
                        {
                            var homepage = new HomePage();
                            homepage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Unknown user role. Contact administrator.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        // helper - must match Registration's hashing exactly
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Temporary buttons for development
        private void Admin_btn_Click(object sender, EventArgs e)
        {
            MainAdminPage adminPage = new MainAdminPage();
            adminPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Denics.UserAccount.SetUserId(2); // set temporary user id
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Hide();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
            this.Hide();
        }

        // Checkbox to show/hide password
        private void ShowPassword_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_chkbx.Checked)
            {
                Passwordtxtb.UseSystemPasswordChar = false;
            }
            else
            {
                Passwordtxtb.UseSystemPasswordChar = true;
            }
        }
    }
}
