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
using static Guna.UI2.Native.WinApi;

namespace School_Management_System
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.Show();
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (adminRadButton.Checked) {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Admins where AdminID = '" + IDTxt.Text + "'and Password = '" + PasswordTxt.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AdminDashboardTab b1 = new AdminDashboardTab();
                    b1.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong ID or Password!!!");
                }
                con.Close();
            }
        }
    }
}
