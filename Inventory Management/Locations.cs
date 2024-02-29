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
    public partial class Locations : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int LocID = 0; // for get the staff data
        public Locations()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        private void Warehouse_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            MainClass.disable_reset(leftPanel);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
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
                    del.delete(LocID, "st_deleteLocation", "@id");
                    r.showLocations(dgvShowData, LocIdGV, cityGV, provinceGV, streetGV);
                }
            }
        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textStreet.Text == string.Empty) { lblstreetError.Visible = true; } else { lblstreetError.Visible = false; }
            if (textStreet.Text == string.Empty) { lblstreetError.Visible = true; } else { lblstreetError.Visible = false; }
            if (cbCity.SelectedIndex == -1) { lblcityError.Visible = true; } else { lblcityError.Visible = false; }
            if (cbProvince.SelectedIndex == -1) { lblprovinceError.Visible = true; } else { lblprovinceError.Visible = false; }

            if (lblcityError.Visible || lblprovinceError.Visible || lblstreetError.Visible || lblstreetError.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); // show the error message
            }
            else
            {
                if (edit == 0) // for save operation
                {
                    Insertion i = new Insertion();
                    i.insertLocation(cbCity.Text , cbProvince.Text, textStreet.Text);
                    r.showLocations(dgvShowData, LocIdGV, cityGV, provinceGV, streetGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation i = new Updation();
                        i.updateLocations(LocID, cbCity.Text, cbProvince.Text, textStreet.Text);
                        r.showLocations(dgvShowData, LocIdGV, cityGV, provinceGV, streetGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showLocations(dgvShowData, LocIdGV, cityGV, provinceGV, streetGV);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showLocations(dgvShowData, LocIdGV, cityGV, provinceGV, streetGV);
        }

        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            btnView_Click(sender, e);
            lblcityError.Visible = false;
            lblprovinceError.Visible = false;
            lblstreetError.Visible = false;
        }

        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                LocID = Convert.ToInt32(row.Cells["locidGV"].Value.ToString());
                cbCity.Text = row.Cells["cityGV"].Value.ToString();
                cbProvince.Text = row.Cells["provinceGV"].Value.ToString();
                textStreet.Text = row.Cells["streetGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
    }
}
