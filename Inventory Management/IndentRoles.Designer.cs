
namespace Inventory_Management
{
    partial class IndentRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.cbprefix = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbllocError = new System.Windows.Forms.Label();
            this.lblprefixError = new System.Windows.Forms.Label();
            this.lblsplError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbsupplier = new System.Windows.Forms.ComboBox();
            this.lbluserError = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbuser = new System.Windows.Forms.ComboBox();
            this.IdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textSearch.Size = new System.Drawing.Size(103, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.cbprefix);
            this.leftPanel.Controls.Add(this.label22);
            this.leftPanel.Controls.Add(this.cbuser);
            this.leftPanel.Controls.Add(this.label11);
            this.leftPanel.Controls.Add(this.cbsupplier);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.cbLocation);
            this.leftPanel.Controls.Add(this.label14);
            this.leftPanel.Controls.Add(this.lbluserError);
            this.leftPanel.Controls.Add(this.lblsplError);
            this.leftPanel.Controls.Add(this.lbllocError);
            this.leftPanel.Controls.Add(this.lblprefixError);
            this.leftPanel.Size = new System.Drawing.Size(274, 570);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblprefixError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbllocError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblsplError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbluserError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label14, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbLocation, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbsupplier, 0);
            this.leftPanel.Controls.SetChildIndex(this.label11, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbuser, 0);
            this.leftPanel.Controls.SetChildIndex(this.label22, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbprefix, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(680, 570);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
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
            this.IdGV,
            this.userGV,
            this.suplGV,
            this.locidGV,
            this.codeGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(680, 394);
            this.dgvShowData.TabIndex = 6;
            // 
            // cbprefix
            // 
            this.cbprefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprefix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbprefix.FormattingEnabled = true;
            this.cbprefix.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.cbprefix.Location = new System.Drawing.Point(16, 262);
            this.cbprefix.Name = "cbprefix";
            this.cbprefix.Size = new System.Drawing.Size(237, 23);
            this.cbprefix.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 245);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 64;
            this.label22.Text = "Prefix";
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(16, 209);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(237, 23);
            this.cbLocation.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 57;
            this.label14.Text = "Location";
            // 
            // lbllocError
            // 
            this.lbllocError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllocError.Location = new System.Drawing.Point(226, 186);
            this.lbllocError.Name = "lbllocError";
            this.lbllocError.Size = new System.Drawing.Size(32, 28);
            this.lbllocError.TabIndex = 58;
            this.lbllocError.Text = "*";
            this.lbllocError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbllocError.Visible = false;
            // 
            // lblprefixError
            // 
            this.lblprefixError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprefixError.Location = new System.Drawing.Point(226, 239);
            this.lblprefixError.Name = "lblprefixError";
            this.lblprefixError.Size = new System.Drawing.Size(32, 28);
            this.lblprefixError.TabIndex = 65;
            this.lblprefixError.Text = "*";
            this.lblprefixError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblprefixError.Visible = false;
            // 
            // lblsplError
            // 
            this.lblsplError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsplError.Location = new System.Drawing.Point(226, 134);
            this.lblsplError.Name = "lblsplError";
            this.lblsplError.Size = new System.Drawing.Size(32, 28);
            this.lblsplError.TabIndex = 58;
            this.lblsplError.Text = "*";
            this.lblsplError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsplError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Supplier";
            // 
            // cbsupplier
            // 
            this.cbsupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsupplier.FormattingEnabled = true;
            this.cbsupplier.Location = new System.Drawing.Point(16, 157);
            this.cbsupplier.Name = "cbsupplier";
            this.cbsupplier.Size = new System.Drawing.Size(237, 23);
            this.cbsupplier.TabIndex = 47;
            // 
            // lbluserError
            // 
            this.lbluserError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserError.Location = new System.Drawing.Point(226, 84);
            this.lbluserError.Name = "lbluserError";
            this.lbluserError.Size = new System.Drawing.Size(32, 28);
            this.lbluserError.TabIndex = 58;
            this.lbluserError.Text = "*";
            this.lbluserError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbluserError.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 57;
            this.label11.Text = "User";
            // 
            // cbuser
            // 
            this.cbuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbuser.FormattingEnabled = true;
            this.cbuser.Location = new System.Drawing.Point(16, 107);
            this.cbuser.Name = "cbuser";
            this.cbuser.Size = new System.Drawing.Size(237, 23);
            this.cbuser.TabIndex = 47;
            // 
            // IdGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdGV.HeaderText = "ID";
            this.IdGV.Name = "IdGV";
            this.IdGV.ReadOnly = true;
            // 
            // userGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.userGV.HeaderText = "User ID";
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            // 
            // suplGV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.suplGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.suplGV.HeaderText = "Supplier";
            this.suplGV.Name = "suplGV";
            this.suplGV.ReadOnly = true;
            // 
            // locidGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.locidGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.locidGV.HeaderText = "Location";
            this.locidGV.Name = "locidGV";
            this.locidGV.ReadOnly = true;
            // 
            // codeGV
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codeGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.codeGV.HeaderText = "Code";
            this.codeGV.Name = "codeGV";
            this.codeGV.ReadOnly = true;
            // 
            // IndentRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 570);
            this.Name = "IndentRoles";
            this.Text = "IndentRoles";
            this.Load += new System.EventHandler(this.IndentRoles_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.ComboBox cbprefix;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbllocError;
        private System.Windows.Forms.Label lblprefixError;
        private System.Windows.Forms.ComboBox cbuser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbsupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbluserError;
        private System.Windows.Forms.Label lblsplError;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn locidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
    }
}