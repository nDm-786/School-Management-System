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
    public partial class AdminStudentTab : Form
    {
        public AdminStudentTab()
        {
            InitializeComponent();
        }

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
            AdminTeachersTab adt=new AdminTeachersTab();
            adt.Show();
            this.Hide();
        }

        private void TeacherTab_Click(object sender, EventArgs e)
        {
            AdminTeachersTab adt = new AdminTeachersTab();
            adt.Show();
            this.Hide();
        }



        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
