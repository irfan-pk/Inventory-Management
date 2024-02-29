using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace Inventory_Management
{
    public partial class NewIndent : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int printInvNo=0,qtyBalance=0,currentQty=0;
        string prodcd=string.Empty;
        Boolean ItemExist = false;
        public NewIndent()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        Updation u = new Updation();
        Insertion i = new Insertion();
        string[] prodArray = new string[11];
        string productID;
        int tot_items = 0;
        bool item_exist = false;
        private void NewIndent_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            MainClass.disable(leftPanel);
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnView.Text = "&Print";
            btnView.Image = (Image)global::Inventory_Management.Properties.Resources.print_16px;
            edit = 0;
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable(leftPanel);
            dgvShowData.Enabled = true;
            if (edit == 0) { btnRefresh_Click(sender, e); lblInvoiceNo.Text = MainClass.GenerateSeqID("SALE_ID", "SALE_MASTER").ToString(); }
            lblIndentFrom.Text = getComboBoxData("st_getRequiredSectionByParam", Retrieve.staff_section_id);
            SqlCommand fillCmd = new SqlCommand("select * from invoice_roles where userid = " + Retrieve.staff_id, MainClass.DBConn);
            fillCmd.CommandType = CommandType.Text;
            fillCmd.CommandTimeout = 0;
            MainClass.DBConn.Open();
            SqlDataReader filler = fillCmd.ExecuteReader();
            if (filler.HasRows)
            {
                while (filler.Read())
                {
                    cbIndentTo.Items.Add(filler["suplname"].ToString().Trim());
                }
            }
            filler.Close();
            MainClass.DBConn.Close();
            dtpInvoiceDate.Enabled = true;
            dtpInvoiceDate.Focus();
        }
        public static String getComboBoxData(string proc, int Filter)
        {
            // output value from stored procedure
            SqlCommand cmd = new SqlCommand(proc, MainClass.DBConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            SqlParameter param = new SqlParameter("@a", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = Filter;
            cmd.Parameters.Add(param);
            SqlParameter param2 = new SqlParameter("@b", SqlDbType.VarChar, 50);
            param2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param2);
            MainClass.DBConn.Open();
            cmd.ExecuteNonQuery();
            MainClass.DBConn.Close();
            // assign value to control
            return Convert.ToString(param2.Value);
        }
        private void textQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            if (cbIndentTo.SelectedIndex == -1) { lblindentError.Visible = true; } else { lblindentError.Visible = false; }
            if (textItemCode.Text == string.Empty) { lblitemError.Visible = true; } else { lblitemError.Visible = false; }
            if (textQty.Text == string.Empty) { lblqtyError.Visible = true; } else { lblqtyError.Visible = false; }

            if (lblindentError.Visible || lblitemError.Visible || lblqtyError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                    if (prodcd != prodArray[1]) { getItemBalance(); }
                    currentQty = Convert.ToInt32(textQty.Text.Trim());
                    if (qtyBalance > currentQty)
                    {
                        if (dgvShowData.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dgvShowData.Rows)
                            {
                                if (row.Cells[1].Value.ToString().ToUpper() == textItemCode.Text)
                                {
                                    row.Cells[5].Value = Convert.ToUInt32(row.Cells[5].Value.ToString()) + currentQty;
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
                            if (edit == 1) 
                            { 
                                i.insertSaleDetails(Convert.ToInt64(lblInvoiceNo.Text), prodArray[1], prodArray[3], prodArray[4], Convert.ToInt32(prodArray[6].ToString()), Convert.ToDecimal(textQty.Text), prodArray[9], dtpInvoiceDate.Value);
                                r.showSaleInvoiceWithDetail(dgvShowData, saleidGV, dateGV, codeGV, NameGV, packGV, qpackGV, qpackGV, catgGV, Convert.ToInt64(lblInvoiceNo.Text));
                            }
                            else { dgvShowData.Rows.Add(lblInvoiceNo.Text, dtpInvoiceDate.Value.ToShortDateString(), prodArray[1], prodArray[3], prodArray[4], prodArray[6], textQty.Text, prodArray[9]); }
                            //clearTextBoxes();
                            tot_items = tot_items + 1;
                            lblTotal.Text = tot_items.ToString();
                        }
                        prodcd = prodArray[1];
                        btnSave.Enabled = true;
                        clearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show(this, "No of Quantity you entered is not available in Stock.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearTextBoxes();
                    }
                }
            }
        }
        private void clearTextBoxes()
        {
            productID = string.Empty;
            textItemCode.Clear();
            textQty.Clear();
            Array.Clear(prodArray, 0, prodArray.Length);
            textItemCode.Focus();
            textQty.Enabled = false;
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (cbIndentTo.SelectedIndex == -1) { lblindentError.Visible = true; } else { lblindentError.Visible = false; }
            if (lblindentError.Visible)
            {
                MainClass.showMSG("Indent To Field is mandatory.", "Stop", "Error"); // show the error message
            }
            else
            {
                if (dgvShowData.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        //Int64 purchaseInvId;
                        int count = 0;
                        Insertion i = new Insertion();
                        Updation u = new Updation();
                        Retrieve r = new Retrieve();
                        if (edit == 0) { i.insertSaleInvoice(Convert.ToInt64(lblInvoiceNo.Text.ToString()), dtpInvoiceDate.Value, lblIndentFrom.Text, cbIndentTo.SelectedItem.ToString(), lblUser.Text); }
                        if (edit == 1) { u.updateSaleInvoice(Convert.ToInt64(lblInvoiceNo.Text.ToString()), dtpInvoiceDate.Value, lblIndentFrom.Text, cbIndentTo.SelectedItem.ToString(), lblUser.Text); }
                        foreach (DataGridViewRow row in dgvShowData.Rows)
                        {
                            //DateTime oDate = DateTime.Parse(dtpInvoiceDate.Value.ToString());
                            if (edit == 0) { i.insertSaleDetails(Convert.ToInt64(row.Cells[0].Value.ToString()), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), Convert.ToInt32(row.Cells[5].Value.ToString()), Convert.ToDecimal(row.Cells[6].Value.ToString()), row.Cells[7].Value.ToString(), dtpInvoiceDate.Value); }
                            if (edit == 1)
                            {
                                Int64 id = Convert.ToInt64(row.Cells[0].Value.ToString());
                                DateTime dt = DateTime.Parse(row.Cells[1].Value.ToString());
                                string code = row.Cells[2].Value.ToString();
                                string desc = row.Cells[3].Value.ToString();
                                string pack = row.Cells[4].Value.ToString();
                                int packQty = Convert.ToInt32(row.Cells[5].Value.ToString());
                                int Qty = Convert.ToInt32(row.Cells[6].Value.ToString());
                                string catg = row.Cells[7].Value.ToString();
                                SaleDetailItemExist(id, desc, dt);
                                if (ItemExist == true) 
                                { 
                                    u.updateSaleDetails(id,code,desc,pack,packQty,Qty,catg,dt); 
                                }
                                else                   
                                { 
                                    i.insertSaleDetails(Convert.ToInt64(row.Cells[0].Value.ToString()), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), Convert.ToInt32(row.Cells[5].Value.ToString()), Convert.ToDecimal(row.Cells[6].Value.ToString()), row.Cells[7].Value.ToString(), dtpInvoiceDate.Value); 
                                }
                            }
                            count += 1;
                        }
                        if (count > 0)
                        {
                            MessageBox.Show(this, "Indent generated / updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Unable to generate / update Indent.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnSave.Enabled = false;
                        MainClass.disable(leftPanel);
                        dtpInvoiceDate.Enabled = false;
                        edit = 0;
                        printInvNo = Convert.ToInt32(lblInvoiceNo.Text);
                        sc.Complete();
                        btnRefresh_Click(sender, e);
                    }
                }
            }
        }
        private void textQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textItemCode_TextChanged(object sender, EventArgs e)
        {
            if (textItemCode.Text != string.Empty)
            {
                prodArray = r.getProductByCode(textItemCode.Text.ToUpper());
                productID = prodArray[0];
                if (productID != null) { textQty.Enabled = true; textQty.Focus(); }
            }
            else
            {
                clearTextBoxes();
            }
        }
        private void textItemCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                CodeList cl = new CodeList();
                cl.ShowDialog();
                textItemCode.Text = MainClass.gblprodCode;
                textItemCode.SelectAll();
            }
        }
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 8)
                {
                    DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show(this, "Are you sure to delete selected item (" + row.Cells[2].Value.ToString() + "? from list.", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        Int64 id = Convert.ToInt64(row.Cells[0].Value.ToString());
                        string desc = row.Cells[3].Value.ToString();
                        DateTime dt = DateTime.Parse(row.Cells[1].Value.ToString());
                        //string cmdQuery = "delete from sale_details where sale_id = " + Convert.ToInt64(row.Cells[0].ToString()) + " and sale_desc = " + row.Cells[3].ToString() + " and sale_detail_date = " + DateTime.Parse(row.Cells[1].ToString());
                        dgvShowData.Rows.Remove(row);
                        if (edit == 1)
                        {
                            try
                            {
                                SqlCommand cmd = new SqlCommand("st_deleteItemFromSaleDetails", MainClass.DBConn);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandTimeout = 0;
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.Parameters.AddWithValue("@desc", desc);
                                cmd.Parameters.AddWithValue("@date", dt);
                                MainClass.DBConn.Open();
                                cmd.ExecuteNonQuery();
                                MainClass.DBConn.Close();
                            }
                            catch (Exception msg)
                            {

                                MainClass.showMSG(msg.Message, "Error..!", "Error"); ;
                            }
                        }
                    }
                }
            }
        }
        private void textSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                SearchSaleInvoice ssi = new SearchSaleInvoice();
                ssi.ShowDialog();
                this.textSearch.Text = MainClass.gblIndentNo.ToString();
                if (MainClass.gblIndentStatus == "INDENTED")
                {
                    btnEdit.Enabled = true;
                    edit = 1;
                }
            }
        }
        private void getItemBalance()
        {
            SqlCommand cmd = new SqlCommand("select product_quantity from products where product_code = N'" + textItemCode.Text.Trim() + "'", MainClass.DBConn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            MainClass.DBConn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    qtyBalance = Convert.ToInt32(dr["product_quantity"].ToString());
                }
            }
            MainClass.DBConn.Close();

            SqlCommand query = new SqlCommand("select sum(sale_qty) as Total from sale_details where sale_item_cd = N'" + textItemCode.Text.Trim() + "' and sale_detail_status = 'INDENTED'", MainClass.DBConn);
            query.CommandType = CommandType.Text;
            query.CommandTimeout = 0;
            MainClass.DBConn.Open();
            SqlDataReader dr2 = query.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    if (dr2[0] != System.DBNull.Value)
                    {
                        qtyBalance -= dr2.GetInt32(0);
                    }
                }
            }
            MainClass.DBConn.Close();
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            if (printInvNo == 0)
            {
                MessageBox.Show(this, "Please select indent to view.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            else
            {
                MainClass.rptChoice = 1;
                MainClass.gblInvoice = Convert.ToInt64(lblInvoiceNo.Text.Trim());
                ReportViewer rv = new ReportViewer();
                rv.Show();
            }
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if(textSearch.Text == null || textSearch.Text == string.Empty) { return; }
                r.showSaleInvoiceWithDetail(dgvShowData, saleidGV, dateGV, codeGV, NameGV,packGV,qpackGV,qtyGV,catgGV,Convert.ToInt64(textSearch.Text.Trim()));
                lblInvoiceNo.Text = Retrieve.gblInvoiceNo.ToString();
                lblIndentFrom.Text = Retrieve.gblFrom;
                cbIndentTo.Text = Retrieve.gblTo.ToString();
                dtpInvoiceDate.Value = Retrieve.gblDate;
                if (MainClass.gblIndentStatus == "INDENTED")
                {
                    btnEdit.Enabled = true;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = true;
                    edit = 1;
                }
                if (dgvShowData .Rows.Count > 0)
                {
                    dgvShowData.Enabled = false;
                }
                if (dgvShowData.Rows.Count==0)
                { textSearch.Clear(); }
            }
        }
        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (Retrieve.staff_role_id == 1)
            {
                if (Retrieve.gblStatus == "ISSUED")
                {
                    MainClass.showMSG("Indent has been issued and cannot be deleted.", "Error", "Error");
                    return;
                }
                else
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to delete indent.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Deletion d = new Deletion();
                        d.delete(Retrieve.gblInvoiceNo, "st_deleteSaleInvoiceWithDetails", "@id");
                        btnRefresh_Click(sender, e);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "you are not authorised to delete indent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            //Code Here
            textSearch.Clear();
            for (int n = 0; n < dgvShowData.RowCount; n++)
            {
                dgvShowData.Rows.RemoveAt(0);
            }
            btnAdd.Enabled = true;
            dgvShowData.DataSource = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvShowData.Enabled = false;
            MainClass.disable(leftPanel);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (Retrieve.staff_role_id == 1)
            {
                //MainClass.enable(leftPanel);
                this.leftPanel.Enabled = true;
                this.btnAdd.Enabled = true;
                dgvShowData.Enabled = true;
                edit = 1;
            }
            else
            {
                MessageBox.Show(this, "you are not authorized.","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SaleDetailItemExist(Int64 id, string desc, DateTime dt)
        {
            string query = "select * from sale_details where sale_id = " + id + " and sale_desc = '" + desc + "' and sale_detail_date = '" + dt.ToString("MM/dd/yyyy") + "'";
            SqlCommand cmd = new SqlCommand(query, MainClass.DBConn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            MainClass.DBConn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                ItemExist = true;
            }
            else
            {
                ItemExist = false;
            }    
        }
    }
}
