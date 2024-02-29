using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
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
            Process[] process = Process.GetProcessesByName(Application.ProductName); //Prevent multiple instance
            if (process.Length > 1)
            {
                MessageBox.Show(Application.ProductName + " is already running. This instance will now close.", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                Application.Run(new MDI());
            }
        }
    }
}
