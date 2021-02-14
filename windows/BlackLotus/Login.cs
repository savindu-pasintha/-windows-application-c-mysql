using BusinessLayer;
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
    public partial class Login : Form
    {
        int c;

        public Login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /*frogotpassword_Click event to set open resetForm*/
        private void frogotpassword_Click(object sender, EventArgs e)
        {
            //this.hide
            this.Hide();
            ResetForm resetformobj = new ResetForm();
            resetformobj.Show();
          
        }
        /*signin button to call business layer logclass*/
        private void Signin_Click(object sender, EventArgs e)
        {
            //  check();

            try
            {

                //BusinessLayer Logclass --> LoginSign(); method execute
                Logclass obj = new Logclass();
                obj.Password = loginpassword.Text;
                obj.UserName = loginemil.Text;
                c = obj.LoginSign();
                if (c == 1)
                {
                    MessageBox.Show("--Login Success--");
                    this.Hide();
                    // open to show dashboard== work form
                    WorkForm workformobj = new WorkForm();
                   workformobj.Show();
                }
                else
                {
                    MessageBox.Show("--Login Failed--");
                    this.Hide();
                    new Login().Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }

        }

        //back Button
        private void XuiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signupobj = new Signup();
            signupobj.Show();

        }


    }


}
