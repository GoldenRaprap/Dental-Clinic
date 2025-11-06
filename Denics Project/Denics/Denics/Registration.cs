using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denics.Administrator
{
    public partial class Registration : Form
    {
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;

        public Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            boxPassword.UseSystemPasswordChar = true;
        }

        private bool IsDuplicateUser(string email, string contact, int? userId = null)
        {
            con.Open();
            string query;

            if (userId == null) // Add mode
            {
                query = "SELECT COUNT(*) FROM Users WHERE email = @Email OR contact = @Contact";
            }
            else // Edit mode
            {
                query = "SELECT COUNT(*) FROM Users WHERE (email = @Email OR contact = @Contact) AND user_id != @UserId";
            }

            SqlCommand checkCmd = new SqlCommand(query, con);
            checkCmd.Parameters.AddWithValue("@Email", email);
            checkCmd.Parameters.AddWithValue("@Contact", contact);

            if (userId != null)
            {
                checkCmd.Parameters.AddWithValue("@UserId", userId.Value);
            }

            int count = (int)checkCmd.ExecuteScalar();
            con.Close();

            return count > 0;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(boxFName.Text) ||
                string.IsNullOrWhiteSpace(boxLName.Text) ||
                string.IsNullOrWhiteSpace(boxEmail.Text) ||
                string.IsNullOrWhiteSpace(boxNumber.Text) ||
                string.IsNullOrWhiteSpace(boxPassword.Text))
            {
                MessageBox.Show("Please fill in all fields before saving.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsDuplicateUser(boxEmail.Text, boxNumber.Text))
            {
                MessageBox.Show("This user already exists (duplicate Email or Contact).", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rawPassword = boxPassword.Text;
            string hashedPassword = HashPassword(rawPassword);

            con.Open();
            cmd = new SqlCommand("INSERT INTO Users (surname, firstname, email, password, contact) VALUES(@surname, @firstname, @email, @password, @contact)", con);
            cmd.Parameters.AddWithValue("@surname", boxLName.Text);
            cmd.Parameters.AddWithValue("@firstname", boxFName.Text);
            cmd.Parameters.AddWithValue("@email", boxEmail.Text);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            cmd.Parameters.AddWithValue("@contact", boxNumber.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Registered!");

            // Return to LogInPage
            LogInPage loginPage = new LogInPage();
            loginPage.Show();
            this.Hide();

        }
        // 🔐 Password Hashing Method
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                boxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                boxPassword.UseSystemPasswordChar = true;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LogInPage loginPage = new LogInPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
