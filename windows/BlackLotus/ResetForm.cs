using BusinessLayer;
using log4net.Layout;
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

namespace BlackLotus
{
    public partial class ResetForm : Form
    {
        public ResetForm()
        {
            InitializeComponent();
        }

        //back button
        private void XuiButton1_Click(object sender, EventArgs e)
        {
           

            this.Hide();
            LoginSignup obj = new LoginSignup();
            obj.Show();

        }

        //reset butoon  Business layer Logclass methods call
        private void XuiSuperButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Logclass obj = new Logclass
                {
                    Comfrimpassword = cpasswordtxt.Text,
                    UserName = usernametxt.Text,
                    Password = passwordtxt.Text
                };

                if (obj.LoginResetPassword() == 1)
                {
                    MessageBox.Show("---Password Reset Now---");
                    this.Hide();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("--- erro in you  username or password ---");
                    this.Hide();
                    new ResetForm().Show();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

    }
}
