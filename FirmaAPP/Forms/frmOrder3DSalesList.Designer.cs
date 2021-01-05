namespace FirmaAPP
{
    partial class frmOrder3DSalesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder3DSalesList));
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridSalesList = new System.Windows.Forms.DataGridView();
            this.panelOrdersForBuyMenu = new System.Windows.Forms.Panel();
            this.panelOrderOptions = new System.Windows.Forms.Panel();
            this.gbOrderStatus = new System.Windows.Forms.GroupBox();
            this.labelNextOrderStatus = new System.Windows.Forms.Label();
            this.labelBackOrderStatus = new System.Windows.Forms.Label();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEditSale = new System.Windows.Forms.Label();
            this.lbDeleteSale = new System.Windows.Forms.Label();
            this.lbAddSale = new System.Windows.Forms.Label();
            this.btnNextOrderStatus = new System.Windows.Forms.Button();
            this.btnBackOrderStatus = new System.Windows.Forms.Button();
            this.btnEditSale = new System.Windows.Forms.Button();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesList)).BeginInit();
            this.panelOrdersForBuyMenu.SuspendLayout();
            this.panelOrderOptions.SuspendLayout();
            this.gbOrderStatus.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            resources.ApplyResources(this.panelGrid, "panelGrid");
            this.panelGrid.Controls.Add(this.dataGridSalesList);
            this.panelGrid.Name = "panelGrid";
            // 
            // dataGridSalesList
            // 
            resources.ApplyResources(this.dataGridSalesList, "dataGridSalesList");
            this.dataGridSalesList.AllowUserToAddRows = false;
            this.dataGridSalesList.AllowUserToDeleteRows = false;
            this.dataGridSalesList.AllowUserToOrderColumns = true;
            this.dataGridSalesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSalesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSalesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSalesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesList.Name = "dataGridSalesList";
            this.dataGridSalesList.ReadOnly = true;
            this.dataGridSalesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSalesList.RowTemplate.Height = 24;
            this.dataGridSalesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalesList_CellClick);
            this.dataGridSalesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalesList_CellDoubleClick);
            this.dataGridSalesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridSalesList_CellFormatting);
            // 
            // panelOrdersForBuyMenu
            // 
            resources.ApplyResources(this.panelOrdersForBuyMenu, "panelOrdersForBuyMenu");
            this.panelOrdersForBuyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelOrdersForBuyMenu.Controls.Add(this.panelOrderOptions);
            this.panelOrdersForBuyMenu.Controls.Add(this.panelCUDFilament);
            this.panelOrdersForBuyMenu.Name = "panelOrdersForBuyMenu";
            // 
            // panelOrderOptions
            // 
            resources.ApplyResources(this.panelOrderOptions, "panelOrderOptions");
            this.panelOrderOptions.Controls.Add(this.gbOrderStatus);
            this.panelOrderOptions.Name = "panelOrderOptions";
            // 
            // gbOrderStatus
            // 
            resources.ApplyResources(this.gbOrderStatus, "gbOrderStatus");
            this.gbOrderStatus.Controls.Add(this.labelNextOrderStatus);
            this.gbOrderStatus.Controls.Add(this.btnNextOrderStatus);
            this.gbOrderStatus.Controls.Add(this.labelBackOrderStatus);
            this.gbOrderStatus.Controls.Add(this.btnBackOrderStatus);
            this.gbOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbOrderStatus.Name = "gbOrderStatus";
            this.gbOrderStatus.TabStop = false;
            // 
            // labelNextOrderStatus
            // 
            resources.ApplyResources(this.labelNextOrderStatus, "labelNextOrderStatus");
            this.labelNextOrderStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNextOrderStatus.Name = "labelNextOrderStatus";
            // 
            // labelBackOrderStatus
            // 
            resources.ApplyResources(this.labelBackOrderStatus, "labelBackOrderStatus");
            this.labelBackOrderStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBackOrderStatus.Name = "labelBackOrderStatus";
            // 
            // panelCUDFilament
            // 
            resources.ApplyResources(this.panelCUDFilament, "panelCUDFilament");
            this.panelCUDFilament.Controls.Add(this.groupBox1);
            this.panelCUDFilament.Name = "panelCUDFilament";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lbEditSale);
            this.groupBox1.Controls.Add(this.lbDeleteSale);
            this.groupBox1.Controls.Add(this.btnEditSale);
            this.groupBox1.Controls.Add(this.btnDeleteSale);
            this.groupBox1.Controls.Add(this.lbAddSale);
            this.groupBox1.Controls.Add(this.btnAddSale);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lbEditSale
            // 
            resources.ApplyResources(this.lbEditSale, "lbEditSale");
            this.lbEditSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditSale.Name = "lbEditSale";
            // 
            // lbDeleteSale
            // 
            resources.ApplyResources(this.lbDeleteSale, "lbDeleteSale");
            this.lbDeleteSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteSale.Name = "lbDeleteSale";
            this.lbDeleteSale.Click += new System.EventHandler(this.lbDeleteSale_Click);
            // 
            // lbAddSale
            // 
            resources.ApplyResources(this.lbAddSale, "lbAddSale");
            this.lbAddSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddSale.Name = "lbAddSale";
            // 
            // btnNextOrderStatus
            // 
            resources.ApplyResources(this.btnNextOrderStatus, "btnNextOrderStatus");
            this.btnNextOrderStatus.BackgroundImage = global::FirmaAPP.Properties.Resources.NextIcon;
            this.btnNextOrderStatus.FlatAppearance.BorderSize = 0;
            this.btnNextOrderStatus.Name = "btnNextOrderStatus";
            this.btnNextOrderStatus.UseVisualStyleBackColor = true;
            this.btnNextOrderStatus.Click += new System.EventHandler(this.btnNextOrderStatus_Click);
            // 
            // btnBackOrderStatus
            // 
            resources.ApplyResources(this.btnBackOrderStatus, "btnBackOrderStatus");
            this.btnBackOrderStatus.BackgroundImage = global::FirmaAPP.Properties.Resources.PreviousIcon;
            this.btnBackOrderStatus.FlatAppearance.BorderSize = 0;
            this.btnBackOrderStatus.Name = "btnBackOrderStatus";
            this.btnBackOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnEditSale
            // 
            resources.ApplyResources(this.btnEditSale, "btnEditSale");
            this.btnEditSale.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditSale.FlatAppearance.BorderSize = 0;
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSale
            // 
            resources.ApplyResources(this.btnDeleteSale, "btnDeleteSale");
            this.btnDeleteSale.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteSale.FlatAppearance.BorderSize = 0;
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // btnAddSale
            // 
            resources.ApplyResources(this.btnAddSale, "btnAddSale");
            this.btnAddSale.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddSale.FlatAppearance.BorderSize = 0;
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // frmOrder3DSalesList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelOrdersForBuyMenu);
            this.Name = "frmOrder3DSalesList";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrder3DSalesList_FormClosed);
            this.Load += new System.EventHandler(this.frmOrderSales3DList_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesList)).EndInit();
            this.panelOrdersForBuyMenu.ResumeLayout(false);
            this.panelOrderOptions.ResumeLayout(false);
            this.gbOrderStatus.ResumeLayout(false);
            this.gbOrderStatus.PerformLayout();
            this.panelCUDFilament.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridSalesList;
        private System.Windows.Forms.Panel panelOrdersForBuyMenu;
        private System.Windows.Forms.Panel panelOrderOptions;
        private System.Windows.Forms.GroupBox gbOrderStatus;
        private System.Windows.Forms.Label labelNextOrderStatus;
        private System.Windows.Forms.Button btnNextOrderStatus;
        private System.Windows.Forms.Label labelBackOrderStatus;
        private System.Windows.Forms.Button btnBackOrderStatus;
        private System.Windows.Forms.Panel panelCUDFilament;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEditSale;
        private System.Windows.Forms.Label lbDeleteSale;
        private System.Windows.Forms.Button btnEditSale;
        private System.Windows.Forms.Button btnDeleteSale;
        private System.Windows.Forms.Label lbAddSale;
        private System.Windows.Forms.Button btnAddSale;
    }
}