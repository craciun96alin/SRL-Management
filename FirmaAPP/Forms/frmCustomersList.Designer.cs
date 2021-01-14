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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersList));
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
            resources.ApplyResources(this.panelCustomerMenu, "panelCustomerMenu");
            this.panelCustomerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelCustomerMenu.Controls.Add(this.panelCUDCustomer);
            this.panelCustomerMenu.Name = "panelCustomerMenu";
            // 
            // panelCUDCustomer
            // 
            resources.ApplyResources(this.panelCUDCustomer, "panelCUDCustomer");
            this.panelCUDCustomer.Controls.Add(this.lbEditCustomer);
            this.panelCUDCustomer.Controls.Add(this.lbDeleteCustomer);
            this.panelCUDCustomer.Controls.Add(this.btnEditCustomer);
            this.panelCUDCustomer.Controls.Add(this.btnDeleteCustomer);
            this.panelCUDCustomer.Controls.Add(this.lbAddCustomer);
            this.panelCUDCustomer.Controls.Add(this.btnAddCustomer);
            this.panelCUDCustomer.Name = "panelCUDCustomer";
            // 
            // lbEditCustomer
            // 
            resources.ApplyResources(this.lbEditCustomer, "lbEditCustomer");
            this.lbEditCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditCustomer.Name = "lbEditCustomer";
            this.lbEditCustomer.Click += new System.EventHandler(this.lbEditCustomer_Click);
            // 
            // lbDeleteCustomer
            // 
            resources.ApplyResources(this.lbDeleteCustomer, "lbDeleteCustomer");
            this.lbDeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteCustomer.Name = "lbDeleteCustomer";
            this.lbDeleteCustomer.Click += new System.EventHandler(this.lbDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            resources.ApplyResources(this.btnEditCustomer, "btnEditCustomer");
            this.btnEditCustomer.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            resources.ApplyResources(this.btnDeleteCustomer, "btnDeleteCustomer");
            this.btnDeleteCustomer.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // lbAddCustomer
            // 
            resources.ApplyResources(this.lbAddCustomer, "lbAddCustomer");
            this.lbAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddCustomer.Name = "lbAddCustomer";
            // 
            // btnAddCustomer
            // 
            resources.ApplyResources(this.btnAddCustomer, "btnAddCustomer");
            this.btnAddCustomer.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // panelProviderGrid
            // 
            resources.ApplyResources(this.panelProviderGrid, "panelProviderGrid");
            this.panelProviderGrid.Controls.Add(this.dataGridCustomer);
            this.panelProviderGrid.Name = "panelProviderGrid";
            // 
            // dataGridCustomer
            // 
            resources.ApplyResources(this.dataGridCustomer, "dataGridCustomer");
            this.dataGridCustomer.AllowUserToAddRows = false;
            this.dataGridCustomer.AllowUserToDeleteRows = false;
            this.dataGridCustomer.AllowUserToOrderColumns = true;
            this.dataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.ReadOnly = true;
            this.dataGridCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCustomer.RowTemplate.Height = 24;
            // 
            // frmCustomersList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panelCustomerMenu);
            this.Name = "frmCustomersList";
            this.ShowIcon = false;
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