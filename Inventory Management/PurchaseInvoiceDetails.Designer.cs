
namespace Inventory_Management
{
    partial class PurchaseInvoiceDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInvoiceMth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInvoices = new System.Windows.Forms.ComboBox();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.pidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qpackGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catgGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btPrint = new System.Windows.Forms.Button();
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // textSearch
            // 
            this.textSearch.Size = new System.Drawing.Size(124, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btPrint);
            this.leftPanel.Controls.Add(this.cbInvoices);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.dtpInvoiceMth);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(274, 694);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpInvoiceMth, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbInvoices, 0);
            this.leftPanel.Controls.SetChildIndex(this.btPrint, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(811, 694);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Invoice Month";
            // 
            // dtpInvoiceMth
            // 
            this.dtpInvoiceMth.CustomFormat = "MMMM - yyyy";
            this.dtpInvoiceMth.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceMth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceMth.Location = new System.Drawing.Point(13, 105);
            this.dtpInvoiceMth.Name = "dtpInvoiceMth";
            this.dtpInvoiceMth.ShowUpDown = true;
            this.dtpInvoiceMth.Size = new System.Drawing.Size(248, 25);
            this.dtpInvoiceMth.TabIndex = 0;
            this.dtpInvoiceMth.ValueChanged += new System.EventHandler(this.dtpInvoiceMth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Invoice";
            // 
            // cbInvoices
            // 
            this.cbInvoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbInvoices.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoices.FormattingEnabled = true;
            this.cbInvoices.Location = new System.Drawing.Point(13, 155);
            this.cbInvoices.Name = "cbInvoices";
            this.cbInvoices.Size = new System.Drawing.Size(248, 25);
            this.cbInvoices.TabIndex = 1;
            this.cbInvoices.SelectedIndexChanged += new System.EventHandler(this.cbInvoices_SelectedIndexChanged);
            // 
            // dgvShowData
            // 
            this.dgvShowData.AllowUserToAddRows = false;
            this.dgvShowData.AllowUserToDeleteRows = false;
            this.dgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowData.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
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
            this.pidGV,
            this.codeGV,
            this.NameGV,
            this.packGV,
            this.qpackGV,
            this.qtyGV,
            this.catgGV,
            this.statGV,
            this.deleteGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(811, 518);
            this.dgvShowData.TabIndex = 7;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // pidGV
            // 
            this.pidGV.HeaderText = "Purch. Invoice";
            this.pidGV.Name = "pidGV";
            this.pidGV.ReadOnly = true;
            this.pidGV.Visible = false;
            // 
            // codeGV
            // 
            this.codeGV.HeaderText = "Code";
            this.codeGV.Name = "codeGV";
            this.codeGV.ReadOnly = true;
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
            // qpackGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qpackGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.qpackGV.HeaderText = "Per Pack";
            this.qpackGV.Name = "qpackGV";
            this.qpackGV.ReadOnly = true;
            // 
            // qtyGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qtyGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtyGV.HeaderText = "Quantity";
            this.qtyGV.Name = "qtyGV";
            this.qtyGV.ReadOnly = true;
            // 
            // catgGV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.catgGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.catgGV.HeaderText = "Category";
            this.catgGV.Name = "catgGV";
            this.catgGV.ReadOnly = true;
            // 
            // statGV
            // 
            this.statGV.HeaderText = "Status";
            this.statGV.Name = "statGV";
            this.statGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.deleteGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.deleteGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.ToolTipText = "Delete current Item";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(13, 206);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(248, 28);
            this.btPrint.TabIndex = 2;
            this.btPrint.Text = "&Print Invoice";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // PurchaseInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 694);
            this.Name = "PurchaseInvoiceDetails";
            this.Text = "PurchaseInvoiceDetails";
            this.Load += new System.EventHandler(this.PurchaseInvoiceDetails_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInvoices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInvoiceMth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn packGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qpackGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catgGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.Button btPrint;
    }
}