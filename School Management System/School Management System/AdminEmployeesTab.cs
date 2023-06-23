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
using System.Windows.Input;

namespace School_Management_System
{
    public partial class AdminEmployeesTab : Form
    {
        public AdminEmployeesTab()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        SqlConnection con = new SqlConnection("Data Source=.\\;Initial Catalog=SMS;Integrated Security=True");
=======
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-38NRAVC\\ALISERVER;Initial Catalog=SMS;Integrated Security=True");
        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
>>>>>>> 835c7f472674a291cbc9de3d9ee38716b03a363b

        private void LogoutTab_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentsTab_Click(object sender, EventArgs e)
        {
            AdminStudentTab st = new AdminStudentTab();
            st.Show();
            this.Hide();
        }

        private void StudentTab_Click(object sender, EventArgs e)
        {
            AdminStudentTab st = new AdminStudentTab();
            st.Show();
            this.Hide();
        }

        private void AdminEmployeesTab_Load(object sender, EventArgs e)
        {
            showEmployee();
        }
        private void showEmployee()
        {
            string querry = "exec GetAllEmployees";
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
            using (SqlCommand command = new SqlCommand("InsertEmployee", con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", IDTxt.Text);
                command.Parameters.AddWithValue("@Name", NameTxt.Text);
                command.Parameters.AddWithValue("@Age", 21);
                command.Parameters.AddWithValue("@Phone", PhoneTxt.Text);
                command.Parameters.AddWithValue("@Address", AddressTxt.Text);
                command.Parameters.AddWithValue("@Gender", "Male");
                command.Parameters.AddWithValue("@RoleID", 2);
                command.Parameters.AddWithValue("@Password", 1786);

                command.ExecuteNonQuery();
                con.Close();
                showEmployee();
                clearFields();

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand("DeleteEmployee", con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", IDTxt.Text);
                command.ExecuteNonQuery();
                con.Close();
                showEmployee();
                clearFields();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand("UpdateEmployee", con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", IDTxt.Text);
                command.Parameters.AddWithValue("@Name", NameTxt.Text);
                command.Parameters.AddWithValue("@Phone", PhoneTxt.Text);
                command.Parameters.AddWithValue("@Address", AddressTxt.Text);
                command.ExecuteNonQuery();
                con.Close();
                showEmployee();
                clearFields();
            }
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

        private void OnHoldStudentsTab_Click(object sender, EventArgs e)
        {
            AdminOnHoldStudents adminOnHoldStudents = new AdminOnHoldStudents();
            adminOnHoldStudents.Show();
            this.Hide();
        }
        int key = 0;
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTxt.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            NameTxt.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTxt.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            AddressTxt.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            if (NameTxt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
