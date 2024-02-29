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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Roles r = new Roles();
            MainClass.showWindow(r, this, MDI.ActiveForm);
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            Types t = new Types();
            MainClass.showWindow(t, this, MDI.ActiveForm);
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            Locations l = new Locations();
            MainClass.showWindow(l, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            MDI.logOutToolStripMenuItem.Enabled = true;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseInvoice p = new PurchaseInvoice();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            Sections s = new Sections();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            NewIndent s = new NewIndent();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void btnUsrLvl_Click(object sender, EventArgs e)
        {
            IndentRoles ir = new IndentRoles();
            MainClass.showWindow(ir, this, MDI.ActiveForm);
        }

        private void btnConsumption_Click(object sender, EventArgs e)
        {
            Consumption c = new Consumption();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void btnStoreOrders_Click(object sender, EventArgs e)
        {
            OrderProcess op = new OrderProcess();
            MainClass.showWindow(op, this, MDI.ActiveForm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsMenu rm = new ReportsMenu();
            MainClass.showWindow(rm, this, MDI.ActiveForm);
        }

        private void btnInvJournal_Click(object sender, EventArgs e)
        {
            InventoryJournal ij = new InventoryJournal();
            MainClass.showWindow(ij,this,MDI.ActiveForm);
        }

        private void btnViewIndents_Click(object sender, EventArgs e)
        {
            SearchSaleInvoice si = new SearchSaleInvoice();
            si.ShowDialog();
        }
    }
}
