﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class AdminDashboardTab : Form
    {
        public AdminDashboardTab()
        {
            InitializeComponent();
        }

        private void EmployeeTab_Paint(object sender, PaintEventArgs e)
        {
            AdminEmployeesTab et = new AdminEmployeesTab();
            et.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            AdminTimeTableTab ttt=new AdminTimeTableTab();
            ttt.Show();
            this.Hide();
        }

        private void StudentsTab_Paint(object sender, PaintEventArgs e)
        {
            AdminStudentTab st = new AdminStudentTab();
            st.Show();
            this.Hide();
        }

        private void ExamTab_Paint(object sender, PaintEventArgs e)
        {
            AdminExamsTab et = new AdminExamsTab();
            et.Show();
            this.Hide();
        }
    }
}
