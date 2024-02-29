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
    public partial class Types : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int typeID = 0; // for get the staff data
        Retrieve r = new Retrieve();
        public Types()
        {
            InitializeComponent();
        }

        private void Types_Load(object sender, EventArgs e)
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
            textDescription.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvShowData.Rows.Count > 0)
            {
                edit = 1;
                MainClass.enable(leftPanel);
                textDescription.Focus();
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
                    del.delete(typeID, "st_deleteType", "@id");
                    r.showTypes(dgvShowData, typeIdGV, descGV);
                    MainClass.disable_reset(leftPanel);
                }
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textDescription.Text == string.Empty) { lbldescError.Visible = true; } else { lbldescError.Visible = false; }

            if (lbldescError.Visible)
            {
                MainClass.showMSG("Field with * is mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (edit == 0) // for save operation
                {
                    Insertion i = new Insertion();
                    i.insertTypes(textDescription.Text);
                    r.showTypes(dgvShowData, typeIdGV, descGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation i = new Updation();
                        i.updateTypes(typeID,textDescription.Text);
                        r.showTypes(dgvShowData, typeIdGV, descGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showTypes(dgvShowData, typeIdGV, descGV);
        }
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                typeID = Convert.ToInt32(row.Cells["typeIdGV"].Value.ToString());
                textDescription.Text = row.Cells["descGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            btnView_Click(sender, e);
            lbldescError.Visible = false;
        }
    }
}
