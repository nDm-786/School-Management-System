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
    public partial class AdminTimeTableTab : Form
    {
        public AdminTimeTableTab()
        {
            InitializeComponent();
        }

        private void DashboardTab_Paint(object sender, PaintEventArgs e)
        {
            AdminDashboardTab dt = new AdminDashboardTab();
            dt.Show();
            this.Hide();
        }

        private void EmployeeTab_Paint(object sender, PaintEventArgs e)
        {
            AdminEmployeesTab et = new AdminEmployeesTab();
            et.Show();
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
