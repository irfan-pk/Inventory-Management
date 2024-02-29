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
    public partial class Roles : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int roleID = 0; // for get the staff data
        public Roles()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        private void Roles_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            MainClass.disable(leftPanel);
            textSearch.Enabled = false;
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            textRole.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvShowData.Rows.Count > 0)
            {
                edit = 1;
                MainClass.enable(leftPanel);
                textRole.Focus();
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
                    del.delete(roleID, "st_deleteRoles", "@id");
                    r.showRoles(dgvShowData, roleIdGV, nameGV, descGV);
                    MainClass.disable_reset(leftPanel);
                }
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textRole.Text == string.Empty) { lblnameError.Visible = true; } else { lblnameError.Visible = false; }
            if (textDescription.Text == string.Empty) { lbldescError.Visible = true; } else { lbldescError.Visible = false; }
            if (lblnameError.Visible || lbldescError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (edit == 0) // for save operation
                {
                    Insertion i = new Insertion();
                    i.insertRoles(textRole.Text, textDescription.Text);
                    r.showRoles(dgvShowData, roleIdGV, nameGV, descGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation i = new Updation();
                        i.updateRoles(roleID, textRole.Text, textDescription.Text);
                        r.showRoles(dgvShowData, roleIdGV, nameGV, descGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showRoles(dgvShowData, roleIdGV, nameGV, descGV);
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showRoles(dgvShowData, roleIdGV, nameGV, descGV);
        }

        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roleIdGV"].Value.ToString());
                textRole.Text = row.Cells["nameGV"].Value.ToString();
                textDescription.Text = row.Cells["descGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            btnView_Click(sender, e);
            lblnameError.Visible = false;
            lbldescError.Visible = false;
        }
    }
}
