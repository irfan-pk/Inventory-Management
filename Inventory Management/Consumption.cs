using System;
using System.Data.SqlClient;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Consumption : SampleExt
    {
        int edit = 0;
        bool item_exist=false;
        Retrieve r = new Retrieve();
        Insertion i = new Insertion();
        Deletion del = new Deletion();
        public Consumption()
        {
            InitializeComponent();
        }
        private void Consumption_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvShowData.Enabled = false;
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showConsumptionDates(dgvDateDisplay, cdateGV);
            if (dgvDateDisplay.Rows.Count > 0)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void dgvDateDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                DataGridViewRow row = dgvDateDisplay.Rows[e.RowIndex];
                r.showConsumptionDetail(dgvShowData,dateGV, codeGV, NameGV, packGV, opnbalGV, consumpGV, clobalGV, row.Cells[0].Value.ToString(),1);
            }
        }
        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            r.showConsumptionDetail(dgvShowData, dateGV, codeGV, NameGV, packGV, opnbalGV, consumpGV, clobalGV, textSearch.Text.Trim(), 2);
        }

        private void dgvDateDisplay_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvDateDisplay.Rows[dgvDateDisplay.CurrentRow.Index];
            r.showConsumptionDetail(dgvShowData, dateGV, codeGV, NameGV, packGV, opnbalGV, consumpGV, clobalGV, row.Cells[0].Value.ToString(), 1);
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            textSearch.Clear();
            textCode.Clear();
            textDesc.Clear();
            textPack.Clear();
            textStock.Clear();
            textConsumption.Clear();
            dgvShowData.DataSource = null;
            btnView_Click(sender, e);
            splitContainer1.Panel1.Enabled = false;
            dgvShowData.Enabled = false;
            dgvDateDisplay.Enabled = true;
            edit = 0;
            btnView.Enabled = true;
            btnAdd.Enabled = true;
            dtpConsumptionDate.Value = DateTime.Now;
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
            splitContainer1.Panel1.Enabled = true;
            edit = 1;
            dtpConsumptionDate.Focus();
            btnView.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void textCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                CodeList cl = new CodeList();
                cl.ShowDialog();
                textCode.Text = MainClass.gblprodCode;
            }
        }

        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if(textCode.Text==null || textCode.Text==string.Empty || textCode.Text.Length==0)
                {
                    MessageBox.Show(this, "please enter valid item code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (edit==1)
                {
                    r.showConsumptionStock(textCode.Text, Retrieve.staff_section_id, textDesc, textPack, textStock,dtpConsumptionDate.Value);
                    textConsumption.Focus();
                    dgvShowData.DataSource = null;
                    dgvDateDisplay.Enabled = false;
                }
            }
        }

        private void textConsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textConsumption_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textConsumption.Text == null || textConsumption.Text == string.Empty || Convert.ToInt32(textConsumption.Text) == 0)
                { MessageBox.Show(this, "Quantity cannot by zero or null", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                decimal clobal = Convert.ToDecimal(textStock.Text) - Convert.ToDecimal(textConsumption.Text);
                if (dgvShowData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvShowData.Rows)
                    {
                        if (row.Cells[0].Value.ToString().ToUpper() == textCode.Text)
                        {
                            row.Cells[4].Value = textStock.Text.Trim();
                            row.Cells[5].Value = row.Cells[5].Value.ToString();
                            row.Cells[6].Value = clobal;
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
                    dgvShowData.Rows.Add(dtpConsumptionDate.Value.ToShortDateString(), textCode.Text.Trim(), textDesc.Text.Trim(), textPack.Text.Trim(),textStock.Text.Trim(), textConsumption.Text.Trim(),clobal.ToString());
                }
                btnSave.Enabled = true;
                dgvShowData.Enabled = true;
                textConsumption.Clear();
                textCode.Clear();
                textCode.Focus();
            }
        }
        private void dtpConsumption_ValueChanged(object sender, EventArgs e)
        {
            textCode.Focus();
        }

        private void dtpConsumption_Leave(object sender, EventArgs e)
        {
            textCode.Focus();
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure to save consumption detail.", "Save Consumption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (dgvShowData.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        int count=0;
                        foreach (DataGridViewRow row in dgvShowData.Rows)
                        {
                            DateTime oDate = DateTime.Parse( row.Cells[0].Value.ToString());
                            i.insertConsumptionDetail(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), Convert.ToDecimal(row.Cells[4].Value.ToString()), Convert.ToInt32(row.Cells[5].Value.ToString()), Convert.ToDecimal(row.Cells[6].Value.ToString()), oDate, Retrieve.staff_section_id);
                            count += 1;
                        }
                        if (count > 0)
                        {
                            MessageBox.Show(this, "consumption saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Unable to save consumption.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        btnSave.Enabled = false;
                        dgvShowData.Enabled = false;
                        dgvShowData.Rows.Clear();
                        btnView.Enabled = true;
                        btnAdd.Enabled = true;
                        btnRefresh_Click(sender, e);
                        edit = 0;
                        sc.Complete();
                    }
                }
            }
        }
        public override void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvShowData.Rows[dgvShowData.CurrentRow.Index];
            DialogResult dr = MessageBox.Show(this,"Are you sure to delete the consumption of date (" + row.Cells[0].Value.ToString()+ "","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion d = new Deletion();
                d.delete(row.Cells[0].Value, "st_deleteconsumption", "deldate");
                btnRefresh_Click(sender, e);
            }
        }
        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 2;
            dgvShowData.Enabled = true;
        }

        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (edit == 2)
                { 
                    dtpConsumptionDate.Value = DateTime.Parse(row.Cells[0].Value.ToString());
                    textDesc.Text = row.Cells[2].Value.ToString();
                    textPack.Text = row.Cells[3].Value.ToString();
                    textStock.Text = row.Cells[4].Value.ToString();
                    textConsumption.Text = row.Cells[5].Value.ToString();
                    splitContainer1.Panel1.Enabled = true;
                    textConsumption.Focus();
                }
                if(e.ColumnIndex==7)
                {
                    //DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show(this, "Are you sure to delete selected item (" + row.Cells[2].Value.ToString() + "? from list.", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        DateTime oDate = DateTime.Parse(row.Cells[0].Value.ToString());
                        del.deleteConsumptionItem(oDate, row.Cells[1].Value.ToString());                        
                        dgvShowData.Rows.Remove(row);
                        btnRefresh_Click(sender, e);
                    }
                }
            }
        }
    }
}
