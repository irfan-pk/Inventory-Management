
namespace Inventory_Management
{
    partial class NewIndent
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
            this.label6 = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIndentFrom = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbIndentTo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textItemCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textQty = new System.Windows.Forms.TextBox();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.saleidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qpackGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catgGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblindentError = new System.Windows.Forms.Label();
            this.lblitemError = new System.Windows.Forms.Label();
            this.lblqtyError = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
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
            this.textSearch.Size = new System.Drawing.Size(130, 23);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            this.textSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyUp);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.dtpInvoiceDate);
            this.leftPanel.Controls.Add(this.panel6);
            this.leftPanel.Controls.Add(this.textQty);
            this.leftPanel.Controls.Add(this.textItemCode);
            this.leftPanel.Controls.Add(this.cbIndentTo);
            this.leftPanel.Controls.Add(this.label13);
            this.leftPanel.Controls.Add(this.lblIndentFrom);
            this.leftPanel.Controls.Add(this.label12);
            this.leftPanel.Controls.Add(this.label11);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.lblInvoiceNo);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.lblindentError);
            this.leftPanel.Controls.Add(this.lblitemError);
            this.leftPanel.Controls.Add(this.lblqtyError);
            this.leftPanel.Size = new System.Drawing.Size(274, 720);
            this.leftPanel.Controls.SetChildIndex(this.lblqtyError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblitemError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblindentError, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblInvoiceNo, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label11, 0);
            this.leftPanel.Controls.SetChildIndex(this.label12, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblIndentFrom, 0);
            this.leftPanel.Controls.SetChildIndex(this.label13, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbIndentTo, 0);
            this.leftPanel.Controls.SetChildIndex(this.textItemCode, 0);
            this.leftPanel.Controls.SetChildIndex(this.textQty, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel6, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpInvoiceDate, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(847, 720);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Indent Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Indent #";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.BackColor = System.Drawing.Color.Gainsboro;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(13, 160);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(248, 24);
            this.lblInvoiceNo.TabIndex = 1;
            this.lblInvoiceNo.Text = "0";
            this.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Indent From";
            // 
            // lblIndentFrom
            // 
            this.lblIndentFrom.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIndentFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndentFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIndentFrom.Location = new System.Drawing.Point(13, 214);
            this.lblIndentFrom.Name = "lblIndentFrom";
            this.lblIndentFrom.Size = new System.Drawing.Size(248, 24);
            this.lblIndentFrom.TabIndex = 2;
            this.lblIndentFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Indent To";
            // 
            // cbIndentTo
            // 
            this.cbIndentTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbIndentTo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIndentTo.FormattingEnabled = true;
            this.cbIndentTo.Location = new System.Drawing.Point(13, 268);
            this.cbIndentTo.Name = "cbIndentTo";
            this.cbIndentTo.Size = new System.Drawing.Size(248, 25);
            this.cbIndentTo.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Item Code (F2 List)";
            // 
            // textItemCode
            // 
            this.textItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textItemCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textItemCode.Location = new System.Drawing.Point(13, 324);
            this.textItemCode.Name = "textItemCode";
            this.textItemCode.Size = new System.Drawing.Size(248, 25);
            this.textItemCode.TabIndex = 4;
            this.textItemCode.TextChanged += new System.EventHandler(this.textItemCode_TextChanged);
            this.textItemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textItemCode_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Required Qty.";
            // 
            // textQty
            // 
            this.textQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textQty.Enabled = false;
            this.textQty.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQty.Location = new System.Drawing.Point(13, 379);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(248, 25);
            this.textQty.TabIndex = 5;
            this.textQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textQty_KeyDown);
            this.textQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQty_KeyPress);
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
            this.saleidGV,
            this.dateGV,
            this.codeGV,
            this.NameGV,
            this.packGV,
            this.qpackGV,
            this.qtyGV,
            this.catgGV,
            this.deleteGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.RowTemplate.Height = 26;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(847, 544);
            this.dgvShowData.TabIndex = 7;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // saleidGV
            // 
            this.saleidGV.HeaderText = "Invoice ID";
            this.saleidGV.Name = "saleidGV";
            this.saleidGV.ReadOnly = true;
            this.saleidGV.Visible = false;
            // 
            // dateGV
            // 
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
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
            // deleteGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.deleteGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.deleteGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.ToolTipText = "Delete current Item";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // lblindentError
            // 
            this.lblindentError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindentError.Location = new System.Drawing.Point(235, 244);
            this.lblindentError.Name = "lblindentError";
            this.lblindentError.Size = new System.Drawing.Size(32, 28);
            this.lblindentError.TabIndex = 13;
            this.lblindentError.Text = "*";
            this.lblindentError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblindentError.Visible = false;
            // 
            // lblitemError
            // 
            this.lblitemError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemError.Location = new System.Drawing.Point(235, 302);
            this.lblitemError.Name = "lblitemError";
            this.lblitemError.Size = new System.Drawing.Size(32, 28);
            this.lblitemError.TabIndex = 14;
            this.lblitemError.Text = "*";
            this.lblitemError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblitemError.Visible = false;
            // 
            // lblqtyError
            // 
            this.lblqtyError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtyError.Location = new System.Drawing.Point(235, 358);
            this.lblqtyError.Name = "lblqtyError";
            this.lblqtyError.Size = new System.Drawing.Size(32, 28);
            this.lblqtyError.TabIndex = 15;
            this.lblqtyError.Text = "*";
            this.lblqtyError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblqtyError.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 607);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 42);
            this.panel6.TabIndex = 48;
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
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "MMMM - yyyy";
            this.dtpInvoiceDate.Enabled = false;
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Location = new System.Drawing.Point(13, 108);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(248, 25);
            this.dtpInvoiceDate.TabIndex = 0;
            // 
            // NewIndent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 720);
            this.Name = "NewIndent";
            this.Text = "NewIndent";
            this.Load += new System.EventHandler(this.NewIndent_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblIndentFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIndentTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textItemCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.Label lblindentError;
        private System.Windows.Forms.Label lblitemError;
        private System.Windows.Forms.Label lblqtyError;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn packGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qpackGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catgGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}