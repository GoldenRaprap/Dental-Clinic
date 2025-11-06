using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denics.Administrator
{
    public partial class NotificationPage : Form
    {
        // Database connection
        static CallDatabase db = new CallDatabase();
        SqlConnection con = new SqlConnection(db.getDatabaseStringName());
        SqlCommand cmd;

        public NotificationPage()
        {
            InitializeComponent();
        }

        private void NotificationPage_Load(object sender, EventArgs e)
        {

        }
    }
}
