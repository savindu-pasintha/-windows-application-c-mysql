﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackLotus
{
    public partial class LoginSignup : Form
    {
        public LoginSignup()
        {
            InitializeComponent();
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open the login page
            Login loginformobj = new Login();
            loginformobj.Show();

        }

        private void xuiSuperButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open the sign up page
            Signup signupformobj = new Signup();
            signupformobj.Show();

        }
    }
}
