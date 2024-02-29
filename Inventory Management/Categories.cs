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
    public partial class Categories : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int catID = 0; // for get the staff data
        short stat; // for active or inactive selection
        public Categories()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        private void Categories_Load(object sender, EventArgs e)
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
            textCategory.Focus();
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvShowData.Rows.Count > 0)
            {
                edit = 1;
                MainClass.enable(leftPanel);
                textCategory.Focus();
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
                    del.delete(catID, "st_deleteCategory", "@id");
                    r.showCategory(dgvShowData, catIdGV, nameGV, statGV);
                    MainClass.disable_reset(leftPanel);
                }
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textCategory.Text == string.Empty) { lblcatgError.Visible = true; } else { lblcatgError.Visible = false; }
            if (cbIsActive.SelectedIndex == -1) { lblactiveError.Visible = true; } else { lblactiveError.Visible = false; }

            if (lblcatgError.Visible || lblactiveError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (cbIsActive.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (cbIsActive.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // for save operation
                {
                    Insertion i = new Insertion();
                    i.insertCategory(textCategory.Text, stat);
                    r.showCategory(dgvShowData, catIdGV, nameGV, statGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation i = new Updation();
                        i.updateCategory(catID, textCategory.Text, stat);
                        r.showCategory(dgvShowData, catIdGV, nameGV, statGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showCategory(dgvShowData, catIdGV, nameGV, statGV);
            }
        }

        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showCategory(dgvShowData, catIdGV, nameGV, statGV);
        }

        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIdGV"].Value.ToString());
                textCategory.Text = row.Cells["nameGV"].Value.ToString();
                cbIsActive.Text = row.Cells["statGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            btnView_Click(sender, e);
            lblcatgError.Visible = false;
            lblactiveError.Visible = false;
        }
    }
}
