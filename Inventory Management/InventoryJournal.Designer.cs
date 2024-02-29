
namespace Inventory_Management
{
    partial class InventoryJournal
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
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textItemCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblitemError = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indentGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opnbalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recvGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clobalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textSearch.Size = new System.Drawing.Size(128, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnSearch);
            this.leftPanel.Controls.Add(this.textItemCode);
            this.leftPanel.Controls.Add(this.label12);
            this.leftPanel.Controls.Add(this.lblitemError);
            this.leftPanel.Controls.Add(this.dtpToDate);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.dtpFromDate);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(274, 658);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpFromDate, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpToDate, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblitemError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label12, 0);
            this.leftPanel.Controls.SetChildIndex(this.textItemCode, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnSearch, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(810, 658);
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
            this.dgvShowData.ColumnHeadersHeight = 40;
            this.dgvShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGV,
            this.dateGV,
            this.indentGV,
            this.codeGV,
            this.nameGV,
            this.descGV,
            this.opnbalGV,
            this.recvGV,
            this.issueGV,
            this.clobalGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.MultiSelect = false;
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(810, 482);
            this.dgvShowData.TabIndex = 5;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(13, 152);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(249, 23);
            this.dtpToDate.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "To";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(13, 107);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(249, 23);
            this.dtpFromDate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "From";
            // 
            // textItemCode
            // 
            this.textItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textItemCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textItemCode.Location = new System.Drawing.Point(14, 198);
            this.textItemCode.Name = "textItemCode";
            this.textItemCode.Size = new System.Drawing.Size(248, 25);
            this.textItemCode.TabIndex = 20;
            this.textItemCode.TextChanged += new System.EventHandler(this.textItemCode_TextChanged);
            this.textItemCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textItemCode_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Item Code";
            // 
            // lblitemError
            // 
            this.lblitemError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemError.Location = new System.Drawing.Point(236, 175);
            this.lblitemError.Name = "lblitemError";
            this.lblitemError.Size = new System.Drawing.Size(32, 28);
            this.lblitemError.TabIndex = 22;
            this.lblitemError.Text = "*";
            this.lblitemError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblitemError.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(13, 246);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(248, 28);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // idGV
            // 
            this.idGV.HeaderText = "Trans. Id";
            this.idGV.Name = "idGV";
            this.idGV.ReadOnly = true;
            this.idGV.Visible = false;
            // 
            // dateGV
            // 
            dataGridViewCellStyle2.Format = "dd/MMM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.dateGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            // 
            // indentGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.indentGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.indentGV.HeaderText = "Indent No";
            this.indentGV.Name = "indentGV";
            this.indentGV.ReadOnly = true;
            // 
            // codeGV
            // 
            this.codeGV.HeaderText = "Code";
            this.codeGV.Name = "codeGV";
            this.codeGV.ReadOnly = true;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // descGV
            // 
            this.descGV.HeaderText = "Description";
            this.descGV.Name = "descGV";
            this.descGV.ReadOnly = true;
            // 
            // opnbalGV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.opnbalGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.opnbalGV.HeaderText = "Open Bal.";
            this.opnbalGV.Name = "opnbalGV";
            this.opnbalGV.ReadOnly = true;
            // 
            // recvGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.recvGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.recvGV.HeaderText = "Recieved";
            this.recvGV.Name = "recvGV";
            this.recvGV.ReadOnly = true;
            // 
            // issueGV
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.issueGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.issueGV.HeaderText = "Issued";
            this.issueGV.Name = "issueGV";
            this.issueGV.ReadOnly = true;
            // 
            // clobalGV
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clobalGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.clobalGV.HeaderText = "Closing Bal.";
            this.clobalGV.Name = "clobalGV";
            this.clobalGV.ReadOnly = true;
            // 
            // InventoryJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 658);
            this.Name = "InventoryJournal";
            this.Text = "InventoryJournal";
            this.Load += new System.EventHandler(this.InventoryJournal_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textItemCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblitemError;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn indentGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn descGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn opnbalGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn recvGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clobalGV;
    }
}