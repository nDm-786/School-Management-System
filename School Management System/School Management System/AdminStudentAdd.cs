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
    public partial class AdminStudentAdd : Form
    {
        public AdminStudentAdd()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            // yahan pr new Add Student ka Procedure aayega
        }

        private void HumanVerification_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if (HumanVerification.Value == 100)
            {
                VerifyTxt.Text = "     Verified";
            }
        }
    }
}
