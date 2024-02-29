
namespace Inventory_Management
{
    partial class SearchSaleInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSaleInvoice));
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.saleidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isubyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lvbIndents = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
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
            // 
            // textSearch
            // 
            this.textSearch.Size = new System.Drawing.Size(111, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btPrint);
            this.leftPanel.Controls.Add(this.btnSearch);
            this.leftPanel.Controls.Add(this.lvbIndents);
            this.leftPanel.Controls.Add(this.dtpToDate);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.dtpFromDate);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(274, 645);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpFromDate, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpToDate, 0);
            this.leftPanel.Controls.SetChildIndex(this.lvbIndents, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnSearch, 0);
            this.leftPanel.Controls.SetChildIndex(this.btPrint, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(718, 645);
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
            this.saleidGV,
            this.dateGV,
            this.fromGV,
            this.toGV,
            this.userGV,
            this.statGV,
            this.isubyGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(718, 469);
            this.dgvShowData.TabIndex = 8;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            this.dgvShowData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            this.dgvShowData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellDoubleClick);
            // 
            // saleidGV
            // 
            this.saleidGV.HeaderText = "Invoice ID";
            this.saleidGV.Name = "saleidGV";
            this.saleidGV.ReadOnly = true;
            // 
            // dateGV
            // 
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            // 
            // fromGV
            // 
            this.fromGV.HeaderText = "Indent From";
            this.fromGV.Name = "fromGV";
            this.fromGV.ReadOnly = true;
            // 
            // toGV
            // 
            this.toGV.HeaderText = "Indent To";
            this.toGV.Name = "toGV";
            this.toGV.ReadOnly = true;
            // 
            // userGV
            // 
            this.userGV.HeaderText = "User";
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            // 
            // statGV
            // 
            this.statGV.HeaderText = "Status";
            this.statGV.Name = "statGV";
            this.statGV.ReadOnly = true;
            // 
            // isubyGV
            // 
            this.isubyGV.HeaderText = "Issued By";
            this.isubyGV.Name = "isubyGV";
            this.isubyGV.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(12, 107);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(249, 23);
            this.dtpFromDate.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(12, 152);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(249, 23);
            this.dtpToDate.TabIndex = 1;
            // 
            // lvbIndents
            // 
            this.lvbIndents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvbIndents.FormattingEnabled = true;
            this.lvbIndents.ItemHeight = 15;
            this.lvbIndents.Location = new System.Drawing.Point(12, 292);
            this.lvbIndents.Name = "lvbIndents";
            this.lvbIndents.Size = new System.Drawing.Size(249, 272);
            this.lvbIndents.TabIndex = 4;
            this.lvbIndents.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Indent List";
            this.label6.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 196);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(249, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(12, 230);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(249, 28);
            this.btPrint.TabIndex = 3;
            this.btPrint.Text = "&Print Invoice";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SearchSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 645);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchSaleInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Indents";
            this.Load += new System.EventHandler(this.SearchSaleInvoice_Load);
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
        private System.Windows.Forms.ListBox lvbIndents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn toGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn isubyGV;
        private System.Windows.Forms.Button btPrint;
    }
}