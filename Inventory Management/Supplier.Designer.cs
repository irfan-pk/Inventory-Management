
namespace Inventory_Management
{
    partial class Supplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textContact = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbllocError = new System.Windows.Forms.Label();
            this.lblcontactError = new System.Windows.Forms.Label();
            this.lblcompError = new System.Windows.Forms.Label();
            this.lblnameError = new System.Windows.Forms.Label();
            this.lblntnError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNTN = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lblstatusError = new System.Windows.Forms.Label();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.lblshortError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textShortCd = new System.Windows.Forms.TextBox();
            this.suplidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conctGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBack.FlatAppearance.BorderSize = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            // 
            // textSearch
            // 
            this.textSearch.Size = new System.Drawing.Size(123, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.cbStatus);
            this.leftPanel.Controls.Add(this.label22);
            this.leftPanel.Controls.Add(this.cbLocation);
            this.leftPanel.Controls.Add(this.label14);
            this.leftPanel.Controls.Add(this.textShortCd);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.textNTN);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.textContact);
            this.leftPanel.Controls.Add(this.label12);
            this.leftPanel.Controls.Add(this.textCompany);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.textName);
            this.leftPanel.Controls.Add(this.lblshortError);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.lblntnError);
            this.leftPanel.Controls.Add(this.lbllocError);
            this.leftPanel.Controls.Add(this.lblcontactError);
            this.leftPanel.Controls.Add(this.lblcompError);
            this.leftPanel.Controls.Add(this.lblnameError);
            this.leftPanel.Controls.Add(this.lblstatusError);
            this.leftPanel.Size = new System.Drawing.Size(274, 671);
            this.leftPanel.Controls.SetChildIndex(this.lblstatusError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblnameError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblcompError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblcontactError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbllocError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblntnError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblshortError, 0);
            this.leftPanel.Controls.SetChildIndex(this.textName, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.textCompany, 0);
            this.leftPanel.Controls.SetChildIndex(this.label12, 0);
            this.leftPanel.Controls.SetChildIndex(this.textContact, 0);
            this.leftPanel.Controls.SetChildIndex(this.label9, 0);
            this.leftPanel.Controls.SetChildIndex(this.textNTN, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.textShortCd, 0);
            this.leftPanel.Controls.SetChildIndex(this.label14, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbLocation, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label22, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbStatus, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(790, 671);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(19, 230);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(237, 23);
            this.cbLocation.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Location";
            // 
            // textContact
            // 
            this.textContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textContact.Location = new System.Drawing.Point(19, 277);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(237, 23);
            this.textContact.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Contact";
            // 
            // textCompany
            // 
            this.textCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCompany.Location = new System.Drawing.Point(19, 183);
            this.textCompany.Name = "textCompany";
            this.textCompany.Size = new System.Drawing.Size(237, 23);
            this.textCompany.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Company Name";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Location = new System.Drawing.Point(19, 138);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(237, 23);
            this.textName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Supplier Name";
            // 
            // lbllocError
            // 
            this.lbllocError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllocError.Location = new System.Drawing.Point(229, 207);
            this.lbllocError.Name = "lbllocError";
            this.lbllocError.Size = new System.Drawing.Size(32, 28);
            this.lbllocError.TabIndex = 34;
            this.lbllocError.Text = "*";
            this.lbllocError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbllocError.Visible = false;
            // 
            // lblcontactError
            // 
            this.lblcontactError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactError.Location = new System.Drawing.Point(229, 256);
            this.lblcontactError.Name = "lblcontactError";
            this.lblcontactError.Size = new System.Drawing.Size(32, 28);
            this.lblcontactError.TabIndex = 35;
            this.lblcontactError.Text = "*";
            this.lblcontactError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcontactError.Visible = false;
            // 
            // lblcompError
            // 
            this.lblcompError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompError.Location = new System.Drawing.Point(229, 161);
            this.lblcompError.Name = "lblcompError";
            this.lblcompError.Size = new System.Drawing.Size(32, 28);
            this.lblcompError.TabIndex = 40;
            this.lblcompError.Text = "*";
            this.lblcompError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcompError.Visible = false;
            // 
            // lblnameError
            // 
            this.lblnameError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameError.Location = new System.Drawing.Point(229, 117);
            this.lblnameError.Name = "lblnameError";
            this.lblnameError.Size = new System.Drawing.Size(32, 28);
            this.lblnameError.TabIndex = 41;
            this.lblnameError.Text = "*";
            this.lblnameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnameError.Visible = false;
            // 
            // lblntnError
            // 
            this.lblntnError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblntnError.Location = new System.Drawing.Point(229, 301);
            this.lblntnError.Name = "lblntnError";
            this.lblntnError.Size = new System.Drawing.Size(32, 28);
            this.lblntnError.TabIndex = 35;
            this.lblntnError.Text = "*";
            this.lblntnError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblntnError.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "NTN #";
            // 
            // textNTN
            // 
            this.textNTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNTN.Location = new System.Drawing.Point(19, 322);
            this.textNTN.Name = "textNTN";
            this.textNTN.Size = new System.Drawing.Size(237, 23);
            this.textNTN.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.cbStatus.Location = new System.Drawing.Point(19, 414);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(237, 23);
            this.cbStatus.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 397);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 15);
            this.label22.TabIndex = 42;
            this.label22.Text = "Status";
            // 
            // lblstatusError
            // 
            this.lblstatusError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatusError.Location = new System.Drawing.Point(229, 391);
            this.lblstatusError.Name = "lblstatusError";
            this.lblstatusError.Size = new System.Drawing.Size(32, 28);
            this.lblstatusError.TabIndex = 44;
            this.lblstatusError.Text = "*";
            this.lblstatusError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblstatusError.Visible = false;
            // 
            // dgvShowData
            // 
            this.dgvShowData.AllowUserToAddRows = false;
            this.dgvShowData.AllowUserToDeleteRows = false;
            this.dgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowData.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowData.ColumnHeadersHeight = 35;
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suplidGV,
            this.nameGV,
            this.compNameGV,
            this.locidGV,
            this.conctGV,
            this.ntnnoGV,
            this.nmcodeGV,
            this.statGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(790, 495);
            this.dgvShowData.TabIndex = 5;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // lblshortError
            // 
            this.lblshortError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshortError.Location = new System.Drawing.Point(229, 347);
            this.lblshortError.Name = "lblshortError";
            this.lblshortError.Size = new System.Drawing.Size(32, 28);
            this.lblshortError.TabIndex = 35;
            this.lblshortError.Text = "*";
            this.lblshortError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblshortError.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Loc Short Code";
            // 
            // textShortCd
            // 
            this.textShortCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textShortCd.Location = new System.Drawing.Point(19, 368);
            this.textShortCd.Name = "textShortCd";
            this.textShortCd.Size = new System.Drawing.Size(237, 23);
            this.textShortCd.TabIndex = 5;
            // 
            // suplidGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.suplidGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.suplidGV.HeaderText = "Supplier ID";
            this.suplidGV.Name = "suplidGV";
            this.suplidGV.ReadOnly = true;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // compNameGV
            // 
            this.compNameGV.HeaderText = "Company";
            this.compNameGV.Name = "compNameGV";
            this.compNameGV.ReadOnly = true;
            // 
            // locidGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.locidGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.locidGV.HeaderText = "Location";
            this.locidGV.Name = "locidGV";
            this.locidGV.ReadOnly = true;
            // 
            // conctGV
            // 
            this.conctGV.HeaderText = "Contact";
            this.conctGV.Name = "conctGV";
            this.conctGV.ReadOnly = true;
            // 
            // ntnnoGV
            // 
            this.ntnnoGV.HeaderText = "NTN #";
            this.ntnnoGV.Name = "ntnnoGV";
            this.ntnnoGV.ReadOnly = true;
            // 
            // nmcodeGV
            // 
            this.nmcodeGV.HeaderText = "Short Name";
            this.nmcodeGV.Name = "nmcodeGV";
            this.nmcodeGV.ReadOnly = true;
            // 
            // statGV
            // 
            this.statGV.HeaderText = "Status";
            this.statGV.Name = "statGV";
            this.statGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 671);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbllocError;
        private System.Windows.Forms.Label lblcontactError;
        private System.Windows.Forms.Label lblcompError;
        private System.Windows.Forms.Label lblnameError;
        private System.Windows.Forms.TextBox textNTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblntnError;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblstatusError;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.TextBox textShortCd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblshortError;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn compNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn locidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn conctGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statGV;
    }
}