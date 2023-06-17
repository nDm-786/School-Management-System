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
    public partial class AdminMDI : Form
    {
        public AdminMDI()
        {
            InitializeComponent();
        }
        private bool isStudentFormOpen = false;
        private void StudentTab_Click(object sender, EventArgs e)
        {
            if (!isStudentFormOpen)
            {
                AdminStudents adminStudents = new AdminStudents();
                adminStudents.MdiParent = this;
                adminStudents.Show();
                isStudentFormOpen = true;
            }
        }
    }
}
