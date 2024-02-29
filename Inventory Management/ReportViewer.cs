using System;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class ReportViewer : Sample
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            lblUser.Text = Retrieve.staff_name;
            MainClass.disable(leftPanel);
            if (MainClass.rptChoice == 1) { r.showReport(crystalReportViewer1, "st_SaleInvoiceReceipt", "@saleinvoice", MainClass.gblInvoice, "crSaleInvoice.rpt"); }
            if (MainClass.rptChoice==2) { r.showReport(crystalReportViewer1,"crStockPosition.rpt", "st_getProductData",1); }
            if (MainClass.rptChoice == 3) { r.showReport(crystalReportViewer1, "st_stockPositionReport",MainClass.gblFromDate,MainClass.gblToDate,1); }
            if (MainClass.rptChoice == 4) { r.showReport(crystalReportViewer1,  "crStockBalanceDetails.rpt", "st_showStockWithDetail", 1); }
            if (MainClass.rptChoice == 5) { r.showReport(crystalReportViewer1); }
            if (MainClass.rptChoice == 6) { r.showReport(crystalReportViewer1, "st_PurchaseInvoiceReceipt", "@prchinvoice", MainClass.gblInvoice, "crPurchaseInvoice.rpt"); }
            this.Cursor = Cursors.Default;
        }
    }
}
