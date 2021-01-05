namespace FirmaAPP
{
    partial class frmProviderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProviderList));
            this.panelFilamentMenu = new System.Windows.Forms.Panel();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.lbEditProvider = new System.Windows.Forms.Label();
            this.lbDeleteProvider = new System.Windows.Forms.Label();
            this.lbAddFilament = new System.Windows.Forms.Label();
            this.panelProviderGrid = new System.Windows.Forms.Panel();
            this.dataGridProvider = new System.Windows.Forms.DataGridView();
            this.btnEditProvider = new System.Windows.Forms.Button();
            this.btnDeleteProvider = new System.Windows.Forms.Button();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.panelFilamentMenu.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.panelProviderGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilamentMenu
            // 
            resources.ApplyResources(this.panelFilamentMenu, "panelFilamentMenu");
            this.panelFilamentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelFilamentMenu.Controls.Add(this.panelCUDFilament);
            this.panelFilamentMenu.Name = "panelFilamentMenu";
            // 
            // panelCUDFilament
            // 
            resources.ApplyResources(this.panelCUDFilament, "panelCUDFilament");
            this.panelCUDFilament.Controls.Add(this.lbEditProvider);
            this.panelCUDFilament.Controls.Add(this.lbDeleteProvider);
            this.panelCUDFilament.Controls.Add(this.btnEditProvider);
            this.panelCUDFilament.Controls.Add(this.btnDeleteProvider);
            this.panelCUDFilament.Controls.Add(this.lbAddFilament);
            this.panelCUDFilament.Controls.Add(this.btnAddProvider);
            this.panelCUDFilament.Name = "panelCUDFilament";
            // 
            // lbEditProvider
            // 
            resources.ApplyResources(this.lbEditProvider, "lbEditProvider");
            this.lbEditProvider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditProvider.Name = "lbEditProvider";
            this.lbEditProvider.Click += new System.EventHandler(this.lbEditProvider_Click);
            // 
            // lbDeleteProvider
            // 
            resources.ApplyResources(this.lbDeleteProvider, "lbDeleteProvider");
            this.lbDeleteProvider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteProvider.Name = "lbDeleteProvider";
            this.lbDeleteProvider.Click += new System.EventHandler(this.lbDeleteProvider_Click);
            // 
            // lbAddFilament
            // 
            resources.ApplyResources(this.lbAddFilament, "lbAddFilament");
            this.lbAddFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddFilament.Name = "lbAddFilament";
            // 
            // panelProviderGrid
            // 
            resources.ApplyResources(this.panelProviderGrid, "panelProviderGrid");
            this.panelProviderGrid.Controls.Add(this.dataGridProvider);
            this.panelProviderGrid.Name = "panelProviderGrid";
            // 
            // dataGridProvider
            // 
            resources.ApplyResources(this.dataGridProvider, "dataGridProvider");
            this.dataGridProvider.AllowUserToAddRows = false;
            this.dataGridProvider.AllowUserToDeleteRows = false;
            this.dataGridProvider.AllowUserToOrderColumns = true;
            this.dataGridProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProvider.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridProvider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProvider.Name = "dataGridProvider";
            this.dataGridProvider.ReadOnly = true;
            this.dataGridProvider.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridProvider.RowTemplate.Height = 24;
            this.dataGridProvider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProvider_CellDoubleClick);
            // 
            // btnEditProvider
            // 
            resources.ApplyResources(this.btnEditProvider, "btnEditProvider");
            this.btnEditProvider.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditProvider.Name = "btnEditProvider";
            this.btnEditProvider.UseVisualStyleBackColor = true;
            this.btnEditProvider.Click += new System.EventHandler(this.btnEditProvider_Click);
            // 
            // btnDeleteProvider
            // 
            resources.ApplyResources(this.btnDeleteProvider, "btnDeleteProvider");
            this.btnDeleteProvider.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteProvider.Name = "btnDeleteProvider";
            this.btnDeleteProvider.UseVisualStyleBackColor = true;
            this.btnDeleteProvider.Click += new System.EventHandler(this.btnDeleteProvider_Click);
            // 
            // btnAddProvider
            // 
            resources.ApplyResources(this.btnAddProvider, "btnAddProvider");
            this.btnAddProvider.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // frmProviderList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panelFilamentMenu);
            this.Name = "frmProviderList";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProviderList_FormClosed);
            this.Load += new System.EventHandler(this.frmProviderList_Load);
            this.panelFilamentMenu.ResumeLayout(false);
            this.panelCUDFilament.ResumeLayout(false);
            this.panelCUDFilament.PerformLayout();
            this.panelProviderGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilamentMenu;
        private System.Windows.Forms.Panel panelCUDFilament;
        private System.Windows.Forms.Label lbEditProvider;
        private System.Windows.Forms.Label lbDeleteProvider;
        private System.Windows.Forms.Button btnEditProvider;
        private System.Windows.Forms.Button btnDeleteProvider;
        private System.Windows.Forms.Label lbAddFilament;
        private System.Windows.Forms.Button btnAddProvider;
        private System.Windows.Forms.Panel panelProviderGrid;
        private System.Windows.Forms.DataGridView dataGridProvider;
    }
}