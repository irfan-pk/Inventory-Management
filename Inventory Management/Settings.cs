using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory_Management
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = string.Empty;
            string path = Directory.GetCurrentDirectory();
            if (cbIntegrated.Checked)
            {
                if (textServer.Text != string.Empty && textDatabase.Text != string.Empty)
                {
                    connString = "Data Source="+textServer.Text+";Initial Catalog="+textDatabase.Text+ ";Integrated Security=true;NETWORK LIBRARY=DBMSSOCN;MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect", connString);
                    DialogResult dr =  MessageBox.Show("Settings saved successfully ..!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                        {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give all parameters ...","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                if (textServer.Text != string.Empty && textDatabase.Text != string.Empty && textUserId.Text != string.Empty && textPassword .Text != string.Empty)
                {
                    connString = "Data Source="+textServer.Text +";Initial Catalog="+textDatabase.Text+";User Id="+textUserId.Text +";password="+textPassword.Text+ ";NETWORK LIBRARY=DBMSSOCN;MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect", connString);
                    DialogResult dr = MessageBox.Show("Settings saved successfully ..!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give all parameters ...","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cbIntegrated_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIntegrated.Checked)
            {
                textUserId.Enabled = false;
                textPassword.Enabled = false;
                textUserId.Clear();
                textPassword.Clear();
            }
            else
            {
                textUserId.Enabled = true;
                textPassword.Enabled = true;
            }
        }
    }
}
