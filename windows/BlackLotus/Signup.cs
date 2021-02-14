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
    public partial class Signup : Form
    {
        //object creat login class
        Login loginformobj = new Login();

        public Signup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
           
            try
            {

                //value passs to business layer Logclass variable to
                Logclass obj = new Logclass();
                //check if same password input or not
                if (passwordtxt.Text == cpasswordtxt.Text)
                {
                    obj.Password = passwordtxt.Text;
                    obj.UserName = usernametxt.Text;
                    obj.Comfrimpassword = cpasswordtxt.Text;

                    //  ExecuteNonQuery() if worked return value=truee return value=0

                    if (obj.Loginsignup() == 1)
                    {
                        MessageBox.Show("---SignUp completed---");
                        this.Hide();
                        //open login page
                        loginformobj.Show();


                        //  Console.WriteLine("---INSERTED DATA---");
                    }
                    else
                    {
                        MessageBox.Show("---EXECUTE ERROR---");
                        // Console.WriteLine("---EXECUTE ERROR---");
                    }
                }
                else
                {
                    MessageBox.Show("--- your passwords not same ---");
                    this.Hide();
                    new Signup().Show();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("---ERROR IN SQL CONNECTION---" + '\n' + ex);

                // Console.WriteLine("---ERROR IN SQL CONNECTION---");
                //    Console.WriteLine(ex);
            }
          
        }

        //back Button
        private void xuiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginformobj.Show();
        }
    }
}
