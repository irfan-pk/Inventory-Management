using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class InventoryJournal : SampleExt
    {
        string[] prodArray = new string[11];
        string productID;
        Retrieve r = new Retrieve();
        public InventoryJournal()
        {
            InitializeComponent();
        }

        private void InventoryJournal_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            tableLayoutPanel1.Visible = false;
            dgvShowData.AutoGenerateColumns = false;
            dgvShowData.DataSource = null;
        }

        private void textItemCode_TextChanged(object sender, EventArgs e)
        {
            if (textItemCode.Text != string.Empty)
            {
                prodArray = r.getProductByCode(textItemCode.Text.ToUpper());
                productID = prodArray[0];
                if (productID != null) { btnSearch.Focus(); }
            }
            else
            {
                textItemCode.Clear();
            }
        }

        private void textItemCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                CodeList cl = new CodeList();
                cl.ShowDialog();
                textItemCode.Text = MainClass.gblprodCode;
                textItemCode.SelectAll();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textItemCode.Text == string.Empty) { lblitemError.Visible = true; } else { lblitemError.Visible = false; }

            if (lblitemError.Visible)
            {
                MainClass.showMSG("Field with * is mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                r.showInvJournalByDate(dgvShowData, idGV, dateGV, indentGV, codeGV, nameGV, descGV, opnbalGV, recvGV, issueGV, clobalGV, dtpFromDate.Value, dtpToDate.Value, textItemCode.Text.Trim());
                Array.Clear(prodArray, 0, prodArray.Length);
                textItemCode.Clear();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dgvShowData.DataSource = null;
            dtpFromDate.Value = DateTime.Now;
            dtpToDate.Value = DateTime.Now;
            textItemCode.Clear();
            dtpFromDate.Focus();
            Array.Clear(prodArray, 0, prodArray.Length);
        }
    }
}
