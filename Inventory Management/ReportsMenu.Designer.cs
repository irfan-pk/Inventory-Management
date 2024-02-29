
namespace Inventory_Management
{
    partial class ReportsMenu
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
            this.gbSelectReport = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnPreview = new System.Windows.Forms.Button();
            this.rbStockPosition = new System.Windows.Forms.RadioButton();
            this.rbBalSummary = new System.Windows.Forms.RadioButton();
            this.rbBalDetail = new System.Windows.Forms.RadioButton();
            this.rbCashSheet = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.gbSelectReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.textSearch.Size = new System.Drawing.Size(102, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Size = new System.Drawing.Size(274, 638);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.gbSelectReport);
            this.rightPanel.Size = new System.Drawing.Size(659, 638);
            this.rightPanel.Controls.SetChildIndex(this.gbSelectReport, 0);
            // 
            // gbSelectReport
            // 
            this.gbSelectReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbSelectReport.Controls.Add(this.label3);
            this.gbSelectReport.Controls.Add(this.label2);
            this.gbSelectReport.Controls.Add(this.dtpTo);
            this.gbSelectReport.Controls.Add(this.dtpFrom);
            this.gbSelectReport.Controls.Add(this.btnPreview);
            this.gbSelectReport.Controls.Add(this.rbStockPosition);
            this.gbSelectReport.Controls.Add(this.rbBalSummary);
            this.gbSelectReport.Controls.Add(this.rbBalDetail);
            this.gbSelectReport.Controls.Add(this.rbCashSheet);
            this.gbSelectReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelectReport.Location = new System.Drawing.Point(0, 105);
            this.gbSelectReport.Name = "gbSelectReport";
            this.gbSelectReport.Size = new System.Drawing.Size(659, 462);
            this.gbSelectReport.TabIndex = 4;
            this.gbSelectReport.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date From";
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(112, 296);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(240, 23);
            this.dtpTo.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(112, 246);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(240, 23);
            this.dtpFrom.TabIndex = 9;
            // 
            // btnPreview
            // 
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = global::Inventory_Management.Properties.Resources.analyze_24px;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(112, 339);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(122, 37);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // rbStockPosition
            // 
            this.rbStockPosition.AutoSize = true;
            this.rbStockPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbStockPosition.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStockPosition.Location = new System.Drawing.Point(112, 58);
            this.rbStockPosition.Name = "rbStockPosition";
            this.rbStockPosition.Size = new System.Drawing.Size(140, 29);
            this.rbStockPosition.TabIndex = 4;
            this.rbStockPosition.TabStop = true;
            this.rbStockPosition.Text = "Stock Postion";
            this.rbStockPosition.UseVisualStyleBackColor = true;
            this.rbStockPosition.Click += new System.EventHandler(this.rbStockPosition_Click);
            // 
            // rbBalSummary
            // 
            this.rbBalSummary.AutoSize = true;
            this.rbBalSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbBalSummary.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBalSummary.Location = new System.Drawing.Point(112, 92);
            this.rbBalSummary.Name = "rbBalSummary";
            this.rbBalSummary.Size = new System.Drawing.Size(228, 29);
            this.rbBalSummary.TabIndex = 5;
            this.rbBalSummary.TabStop = true;
            this.rbBalSummary.Text = "Stock Balance Summary";
            this.rbBalSummary.UseVisualStyleBackColor = true;
            this.rbBalSummary.Click += new System.EventHandler(this.rbBalSummary_Click);
            // 
            // rbBalDetail
            // 
            this.rbBalDetail.AutoSize = true;
            this.rbBalDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbBalDetail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBalDetail.Location = new System.Drawing.Point(112, 126);
            this.rbBalDetail.Name = "rbBalDetail";
            this.rbBalDetail.Size = new System.Drawing.Size(243, 29);
            this.rbBalDetail.TabIndex = 6;
            this.rbBalDetail.TabStop = true;
            this.rbBalDetail.Text = "Stock Balance With Detail";
            this.rbBalDetail.UseVisualStyleBackColor = true;
            this.rbBalDetail.Click += new System.EventHandler(this.rbBalDetail_Click);
            // 
            // rbCashSheet
            // 
            this.rbCashSheet.AutoSize = true;
            this.rbCashSheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbCashSheet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCashSheet.Location = new System.Drawing.Point(112, 161);
            this.rbCashSheet.Name = "rbCashSheet";
            this.rbCashSheet.Size = new System.Drawing.Size(122, 29);
            this.rbCashSheet.TabIndex = 7;
            this.rbCashSheet.TabStop = true;
            this.rbCashSheet.Text = "Cash Sheet";
            this.rbCashSheet.UseVisualStyleBackColor = true;
            this.rbCashSheet.Click += new System.EventHandler(this.rbCashSheet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Inventory_Management.Properties.Resources.report_icon_133351;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 512);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ReportsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 638);
            this.Name = "ReportsMenu";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsMenu_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.gbSelectReport.ResumeLayout(false);
            this.gbSelectReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectReport;
        private System.Windows.Forms.RadioButton rbStockPosition;
        private System.Windows.Forms.RadioButton rbBalSummary;
        private System.Windows.Forms.RadioButton rbBalDetail;
        private System.Windows.Forms.RadioButton rbCashSheet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
    }
}