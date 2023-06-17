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

namespace School_Management_System
{
    public partial class AdminStudentTab : Form
    {
        public AdminStudentTab()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);

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
            AdminEmployeesTab adt=new AdminEmployeesTab();
            adt.Show();
            this.Hide();
        }

        private void TeacherTab_Click(object sender, EventArgs e)
        {
            AdminEmployeesTab adt = new AdminEmployeesTab();
            adt.Show();
            this.Hide();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            con.Open();
            using (SqlCommand command = new SqlCommand("CreateStudent", con))
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

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
