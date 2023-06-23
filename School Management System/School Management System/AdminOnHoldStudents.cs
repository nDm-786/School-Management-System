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
using System.Windows.Input;

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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardTabb_Click(object sender, EventArgs e)
        {
            AdminDashboardTab adt=new AdminDashboardTab();
            adt.Show();
            this.Hide();
        }

        private void StudentTab_Click(object sender, EventArgs e)
        {
            AdminStudentTab adt = new AdminStudentTab();
            adt.Show();
            this.Hide();
        }

        private void EmployeesTab_Click(object sender, EventArgs e)
        {
            AdminEmployeesTab adt = new AdminEmployeesTab();
            adt.Show();
            this.Hide();
        }

        private void TimeTableTab_Click(object sender, EventArgs e)
        {
            AdminTimeTableTab adt = new AdminTimeTableTab();
            adt.Show();
            this.Hide();
        }

        private void ExamsTab_Click(object sender, EventArgs e)
        {
            AdminExamsTab adminExamsTab = new AdminExamsTab(); 
            adminExamsTab.Show();
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string querry = "Update OnHoldStudents set ClassID = " + AssignClassTxt.SelectedIndex.ToString() + " where StudentID =" + IDTxt.Text + ";";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataGrid.DataSource = dt;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            IDTxt.Text = "";
            NameTxt.Text = "";
            PhoneTxt.Text = "";
            AddressTxt.Text = "";
            AssignClassTxt.SelectedIndex = 0;
        }
    }
}
