
namespace Inventory_Management
{
    partial class Roles
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
            this.textRole = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblnameError = new System.Windows.Forms.Label();
            this.lbldescError = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.roleIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textSearch.Size = new System.Drawing.Size(125, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.textDescription);
            this.leftPanel.Controls.Add(this.lbldesc);
            this.leftPanel.Controls.Add(this.textRole);
            this.leftPanel.Controls.Add(this.lbldescError);
            this.leftPanel.Controls.Add(this.label23);
            this.leftPanel.Controls.Add(this.lblnameError);
            this.leftPanel.Size = new System.Drawing.Size(274, 611);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblnameError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label23, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbldescError, 0);
            this.leftPanel.Controls.SetChildIndex(this.textRole, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbldesc, 0);
            this.leftPanel.Controls.SetChildIndex(this.textDescription, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(797, 611);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
            // 
            // textRole
            // 
            this.textRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRole.Location = new System.Drawing.Point(9, 139);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(255, 25);
            this.textRole.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 15);
            this.label23.TabIndex = 19;
            this.label23.Text = "Role Name";
            // 
            // lblnameError
            // 
            this.lblnameError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameError.Location = new System.Drawing.Point(239, 118);
            this.lblnameError.Name = "lblnameError";
            this.lblnameError.Size = new System.Drawing.Size(32, 28);
            this.lblnameError.TabIndex = 21;
            this.lblnameError.Text = "*";
            this.lblnameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnameError.Visible = false;
            // 
            // lbldescError
            // 
            this.lbldescError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescError.Location = new System.Drawing.Point(239, 169);
            this.lbldescError.Name = "lbldescError";
            this.lbldescError.Size = new System.Drawing.Size(32, 28);
            this.lbldescError.TabIndex = 21;
            this.lbldescError.Text = "*";
            this.lbldescError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldescError.Visible = false;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(9, 173);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(94, 15);
            this.lbldesc.TabIndex = 19;
            this.lbldesc.Text = "Role Description";
            // 
            // textDescription
            // 
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(9, 190);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(255, 25);
            this.textDescription.TabIndex = 1;
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
            this.roleIdGV,
            this.nameGV,
            this.descGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(797, 435);
            this.dgvShowData.TabIndex = 6;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // roleIdGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roleIdGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.roleIdGV.HeaderText = "Role ID";
            this.roleIdGV.Name = "roleIdGV";
            this.roleIdGV.ReadOnly = true;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Role Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // descGV
            // 
            this.descGV.HeaderText = "Role Description";
            this.descGV.Name = "descGV";
            this.descGV.ReadOnly = true;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 611);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.Label lbldescError;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblnameError;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn descGV;
    }
}