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
    public partial class SearchSaleInvoice : SampleExt
    {
        public SearchSaleInvoice()
        {
            InitializeComponent();
        }
        Int64 printInvoiceNo = 0;
        Retrieve r = new Retrieve();
        private void SearchSaleInvoice_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            tableLayoutPanel1.Visible = false;
            r.populateListBox("st_getSaleInvoices", lvbIndents, "saleid", "saleid");
            lvbIndents.SelectedIndex = 0;
        }
        public override void btnBack_Click(object sender, EventArgs e)
        {
            if (dgvShowData.Rows.Count > 0) { MainClass.gblInvoice = Convert.ToInt64(dgvShowData.Rows[dgvShowData.CurrentRow.Index].Cells[0].Value.ToString()); }
            //NewIndent obj = new NewIndent();
            //MainClass.showWindow(obj, this, MDI.ActiveForm);
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            r.showSaleInvoiceByDate(dgvShowData, saleidGV, dateGV, fromGV, toGV, userGV, statGV, isubyGV, dtpFromDate.Value, dtpToDate.Value);
        }
        private void dgvShowData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShowData.Rows.Count > 0) { MainClass.gblInvoice = Convert.ToInt64(dgvShowData.Rows[e.RowIndex].Cells[0].Value.ToString()); }
            //NewIndent obj = new NewIndent();
            //MainClass.showWindow(obj, this, MDI.ActiveForm);
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(printInvoiceNo) == 0)
            {
                MessageBox.Show(this, "Please select indent to view.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainClass.rptChoice = 1;
                MainClass.gblInvoice = Convert.ToInt64(printInvoiceNo);
                ReportViewer rv = new ReportViewer();
                rv.Show();
                //InvoiceNo = 0;
            }
        }
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                printInvoiceNo = Convert.ToInt64( row.Cells[0].Value.ToString());
            }
        }
    }
}
