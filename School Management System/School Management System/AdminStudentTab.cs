using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Net;
using System.Xml.Linq;
using System.Configuration;
using System.Runtime.Serialization.Formatters;

// ...


namespace School_Management_System
{
    public partial class AdminStudentTab : Form
    {
        //private readonly string  connectionString;
        //private readonly SqlConnection con;
        public AdminStudentTab()
        {
          
            InitializeComponent();
            //connectionString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            //con = new SqlConnection(connectionString);
        }

        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
        //SqlConnection  con = new SqlConnection("Data Source=DESKTOP-38NRAVC\\ALISERVER;Initial Catalog=SMS;Integrated Security=True");
        private void LogoutTab_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeachersTab_Click(object sender, EventArgs e)
        {
// HEAD
            //AdminTeachersTab adt = new AdminTeachersTab();
//
            AdminEmployeesTab adt=new AdminEmployeesTab();
// 5746d54abf6e1cdade2c127bc48f96ac81e45cfe
            adt.Show();
            this.Hide();
        }

        private void TeacherTab_Click(object sender, EventArgs e)
        {
            AdminEmployeesTab adt = new AdminEmployeesTab();
            adt.Show();
            this.Hide();
        }
        int key = 0;
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTxt.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            NameTxt.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTxt.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            AddressTxt.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            if (NameTxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void AdminStudentTab_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void LoadStudent()
        {
            string querry = "exec getStudents";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataGrid.DataSource = dt;

        }

        private void clearFields()
        {

            IDTxt.Text = "";
            NameTxt.Text = "";
            PhoneTxt.Text = "";
            AddressTxt.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AdminStudentAdd adminStudentAdd = new AdminStudentAdd();
            adminStudentAdd.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand("UpdateStudent", con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", IDTxt.Text);
                command.Parameters.AddWithValue("@Name", NameTxt.Text);
                command.Parameters.AddWithValue("@Phone", PhoneTxt.Text);
                command.Parameters.AddWithValue("@Address", AddressTxt.Text);
                command.ExecuteNonQuery();
                con.Close();
                LoadStudent();
                clearFields();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand("DeleteStudent", con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", IDTxt.Text);
                command.ExecuteNonQuery();
                con.Close();
                LoadStudent();
                clearFields();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }



        private void DashboardTabb_Click(object sender, EventArgs e)
        {
            AdminDashboardTab dt = new AdminDashboardTab();
            dt.Show();
            this.Hide();
        }

        private void TimeTableTab_Click(object sender, EventArgs e)
        {
            AdminTimeTableTab ttt = new AdminTimeTableTab();
            ttt.Show();
            this.Hide();
        }

        private void ExamsTab_Click(object sender, EventArgs e)
        {
            AdminExamsTab et = new AdminExamsTab();
            et.Show();
            this.Hide();
        }
    }
}
