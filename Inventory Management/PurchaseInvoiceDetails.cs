using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class PurchaseInvoiceDetails : SampleExt
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        Int64 printInvoiceNo = 0;
        Retrieve r = new Retrieve();
        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            textSearch.Enabled = false;
            btnEdit.Enabled = false;
            btnView.Enabled = false;
            r.getPurchaseInvList("st_getPurchaseInvoiceList", cbInvoices, "pid","ID",dtpInvoiceMth.Value.Month,dtpInvoiceMth.Value.Year);
        }

        private void dtpInvoiceMth_ValueChanged(object sender, EventArgs e)
        {
            r.getPurchaseInvList("st_getPurchaseInvoiceList", cbInvoices, "pid", "ID", dtpInvoiceMth.Value.Month,dtpInvoiceMth.Value.Year);
        }
        public override void btnBack_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void cbInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbInvoices.SelectedIndex != -1)
            {
                r.showPurchaseInvDetails( dgvShowData, Convert.ToInt64(cbInvoices.Text),pidGV, codeGV, NameGV, packGV, qpackGV, qtyGV, catgGV, statGV);
                printInvoiceNo = Convert.ToInt64(cbInvoices.Text);
            }
        }
        Insertion i = new Insertion();
        Updation u = new Updation();
        Deletion d = new Deletion();
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                printInvoiceNo = Convert.ToInt64(row.Cells[0].Value.ToString());
                if (e.ColumnIndex == 8)
                {
                    if (row.Cells[7].Value.ToString() == "INVOICE")
                    {
                        DialogResult dr = MessageBox.Show(this, "Are you sure to delete selected item (" + row.Cells[1].Value.ToString() + ")? from purchase .", "Delete Purchase", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            using (TransactionScope sc = new TransactionScope())
                            {
                                //i.insertDeleteItem();
                                //u.updateStock(row.Cells[0].Value.ToString(), qty);
                                //d.delete(Convert.ToInt64(row.Cells[0].Value.ToString()), "st_deleteItemFromPurchase", "pid");
                                d.deletePurchaseInvoiceItem(Convert.ToInt64(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString());
                                dgvShowData.Rows.Remove(row);
                                sc.Complete();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "purchase order recieved, go to purchase return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvShowData.Rows[dgvShowData.CurrentRow.Index];
            if (row.Cells[7].Value.ToString() == "INVOICE")
            { 
                DialogResult dr = MessageBox.Show(this, "Are you sure to delete purchase invoice with details ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("st_deletePurchaseInvoiceWithDetails", MainClass.DBConn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt64(cbInvoices.Text));
                        MainClass.DBConn.Open();
                        cmd.ExecuteNonQuery();
                        MainClass.DBConn.Close();
                        r.getPurchaseInvList("st_getPurchaseInvoiceList", cbInvoices, "pid", "ID", dtpInvoiceMth.Value.Month, dtpInvoiceMth.Value.Year);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(printInvoiceNo) == 0)
            {
                MessageBox.Show(this, "Please select indent to view.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainClass.rptChoice = 6;
                MainClass.gblInvoice = Convert.ToInt64(printInvoiceNo);
                ReportViewer rv = new ReportViewer();
                rv.Show();
                //InvoiceNo = 0;
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            r.getPurchaseInvList("st_getPurchaseInvoiceList", cbInvoices, "pid", "ID", dtpInvoiceMth.Value.Month, dtpInvoiceMth.Value.Year);
        }
    }
}