using System;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class Users : SampleExt
    {
        int edit = 0; // this is an indication to save operation or an indication to update operation
        int staffID = 0; // for get the staff data
        short stat; // for active or inactive selection
        public Users()
        {
            InitializeComponent();
        }
        Retrieve r = new Retrieve();
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {
            r.populateComboBoxList("st_getLocationList", cbLocation, "city", "ID");
            r.populateComboBoxList("st_getRoleList", cbRole, "RoleName", "ID");
            r.populateComboBoxList("st_getTypeList", cbType, "TypeDesc", "ID");
            r.populateComboBoxList("st_getManagerList", cbManager, "Name", "ID");
            r.populateComboBoxList("st_getSectionList", cbSection, "secdesc", "ID");
        }
        public override void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            FillComboBoxes();
            MainClass.enable(leftPanel);
        }
        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (edit==1)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure to delete the record..!", "Del. Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion del = new Deletion();
                    del.delete(staffID, "st_deletestaff", "@sid");
                    r.showStaff(dgvShowData, staffidGV, fnameGV, lnameGV, unameGV, passGV, conctGV, addrsGV, typeidGV, roleidGV, locidGV, secidGV, manidGV, statGV);
                }
            }
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textFName.Text == string.Empty) { lblfnameError.Visible = true; } else { lblfnameError.Visible = false; }
            if (textLName.Text == string.Empty) { lbllnameError.Visible = true; } else { lbllnameError.Visible = false; }
            if (textUsername.Text == string.Empty) { lbluserError.Visible = true; } else { lbluserError.Visible = false; }
            if (textPassword.Text == string.Empty) { lblpwdError.Visible = true; } else { lblpwdError.Visible = false; }
            if (textContact.Text == string.Empty) { lblcontactError.Visible = true; } else { lblcontactError.Visible = false; }
            if (textAddress.Text == string.Empty) { lbladrsError.Visible = true; } else { lbladrsError.Visible = false; }
            if (cbType.SelectedIndex == -1) { lbltypeError.Visible = true; } else { lbltypeError.Visible = false; }
            if (cbLocation.SelectedIndex == -1) { lbllocError.Visible = true; } else { lbllocError.Visible = false; }
            if (cbRole.SelectedIndex == -1) { lblroleError.Visible = true; } else { lblroleError.Visible = false; }
            if (cbManager.SelectedIndex == -1) { lblmangerError.Visible = true; } else { lblmangerError.Visible = false; }
            if (cbStatus.SelectedIndex == -1) { lblstatError.Visible = true; } else { lblstatError.Visible = false; }

            if (lblfnameError.Visible || lbllnameError.Visible || lbluserError.Visible || lblpwdError.Visible || lblstatError.Visible ||
                lbladrsError.Visible || lblcontactError.Visible || lblroleError.Visible || lbltypeError.Visible || lbllocError.Visible || lblmangerError.Visible)
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
                    i.insertStaff(textFName.Text,textLName.Text,textUsername.Text,textPassword.Text,textAddress.Text ,textContact.Text , Convert.ToInt32(cbType.SelectedValue), Convert.ToInt32 (cbRole.SelectedValue), Convert.ToInt32(cbLocation.SelectedValue), Convert.ToInt32(cbSection.SelectedValue), Convert.ToInt32(cbManager.SelectedValue), stat);
                    r.showStaff(dgvShowData, staffidGV, fnameGV, lnameGV, unameGV, passGV, conctGV, addrsGV, typeidGV, roleidGV, locidGV, secidGV, manidGV, statGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // for edit operation
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure to update the record..!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation i = new Updation();
                        i.updateStaff(staffID, textFName.Text, textLName.Text, textUsername.Text, textPassword.Text, textAddress.Text, textContact.Text, Convert.ToInt32(cbType.SelectedValue), Convert.ToInt32(cbRole.SelectedValue), Convert.ToInt32(cbLocation.SelectedValue), Convert.ToInt32(cbSection.SelectedValue), Convert.ToInt32(cbManager.SelectedValue), stat);
                        r.showStaff(dgvShowData, staffidGV, fnameGV, lnameGV, unameGV, passGV, conctGV, addrsGV, typeidGV, roleidGV, locidGV, secidGV, manidGV, statGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }
        public override void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text != string.Empty)
            {
                r.showStaff(dgvShowData, staffidGV, fnameGV, lnameGV, unameGV, passGV, conctGV, addrsGV, typeidGV, roleidGV, locidGV, secidGV, manidGV, statGV, textSearch.Text);
            }
        }
        private void Users_Load(object sender, EventArgs e)
        {
            lblUser.Text = Retrieve.staff_name;
            dgvShowData.AutoGenerateColumns = false;
            MainClass.disable_reset(leftPanel);
        }
        public override void btnView_Click(object sender, EventArgs e)
        {
            r.showStaff(dgvShowData, staffidGV, fnameGV, lnameGV, unameGV, passGV, conctGV, addrsGV, typeidGV, roleidGV, locidGV, secidGV, manidGV, statGV);
        }
        public override void btnRefresh_Click(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            btnView_Click(sender, e);
            lblfnameError.Visible = false;
            lbllnameError.Visible = false;
            lbluserError.Visible = false;
            lblpwdError.Visible = false;
            lbllocError.Visible = false;
            lbltypeError.Visible = false;
            lblroleError.Visible = false;
            lbladrsError.Visible = false;
            lblcontactError.Visible = false;
            lblmangerError.Visible = false;
            lblstatError.Visible = false;
        }
        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvShowData.Rows[e.RowIndex];
                staffID = Convert.ToInt32(row.Cells["staffidGV"].Value.ToString());
                textFName.Text = row.Cells["fnameGV"].Value.ToString();
                textLName.Text = row.Cells["lnameGV"].Value.ToString();
                textUsername.Text = row.Cells["unameGV"].Value.ToString();
                textPassword.Text = row.Cells["passGV"].Value.ToString();
                textAddress.Text = row.Cells["addrsGV"].Value.ToString();
                textContact.Text = row.Cells["conctGV"].Value.ToString();
                cbType.Text = row.Cells["typeidGV"].Value.ToString();
                cbRole.Text = row.Cells["roleidGV"].Value.ToString();
                cbLocation.Text = row.Cells["locidGV"].Value.ToString();
                cbSection.Text = row.Cells["secidGV"].Value.ToString();
                cbManager.Text = row.Cells["manidGV"].Value.ToString();
                cbStatus.Text = row.Cells["statGV"].Value.ToString();
                MainClass.disable(leftPanel);
                edit = 1;
            }
        }
    }
}
