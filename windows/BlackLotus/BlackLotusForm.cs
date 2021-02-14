using System;
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
    public partial class BlackLotusForm : Form
    {
        //progress abr to timer
        int count = 0;

        public BlackLotusForm()
        {
            InitializeComponent();

           //timer to progress bar
            timer1.Start();
            timer1.Enabled = true;
            timer1.Interval = 10;


        }

      


        //timer auto increment event
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            count++;
           
                xuiFlatProgressBar1.Value = count;
                              // int convert to string
                label2.Text = count.ToString();
           
            if (count >= 100)
            {    
                //stop the timer repetition
                timer1.Stop();
                //hide the current view page
                this.Hide();
                //open new new page --> LoginSignup.cs file
                new LoginSignup().Visible=true;
                
            }
        }




        private void BlackLotusForm_Load(object sender, EventArgs e)
        {

        }

        private void xuiFlatProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
