
namespace Inventory_Management
{
    partial class CodeList
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
            this.dgvCodeHelp = new System.Windows.Forms.DataGridView();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCodeHelp
            // 
            this.dgvCodeHelp.AllowUserToAddRows = false;
            this.dgvCodeHelp.AllowUserToDeleteRows = false;
            this.dgvCodeHelp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCodeHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCodeHelp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCodeHelp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCodeHelp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCodeHelp.ColumnHeadersHeight = 24;
            this.dgvCodeHelp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeGV,
            this.descGV});
            this.dgvCodeHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCodeHelp.EnableHeadersVisualStyles = false;
            this.dgvCodeHelp.Location = new System.Drawing.Point(0, 0);
            this.dgvCodeHelp.MultiSelect = false;
            this.dgvCodeHelp.Name = "dgvCodeHelp";
            this.dgvCodeHelp.ReadOnly = true;
            this.dgvCodeHelp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCodeHelp.RowHeadersVisible = false;
            this.dgvCodeHelp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCodeHelp.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCodeHelp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodeHelp.Size = new System.Drawing.Size(570, 357);
            this.dgvCodeHelp.TabIndex = 0;
            this.dgvCodeHelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCodeHelp_KeyDown);
            // 
            // codeGV
            // 
            this.codeGV.HeaderText = "Item Code";
            this.codeGV.Name = "codeGV";
            this.codeGV.ReadOnly = true;
            // 
            // descGV
            // 
            this.descGV.HeaderText = "Item Description";
            this.descGV.Name = "descGV";
            this.descGV.ReadOnly = true;
            // 
            // CodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 357);
            this.Controls.Add(this.dgvCodeHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Code List";
            this.Load += new System.EventHandler(this.CodeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCodeHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn descGV;
    }
}