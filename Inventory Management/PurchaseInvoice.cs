using System;
using System.Windows.Forms;
using System.Transactions;

namespace Inventory_Management
{
    public partial class PurchaseInvoice : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        //int suplId = 0; // for get the staff data
        //short stat; // for active or inactive selection
        string supplier=string.Empty;
        int tot_items = 0;
        bool item_exist = false;
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        Updation u = new Updation();
        string[] prodArray = new string[11];
        string productID;
        private void PruchaseInvoice_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            r.populateComboBoxList("st_getSupplierList", cbSupplier, "Name", "supl_id");
            dgvShowData.AutoGenerateColumns = false;
            MainClass.disable(leftPanel);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            textSearch.Enabled = false;
            btnDelete.Text = "&Return";
        }
        private void textCode_TextChanged(object sender, EventArgs e)
        {
            if (textCode.Text != string.Empty)
            {
                prodArray = r.getProductByCode(textCode.Text.ToUpper());
                productID = prodArray[0];
                textName.Text = prodArray[3];
                textPack.Text = prodArray[4];
                textPerPack.Text = prodArray[6];
                textCategory.Text = prodArray[9];
                if (productID != null) { textQty.Focus(); }
            }
            else
            {
                clearTextBoxes();
            }
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (cbSupplier.SelectedIndex == -1) { lblsuplError.Visible = true; } else { lblsuplError.Visible = false; }
            if (textCode.Text == string.Empty) { lblcodeError.Visible = true; } else { lblcodeError.Visible = false; }
            if (textQty.Text == string.Empty) { lblqtyError.Visible = true; } else { lblqtyError.Visible = false; }
            
            if (lblsuplError.Visible || lblcodeError.Visible || lblqtyError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (dgvShowData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvShowData.Rows)
                    {
                        if (row.Cells[1].Value.ToString().ToUpper() == textCode.Text)
                        {
                            row.Cells[5].Value = Convert.ToUInt32(row.Cells[5].Value.ToString()) + Convert.ToUInt32(textQty.Text);
                            clearTextBoxes();
                            item_exist = true;
                        }
                        else
                        {
                            item_exist = false;
                        }
                    }
                }
                if (item_exist == false)
                {
                    supplier = cbSupplier.Text;
                    dgvShowData.Rows.Add('0',textCode.Text, textName.Text, textPack.Text, textPerPack.Text, textQty.Text, textCategory.Text,"x");
                    clearTextBoxes();
                    btnView.Enabled = false;
                    btnAdd.Enabled = false;
                    tot_items = tot_items + 1;
                    lblTotal.Text = tot_items.ToString();
                }
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void clearTextBoxes()
        {
            productID = string.Empty;
            textCode.Clear();
            textName.Clear();
            textPack.Clear();
            textCategory.Clear();
            textPerPack.Clear();
            textQty.Clear();
            Array.Clear(prodArray, 0, prodArray.Length);
            textCode.Focus();
        }
        public override void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable(leftPanel);
            dtpInvoiceDate.Enabled = true;
            btnAddCart.Enabled = true;
            dtpInvoiceDate.Focus();
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            ProcessPurchaseInvoice(0);
            btnView.Enabled = true;
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }

        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
            dgvShowData.Rows.Clear();
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void dtpInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            cbSupplier.Focus();
        }
        public override void btnDelete_Click(object sender, EventArgs e)
        {
            ProcessPurchaseInvoice(1);
        }
        private void ProcessPurchaseInvoice(int option)
        {
            if (dgvShowData.Rows.Count > 0)
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    Int64 purchaseInvId;
                    int count = 0;
                    Insertion i = new Insertion();
                    Int64 pid = MainClass.GenerateSeqID("pi_id", "purchaseinvoice");
                    purchaseInvId = i.insertPurchaseInvoice(pid, cbSupplier.Text.Trim(), dtpInvoiceDate.Value, Retrieve.user);
                    foreach (DataGridViewRow row in dgvShowData.Rows)
                    {
                        //int qty;
                        if (option == 0) { i.insertPurchaseInvoiceDetails(pid, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), Convert.ToInt32(row.Cells[5].Value.ToString()), row.Cells[6].Value.ToString(),dtpInvoiceDate.Value); }
                        if (option == 1) { i.insertPurchaseInvoiceDetails(pid, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), Convert.ToInt32(row.Cells[5].Value.ToString()) * -1, row.Cells[6].Value.ToString(),dtpInvoiceDate.Value); }
                        // for future use
                        //if ((qty = r.getProductQuantity(row.Cells[0].Value.ToString())) >= 0 || (qty = r.getProductQuantity(row.Cells[0].Value.ToString())) != null)
                        //{
                        // qty += Convert.ToInt32(row.Cells[4].Value.ToString())
                        //u.updateStock(row.Cells[0].Value.ToString(), qty);
                        //}
                        //    else
                        //    {
                        //i.insertStock(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[4].Value.ToString()));
                        //}
                        count += 1;
                    }
                    if (count > 0)
                    {
                        MessageBox.Show(this, "Purchase Invoice generated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvShowData.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show(this, "Unable to generate Purchase Invoice.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sc.Complete();
                }
            }
        }

        private void textCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                CodeList cl = new CodeList();
                cl.ShowDialog();
                textCode.Text = MainClass.gblprodCode;
                textCode.SelectAll();
            }
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                r.showPurchaseInvDetails(dgvShowData, Convert.ToInt64(textSearch.Text.Trim()), pidGV, codeGV, NameGV, packGV, qpackGV, qtyGV, catgGV, statGV);
            }
        }
    }
}
