﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class AdminTimeTableTab : Form
    {
        public AdminTimeTableTab()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString);

        private void DashboardTabb_Click(object sender, EventArgs e)
        {
            AdminDashboardTab dt = new AdminDashboardTab();
            dt.Show();
            this.Hide();
        }

        private void StudentTab_Click(object sender, EventArgs e)
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

        private void AdminTimeTableTab_Load(object sender, EventArgs e)
        {
            showTimeTables();
        }
        private void showTimeTables()
        {
            string querry = "exec GetAllTimeTables";
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
    }
}
