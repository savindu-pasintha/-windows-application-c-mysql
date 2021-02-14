using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackLotus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*Run programs names constructors call here*/
            Application.Run(new BlackLotusForm());
            //  Application.Run(new WorkForm());
            //   Application.Run(new Login());
            //Application.Run(new Signup());
            //  Application.Run(new LoginSignup());
            //Application.Run(new Form1());
            //   Application.Run(new ResetForm());

        }
    }
}
