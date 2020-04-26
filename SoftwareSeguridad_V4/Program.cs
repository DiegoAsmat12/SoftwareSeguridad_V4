using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SoftwareSeguridad_V4
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
            PestañaLogin login = new PestañaLogin();
            login.FormClosed += Login_Closed;
            login.Show();
            Application.Run();
        }

        private static void Login_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Login_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Login_Closed;
            }
        }
    }
}
