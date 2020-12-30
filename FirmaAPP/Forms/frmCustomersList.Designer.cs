namespace FirmaAPP
{
    partial class frmCustomersList
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
            this.panelCustomerMenu = new System.Windows.Forms.Panel();
            this.panelCUDCustomer = new System.Windows.Forms.Panel();
            this.lbEditCustomer = new System.Windows.Forms.Label();
            this.lbDeleteCustomer = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.lbAddCustomer = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.panelProviderGrid = new System.Windows.Forms.Panel();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.panelCustomerMenu.SuspendLayout();
            this.panelCUDCustomer.SuspendLayout();
            this.panelProviderGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCustomerMenu
            // 
            this.panelCustomerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelCustomerMenu.Controls.Add(this.panelCUDCustomer);
            this.panelCustomerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerMenu.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerMenu.Name = "panelCustomerMenu";
            this.panelCustomerMenu.Size = new System.Drawing.Size(1198, 100);
            this.panelCustomerMenu.TabIndex = 2;
            // 
            // panelCUDCustomer
            // 
            this.panelCUDCustomer.Controls.Add(this.lbEditCustomer);
            this.panelCUDCustomer.Controls.Add(this.lbDeleteCustomer);
            this.panelCUDCustomer.Controls.Add(this.btnEditCustomer);
            this.panelCUDCustomer.Controls.Add(this.btnDeleteCustomer);
            this.panelCUDCustomer.Controls.Add(this.lbAddCustomer);
            this.panelCUDCustomer.Controls.Add(this.btnAddCustomer);
            this.panelCUDCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCUDCustomer.Name = "panelCUDCustomer";
            this.panelCUDCustomer.Size = new System.Drawing.Size(262, 100);
            this.panelCUDCustomer.TabIndex = 0;
            // 
            // lbEditCustomer
            // 
            this.lbEditCustomer.AutoSize = true;
            this.lbEditCustomer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditCustomer.Location = new System.Drawing.Point(144, 53);
            this.lbEditCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.lbEditCustomer.Name = "lbEditCustomer";
            this.lbEditCustomer.Size = new System.Drawing.Size(111, 30);
            this.lbEditCustomer.TabIndex = 5;
            this.lbEditCustomer.Text = "Modifică";
            this.lbEditCustomer.Click += new System.EventHandler(this.lbEditCustomer_Click);
            // 
            // lbDeleteCustomer
            // 
            this.lbDeleteCustomer.AutoSize = true;
            this.lbDeleteCustomer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteCustomer.Location = new System.Drawing.Point(144, 12);
            this.lbDeleteCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.lbDeleteCustomer.Name = "lbDeleteCustomer";
            this.lbDeleteCustomer.Size = new System.Drawing.Size(90, 30);
            this.lbDeleteCustomer.TabIndex = 4;
            this.lbDeleteCustomer.Text = "Șterge";
            this.lbDeleteCustomer.Click += new System.EventHandler(this.lbDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Location = new System.Drawing.Point(106, 49);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(46, 42);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(108, 10);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(44, 36);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // lbAddCustomer
            // 
            this.lbAddCustomer.AutoSize = true;
            this.lbAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddCustomer.Location = new System.Drawing.Point(25, 78);
            this.lbAddCustomer.Name = "lbAddCustomer";
            this.lbAddCustomer.Size = new System.Drawing.Size(57, 18);
            this.lbAddCustomer.TabIndex = 1;
            this.lbAddCustomer.Text = "Adaugă";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(102, 78);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // panelProviderGrid
            // 
            this.panelProviderGrid.Controls.Add(this.dataGridCustomer);
            this.panelProviderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProviderGrid.Location = new System.Drawing.Point(0, 100);
            this.panelProviderGrid.Name = "panelProviderGrid";
            this.panelProviderGrid.Size = new System.Drawing.Size(1198, 554);
            this.panelProviderGrid.TabIndex = 3;
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToAddRows = false;
            this.dataGridCustomer.AllowUserToDeleteRows = false;
            this.dataGridCustomer.AllowUserToOrderColumns = true;
            this.dataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.ReadOnly = true;
            this.dataGridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCustomer.RowTemplate.Height = 24;
            this.dataGridCustomer.Size = new System.Drawing.Size(1198, 554);
            this.dataGridCustomer.TabIndex = 0;
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panelCustomerMenu);
            this.Name = "frmCustomersList";
            this.ShowIcon = false;
            this.Text = "Listă clienți";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomersList_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomersList_Load);
            this.panelCustomerMenu.ResumeLayout(false);
            this.panelCUDCustomer.ResumeLayout(false);
            this.panelCUDCustomer.PerformLayout();
            this.panelProviderGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCustomerMenu;
        private System.Windows.Forms.Panel panelCUDCustomer;
        private System.Windows.Forms.Label lbEditCustomer;
        private System.Windows.Forms.Label lbDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label lbAddCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel panelProviderGrid;
        private System.Windows.Forms.DataGridView dataGridCustomer;
    }
}