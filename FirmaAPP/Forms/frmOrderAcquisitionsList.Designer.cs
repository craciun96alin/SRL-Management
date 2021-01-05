namespace FirmaAPP
{
    partial class frmOrderAcquisitionsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderAcquisitionsList));
            this.panelFilamentGrid = new System.Windows.Forms.Panel();
            this.dataGridAcquistionsList = new System.Windows.Forms.DataGridView();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEditAcquisition = new System.Windows.Forms.Label();
            this.lbDeleteAcquisition = new System.Windows.Forms.Label();
            this.lbAddFilament = new System.Windows.Forms.Label();
            this.panelOrdersForBuyMenu = new System.Windows.Forms.Panel();
            this.panelOrderOptions = new System.Windows.Forms.Panel();
            this.gbOrderStatus = new System.Windows.Forms.GroupBox();
            this.labelNextOrderStatus = new System.Windows.Forms.Label();
            this.labelBackOrderStatus = new System.Windows.Forms.Label();
            this.btnNextOrderStatus = new System.Windows.Forms.Button();
            this.btnBackOrderStatus = new System.Windows.Forms.Button();
            this.btnEditAcquisition = new System.Windows.Forms.Button();
            this.btnDeleteAcquisition = new System.Windows.Forms.Button();
            this.btnAddAcquisition = new System.Windows.Forms.Button();
            this.panelFilamentGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcquistionsList)).BeginInit();
            this.panelCUDFilament.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelOrdersForBuyMenu.SuspendLayout();
            this.panelOrderOptions.SuspendLayout();
            this.gbOrderStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilamentGrid
            // 
            resources.ApplyResources(this.panelFilamentGrid, "panelFilamentGrid");
            this.panelFilamentGrid.Controls.Add(this.dataGridAcquistionsList);
            this.panelFilamentGrid.Name = "panelFilamentGrid";
            // 
            // dataGridAcquistionsList
            // 
            resources.ApplyResources(this.dataGridAcquistionsList, "dataGridAcquistionsList");
            this.dataGridAcquistionsList.AllowUserToAddRows = false;
            this.dataGridAcquistionsList.AllowUserToDeleteRows = false;
            this.dataGridAcquistionsList.AllowUserToOrderColumns = true;
            this.dataGridAcquistionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAcquistionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAcquistionsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAcquistionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAcquistionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAcquistionsList.Name = "dataGridAcquistionsList";
            this.dataGridAcquistionsList.ReadOnly = true;
            this.dataGridAcquistionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAcquistionsList.RowTemplate.Height = 24;
            this.dataGridAcquistionsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAcquistionsList_CellClick);
            this.dataGridAcquistionsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAcquistionsList_CellDoubleClick);
            this.dataGridAcquistionsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridAcquistionsList_CellFormatting);
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
            this.groupBox1.Controls.Add(this.lbEditAcquisition);
            this.groupBox1.Controls.Add(this.lbDeleteAcquisition);
            this.groupBox1.Controls.Add(this.btnEditAcquisition);
            this.groupBox1.Controls.Add(this.btnDeleteAcquisition);
            this.groupBox1.Controls.Add(this.lbAddFilament);
            this.groupBox1.Controls.Add(this.btnAddAcquisition);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lbEditAcquisition
            // 
            resources.ApplyResources(this.lbEditAcquisition, "lbEditAcquisition");
            this.lbEditAcquisition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditAcquisition.Name = "lbEditAcquisition";
            this.lbEditAcquisition.Click += new System.EventHandler(this.lbEditAcquisition_Click);
            // 
            // lbDeleteAcquisition
            // 
            resources.ApplyResources(this.lbDeleteAcquisition, "lbDeleteAcquisition");
            this.lbDeleteAcquisition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteAcquisition.Name = "lbDeleteAcquisition";
            this.lbDeleteAcquisition.Click += new System.EventHandler(this.lbDeleteAcquisition_Click);
            // 
            // lbAddFilament
            // 
            resources.ApplyResources(this.lbAddFilament, "lbAddFilament");
            this.lbAddFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddFilament.Name = "lbAddFilament";
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
            // btnEditAcquisition
            // 
            resources.ApplyResources(this.btnEditAcquisition, "btnEditAcquisition");
            this.btnEditAcquisition.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditAcquisition.FlatAppearance.BorderSize = 0;
            this.btnEditAcquisition.Name = "btnEditAcquisition";
            this.btnEditAcquisition.UseVisualStyleBackColor = true;
            this.btnEditAcquisition.Click += new System.EventHandler(this.btnEditAcquisition_Click);
            // 
            // btnDeleteAcquisition
            // 
            resources.ApplyResources(this.btnDeleteAcquisition, "btnDeleteAcquisition");
            this.btnDeleteAcquisition.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteAcquisition.FlatAppearance.BorderSize = 0;
            this.btnDeleteAcquisition.Name = "btnDeleteAcquisition";
            this.btnDeleteAcquisition.UseVisualStyleBackColor = true;
            this.btnDeleteAcquisition.Click += new System.EventHandler(this.btnDeleteAcquisition_Click);
            // 
            // btnAddAcquisition
            // 
            resources.ApplyResources(this.btnAddAcquisition, "btnAddAcquisition");
            this.btnAddAcquisition.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddAcquisition.FlatAppearance.BorderSize = 0;
            this.btnAddAcquisition.Name = "btnAddAcquisition";
            this.btnAddAcquisition.UseVisualStyleBackColor = true;
            this.btnAddAcquisition.Click += new System.EventHandler(this.btnAddAcquisition_Click);
            // 
            // frmOrderAcquisitionsList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFilamentGrid);
            this.Controls.Add(this.panelOrdersForBuyMenu);
            this.Name = "frmOrderAcquisitionsList";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrderAcquisitionsList_FormClosed);
            this.Load += new System.EventHandler(this.frmOrderAcquisitionsList_Load);
            this.panelFilamentGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcquistionsList)).EndInit();
            this.panelCUDFilament.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelOrdersForBuyMenu.ResumeLayout(false);
            this.panelOrderOptions.ResumeLayout(false);
            this.gbOrderStatus.ResumeLayout(false);
            this.gbOrderStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFilamentGrid;
        private System.Windows.Forms.DataGridView dataGridAcquistionsList;
        private System.Windows.Forms.Panel panelCUDFilament;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEditAcquisition;
        private System.Windows.Forms.Label lbDeleteAcquisition;
        private System.Windows.Forms.Button btnEditAcquisition;
        private System.Windows.Forms.Button btnDeleteAcquisition;
        private System.Windows.Forms.Label lbAddFilament;
        private System.Windows.Forms.Button btnAddAcquisition;
        private System.Windows.Forms.Panel panelOrdersForBuyMenu;
        private System.Windows.Forms.Panel panelOrderOptions;
        private System.Windows.Forms.GroupBox gbOrderStatus;
        private System.Windows.Forms.Label labelNextOrderStatus;
        private System.Windows.Forms.Button btnNextOrderStatus;
        private System.Windows.Forms.Label labelBackOrderStatus;
        private System.Windows.Forms.Button btnBackOrderStatus;
    }
}