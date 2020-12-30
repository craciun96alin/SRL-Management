namespace FirmaAPP
{
    partial class frmOrderTshirtsSalesList
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
            this.panelOrdersForBuyMenu = new System.Windows.Forms.Panel();
            this.panelOrderOptions = new System.Windows.Forms.Panel();
            this.gbOrderStatus = new System.Windows.Forms.GroupBox();
            this.labelNextOrderStatus = new System.Windows.Forms.Label();
            this.btnNextOrderStatus = new System.Windows.Forms.Button();
            this.labelBackOrderStatus = new System.Windows.Forms.Label();
            this.btnBackOrderStatus = new System.Windows.Forms.Button();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEditSale = new System.Windows.Forms.Label();
            this.lbDeleteSale = new System.Windows.Forms.Label();
            this.btnEditSale = new System.Windows.Forms.Button();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.lbAddSale = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridSalesList = new System.Windows.Forms.DataGridView();
            this.panelOrdersForBuyMenu.SuspendLayout();
            this.panelOrderOptions.SuspendLayout();
            this.gbOrderStatus.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOrdersForBuyMenu
            // 
            this.panelOrdersForBuyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelOrdersForBuyMenu.Controls.Add(this.panelOrderOptions);
            this.panelOrdersForBuyMenu.Controls.Add(this.panelCUDFilament);
            this.panelOrdersForBuyMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdersForBuyMenu.Location = new System.Drawing.Point(0, 0);
            this.panelOrdersForBuyMenu.Name = "panelOrdersForBuyMenu";
            this.panelOrdersForBuyMenu.Size = new System.Drawing.Size(1180, 117);
            this.panelOrdersForBuyMenu.TabIndex = 2;
            // 
            // panelOrderOptions
            // 
            this.panelOrderOptions.Controls.Add(this.gbOrderStatus);
            this.panelOrderOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOrderOptions.Location = new System.Drawing.Point(273, 0);
            this.panelOrderOptions.Name = "panelOrderOptions";
            this.panelOrderOptions.Size = new System.Drawing.Size(230, 117);
            this.panelOrderOptions.TabIndex = 1;
            // 
            // gbOrderStatus
            // 
            this.gbOrderStatus.Controls.Add(this.labelNextOrderStatus);
            this.gbOrderStatus.Controls.Add(this.btnNextOrderStatus);
            this.gbOrderStatus.Controls.Add(this.labelBackOrderStatus);
            this.gbOrderStatus.Controls.Add(this.btnBackOrderStatus);
            this.gbOrderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbOrderStatus.Location = new System.Drawing.Point(0, 0);
            this.gbOrderStatus.Name = "gbOrderStatus";
            this.gbOrderStatus.Size = new System.Drawing.Size(230, 117);
            this.gbOrderStatus.TabIndex = 0;
            this.gbOrderStatus.TabStop = false;
            // 
            // labelNextOrderStatus
            // 
            this.labelNextOrderStatus.AutoSize = true;
            this.labelNextOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextOrderStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNextOrderStatus.Location = new System.Drawing.Point(143, 92);
            this.labelNextOrderStatus.Name = "labelNextOrderStatus";
            this.labelNextOrderStatus.Size = new System.Drawing.Size(50, 18);
            this.labelNextOrderStatus.TabIndex = 9;
            this.labelNextOrderStatus.Text = "Înainte";
            // 
            // btnNextOrderStatus
            // 
            this.btnNextOrderStatus.BackgroundImage = global::FirmaAPP.Properties.Resources.NextIcon;
            this.btnNextOrderStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextOrderStatus.FlatAppearance.BorderSize = 0;
            this.btnNextOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextOrderStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextOrderStatus.Location = new System.Drawing.Point(114, 17);
            this.btnNextOrderStatus.Name = "btnNextOrderStatus";
            this.btnNextOrderStatus.Size = new System.Drawing.Size(102, 78);
            this.btnNextOrderStatus.TabIndex = 8;
            this.btnNextOrderStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNextOrderStatus.UseVisualStyleBackColor = true;
            this.btnNextOrderStatus.Click += new System.EventHandler(this.btnNextOrderStatus_Click);
            // 
            // labelBackOrderStatus
            // 
            this.labelBackOrderStatus.AutoSize = true;
            this.labelBackOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackOrderStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBackOrderStatus.Location = new System.Drawing.Point(33, 92);
            this.labelBackOrderStatus.Name = "labelBackOrderStatus";
            this.labelBackOrderStatus.Size = new System.Drawing.Size(47, 18);
            this.labelBackOrderStatus.TabIndex = 7;
            this.labelBackOrderStatus.Text = "Înapoi";
            // 
            // btnBackOrderStatus
            // 
            this.btnBackOrderStatus.BackgroundImage = global::FirmaAPP.Properties.Resources.PreviousIcon;
            this.btnBackOrderStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackOrderStatus.FlatAppearance.BorderSize = 0;
            this.btnBackOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackOrderStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackOrderStatus.Location = new System.Drawing.Point(6, 17);
            this.btnBackOrderStatus.Name = "btnBackOrderStatus";
            this.btnBackOrderStatus.Size = new System.Drawing.Size(102, 78);
            this.btnBackOrderStatus.TabIndex = 6;
            this.btnBackOrderStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackOrderStatus.UseVisualStyleBackColor = true;
            // 
            // panelCUDFilament
            // 
            this.panelCUDFilament.Controls.Add(this.groupBox1);
            this.panelCUDFilament.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDFilament.Location = new System.Drawing.Point(0, 0);
            this.panelCUDFilament.Name = "panelCUDFilament";
            this.panelCUDFilament.Size = new System.Drawing.Size(273, 117);
            this.panelCUDFilament.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbEditSale);
            this.groupBox1.Controls.Add(this.lbDeleteSale);
            this.groupBox1.Controls.Add(this.btnEditSale);
            this.groupBox1.Controls.Add(this.btnDeleteSale);
            this.groupBox1.Controls.Add(this.lbAddSale);
            this.groupBox1.Controls.Add(this.btnAddSale);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUD";
            // 
            // lbEditSale
            // 
            this.lbEditSale.AutoSize = true;
            this.lbEditSale.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditSale.Location = new System.Drawing.Point(155, 67);
            this.lbEditSale.Margin = new System.Windows.Forms.Padding(0);
            this.lbEditSale.Name = "lbEditSale";
            this.lbEditSale.Size = new System.Drawing.Size(111, 30);
            this.lbEditSale.TabIndex = 11;
            this.lbEditSale.Text = "Modifică";
            // 
            // lbDeleteSale
            // 
            this.lbDeleteSale.AutoSize = true;
            this.lbDeleteSale.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeleteSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteSale.Location = new System.Drawing.Point(155, 26);
            this.lbDeleteSale.Margin = new System.Windows.Forms.Padding(0);
            this.lbDeleteSale.Name = "lbDeleteSale";
            this.lbDeleteSale.Size = new System.Drawing.Size(90, 30);
            this.lbDeleteSale.TabIndex = 10;
            this.lbDeleteSale.Text = "Șterge";
            this.lbDeleteSale.Click += new System.EventHandler(this.lbDeleteSale_Click);
            // 
            // btnEditSale
            // 
            this.btnEditSale.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditSale.FlatAppearance.BorderSize = 0;
            this.btnEditSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSale.Location = new System.Drawing.Point(109, 63);
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.Size = new System.Drawing.Size(46, 42);
            this.btnEditSale.TabIndex = 9;
            this.btnEditSale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteSale.FlatAppearance.BorderSize = 0;
            this.btnDeleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSale.Location = new System.Drawing.Point(111, 24);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(44, 36);
            this.btnDeleteSale.TabIndex = 8;
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // lbAddSale
            // 
            this.lbAddSale.AutoSize = true;
            this.lbAddSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddSale.Location = new System.Drawing.Point(28, 92);
            this.lbAddSale.Name = "lbAddSale";
            this.lbAddSale.Size = new System.Drawing.Size(57, 18);
            this.lbAddSale.TabIndex = 7;
            this.lbAddSale.Text = "Adaugă";
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSale.FlatAppearance.BorderSize = 0;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSale.Location = new System.Drawing.Point(6, 17);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(102, 78);
            this.btnAddSale.TabIndex = 6;
            this.btnAddSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridSalesList);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 117);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1180, 373);
            this.panelGrid.TabIndex = 5;
            // 
            // dataGridSalesList
            // 
            this.dataGridSalesList.AllowUserToAddRows = false;
            this.dataGridSalesList.AllowUserToDeleteRows = false;
            this.dataGridSalesList.AllowUserToOrderColumns = true;
            this.dataGridSalesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSalesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSalesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridSalesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSalesList.Location = new System.Drawing.Point(0, 0);
            this.dataGridSalesList.Name = "dataGridSalesList";
            this.dataGridSalesList.ReadOnly = true;
            this.dataGridSalesList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridSalesList.RowTemplate.Height = 24;
            this.dataGridSalesList.Size = new System.Drawing.Size(1180, 373);
            this.dataGridSalesList.TabIndex = 0;
            this.dataGridSalesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalesList_CellClick);
            this.dataGridSalesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalesList_CellDoubleClick);
            this.dataGridSalesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridSalesList_CellFormatting);
            // 
            // frmOrderTshirtsSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 490);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelOrdersForBuyMenu);
            this.Name = "frmOrderTshirtsSalesList";
            this.Text = "Vânzări tricouri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrderSalesList_FormClosed);
            this.Load += new System.EventHandler(this.frmOrderSalesList_Load);
            this.panelOrdersForBuyMenu.ResumeLayout(false);
            this.panelOrderOptions.ResumeLayout(false);
            this.gbOrderStatus.ResumeLayout(false);
            this.gbOrderStatus.PerformLayout();
            this.panelCUDFilament.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridSalesList;
    }
}