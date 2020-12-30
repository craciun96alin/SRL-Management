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
            this.panelFilamentGrid = new System.Windows.Forms.Panel();
            this.dataGridAcquistionsList = new System.Windows.Forms.DataGridView();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEditAcquisition = new System.Windows.Forms.Label();
            this.lbDeleteAcquisition = new System.Windows.Forms.Label();
            this.btnEditAcquisition = new System.Windows.Forms.Button();
            this.btnDeleteAcquisition = new System.Windows.Forms.Button();
            this.lbAddFilament = new System.Windows.Forms.Label();
            this.btnAddAcquisition = new System.Windows.Forms.Button();
            this.panelOrdersForBuyMenu = new System.Windows.Forms.Panel();
            this.panelOrderOptions = new System.Windows.Forms.Panel();
            this.gbOrderStatus = new System.Windows.Forms.GroupBox();
            this.labelNextOrderStatus = new System.Windows.Forms.Label();
            this.btnNextOrderStatus = new System.Windows.Forms.Button();
            this.labelBackOrderStatus = new System.Windows.Forms.Label();
            this.btnBackOrderStatus = new System.Windows.Forms.Button();
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
            this.panelFilamentGrid.Controls.Add(this.dataGridAcquistionsList);
            this.panelFilamentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilamentGrid.Location = new System.Drawing.Point(0, 117);
            this.panelFilamentGrid.Name = "panelFilamentGrid";
            this.panelFilamentGrid.Size = new System.Drawing.Size(1198, 537);
            this.panelFilamentGrid.TabIndex = 4;
            // 
            // dataGridAcquistionsList
            // 
            this.dataGridAcquistionsList.AllowUserToAddRows = false;
            this.dataGridAcquistionsList.AllowUserToDeleteRows = false;
            this.dataGridAcquistionsList.AllowUserToOrderColumns = true;
            this.dataGridAcquistionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAcquistionsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAcquistionsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAcquistionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAcquistionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAcquistionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAcquistionsList.Location = new System.Drawing.Point(0, 0);
            this.dataGridAcquistionsList.Name = "dataGridAcquistionsList";
            this.dataGridAcquistionsList.ReadOnly = true;
            this.dataGridAcquistionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridAcquistionsList.RowTemplate.Height = 24;
            this.dataGridAcquistionsList.Size = new System.Drawing.Size(1198, 537);
            this.dataGridAcquistionsList.TabIndex = 0;
            this.dataGridAcquistionsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAcquistionsList_CellClick);
            this.dataGridAcquistionsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAcquistionsList_CellDoubleClick);
            this.dataGridAcquistionsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridAcquistionsList_CellFormatting);
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
            this.groupBox1.Controls.Add(this.lbEditAcquisition);
            this.groupBox1.Controls.Add(this.lbDeleteAcquisition);
            this.groupBox1.Controls.Add(this.btnEditAcquisition);
            this.groupBox1.Controls.Add(this.btnDeleteAcquisition);
            this.groupBox1.Controls.Add(this.lbAddFilament);
            this.groupBox1.Controls.Add(this.btnAddAcquisition);
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
            // lbEditAcquisition
            // 
            this.lbEditAcquisition.AutoSize = true;
            this.lbEditAcquisition.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditAcquisition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditAcquisition.Location = new System.Drawing.Point(155, 67);
            this.lbEditAcquisition.Margin = new System.Windows.Forms.Padding(0);
            this.lbEditAcquisition.Name = "lbEditAcquisition";
            this.lbEditAcquisition.Size = new System.Drawing.Size(111, 30);
            this.lbEditAcquisition.TabIndex = 11;
            this.lbEditAcquisition.Text = "Modifică";
            this.lbEditAcquisition.Click += new System.EventHandler(this.lbEditAcquisition_Click);
            // 
            // lbDeleteAcquisition
            // 
            this.lbDeleteAcquisition.AutoSize = true;
            this.lbDeleteAcquisition.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeleteAcquisition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteAcquisition.Location = new System.Drawing.Point(155, 26);
            this.lbDeleteAcquisition.Margin = new System.Windows.Forms.Padding(0);
            this.lbDeleteAcquisition.Name = "lbDeleteAcquisition";
            this.lbDeleteAcquisition.Size = new System.Drawing.Size(90, 30);
            this.lbDeleteAcquisition.TabIndex = 10;
            this.lbDeleteAcquisition.Text = "Șterge";
            this.lbDeleteAcquisition.Click += new System.EventHandler(this.lbDeleteAcquisition_Click);
            // 
            // btnEditAcquisition
            // 
            this.btnEditAcquisition.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditAcquisition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditAcquisition.FlatAppearance.BorderSize = 0;
            this.btnEditAcquisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcquisition.Location = new System.Drawing.Point(109, 63);
            this.btnEditAcquisition.Name = "btnEditAcquisition";
            this.btnEditAcquisition.Size = new System.Drawing.Size(46, 42);
            this.btnEditAcquisition.TabIndex = 9;
            this.btnEditAcquisition.UseVisualStyleBackColor = true;
            this.btnEditAcquisition.Click += new System.EventHandler(this.btnEditAcquisition_Click);
            // 
            // btnDeleteAcquisition
            // 
            this.btnDeleteAcquisition.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteAcquisition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteAcquisition.FlatAppearance.BorderSize = 0;
            this.btnDeleteAcquisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcquisition.Location = new System.Drawing.Point(111, 24);
            this.btnDeleteAcquisition.Name = "btnDeleteAcquisition";
            this.btnDeleteAcquisition.Size = new System.Drawing.Size(44, 36);
            this.btnDeleteAcquisition.TabIndex = 8;
            this.btnDeleteAcquisition.UseVisualStyleBackColor = true;
            this.btnDeleteAcquisition.Click += new System.EventHandler(this.btnDeleteAcquisition_Click);
            // 
            // lbAddFilament
            // 
            this.lbAddFilament.AutoSize = true;
            this.lbAddFilament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddFilament.Location = new System.Drawing.Point(28, 92);
            this.lbAddFilament.Name = "lbAddFilament";
            this.lbAddFilament.Size = new System.Drawing.Size(57, 18);
            this.lbAddFilament.TabIndex = 7;
            this.lbAddFilament.Text = "Adaugă";
            // 
            // btnAddAcquisition
            // 
            this.btnAddAcquisition.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddAcquisition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAcquisition.FlatAppearance.BorderSize = 0;
            this.btnAddAcquisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcquisition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAcquisition.Location = new System.Drawing.Point(6, 17);
            this.btnAddAcquisition.Name = "btnAddAcquisition";
            this.btnAddAcquisition.Size = new System.Drawing.Size(102, 78);
            this.btnAddAcquisition.TabIndex = 6;
            this.btnAddAcquisition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAcquisition.UseVisualStyleBackColor = true;
            this.btnAddAcquisition.Click += new System.EventHandler(this.btnAddAcquisition_Click);
            // 
            // panelOrdersForBuyMenu
            // 
            this.panelOrdersForBuyMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelOrdersForBuyMenu.Controls.Add(this.panelOrderOptions);
            this.panelOrdersForBuyMenu.Controls.Add(this.panelCUDFilament);
            this.panelOrdersForBuyMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdersForBuyMenu.Location = new System.Drawing.Point(0, 0);
            this.panelOrdersForBuyMenu.Name = "panelOrdersForBuyMenu";
            this.panelOrdersForBuyMenu.Size = new System.Drawing.Size(1198, 117);
            this.panelOrdersForBuyMenu.TabIndex = 1;
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
            // frmOrderAcquisitionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelFilamentGrid);
            this.Controls.Add(this.panelOrdersForBuyMenu);
            this.Name = "frmOrderAcquisitionsList";
            this.Text = "Comenzi achiziționare";
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