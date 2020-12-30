namespace FirmaAPP
{
    partial class frmFilamentList
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
            this.lbEditFilament = new System.Windows.Forms.Label();
            this.lbDeleteFilament = new System.Windows.Forms.Label();
            this.btnEditFilament = new System.Windows.Forms.Button();
            this.btnDeleteFilament = new System.Windows.Forms.Button();
            this.lbAddFilament = new System.Windows.Forms.Label();
            this.btnAddFilament = new System.Windows.Forms.Button();
            this.panelFilamentGrid = new System.Windows.Forms.Panel();
            this.dataGridFilament = new System.Windows.Forms.DataGridView();
            this.panelFilamentMenu.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.panelFilamentGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilament)).BeginInit();
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
            this.panelFilamentMenu.TabIndex = 0;
            // 
            // panelCUDFilament
            // 
            this.panelCUDFilament.Controls.Add(this.lbEditFilament);
            this.panelCUDFilament.Controls.Add(this.lbDeleteFilament);
            this.panelCUDFilament.Controls.Add(this.btnEditFilament);
            this.panelCUDFilament.Controls.Add(this.btnDeleteFilament);
            this.panelCUDFilament.Controls.Add(this.lbAddFilament);
            this.panelCUDFilament.Controls.Add(this.btnAddFilament);
            this.panelCUDFilament.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDFilament.Location = new System.Drawing.Point(0, 0);
            this.panelCUDFilament.Name = "panelCUDFilament";
            this.panelCUDFilament.Size = new System.Drawing.Size(262, 100);
            this.panelCUDFilament.TabIndex = 0;
            // 
            // lbEditFilament
            // 
            this.lbEditFilament.AutoSize = true;
            this.lbEditFilament.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditFilament.Location = new System.Drawing.Point(144, 53);
            this.lbEditFilament.Margin = new System.Windows.Forms.Padding(0);
            this.lbEditFilament.Name = "lbEditFilament";
            this.lbEditFilament.Size = new System.Drawing.Size(111, 30);
            this.lbEditFilament.TabIndex = 5;
            this.lbEditFilament.Text = "Modifică";
            this.lbEditFilament.Click += new System.EventHandler(this.lbEditFilament_Click);
            // 
            // lbDeleteFilament
            // 
            this.lbDeleteFilament.AutoSize = true;
            this.lbDeleteFilament.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeleteFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteFilament.Location = new System.Drawing.Point(144, 12);
            this.lbDeleteFilament.Margin = new System.Windows.Forms.Padding(0);
            this.lbDeleteFilament.Name = "lbDeleteFilament";
            this.lbDeleteFilament.Size = new System.Drawing.Size(90, 30);
            this.lbDeleteFilament.TabIndex = 4;
            this.lbDeleteFilament.Text = "Șterge";
            this.lbDeleteFilament.Click += new System.EventHandler(this.lbDeleteFilament_Click);
            // 
            // btnEditFilament
            // 
            this.btnEditFilament.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditFilament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditFilament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFilament.Location = new System.Drawing.Point(106, 49);
            this.btnEditFilament.Name = "btnEditFilament";
            this.btnEditFilament.Size = new System.Drawing.Size(46, 42);
            this.btnEditFilament.TabIndex = 3;
            this.btnEditFilament.UseVisualStyleBackColor = true;
            this.btnEditFilament.Click += new System.EventHandler(this.btnEditFilament_Click);
            // 
            // btnDeleteFilament
            // 
            this.btnDeleteFilament.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteFilament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteFilament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFilament.Location = new System.Drawing.Point(108, 10);
            this.btnDeleteFilament.Name = "btnDeleteFilament";
            this.btnDeleteFilament.Size = new System.Drawing.Size(44, 36);
            this.btnDeleteFilament.TabIndex = 2;
            this.btnDeleteFilament.UseVisualStyleBackColor = true;
            this.btnDeleteFilament.Click += new System.EventHandler(this.btnDeleteFilament_Click);
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
            // btnAddFilament
            // 
            this.btnAddFilament.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddFilament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFilament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFilament.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFilament.Location = new System.Drawing.Point(3, 3);
            this.btnAddFilament.Name = "btnAddFilament";
            this.btnAddFilament.Size = new System.Drawing.Size(102, 78);
            this.btnAddFilament.TabIndex = 0;
            this.btnAddFilament.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddFilament.UseVisualStyleBackColor = true;
            this.btnAddFilament.Click += new System.EventHandler(this.btnAddFilament_Click);
            // 
            // panelFilamentGrid
            // 
            this.panelFilamentGrid.Controls.Add(this.dataGridFilament);
            this.panelFilamentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilamentGrid.Location = new System.Drawing.Point(0, 100);
            this.panelFilamentGrid.Name = "panelFilamentGrid";
            this.panelFilamentGrid.Size = new System.Drawing.Size(1198, 554);
            this.panelFilamentGrid.TabIndex = 1;
            // 
            // dataGridFilament
            // 
            this.dataGridFilament.AllowUserToAddRows = false;
            this.dataGridFilament.AllowUserToDeleteRows = false;
            this.dataGridFilament.AllowUserToOrderColumns = true;
            this.dataGridFilament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFilament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFilament.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFilament.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridFilament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFilament.Location = new System.Drawing.Point(0, 0);
            this.dataGridFilament.Name = "dataGridFilament";
            this.dataGridFilament.ReadOnly = true;
            this.dataGridFilament.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridFilament.RowTemplate.Height = 24;
            this.dataGridFilament.Size = new System.Drawing.Size(1198, 554);
            this.dataGridFilament.TabIndex = 0;
            this.dataGridFilament.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFilament_CellDoubleClick);
            // 
            // frmFilamentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelFilamentGrid);
            this.Controls.Add(this.panelFilamentMenu);
            this.Name = "frmFilamentList";
            this.Text = "Listă filament";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFilament_FormClosed);
            this.Load += new System.EventHandler(this.frmFilament_Load);
            this.panelFilamentMenu.ResumeLayout(false);
            this.panelCUDFilament.ResumeLayout(false);
            this.panelCUDFilament.PerformLayout();
            this.panelFilamentGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilamentMenu;
        private System.Windows.Forms.Panel panelCUDFilament;
        private System.Windows.Forms.Button btnAddFilament;
        private System.Windows.Forms.Label lbDeleteFilament;
        private System.Windows.Forms.Button btnEditFilament;
        private System.Windows.Forms.Button btnDeleteFilament;
        private System.Windows.Forms.Label lbAddFilament;
        private System.Windows.Forms.Label lbEditFilament;
        private System.Windows.Forms.Panel panelFilamentGrid;
        private System.Windows.Forms.DataGridView dataGridFilament;
    }
}