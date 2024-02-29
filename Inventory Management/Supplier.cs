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
    public partial class Supplier : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int suplId = 0; // for get the staff data
        short stat; // for active or inactive selection
        public Supplier()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            r.populateComboBoxList("st_getLocationList", cbLocation, "city", "ID");
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            r.populateComboBoxList("st_getLocationList", cbLocation, "city", "ID");
            MainClass.enable(leftPanel);
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure to delete the record..!", "Del. Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion del = new Deletion();
                    del.delete(suplId, "st_deleteSupplier", "@sid");
                    r.showSupplier(dgvShowData, suplidGV, nameGV, compNameGV, locidGV, conctGV, ntnnoGV, nmcodeGV, statGV);
                }
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textName.Text == string.Empty) { lblnameError.Visible = true; } else { lblnameError.Visible = false; }
            if (textCompany.Text == string.Empty) { lblcompError.Visible = true; } else { lblcompError.Visible = false; }
            if (textContact.Text == string.Empty) { lblcontactError.Visible = true; } else { lblcontactError.Visible = false; }
            if (textNTN.Text == string.Empty) { lblntnError.Visible = true; } else { lblntnError.Visible = false; }
            if (cbLocation.SelectedIndex == -1) { lbllocError.Visible = true; } else { lbllocError.Visible = false; }
            if (cbStatus.SelectedIndex == -1) { lblstatusError.Visible = true; } else { lblstatusError.Visible = false; }

            if (lblnameError.Visible || lblcompError.Visible || lblntnError.Visible || lblstatusError.Visible ||
                lblcontactError.Visible || lbllocError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (cbStatus.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (cbStatus.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // for save operation
                {
                    Insertion i = new Insertion();
                    i.insertSupplier(textName.Text, textCompany.Text, Convert.ToInt32(cbLocation.SelectedValue), textContact.Text , textNTN.Text, textShortCd.Text , stat);
                    r.showSupplier(dgvShowData, suplidGV, nameGV, compNameGV, locidGV, conctGV, ntnnoGV, nmcodeGV, statGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation i = new Updation();
                        i.updateSupplier(suplId, textName.Text, textCompany.Text, Convert.ToInt32(cbLocation.SelectedValue), textContact.Text, textNTN.Text, textShortCd.Text, stat);
                        r.showSupplier(dgvShowData, suplidGV, nameGV, compNameGV, locidGV, conctGV, ntnnoGV, nmcodeGV, statGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showSupplier(dgvShowData, suplidGV, nameGV, compNameGV, locidGV, conctGV, ntnnoGV, nmcodeGV, statGV);
        }
        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showSupplier(dgvShowData, suplidGV, nameGV, compNameGV, locidGV, conctGV, ntnnoGV, nmcodeGV, statGV);
            }
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            btnView_Click(sender, e);
            lblnameError.Visible = false;
            lblcompError.Visible = false;
            lbllocError.Visible = false;
            lblcontactError.Visible = false;
            lblntnError.Visible = false;
            lblshortError.Visible = false;
            lblstatusError.Visible = false;
        }
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                suplId = Convert.ToInt32(row.Cells["suplidGV"].Value.ToString());
                textName.Text = row.Cells["nameGV"].Value.ToString();
                textCompany.Text = row.Cells["compnameGV"].Value.ToString();
                cbLocation.Text = row.Cells["locidGV"].Value.ToString();
                textContact.Text = row.Cells["conctGV"].Value.ToString();
                textNTN.Text  = row.Cells["ntnnoGV"].Value.ToString();
                textShortCd.Text = row.Cells["nmcodeGV"].Value.ToString();
                cbStatus.Text = row.Cells["statGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
    }
}
