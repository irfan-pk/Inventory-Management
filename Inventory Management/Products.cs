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
    public partial class Products : SampleExt
    {
        public Products()
        {
            InitializeComponent();
        }
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int prodID = 0; // for get the staff data
        short stat; // for active or inactive selection
        Retrieve r = new Retrieve();
        private void Products_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            MainClass.disable_reset(leftPanel);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            cbCategory.Items.Clear();
            r.populateComboBoxList("st_getcatgList", cbCategory,"Category", "ID");
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvShowData.Rows.Count > 0)
            {
                edit = 1;
                MainClass.enable(leftPanel);
                r.populateComboBoxList("st_getcatgList", cbCategory, "Category", "ID");
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure to delete the record..!", "Del. Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion del = new Deletion();
                    del.delete(prodID, "st_deleteProduct", "@pid");
                    r.showProducts(dgvShowData, prodIDGV, codeGV, barcodeGV,NameGV, packGV, priceGV,qpackGV,qtyGV,statGV,catgGV,minlvlGV);
                }
            }
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textCode.Text == string.Empty) { lblprocodeError.Visible = true; } else { lblprocodeError.Visible = false; }
            if (textBarcode.Text == string.Empty) { lblbarcodeError.Visible = true; } else { lblbarcodeError.Visible = false; }
            if (textName.Text == string.Empty) { lblnameError.Visible = true; } else { lblnameError.Visible = false; }
            if (textPack.Text == string.Empty) { lblpackError.Visible = true; } else { lblpackError.Visible = false; }
            if (textPrice.Text == string.Empty) { lblpriceError.Visible = true; } else { lblpriceError.Visible = false; }
            if (textQPack.Text == string.Empty) { lblqpackError.Visible = true; } else { lblqpackError.Visible = false; }
            if (textQty.Text == string.Empty) { lblqtyError.Visible = true; } else { lblqtyError.Visible = false; }
            if (textMinLVl.Text == string.Empty) { lblminError.Visible = true; } else { lblminError.Visible = false; }
            if (cbStatus.SelectedIndex == -1) { lblstatusError.Visible = true; } else { lblstatusError.Visible = false; }
            if (cbCategory.SelectedIndex == -1 || cbCategory.SelectedIndex == 0) { lblcatgError.Visible = true; } else { lblcatgError.Visible = false; }

            if (lblprocodeError.Visible || lblnameError.Visible || lblbarcodeError.Visible || lblpackError.Visible ||
                lblpriceError.Visible || lblqpackError.Visible || lblqtyError.Visible || lblminError.Visible || lblstatusError.Visible || lblcatgError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (cbStatus.SelectedIndex == 1)
                {
                    stat = 1;
                }
                else if (cbStatus.SelectedIndex == 2)
                {
                    stat = 0;
                }
                if (edit == 0) // for save operation
                {
                    Insertion i = new Insertion();
                    i.insertProduct(textCode.Text, textBarcode.Text, textName.Text, textPack.Text,Convert.ToSingle(textPrice.Text),Convert.ToInt32(textQPack.Text),Convert.ToDecimal(textQty.Text),stat,Convert.ToInt32(cbCategory.SelectedValue),Convert.ToInt32(textMinLVl.Text));
                    r.showProducts(dgvShowData, prodIDGV, codeGV, barcodeGV, NameGV, packGV, priceGV, qpackGV, qtyGV, statGV, catgGV, minlvlGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation i = new Updation();
                        i.updateProduct(prodID, textCode.Text, textBarcode.Text, textName.Text, textPack.Text, Convert.ToSingle(textPrice.Text), Convert.ToInt32(textQPack.Text), Convert.ToDecimal(textQty.Text), stat, Convert.ToInt32(cbCategory.SelectedValue), Convert.ToInt32(textMinLVl.Text));
                        r.showProducts(dgvShowData, prodIDGV, codeGV, barcodeGV, NameGV, packGV, priceGV, qpackGV, qtyGV, statGV, catgGV, minlvlGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showProducts(dgvShowData, prodIDGV, codeGV, barcodeGV, NameGV, packGV, priceGV, qpackGV, qtyGV, statGV, catgGV, minlvlGV , textSearch.Text);
            }
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showProducts(dgvShowData, prodIDGV, codeGV, barcodeGV, NameGV, packGV, priceGV, qpackGV, qtyGV, statGV, catgGV, minlvlGV);
        }
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                r.populateComboBoxList("st_getcatgList", cbCategory, "Category", "ID");
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["prodIDGV"].Value.ToString());
                textCode.Text = row.Cells["codeGV"].Value.ToString();
                textBarcode.Text = row.Cells["barcodeGV"].Value.ToString();
                textName.Text = row.Cells["NameGV"].Value.ToString();
                textPack.Text = row.Cells["packGV"].Value.ToString();
                textPrice.Text = row.Cells["priceGV"].Value.ToString();
                textQPack.Text = row.Cells["qpackGV"].Value.ToString();
                textQty.Text = row.Cells["qtyGV"].Value.ToString();
                cbStatus.Text = row.Cells["statGV"].Value.ToString();
                cbCategory.Text = row.Cells["catgGV"].Value.ToString();
                textMinLVl.Text = row.Cells["minlvlGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
    }
}
