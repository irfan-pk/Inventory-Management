
namespace Inventory_Management
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.btnUsrLvl = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnConsumption = new System.Windows.Forms.Button();
            this.btnStoreOrders = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnInvJournal = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnViewIndents = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(274, 770);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(981, 770);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnStock, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnProducts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSupplier, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCategory, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRoles, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTypes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLocation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSections, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUsrLvl, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPurchase, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConsumption, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStoreOrders, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSales, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInvJournal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnReports, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnViewIndents, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 644);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnStock
            // 
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Image = global::Inventory_Management.Properties.Resources.commodity_48px;
            this.btnStock.Location = new System.Drawing.Point(395, 3);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(190, 122);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = global::Inventory_Management.Properties.Resources.basket_48px;
            this.btnProducts.Location = new System.Drawing.Point(199, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(190, 122);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = global::Inventory_Management.Properties.Resources.users1;
            this.btnUser.Location = new System.Drawing.Point(3, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(190, 122);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Users";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSupplier.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Image = global::Inventory_Management.Properties.Resources.supplier_48px;
            this.btnSupplier.Location = new System.Drawing.Point(787, 131);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(191, 122);
            this.btnSupplier.TabIndex = 9;
            this.btnSupplier.Text = "Suppliers";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = global::Inventory_Management.Properties.Resources.categorize_48px;
            this.btnCategory.Location = new System.Drawing.Point(591, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(190, 122);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Categories";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoles.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.Image = global::Inventory_Management.Properties.Resources.security_ssl_48px;
            this.btnRoles.Location = new System.Drawing.Point(787, 3);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(191, 122);
            this.btnRoles.TabIndex = 4;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnTypes
            // 
            this.btnTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTypes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTypes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypes.Image = global::Inventory_Management.Properties.Resources.profiles_48px_2;
            this.btnTypes.Location = new System.Drawing.Point(3, 131);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(190, 122);
            this.btnTypes.TabIndex = 5;
            this.btnTypes.Text = "User Types";
            this.btnTypes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTypes.UseVisualStyleBackColor = true;
            this.btnTypes.Click += new System.EventHandler(this.btnTypes_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLocation.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.Image = global::Inventory_Management.Properties.Resources.location_48px;
            this.btnLocation.Location = new System.Drawing.Point(199, 131);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(190, 122);
            this.btnLocation.TabIndex = 6;
            this.btnLocation.Text = "Locations";
            this.btnLocation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnSections
            // 
            this.btnSections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSections.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSections.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSections.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSections.Image = global::Inventory_Management.Properties.Resources.Office_48px;
            this.btnSections.Location = new System.Drawing.Point(395, 131);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(190, 122);
            this.btnSections.TabIndex = 7;
            this.btnSections.Text = "Sections";
            this.btnSections.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSections.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // btnUsrLvl
            // 
            this.btnUsrLvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsrLvl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsrLvl.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUsrLvl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsrLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrLvl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsrLvl.Image = global::Inventory_Management.Properties.Resources.administrative_tools_48px;
            this.btnUsrLvl.Location = new System.Drawing.Point(591, 131);
            this.btnUsrLvl.Name = "btnUsrLvl";
            this.btnUsrLvl.Size = new System.Drawing.Size(190, 122);
            this.btnUsrLvl.TabIndex = 8;
            this.btnUsrLvl.Text = "Indent Roles";
            this.btnUsrLvl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsrLvl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsrLvl.UseVisualStyleBackColor = true;
            this.btnUsrLvl.Click += new System.EventHandler(this.btnUsrLvl_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchase.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Image = global::Inventory_Management.Properties.Resources.purchase_order_48px;
            this.btnPurchase.Location = new System.Drawing.Point(3, 259);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(190, 122);
            this.btnPurchase.TabIndex = 10;
            this.btnPurchase.Text = "Purchase Order";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnConsumption
            // 
            this.btnConsumption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsumption.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConsumption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsumption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumption.Image = global::Inventory_Management.Properties.Resources.user_manual_48px;
            this.btnConsumption.Location = new System.Drawing.Point(591, 259);
            this.btnConsumption.Name = "btnConsumption";
            this.btnConsumption.Size = new System.Drawing.Size(190, 122);
            this.btnConsumption.TabIndex = 13;
            this.btnConsumption.Text = "Consumption";
            this.btnConsumption.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsumption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsumption.UseVisualStyleBackColor = true;
            this.btnConsumption.Click += new System.EventHandler(this.btnConsumption_Click);
            // 
            // btnStoreOrders
            // 
            this.btnStoreOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStoreOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStoreOrders.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStoreOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnStoreOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreOrders.Image = global::Inventory_Management.Properties.Resources.ok_48px;
            this.btnStoreOrders.Location = new System.Drawing.Point(199, 259);
            this.btnStoreOrders.Name = "btnStoreOrders";
            this.btnStoreOrders.Size = new System.Drawing.Size(190, 122);
            this.btnStoreOrders.TabIndex = 11;
            this.btnStoreOrders.Text = "Orders Status";
            this.btnStoreOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStoreOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStoreOrders.UseVisualStyleBackColor = true;
            this.btnStoreOrders.Click += new System.EventHandler(this.btnStoreOrders_Click);
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::Inventory_Management.Properties.Resources.invoice_48px;
            this.btnSales.Location = new System.Drawing.Point(395, 259);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(190, 122);
            this.btnSales.TabIndex = 12;
            this.btnSales.Text = "Indent";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnInvJournal
            // 
            this.btnInvJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInvJournal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInvJournal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInvJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvJournal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvJournal.Image = global::Inventory_Management.Properties.Resources.magazine_48px;
            this.btnInvJournal.Location = new System.Drawing.Point(3, 387);
            this.btnInvJournal.Name = "btnInvJournal";
            this.btnInvJournal.Size = new System.Drawing.Size(190, 122);
            this.btnInvJournal.TabIndex = 15;
            this.btnInvJournal.Text = "Inventory Journal";
            this.btnInvJournal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInvJournal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInvJournal.UseVisualStyleBackColor = true;
            this.btnInvJournal.Click += new System.EventHandler(this.btnInvJournal_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = global::Inventory_Management.Properties.Resources.combo_chart_48px;
            this.btnReports.Location = new System.Drawing.Point(199, 387);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(190, 122);
            this.btnReports.TabIndex = 16;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnViewIndents
            // 
            this.btnViewIndents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewIndents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewIndents.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnViewIndents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnViewIndents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIndents.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIndents.Image = global::Inventory_Management.Properties.Resources.view_48px;
            this.btnViewIndents.Location = new System.Drawing.Point(787, 259);
            this.btnViewIndents.Name = "btnViewIndents";
            this.btnViewIndents.Size = new System.Drawing.Size(191, 122);
            this.btnViewIndents.TabIndex = 14;
            this.btnViewIndents.Text = "View Indents";
            this.btnViewIndents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewIndents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewIndents.UseVisualStyleBackColor = true;
            this.btnViewIndents.Click += new System.EventHandler(this.btnViewIndents_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 644);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inventory Managment System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 770);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnTypes;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnSections;
        private System.Windows.Forms.Button btnUsrLvl;
        private System.Windows.Forms.Button btnConsumption;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStoreOrders;
        private System.Windows.Forms.Button btnInvJournal;
        private System.Windows.Forms.Button btnViewIndents;
    }
}