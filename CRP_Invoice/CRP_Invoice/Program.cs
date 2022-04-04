using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRP_Invoice
{    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string WsUsername = System.Configuration.ConfigurationManager.AppSettings["username"];
        public static string WsPassword = System.Configuration.ConfigurationManager.AppSettings["pass"];
        public static string SysUsername = System.Configuration.ConfigurationManager.AppSettings["ACuser"];
        public static string SysPassword = System.Configuration.ConfigurationManager.AppSettings["ACpass"];
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Main());
        }
    }
}