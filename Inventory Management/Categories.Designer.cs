
namespace Inventory_Management
{
    partial class Categories
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
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblactiveError = new System.Windows.Forms.Label();
            this.lblcatgError = new System.Windows.Forms.Label();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.catIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textSearch.Size = new System.Drawing.Size(88, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.cbIsActive);
            this.leftPanel.Controls.Add(this.textCategory);
            this.leftPanel.Controls.Add(this.label23);
            this.leftPanel.Controls.Add(this.label22);
            this.leftPanel.Controls.Add(this.lblactiveError);
            this.leftPanel.Controls.Add(this.lblcatgError);
            this.leftPanel.Size = new System.Drawing.Size(274, 516);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblcatgError, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblactiveError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label22, 0);
            this.leftPanel.Controls.SetChildIndex(this.label23, 0);
            this.leftPanel.Controls.SetChildIndex(this.textCategory, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbIsActive, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dgvShowData);
            this.rightPanel.Size = new System.Drawing.Size(575, 516);
            this.rightPanel.Controls.SetChildIndex(this.dgvShowData, 0);
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(9, 183);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(255, 23);
            this.cbIsActive.TabIndex = 1;
            // 
            // textCategory
            // 
            this.textCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategory.Location = new System.Drawing.Point(9, 139);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(255, 25);
            this.textCategory.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 122);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 15);
            this.label23.TabIndex = 13;
            this.label23.Text = "Category Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 166);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 15);
            this.label22.TabIndex = 14;
            this.label22.Text = "Is Active";
            // 
            // lblactiveError
            // 
            this.lblactiveError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactiveError.Location = new System.Drawing.Point(239, 160);
            this.lblactiveError.Name = "lblactiveError";
            this.lblactiveError.Size = new System.Drawing.Size(32, 28);
            this.lblactiveError.TabIndex = 17;
            this.lblactiveError.Text = "*";
            this.lblactiveError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblactiveError.Visible = false;
            // 
            // lblcatgError
            // 
            this.lblcatgError.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatgError.Location = new System.Drawing.Point(239, 118);
            this.lblcatgError.Name = "lblcatgError";
            this.lblcatgError.Size = new System.Drawing.Size(32, 28);
            this.lblcatgError.TabIndex = 18;
            this.lblcatgError.Text = "*";
            this.lblcatgError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcatgError.Visible = false;
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
            this.catIdGV,
            this.nameGV,
            this.statGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 105);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(575, 340);
            this.dgvShowData.TabIndex = 5;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
            // 
            // catIdGV
            // 
            this.catIdGV.HeaderText = "Catg ID";
            this.catIdGV.Name = "catIdGV";
            this.catIdGV.ReadOnly = true;
            this.catIdGV.Visible = false;
            // 
            // nameGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameGV.HeaderText = "First Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // statGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.statGV.HeaderText = "Status";
            this.statGV.Name = "statGV";
            this.statGV.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 516);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblactiveError;
        private System.Windows.Forms.Label lblcatgError;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statGV;
    }
}