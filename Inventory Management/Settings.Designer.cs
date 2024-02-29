
namespace Inventory_Management
{
    partial class Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.textServer = new System.Windows.Forms.TextBox();
            this.textDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIntegrated = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnSave);
            this.leftPanel.Controls.Add(this.cbIntegrated);
            this.leftPanel.Controls.Add(this.textPassword);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.textUserId);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.textDatabase);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.textServer);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(274, 696);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.textServer, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.textDatabase, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.textUserId, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.textPassword, 0);
            this.leftPanel.Controls.SetChildIndex(this.cbIntegrated, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(274, 0);
            this.rightPanel.Size = new System.Drawing.Size(755, 696);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // textServer
            // 
            this.textServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textServer.Location = new System.Drawing.Point(12, 206);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(251, 23);
            this.textServer.TabIndex = 0;
            // 
            // textDatabase
            // 
            this.textDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDatabase.Location = new System.Drawing.Point(12, 252);
            this.textDatabase.Name = "textDatabase";
            this.textDatabase.Size = new System.Drawing.Size(251, 23);
            this.textDatabase.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // textUserId
            // 
            this.textUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserId.Location = new System.Drawing.Point(12, 298);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(251, 23);
            this.textUserId.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID";
            // 
            // textPassword
            // 
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPassword.Location = new System.Drawing.Point(12, 346);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(251, 23);
            this.textPassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // cbIntegrated
            // 
            this.cbIntegrated.AutoSize = true;
            this.cbIntegrated.Location = new System.Drawing.Point(12, 375);
            this.cbIntegrated.Name = "cbIntegrated";
            this.cbIntegrated.Size = new System.Drawing.Size(127, 19);
            this.cbIntegrated.TabIndex = 9;
            this.cbIntegrated.Text = "Integrated Security";
            this.cbIntegrated.UseVisualStyleBackColor = true;
            this.cbIntegrated.CheckedChanged += new System.EventHandler(this.cbIntegrated_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(251, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 696);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbIntegrated;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.Label label3;
    }
}