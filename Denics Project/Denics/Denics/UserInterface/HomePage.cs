using System;
using System.Data.SqlClient;

namespace Denics.UserInterface
{
    public partial class HomePage : Form
    {
        // Call database connection here
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;
        private int userId;
        private string userName;

        // Allow constructing with an explicit userId
        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Get user ID from UserAccount
            userId = Denics.UserAccount.GetUserIdOrDefault();

            // Load username to Username_lbl
            LoadUsername();
        }

        private void LoadUsername()
        {

            try
            {
                con.Open();
                string query = "SELECT [firstname] FROM [Users] WHERE [user_id] = @UserId";
                using (cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userName = result.ToString();
                        Username_lbl.Text = $"Welcome, {userName}!";
                    }
                    else
                    {
                        Username_lbl.Text = "Welcome!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading username: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void PatientButton_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
            this.Hide();
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            Doctors doctors = new Doctors();
            doctors.Show();
            this.Hide();
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            UserBookingPage userBookingPage = new UserBookingPage();
            userBookingPage.Show();
            this.Hide();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            AvailableServices availableServices = new AvailableServices();
            availableServices.Show();
            this.Hide();
        }
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Denics.UserAccount.Clear(); // Clear current user on logout
            LogInPage loginPage = new LogInPage();
            loginPage.Show();
            this.Hide();
        }

    }
}
