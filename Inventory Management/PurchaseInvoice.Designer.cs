
namespace Inventory_Management
{
    partial class PurchaseInvoice
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
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblsuplError = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcodeError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textPack = new System.Windows.Forms.TextBox();
            this.lblqtyError = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textQty = new System.Windows.Forms.TextBox();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textPerPack = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.pidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qpackGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catgGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.textSearch.Size = new System.Drawing.Size(127, 23);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.dtpInvoiceDate);
            this.leftPanel.Controls.Add(this.btnAddCart);
            this.leftPanel.Controls.Add(this.panel6);
            this.leftPanel.Controls.Add(this.label11);
            this.leftPanel.Controls.Add(this.textQty);
            this.leftPanel.Controls.Add(this.textPerPack);
            this.leftPanel.Controls.Add(this.textPack);
            this.leftPanel.Controls.Add(this.label14);
            this.leftPanel.Controls.Add(this.textName);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.label12);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.lblqtyError);
            this.leftPanel.Controls.Add(this.textCategory);
            this.leftPanel.Controls.Add(this.textCode);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.lblcodeError);
            this.leftPanel.Controls.Add(this.cbSupplier);
            this.leftPanel.Controls.Add(this.label16);
            this.leftPanel.Controls.Add(this.lblsuplError);
            this.leftPanel.Size = new System.Drawing.Size(274, 676);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblsuplError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label16, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbSupplier, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblcodeError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.textCode, 0);
            this.leftPanel.Controls.SetChildIndex(this.textCategory, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblqtyError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.label12, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.textName, 0);
            this.leftPanel.Controls.SetChildIndex(this.label14, 0);
            this.leftPanel.Controls.SetChildIndex(this.textPack, 0);
            this.leftPanel.Controls.SetChildIndex(this.textPerPack, 0);
            this.leftPanel.Controls.SetChildIndex(this.textQty, 0);
            this.leftPanel.Controls.SetChildIndex(this.label11, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel6, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnAddCart, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpInvoiceDate, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(809, 676);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(18, 157);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(237, 23);
            this.cbSupplier.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "Supplier";
            // 
            // lblsuplError
            // 
            this.lblsuplError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuplError.Location = new System.Drawing.Point(228, 134);
            this.lblsuplError.Name = "lblsuplError";
            this.lblsuplError.Size = new System.Drawing.Size(32, 28);
            this.lblsuplError.TabIndex = 14;
            this.lblsuplError.Text = "*";
            this.lblsuplError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblsuplError.Visible = false;
            // 
            // textCode
            // 
            this.textCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textCode.Location = new System.Drawing.Point(18, 205);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(237, 23);
            this.textCode.TabIndex = 2;
            this.textCode.TextChanged += new System.EventHandler(this.textCode_TextChanged);
            this.textCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Item Code";
            // 
            // lblcodeError
            // 
            this.lblcodeError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodeError.Location = new System.Drawing.Point(228, 184);
            this.lblcodeError.Name = "lblcodeError";
            this.lblcodeError.Size = new System.Drawing.Size(32, 28);
            this.lblcodeError.TabIndex = 44;
            this.lblcodeError.Text = "*";
            this.lblcodeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcodeError.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Item Name";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(18, 252);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(237, 23);
            this.textName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Category";
            // 
            // textCategory
            // 
            this.textCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCategory.Enabled = false;
            this.textCategory.Location = new System.Drawing.Point(18, 298);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(237, 23);
            this.textCategory.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "Item Pack";
            // 
            // textPack
            // 
            this.textPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPack.Enabled = false;
            this.textPack.Location = new System.Drawing.Point(18, 345);
            this.textPack.Name = "textPack";
            this.textPack.Size = new System.Drawing.Size(237, 23);
            this.textPack.TabIndex = 5;
            // 
            // lblqtyError
            // 
            this.lblqtyError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtyError.Location = new System.Drawing.Point(228, 419);
            this.lblqtyError.Name = "lblqtyError";
            this.lblqtyError.Size = new System.Drawing.Size(32, 28);
            this.lblqtyError.TabIndex = 44;
            this.lblqtyError.Text = "*";
            this.lblqtyError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblqtyError.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 43;
            this.label14.Text = "Required Qty.";
            // 
            // textQty
            // 
            this.textQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQty.Location = new System.Drawing.Point(18, 440);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(237, 23);
            this.textQty.TabIndex = 7;
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
            this.dgvShowData.Size = new System.Drawing.Size(809, 500);
            this.dgvShowData.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Per Pack";
            // 
            // textPerPack
            // 
            this.textPerPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPerPack.Enabled = false;
            this.textPerPack.Location = new System.Drawing.Point(18, 391);
            this.textPerPack.Name = "textPerPack";
            this.textPerPack.Size = new System.Drawing.Size(237, 23);
            this.textPerPack.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Invoice Date";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 563);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 42);
            this.panel6.TabIndex = 47;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(110, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 21);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Total Items";
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCart.Enabled = false;
            this.btnAddCart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.Location = new System.Drawing.Point(18, 484);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(237, 40);
            this.btnAddCart.TabIndex = 8;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Location = new System.Drawing.Point(18, 105);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(237, 25);
            this.dtpInvoiceDate.TabIndex = 0;
            // 
            // pidGV
            // 
            this.pidGV.HeaderText = "Prch. Invoice";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.statGV.HeaderText = "Status";
            this.statGV.Name = "statGV";
            this.statGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.deleteGV.DefaultCellStyle = dataGridViewCellStyle6;
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
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 676);
            this.Name = "PurchaseInvoice";
            this.Text = "PruchaseInvoice";
            this.Load += new System.EventHandler(this.PruchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblsuplError;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcodeError;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.TextBox textPack;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblqtyError;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.TextBox textPerPack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn packGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qpackGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catgGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}