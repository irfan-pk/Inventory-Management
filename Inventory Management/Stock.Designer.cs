
namespace Inventory_Management
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.prodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qpackGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catgGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minlvlGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textSearch.Size = new System.Drawing.Size(111, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(274, 682);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(733, 682);
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
            this.prodIDGV,
            this.codeGV,
            this.barcodeGV,
            this.NameGV,
            this.packGV,
            this.priceGV,
            this.qpackGV,
            this.qtyGV,
            this.statGV,
            this.catgGV,
            this.minlvlGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(733, 506);
            this.dgvShowData.TabIndex = 6;
            // 
            // prodIDGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.prodIDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.prodIDGV.HeaderText = "Prod ID";
            this.prodIDGV.Name = "prodIDGV";
            this.prodIDGV.ReadOnly = true;
            this.prodIDGV.Visible = false;
            // 
            // codeGV
            // 
            this.codeGV.HeaderText = "Code";
            this.codeGV.Name = "codeGV";
            this.codeGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Prod. Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // packGV
            // 
            this.packGV.HeaderText = "Packing";
            this.packGV.Name = "packGV";
            this.packGV.ReadOnly = true;
            // 
            // priceGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // qpackGV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qpackGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.qpackGV.HeaderText = "Per Pack";
            this.qpackGV.Name = "qpackGV";
            this.qpackGV.ReadOnly = true;
            // 
            // qtyGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qtyGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.qtyGV.HeaderText = "Quantity";
            this.qtyGV.Name = "qtyGV";
            this.qtyGV.ReadOnly = true;
            // 
            // statGV
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.statGV.HeaderText = "Status";
            this.statGV.Name = "statGV";
            this.statGV.ReadOnly = true;
            // 
            // catgGV
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.catgGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.catgGV.HeaderText = "Category";
            this.catgGV.Name = "catgGV";
            this.catgGV.ReadOnly = true;
            // 
            // minlvlGV
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.minlvlGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.minlvlGV.HeaderText = "Min. Level";
            this.minlvlGV.Name = "minlvlGV";
            this.minlvlGV.ReadOnly = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 682);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn packGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qpackGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catgGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn minlvlGV;
    }
}