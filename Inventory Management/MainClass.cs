using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace Inventory_Management
{
    class MainClass
    {
        private static string path = Directory.GetCurrentDirectory();
        public static string connString=string.Empty;
        public static string s { get; set; }
        //File.ReadAllText(path + "\\connect");
        public static SqlConnection DBConn = new SqlConnection(s);
        public static Int64 purchseqID=0;
        public static int requiredID=0,rptChoice=0;
        public static string gblprodCode = string.Empty;
        public static string gblIndentStatus { get; set; }
        public static Int64 gblInvoice { get; set; }
        public static DateTime gblFromDate { get; set; }
        public static DateTime gblToDate { get; set; }
        public static Int64 gblIndentNo
        {
            get { return gblInvoice; }
            set { gblInvoice = value;  }
        }
        public static DialogResult showMSG(string msg, string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void showWindow(Form OpenWin, Form clsWin, Form MDIWin)
        {
            clsWin.Close();
            OpenWin.MdiParent = MDIWin;
            OpenWin.WindowState = FormWindowState.Maximized;
            OpenWin.Show();
        }

        public static void showWindow(Form OpenWin, Form MDIWin)
        {
            OpenWin.MdiParent = MDIWin;
            OpenWin.WindowState = FormWindowState.Maximized;
            OpenWin.Show();
        }
        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls )
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Clear();
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
            }
        }

        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
            }
        }

        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Clear();
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
            }
        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
            }
        }
        public static Int64 GenerateSeqID(String field, String tablename)
        {
            purchseqID = 0;
            SqlConnection SqlConn = new SqlConnection(s);
            SqlCommand SqlCmd = new SqlCommand("select max(" + field + ") from " + tablename, SqlConn);
            SqlConn.Open();
            SqlCmd.CommandType = CommandType.Text;
            SqlDataReader reader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        purchseqID = Convert.ToInt32(reader[0].ToString()) + 1;
                    }
                    else
                    {
                        purchseqID = 1;
                    }
                }
            }
            else
            {
                purchseqID = 1;
            }
            SqlConn.Close();
            return purchseqID;
        }

        public static void ValidateNumbersOnly(TextBox strTbox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(strTbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                strTbox.Text = strTbox.Text.Remove(strTbox.Text.Length - 1);
            }
        }
        public static int GetUnitId(String fieldIn, String fieldOut, String tablename, String Condition)
        {
            requiredID = 0;
            SqlConnection SqlConn = new SqlConnection(s);
            SqlCommand SqlCmd = new SqlCommand("select " + fieldOut + " from " + tablename + " where " + fieldIn + "='" + Condition + "'", SqlConn);
            SqlConn.Open();
            SqlCmd.CommandType = CommandType.Text;
            SqlDataReader reader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        requiredID = Convert.ToInt32(reader[0].ToString());
                    }
                }
            }
            SqlConn.Close();
            return requiredID;
        }

        public static String GetFieldInfo(String fieldIn, String fieldOut, String tablename, String Condition)
        {
            String RequiredString = String.Empty;
            SqlConnection SqlConn = new SqlConnection(s);
            SqlCommand SqlCmd = new SqlCommand("select " + fieldOut + " from " + tablename + " where " + fieldIn + "='" + Condition + "'", SqlConn);
            SqlConn.Open();
            SqlCmd.CommandType = CommandType.Text;
            SqlDataReader reader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        RequiredString = reader[0].ToString();
                    }
                }
            }
            SqlConn.Close();
            return RequiredString;
        }
    }
}
