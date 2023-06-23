using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ServiceModel.Configuration;

namespace School_Management_System
{
    public partial class AdminStudentAdd : Form
    {
        public AdminStudentAdd()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand("AddStudentToOnHoldStudents", con))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", NameTxt.Text);
                command.Parameters.AddWithValue("@Age", AgeTxt.Text);
                command.Parameters.AddWithValue("@Phone", PhoneTxt.Text);
                command.Parameters.AddWithValue("@Address", AddressTxt.Text);
                command.Parameters.AddWithValue("@Gender", GenderTxt.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Password", PasswordTxt.Text);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Registered Successfully!!!");
                AdminStudentTab ast=new AdminStudentTab();
                ast.Show();
                this.Hide();
            }
        }

    }
}
