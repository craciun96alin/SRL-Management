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
            this.panelFilamentMenu = new System.Windows.Forms.Panel();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.lbEditProvider = new System.Windows.Forms.Label();
            this.lbDeleteProvider = new System.Windows.Forms.Label();
            this.btnEditProvider = new System.Windows.Forms.Button();
            this.btnDeleteProvider = new System.Windows.Forms.Button();
            this.lbAddFilament = new System.Windows.Forms.Label();
            this.btnAddProvider = new System.Windows.Forms.Button();
            this.panelProviderGrid = new System.Windows.Forms.Panel();
            this.dataGridProvider = new System.Windows.Forms.DataGridView();
            this.panelFilamentMenu.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.panelProviderGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilamentMenu
            // 
            this.panelFilamentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelFilamentMenu.Controls.Add(this.panelCUDFilament);
            this.panelFilamentMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilamentMenu.Location = new System.Drawing.Point(0, 0);
            this.panelFilamentMenu.Name = "panelFilamentMenu";
            this.panelFilamentMenu.Size = new System.Drawing.Size(1198, 100);
            this.panelFilamentMenu.TabIndex = 1;
            // 
            // panelCUDFilament
            // 
            this.panelCUDFilament.Controls.Add(this.lbEditProvider);
            this.panelCUDFilament.Controls.Add(this.lbDeleteProvider);
            this.panelCUDFilament.Controls.Add(this.btnEditProvider);
            this.panelCUDFilament.Controls.Add(this.btnDeleteProvider);
            this.panelCUDFilament.Controls.Add(this.lbAddFilament);
            this.panelCUDFilament.Controls.Add(this.btnAddProvider);
            this.panelCUDFilament.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDFilament.Location = new System.Drawing.Point(0, 0);
            this.panelCUDFilament.Name = "panelCUDFilament";
            this.panelCUDFilament.Size = new System.Drawing.Size(262, 100);
            this.panelCUDFilament.TabIndex = 0;
            // 
            // lbEditProvider
            // 
            this.lbEditProvider.AutoSize = true;
            this.lbEditProvider.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditProvider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditProvider.Location = new System.Drawing.Point(144, 53);
            this.lbEditProvider.Margin = new System.Windows.Forms.Padding(0);
            this.lbEditProvider.Name = "lbEditProvider";
            this.lbEditProvider.Size = new System.Drawing.Size(111, 30);
            this.lbEditProvider.TabIndex = 5;
            this.lbEditProvider.Text = "Modifică";
            this.lbEditProvider.Click += new System.EventHandler(this.lbEditProvider_Click);
            // 
            // lbDeleteProvider
            // 
            this.lbDeleteProvider.AutoSize = true;
            this.lbDeleteProvider.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeleteProvider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteProvider.Location = new System.Drawing.Point(144, 12);
            this.lbDeleteProvider.Margin = new System.Windows.Forms.Padding(0);
            this.lbDeleteProvider.Name = "lbDeleteProvider";
            this.lbDeleteProvider.Size = new System.Drawing.Size(90, 30);
            this.lbDeleteProvider.TabIndex = 4;
            this.lbDeleteProvider.Text = "Șterge";
            this.lbDeleteProvider.Click += new System.EventHandler(this.lbDeleteProvider_Click);
            // 
            // btnEditProvider
            // 
            this.btnEditProvider.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditProvider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProvider.Location = new System.Drawing.Point(106, 49);
            this.btnEditProvider.Name = "btnEditProvider";
            this.btnEditProvider.Size = new System.Drawing.Size(46, 42);
            this.btnEditProvider.TabIndex = 3;
            this.btnEditProvider.UseVisualStyleBackColor = true;
            this.btnEditProvider.Click += new System.EventHandler(this.btnEditProvider_Click);
            // 
            // btnDeleteProvider
            // 
            this.btnDeleteProvider.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteProvider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProvider.Location = new System.Drawing.Point(108, 10);
            this.btnDeleteProvider.Name = "btnDeleteProvider";
            this.btnDeleteProvider.Size = new System.Drawing.Size(44, 36);
            this.btnDeleteProvider.TabIndex = 2;
            this.btnDeleteProvider.UseVisualStyleBackColor = true;
            this.btnDeleteProvider.Click += new System.EventHandler(this.btnDeleteProvider_Click);
            // 
            // lbAddFilament
            // 
            this.lbAddFilament.AutoSize = true;
            this.lbAddFilament.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddFilament.Location = new System.Drawing.Point(25, 78);
            this.lbAddFilament.Name = "lbAddFilament";
            this.lbAddFilament.Size = new System.Drawing.Size(57, 18);
            this.lbAddFilament.TabIndex = 1;
            this.lbAddFilament.Text = "Adaugă";
            // 
            // btnAddProvider
            // 
            this.btnAddProvider.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddProvider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProvider.Location = new System.Drawing.Point(3, 3);
            this.btnAddProvider.Name = "btnAddProvider";
            this.btnAddProvider.Size = new System.Drawing.Size(102, 78);
            this.btnAddProvider.TabIndex = 0;
            this.btnAddProvider.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProvider.UseVisualStyleBackColor = true;
            this.btnAddProvider.Click += new System.EventHandler(this.btnAddProvider_Click);
            // 
            // panelProviderGrid
            // 
            this.panelProviderGrid.Controls.Add(this.dataGridProvider);
            this.panelProviderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProviderGrid.Location = new System.Drawing.Point(0, 100);
            this.panelProviderGrid.Name = "panelProviderGrid";
            this.panelProviderGrid.Size = new System.Drawing.Size(1198, 554);
            this.panelProviderGrid.TabIndex = 2;
            // 
            // dataGridProvider
            // 
            this.dataGridProvider.AllowUserToAddRows = false;
            this.dataGridProvider.AllowUserToDeleteRows = false;
            this.dataGridProvider.AllowUserToOrderColumns = true;
            this.dataGridProvider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProvider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProvider.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridProvider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProvider.Location = new System.Drawing.Point(0, 0);
            this.dataGridProvider.Name = "dataGridProvider";
            this.dataGridProvider.ReadOnly = true;
            this.dataGridProvider.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridProvider.RowTemplate.Height = 24;
            this.dataGridProvider.Size = new System.Drawing.Size(1198, 554);
            this.dataGridProvider.TabIndex = 0;
            this.dataGridProvider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProvider_CellDoubleClick);
            // 
            // frmProviderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panelFilamentMenu);
            this.Name = "frmProviderList";
            this.ShowIcon = false;
            this.Text = "Listă furnizori";
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