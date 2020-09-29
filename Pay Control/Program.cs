using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_Control
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
            frmlogin logando = new frmlogin();
            if (logando.ShowDialog() == DialogResult.OK)
            { 
                Application.Run(new frmhome()); 
            }

            
        }
    }
}
