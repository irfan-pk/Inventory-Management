using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Inventory_Management
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            if (File.Exists(path + "\\connect"))
            {
                MainClass.s = File.ReadAllText(path + "\\connect");
                Login log = new Login();
                MainClass.showWindow(log, this);
            }
            else
            {
                Settings set = new Settings();
                MainClass.showWindow(set, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.showWindow(log, this);
            MDI.logOutToolStripMenuItem.Enabled = false;
        }
    }
}
