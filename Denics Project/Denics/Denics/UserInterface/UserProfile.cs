using System.Data.SqlClient;

namespace Denics.UserInterface
{
    public partial class UserProfile : Form
    {
        // Call database connection here
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;
        // Recived user ID from UserAccount
        private int userId;

        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            // Get user ID from UserAccount
            userId = Denics.UserAccount.GetUserIdOrDefault();
            UserIdtxtb.Text = userId.ToString();

        }
    }
}
