namespace FirmaAPP
{
    partial class frmVinylList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVinylList));
            this.panelVinylMenu = new System.Windows.Forms.Panel();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.lbEdit = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.panelFilamentGrid = new System.Windows.Forms.Panel();
            this.dataGridVinyl = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelVinylMenu.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.panelFilamentGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinyl)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVinylMenu
            // 
            resources.ApplyResources(this.panelVinylMenu, "panelVinylMenu");
            this.panelVinylMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelVinylMenu.Controls.Add(this.panelCUDFilament);
            this.panelVinylMenu.Name = "panelVinylMenu";
            // 
            // panelCUDFilament
            // 
            resources.ApplyResources(this.panelCUDFilament, "panelCUDFilament");
            this.panelCUDFilament.Controls.Add(this.lbEdit);
            this.panelCUDFilament.Controls.Add(this.lbDelete);
            this.panelCUDFilament.Controls.Add(this.btnEdit);
            this.panelCUDFilament.Controls.Add(this.btnDelete);
            this.panelCUDFilament.Controls.Add(this.lbAdd);
            this.panelCUDFilament.Controls.Add(this.btnAdd);
            this.panelCUDFilament.Name = "panelCUDFilament";
            // 
            // lbEdit
            // 
            resources.ApplyResources(this.lbEdit, "lbEdit");
            this.lbEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Click += new System.EventHandler(this.lbEdit_Click);
            // 
            // lbDelete
            // 
            resources.ApplyResources(this.lbDelete, "lbDelete");
            this.lbDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Click += new System.EventHandler(this.lbDelete_Click);
            // 
            // lbAdd
            // 
            resources.ApplyResources(this.lbAdd, "lbAdd");
            this.lbAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAdd.Name = "lbAdd";
            // 
            // panelFilamentGrid
            // 
            resources.ApplyResources(this.panelFilamentGrid, "panelFilamentGrid");
            this.panelFilamentGrid.Controls.Add(this.dataGridVinyl);
            this.panelFilamentGrid.Name = "panelFilamentGrid";
            // 
            // dataGridVinyl
            // 
            resources.ApplyResources(this.dataGridVinyl, "dataGridVinyl");
            this.dataGridVinyl.AllowUserToAddRows = false;
            this.dataGridVinyl.AllowUserToDeleteRows = false;
            this.dataGridVinyl.AllowUserToOrderColumns = true;
            this.dataGridVinyl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVinyl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVinyl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridVinyl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridVinyl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVinyl.Name = "dataGridVinyl";
            this.dataGridVinyl.ReadOnly = true;
            this.dataGridVinyl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridVinyl.RowTemplate.Height = 24;
            this.dataGridVinyl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVinyl_CellDoubleClick);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmVinylList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFilamentGrid);
            this.Controls.Add(this.panelVinylMenu);
            this.Name = "frmVinylList";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVinylList_FormClosed);
            this.Load += new System.EventHandler(this.frmVinylList_Load);
            this.panelVinylMenu.ResumeLayout(false);
            this.panelCUDFilament.ResumeLayout(false);
            this.panelCUDFilament.PerformLayout();
            this.panelFilamentGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVinyl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVinylMenu;
        private System.Windows.Forms.Panel panelCUDFilament;
        private System.Windows.Forms.Label lbEdit;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelFilamentGrid;
        private System.Windows.Forms.DataGridView dataGridVinyl;
    }
}