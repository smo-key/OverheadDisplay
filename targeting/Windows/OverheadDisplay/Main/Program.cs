using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OverheadDisplay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);            
                Application.Run(new Startup());
            }
            catch (Exception ex)
            {
                Assets.PreLoad_Error error = new Assets.PreLoad_Error("An internal error has occured.\r\n[Overhead Display]  " + ex.Message);
                error.ShowDialog();
                return;
            }
        }
    }
}
