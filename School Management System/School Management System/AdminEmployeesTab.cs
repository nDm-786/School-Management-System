using System;
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
    public partial class AdminEmployeesTab : Form
    {
        public AdminEmployeesTab()
        {
            InitializeComponent();
        }

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
            AdminStudentTab ads = new AdminStudentTab();
            ads.Show();
            this.Hide();
        }

        private void StudentTab_Click(object sender, EventArgs e)
        {
            AdminStudentTab ads = new AdminStudentTab();
            ads.Show();
            this.Hide();
        }
    }
}
