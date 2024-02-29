
namespace Inventory_Management
{
    partial class Locations
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
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblprovinceError = new System.Windows.Forms.Label();
            this.lblcityError = new System.Windows.Forms.Label();
            this.lblstreetError = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.LocIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textSearch.Size = new System.Drawing.Size(119, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.cbProvince);
            this.leftPanel.Controls.Add(this.cbCity);
            this.leftPanel.Controls.Add(this.textStreet);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.lblstreetError);
            this.leftPanel.Controls.Add(this.lblprovinceError);
            this.leftPanel.Controls.Add(this.lblcityError);
            this.leftPanel.Size = new System.Drawing.Size(274, 736);
            this.leftPanel.Controls.SetChildIndex(this.lblcityError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblprovinceError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblstreetError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.label9, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.textStreet, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbCity, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbProvince, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(781, 736);
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
            this.LocIdGV,
            this.cityGV,
            this.provinceGV,
            this.streetGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(781, 560);
            this.dgvShowData.TabIndex = 7;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Province";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "City";
            // 
            // lblprovinceError
            // 
            this.lblprovinceError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprovinceError.Location = new System.Drawing.Point(233, 164);
            this.lblprovinceError.Name = "lblprovinceError";
            this.lblprovinceError.Size = new System.Drawing.Size(32, 28);
            this.lblprovinceError.TabIndex = 27;
            this.lblprovinceError.Text = "*";
            this.lblprovinceError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblprovinceError.Visible = false;
            // 
            // lblcityError
            // 
            this.lblcityError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcityError.Location = new System.Drawing.Point(233, 118);
            this.lblcityError.Name = "lblcityError";
            this.lblcityError.Size = new System.Drawing.Size(32, 28);
            this.lblcityError.TabIndex = 28;
            this.lblcityError.Text = "*";
            this.lblcityError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcityError.Visible = false;
            // 
            // lblstreetError
            // 
            this.lblstreetError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstreetError.Location = new System.Drawing.Point(233, 212);
            this.lblstreetError.Name = "lblstreetError";
            this.lblstreetError.Size = new System.Drawing.Size(32, 28);
            this.lblstreetError.TabIndex = 26;
            this.lblstreetError.Text = "*";
            this.lblstreetError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblstreetError.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Street";
            // 
            // textStreet
            // 
            this.textStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textStreet.Location = new System.Drawing.Point(20, 234);
            this.textStreet.Name = "textStreet";
            this.textStreet.Size = new System.Drawing.Size(237, 23);
            this.textStreet.TabIndex = 3;
            // 
            // cbCity
            // 
            this.cbCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Faislabad",
            "Gujranwala",
            "Hyderabad",
            "Islamabad",
            "Karachi",
            "Lahore",
            "Mirpur Khas",
            "Multan",
            "Nawabshah",
            "Peshawar",
            "Quetta",
            "Rawalpindi",
            "Sukkur"});
            this.cbCity.Location = new System.Drawing.Point(20, 141);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(237, 23);
            this.cbCity.Sorted = true;
            this.cbCity.TabIndex = 1;
            // 
            // cbProvince
            // 
            this.cbProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "Balochistan",
            "Kahyber Pakhtunkhua",
            "Punjab",
            "Sindh"});
            this.cbProvince.Location = new System.Drawing.Point(20, 188);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(237, 23);
            this.cbProvince.Sorted = true;
            this.cbProvince.TabIndex = 2;
            // 
            // LocIdGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LocIdGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.LocIdGV.HeaderText = "ID";
            this.LocIdGV.Name = "LocIdGV";
            this.LocIdGV.ReadOnly = true;
            // 
            // cityGV
            // 
            this.cityGV.HeaderText = "City";
            this.cityGV.Name = "cityGV";
            this.cityGV.ReadOnly = true;
            // 
            // provinceGV
            // 
            this.provinceGV.HeaderText = "Province";
            this.provinceGV.Name = "provinceGV";
            this.provinceGV.ReadOnly = true;
            // 
            // streetGV
            // 
            this.streetGV.HeaderText = "Street";
            this.streetGV.Name = "streetGV";
            this.streetGV.ReadOnly = true;
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 736);
            this.Name = "Locations";
            this.Text = "Locations";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblstreetError;
        private System.Windows.Forms.Label lblprovinceError;
        private System.Windows.Forms.Label lblcityError;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetGV;
    }
}