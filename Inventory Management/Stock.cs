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
    public partial class Stock : SampleExt
    {
        public Stock()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        private void Stock_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            base.btnAdd.Visible = false;
            base.btnSave.Visible = false;
            base.btnEdit.Visible = false;
            base.btnDelete.Visible = false;
        }
        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showStock(dgvShowData, prodIDGV, codeGV, barcodeGV, NameGV, packGV, priceGV, qpackGV, qtyGV, statGV, catgGV, minlvlGV, textSearch.Text);
            }
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showStock(dgvShowData, prodIDGV, codeGV, barcodeGV, NameGV, packGV, priceGV, qpackGV, qtyGV, statGV, catgGV, minlvlGV);
        }
    }
}
