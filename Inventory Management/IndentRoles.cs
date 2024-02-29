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
    public partial class IndentRoles : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int iroleId = 0; // for get the staff data
        
        public IndentRoles()
        {
            InitializeComponent();
        }

        private void IndentRoles_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            MainClass.disable_reset(leftPanel);
        }
        Retrieve r = new Retrieve();
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            edit = 0;
            FillComboBoxes();
            MainClass.enable_reset(leftPanel);
        }

        private void FillComboBoxes()
        {
            r.populateComboBoxList("st_getStaffList", cbuser, "name", "ID");
            r.populateComboBoxList("st_getSupplierList", cbsupplier, "name", "ID");
            r.populateComboBoxList("st_getLocationList", cbLocation, "city", "ID");
            r.populateComboBoxList("st_getSupplierList", cbprefix, "prefix", "ID");
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            FillComboBoxes();
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
                    del.delete(iroleId, "st_deleteInvRole", "@id");
                    r.showInvRoles(dgvShowData, IdGV, userGV, suplGV, locidGV, codeGV);
                }
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (cbuser.SelectedIndex == -1) { lbluserError.Visible = true; } else { lbluserError.Visible = false; }
            if (cbsupplier.SelectedIndex == -1) { lblsplError.Visible = true; } else { lblsplError.Visible = false; }
            if (cbLocation.SelectedIndex == -1) { lbllocError.Visible = true; } else { lbllocError.Visible = false; }
            if (cbprefix.SelectedIndex == -1) { lblprefixError.Visible = true; } else { lblprefixError.Visible = false; }

            if (lbluserError.Visible || lblsplError.Visible || lbllocError.Visible || lblprefixError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (edit == 0) // for save operation
                {
                    Insertion i = new Insertion();
                    i.insertInvoiceRoles(Convert.ToInt32(cbuser.SelectedValue), cbsupplier.Text, Convert.ToInt32(cbLocation.SelectedValue), Convert.ToInt32(cbLocation.SelectedValue));
                    r.showInvRoles(dgvShowData, IdGV, userGV, suplGV, locidGV, codeGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateInvRoles(iroleId, Convert.ToInt32(cbuser.SelectedValue), cbsupplier.Text, Convert.ToInt32(cbLocation.SelectedValue), Convert.ToInt32(cbLocation.SelectedValue));
                        r.showInvRoles(dgvShowData, IdGV, userGV, suplGV, locidGV, codeGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showInvRoles(dgvShowData, IdGV, userGV, suplGV, locidGV, codeGV);
        }
        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showInvRoles(dgvShowData, IdGV, userGV, suplGV, locidGV, codeGV, textSearch.Text);
            }
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            btnView_Click(sender, e);
            lbluserError.Visible = false;
            lblsplError.Visible = false;
            lbllocError.Visible = false;
            lblprefixError.Visible = false;
        }
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                iroleId = Convert.ToInt32(row.Cells["idGV"].Value.ToString());
                cbuser.Text = row.Cells["userGV"].Value.ToString();
                cbsupplier.Text = row.Cells["suplGV"].Value.ToString();
                cbLocation.Text = row.Cells["locidGV"].Value.ToString();
                cbprefix.Text = row.Cells["codeGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
    }
}
