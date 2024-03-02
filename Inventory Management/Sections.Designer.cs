
namespace Inventory_Management
{
    partial class Sections
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
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.secIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lbldescError = new System.Windows.Forms.Label();
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
            this.textSearch.Size = new System.Drawing.Size(101, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.textDescription);
            this.leftPanel.Controls.Add(this.lbldesc);
            this.leftPanel.Controls.Add(this.lbldescError);
            this.leftPanel.Size = new System.Drawing.Size(274, 540);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbldescError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbldesc, 0);
            this.leftPanel.Controls.SetChildIndex(this.textDescription, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(673, 540);
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
            this.secIdGV,
            this.descGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(673, 364);
            this.dgvShowData.TabIndex = 8;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // secIdGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.secIdGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.secIdGV.HeaderText = "Type ID";
            this.secIdGV.Name = "secIdGV";
            this.secIdGV.ReadOnly = true;
            // 
            // descGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.descGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.descGV.HeaderText = "Description";
            this.descGV.Name = "descGV";
            this.descGV.ReadOnly = true;
            // 
            // textDescription
            // 
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(10, 139);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(255, 25);
            this.textDescription.TabIndex = 28;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(10, 122);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(68, 15);
            this.lbldesc.TabIndex = 27;
            this.lbldesc.Text = "Description";
            // 
            // lbldescError
            // 
            this.lbldescError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescError.Location = new System.Drawing.Point(240, 118);
            this.lbldescError.Name = "lbldescError";
            this.lbldescError.Size = new System.Drawing.Size(32, 28);
            this.lbldescError.TabIndex = 29;
            this.lbldescError.Text = "*";
            this.lbldescError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldescError.Visible = false;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Name = "Sections";
            this.Text = "Sections";
            this.Load += new System.EventHandler(this.Sections_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lbldescError;
        private System.Windows.Forms.DataGridViewTextBoxColumn secIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn descGV;
    }
}