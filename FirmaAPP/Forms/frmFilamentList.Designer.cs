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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilamentList));
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
            resources.ApplyResources(this.panelFilamentMenu, "panelFilamentMenu");
            this.panelFilamentMenu.Name = "panelFilamentMenu";
            // 
            // panelCUDFilament
            // 
            this.panelCUDFilament.Controls.Add(this.lbEditFilament);
            this.panelCUDFilament.Controls.Add(this.lbDeleteFilament);
            this.panelCUDFilament.Controls.Add(this.btnEditFilament);
            this.panelCUDFilament.Controls.Add(this.btnDeleteFilament);
            this.panelCUDFilament.Controls.Add(this.lbAddFilament);
            this.panelCUDFilament.Controls.Add(this.btnAddFilament);
            resources.ApplyResources(this.panelCUDFilament, "panelCUDFilament");
            this.panelCUDFilament.Name = "panelCUDFilament";
            // 
            // lbEditFilament
            // 
            resources.ApplyResources(this.lbEditFilament, "lbEditFilament");
            this.lbEditFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditFilament.Name = "lbEditFilament";
            this.lbEditFilament.Click += new System.EventHandler(this.lbEditFilament_Click);
            // 
            // lbDeleteFilament
            // 
            resources.ApplyResources(this.lbDeleteFilament, "lbDeleteFilament");
            this.lbDeleteFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteFilament.Name = "lbDeleteFilament";
            this.lbDeleteFilament.Click += new System.EventHandler(this.lbDeleteFilament_Click);
            // 
            // btnEditFilament
            // 
            this.btnEditFilament.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            resources.ApplyResources(this.btnEditFilament, "btnEditFilament");
            this.btnEditFilament.Name = "btnEditFilament";
            this.btnEditFilament.UseVisualStyleBackColor = true;
            this.btnEditFilament.Click += new System.EventHandler(this.btnEditFilament_Click);
            // 
            // btnDeleteFilament
            // 
            this.btnDeleteFilament.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            resources.ApplyResources(this.btnDeleteFilament, "btnDeleteFilament");
            this.btnDeleteFilament.Name = "btnDeleteFilament";
            this.btnDeleteFilament.UseVisualStyleBackColor = true;
            this.btnDeleteFilament.Click += new System.EventHandler(this.btnDeleteFilament_Click);
            // 
            // lbAddFilament
            // 
            resources.ApplyResources(this.lbAddFilament, "lbAddFilament");
            this.lbAddFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddFilament.Name = "lbAddFilament";
            // 
            // btnAddFilament
            // 
            this.btnAddFilament.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            resources.ApplyResources(this.btnAddFilament, "btnAddFilament");
            this.btnAddFilament.Name = "btnAddFilament";
            this.btnAddFilament.UseVisualStyleBackColor = true;
            this.btnAddFilament.Click += new System.EventHandler(this.btnAddFilament_Click);
            // 
            // panelFilamentGrid
            // 
            this.panelFilamentGrid.Controls.Add(this.dataGridFilament);
            resources.ApplyResources(this.panelFilamentGrid, "panelFilamentGrid");
            this.panelFilamentGrid.Name = "panelFilamentGrid";
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
            resources.ApplyResources(this.dataGridFilament, "dataGridFilament");
            this.dataGridFilament.Name = "dataGridFilament";
            this.dataGridFilament.ReadOnly = true;
            this.dataGridFilament.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridFilament.RowTemplate.Height = 24;
            this.dataGridFilament.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFilament_CellDoubleClick);
            // 
            // frmFilamentList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFilamentGrid);
            this.Controls.Add(this.panelFilamentMenu);
            this.Name = "frmFilamentList";
            this.ShowIcon = false;
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