using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tourism_Company.PL;

namespace Tourism_Company
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        internal static string salesman;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_LogIn() );
        }
    }
}
