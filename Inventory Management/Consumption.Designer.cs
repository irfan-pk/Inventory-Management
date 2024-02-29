
namespace Inventory_Management
{
    partial class Consumption
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
            this.dgvDateDisplay = new System.Windows.Forms.DataGridView();
            this.cdateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.textConsumption = new System.Windows.Forms.TextBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textPack = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpConsumptionDate = new System.Windows.Forms.DateTimePicker();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opnbalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumpGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clobalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.textSearch.Size = new System.Drawing.Size(128, 23);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.dgvDateDisplay);
            this.leftPanel.Size = new System.Drawing.Size(274, 652);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.dgvDateDisplay, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.splitContainer1);
            this.rightPanel.Size = new System.Drawing.Size(835, 652);
            this.rightPanel.Controls.SetChildIndex(this.splitContainer1, 0);
            // 
            // dgvDateDisplay
            // 
            this.dgvDateDisplay.AllowUserToAddRows = false;
            this.dgvDateDisplay.AllowUserToDeleteRows = false;
            this.dgvDateDisplay.AllowUserToResizeColumns = false;
            this.dgvDateDisplay.AllowUserToResizeRows = false;
            this.dgvDateDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDateDisplay.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvDateDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDateDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDateDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDateDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDateDisplay.ColumnHeadersHeight = 48;
            this.dgvDateDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDateDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdateGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDateDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDateDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDateDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDateDisplay.EnableHeadersVisualStyles = false;
            this.dgvDateDisplay.Location = new System.Drawing.Point(0, 55);
            this.dgvDateDisplay.MultiSelect = false;
            this.dgvDateDisplay.Name = "dgvDateDisplay";
            this.dgvDateDisplay.ReadOnly = true;
            this.dgvDateDisplay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDateDisplay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDateDisplay.RowHeadersVisible = false;
            this.dgvDateDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDateDisplay.Size = new System.Drawing.Size(274, 526);
            this.dgvDateDisplay.TabIndex = 0;
            this.dgvDateDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDateDisplay_CellClick);
            this.dgvDateDisplay.SelectionChanged += new System.EventHandler(this.dgvDateDisplay_SelectionChanged);
            // 
            // cdateGV
            // 
            this.cdateGV.HeaderText = "Consumption Date";
            this.cdateGV.Name = "cdateGV";
            this.cdateGV.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 105);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Enabled = false;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvShowData);
            this.splitContainer1.Size = new System.Drawing.Size(835, 476);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textConsumption, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.textStock, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textPack, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textDesc, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textCode, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpConsumptionDate, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(833, 57);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Select Date";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textConsumption
            // 
            this.textConsumption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textConsumption.Location = new System.Drawing.Point(693, 31);
            this.textConsumption.Name = "textConsumption";
            this.textConsumption.Size = new System.Drawing.Size(137, 23);
            this.textConsumption.TabIndex = 5;
            this.textConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textConsumption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textConsumption_KeyDown);
            // 
            // textStock
            // 
            this.textStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textStock.Location = new System.Drawing.Point(555, 31);
            this.textStock.Name = "textStock";
            this.textStock.ReadOnly = true;
            this.textStock.Size = new System.Drawing.Size(132, 23);
            this.textStock.TabIndex = 4;
            this.textStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textPack
            // 
            this.textPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPack.Location = new System.Drawing.Point(417, 31);
            this.textPack.Name = "textPack";
            this.textPack.ReadOnly = true;
            this.textPack.Size = new System.Drawing.Size(132, 23);
            this.textPack.TabIndex = 3;
            // 
            // textDesc
            // 
            this.textDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDesc.Location = new System.Drawing.Point(279, 31);
            this.textDesc.Name = "textDesc";
            this.textDesc.ReadOnly = true;
            this.textDesc.Size = new System.Drawing.Size(132, 23);
            this.textDesc.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(693, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Consumption";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(555, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Stock";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Packing";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textCode
            // 
            this.textCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCode.Location = new System.Drawing.Point(141, 31);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(132, 23);
            this.textCode.TabIndex = 1;
            this.textCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyDown);
            this.textCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpConsumptionDate
            // 
            this.dtpConsumptionDate.CustomFormat = "MM/dd/yyyy";
            this.dtpConsumptionDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpConsumptionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsumptionDate.Location = new System.Drawing.Point(3, 31);
            this.dtpConsumptionDate.Name = "dtpConsumptionDate";
            this.dtpConsumptionDate.Size = new System.Drawing.Size(132, 23);
            this.dtpConsumptionDate.TabIndex = 0;
            this.dtpConsumptionDate.ValueChanged += new System.EventHandler(this.dtpConsumption_ValueChanged);
            this.dtpConsumptionDate.Leave += new System.EventHandler(this.dtpConsumption_Leave);
            // 
            // dgvShowData
            // 
            this.dgvShowData.AllowUserToAddRows = false;
            this.dgvShowData.AllowUserToDeleteRows = false;
            this.dgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowData.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowData.ColumnHeadersHeight = 35;
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateGV,
            this.codeGV,
            this.NameGV,
            this.packGV,
            this.opnbalGV,
            this.consumpGV,
            this.clobalGV,
            this.actionGV});
            this.dgvShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowData.EnableHeadersVisualStyles = false;
            this.dgvShowData.Location = new System.Drawing.Point(0, 0);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvShowData.RowHeadersVisible = false;
            this.dgvShowData.RowTemplate.Height = 26;
            this.dgvShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowData.Size = new System.Drawing.Size(833, 411);
            this.dgvShowData.TabIndex = 10;
            this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
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
            // opnbalGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.opnbalGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.opnbalGV.HeaderText = "Opening Bal.";
            this.opnbalGV.Name = "opnbalGV";
            this.opnbalGV.ReadOnly = true;
            // 
            // consumpGV
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.consumpGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.consumpGV.HeaderText = "Consumption";
            this.consumpGV.Name = "consumpGV";
            this.consumpGV.ReadOnly = true;
            // 
            // clobalGV
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clobalGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.clobalGV.HeaderText = "Closing Bal.";
            this.clobalGV.Name = "clobalGV";
            this.clobalGV.ReadOnly = true;
            // 
            // actionGV
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.actionGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.actionGV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.actionGV.HeaderText = "Action";
            this.actionGV.Name = "actionGV";
            this.actionGV.ReadOnly = true;
            this.actionGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actionGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.actionGV.Text = "DELETE";
            this.actionGV.ToolTipText = "Delete current Item";
            this.actionGV.UseColumnTextForButtonValue = true;
            // 
            // Consumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 652);
            this.Name = "Consumption";
            this.Text = "Consumption";
            this.Load += new System.EventHandler(this.Consumption_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateDisplay)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgvDateDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdateGV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.TextBox textPack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textConsumption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpConsumptionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn packGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn opnbalGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumpGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clobalGV;
        private System.Windows.Forms.DataGridViewButtonColumn actionGV;
    }
}