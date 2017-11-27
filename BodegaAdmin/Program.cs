using BodegaAdmin.localhost;
using System;
using System.Windows.Forms;

namespace BodegaAdmin
{
    static class Program
    {
        public static User user;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
