
namespace Inventory_Management
{
    partial class OrderProcess
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowPOrders = new System.Windows.Forms.Button();
            this.btnIndents = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvShowData = new System.Windows.Forms.DataGridView();
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
            this.textSearch.Size = new System.Drawing.Size(115, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.dtpToDate);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.dtpFromDate);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.btnFinalize);
            this.leftPanel.Controls.Add(this.btnIndents);
            this.leftPanel.Controls.Add(this.btnShowPOrders);
            this.leftPanel.Size = new System.Drawing.Size(274, 650);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnShowPOrders, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnIndents, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnFinalize, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpFromDate, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.dtpToDate, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(752, 650);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
            // 
            // btnShowPOrders
            // 
            this.btnShowPOrders.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowPOrders.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowPOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPOrders.Location = new System.Drawing.Point(12, 196);
            this.btnShowPOrders.Name = "btnShowPOrders";
            this.btnShowPOrders.Size = new System.Drawing.Size(249, 40);
            this.btnShowPOrders.TabIndex = 2;
            this.btnShowPOrders.Text = "Purchase Orders";
            this.toolTip1.SetToolTip(this.btnShowPOrders, "View Pending Purchase Orders");
            this.btnShowPOrders.UseVisualStyleBackColor = false;
            this.btnShowPOrders.Click += new System.EventHandler(this.btnShowPOrders_Click);
            // 
            // btnIndents
            // 
            this.btnIndents.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIndents.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIndents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndents.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndents.Location = new System.Drawing.Point(12, 242);
            this.btnIndents.Name = "btnIndents";
            this.btnIndents.Size = new System.Drawing.Size(249, 40);
            this.btnIndents.TabIndex = 3;
            this.btnIndents.Text = "Indents Orders";
            this.toolTip1.SetToolTip(this.btnIndents, "View Pending Indents");
            this.btnIndents.UseVisualStyleBackColor = false;
            this.btnIndents.Click += new System.EventHandler(this.btnIndents_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalize.Location = new System.Drawing.Point(12, 288);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(249, 40);
            this.btnFinalize.TabIndex = 4;
            this.btnFinalize.Text = "Finalize";
            this.toolTip1.SetToolTip(this.btnFinalize, "Finalize Purchase / Indents orders");
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(12, 148);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(249, 23);
            this.dtpToDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "To";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(12, 103);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(249, 23);
            this.dtpFromDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "From";
            // 
            // dgvShowData
            // 
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
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.MultiSelect = false;
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(752, 474);
            this.dgvShowData.TabIndex = 4;
            // 
            // OrderProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 650);
            this.Name = "OrderProcess";
            this.Text = "Orders Status";
            this.Load += new System.EventHandler(this.OrderProcess_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnIndents;
        private System.Windows.Forms.Button btnShowPOrders;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvShowData;
    }
}