using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLoginSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin LoginForm = new FormLogin();
            Application.Run(LoginForm);
            //frmRegister RegisterForm = new frmRegister();
            //Application.Run(RegisterForm);
        }
    }
}
