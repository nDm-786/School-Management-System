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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace School_Management_System
{
    public partial class AdminDashboardTab : Form
    {
        public AdminDashboardTab()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        readonly SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=SMS;Integrated Security=True");
=======
        //readonly SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=SMS;Integrated Security=True");
        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
>>>>>>> 835c7f472674a291cbc9de3d9ee38716b03a363b

        public void loadgridviews()
        {
            string querry = "Select * from StudentAudit";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataGridStudents.DataSource = dt;

            string querry1 = "Select * from EmployeeAudit";
            SqlCommand cmd1 = new SqlCommand(querry1, con);
            SqlDataAdapter sd1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sd1.Fill(dt1);
            DataGridEmployees.DataSource = dt1;
        }

        
        private void AdminDashboardTab_Load(object sender, EventArgs e)
        {
            loadgridviews();
            updateStudentCount();
            updateEmployeeCount();
            updateEnrollCount();
            updateClassWithMostAdmissions();
            updateBestPerformingClass();
            updateOnHoldStudents();
        }
        public void updateStudentCount()
        {
            string querry = "SELECT * FROM TotalStudentsView;";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            StudentCount.Text = dt.Rows[0][0].ToString();
        }
        public void updateEmployeeCount()
        {
            string querry = "SELECT * FROM TotalEmployeesView;";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            EmployeeCount.Text = dt.Rows[0][0].ToString();
        }
        public void updateEnrollCount()
        {
            string querry = "SELECT * FROM View_EnrollmentCountLast6Months;";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            Past6MonthCount.Text = dt.Rows[0][0].ToString();
            StartDate.Text = dt.Rows[0][1].ToString().Substring(0,11);
            EndDate.Text = dt.Rows[0][2].ToString().Substring(0, 11);
        }
        public void updateClassWithMostAdmissions()
        {
            string querry = "SELECT * FROM ClassWithMostAdmissions;";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            MostAdmittedClass.Text = dt.Rows[0][1].ToString();
        }
        public void updateBestPerformingClass()
        {
            string querry = "Select ClassName from Classes where ClassID = (select ClassID from BestPerformingClass);";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            BestPerformance.Text = dt.Rows[0][0].ToString();
        }
        public void updateOnHoldStudents()
        {
            string querry = "select * from GetOnHoldStudents1;";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            OnHoldStdCount.Text = dt.Rows[0][0].ToString();
        }
        private void StudentsTabb_Click(object sender, EventArgs e)
        {
            AdminStudentTab st = new AdminStudentTab();
            st.Show();
            this.Hide();
        }

        private void EmployeesTab_Click(object sender, EventArgs e)
        {
            AdminEmployeesTab et = new AdminEmployeesTab();
            et.Show();
            this.Hide();
        }

        private void TimeTableTabb_Click(object sender, EventArgs e)
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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnHoldStudentsTab_Click(object sender, EventArgs e)
        {
            AdminOnHoldStudents adminOnHoldStudents = new AdminOnHoldStudents();
            adminOnHoldStudents.Show();
            this.Hide();
        }
    }
}
