using System;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class OrderProcess : SampleExt
    {
        bool processPurchase = false, processIndent=false;
        int btnChoice = 0;
        Insertion i = new Insertion();
        Retrieve r = new Retrieve();
        public OrderProcess()
        {
            InitializeComponent();
        }

        private void OrderProcess_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            tableLayoutPanel1.Visible = false;
        }

        private void btnShowPOrders_Click(object sender, EventArgs e)
        {
            processPurchase = true;
            processIndent = false;
            dgvShowData.DataSource = null;
            btnChoice = 1;
            r.showPurchaseInvoiceByDate(dgvShowData,dtpFromDate.Value,dtpToDate.Value);
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if(processPurchase==true) 
            {
                if(dgvShowData .Rows.Count > 0)
                {
                    DataGridViewRow row = dgvShowData.Rows[dgvShowData.CurrentRow.Index];
                    if(row.Cells[8].Value.ToString()!="RECIEVED")
                    {
                        i.processOrders(row.Cells[0].Value.ToString());
                        r.showPurchaseInvoiceByDate(dgvShowData, dtpFromDate.Value, dtpToDate.Value);
                    }
                    else
                    {
                        MessageBox.Show(this, "Order already processed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (processIndent == true)
            {
                if (dgvShowData.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvShowData.Rows[dgvShowData.CurrentRow.Index];
                    if (row.Cells[5].Value.ToString() != "ISSUED")
                    {
                        i.processOrders(row.Cells[0].Value.ToString(),Retrieve.staff_name);
                        r.showSaleInvoiceByDate(dgvShowData, dtpFromDate.Value, dtpToDate.Value);
                    }
                    else
                    {
                        MessageBox.Show(this, "Order already processed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnIndents_Click(object sender, EventArgs e)
        {
            processPurchase = false;
            processIndent = true;
            dgvShowData.DataSource = null;
            btnChoice = 2;
            r.showSaleInvoiceByDate(dgvShowData, dtpFromDate.Value, dtpToDate.Value);
        }
    }
}
