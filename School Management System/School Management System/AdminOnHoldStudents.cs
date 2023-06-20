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
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class AdminOnHoldStudents : Form
    {
        public AdminOnHoldStudents()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
        private void AdminOnHoldStudents_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }
        private void LoadStudent()
        {
            string querry = "exec GetOnHoldStudents";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataGrid.DataSource = dt;

        }
    }
}
