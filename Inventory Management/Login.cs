using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Login : Sample 
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == string.Empty) { lblnameError.Visible = true; } else { lblnameError.Visible = false; }
            if (textPassword.Text == string.Empty) { lblPassError.Visible = true; } else { lblPassError.Visible = false; }

            if (lblnameError.Visible || lblPassError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (Retrieve.getUserDetail(textUsername.Text, textPassword.Text))
                {
                    HomeScreen obj = new HomeScreen();
                    MainClass.showWindow(obj, this, MDI.ActiveForm);
                }
                else
                {

                }
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
            if (textUsername.Text == string.Empty) { lblnameError.Visible = true; } else { lblnameError.Visible = false; }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text == string.Empty) { lblPassError.Visible = true; } else { lblPassError.Visible = false; }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { btnLogin_Click(sender, e); }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            MainClass.s = File.ReadAllText(path + "\\connect");
            MainClass.DBConn.ConnectionString = MainClass.s;
        }
    }
}
