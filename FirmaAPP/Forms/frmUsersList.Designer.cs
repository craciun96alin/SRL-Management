namespace FirmaAPP
{
    partial class frmUsersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersList));
            this.panelUserGrid = new System.Windows.Forms.Panel();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.panelFilamentMenu = new System.Windows.Forms.Panel();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.lbEditUser = new System.Windows.Forms.Label();
            this.lbDeleteUser = new System.Windows.Forms.Label();
            this.lbAddUser = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panelUserGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.panelFilamentMenu.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserGrid
            // 
            resources.ApplyResources(this.panelUserGrid, "panelUserGrid");
            this.panelUserGrid.Controls.Add(this.dataGridUser);
            this.panelUserGrid.Name = "panelUserGrid";
            // 
            // dataGridUser
            // 
            resources.ApplyResources(this.dataGridUser, "dataGridUser");
            this.dataGridUser.AllowUserToAddRows = false;
            this.dataGridUser.AllowUserToDeleteRows = false;
            this.dataGridUser.AllowUserToOrderColumns = true;
            this.dataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.ReadOnly = true;
            this.dataGridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridUser.RowTemplate.Height = 24;
            this.dataGridUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellClick);
            this.dataGridUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellDoubleClick);
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
            this.panelCUDFilament.Controls.Add(this.lbEditUser);
            this.panelCUDFilament.Controls.Add(this.lbDeleteUser);
            this.panelCUDFilament.Controls.Add(this.btnEditUser);
            this.panelCUDFilament.Controls.Add(this.btnDeleteUser);
            this.panelCUDFilament.Controls.Add(this.lbAddUser);
            this.panelCUDFilament.Controls.Add(this.btnAddUser);
            this.panelCUDFilament.Name = "panelCUDFilament";
            // 
            // lbEditUser
            // 
            resources.ApplyResources(this.lbEditUser, "lbEditUser");
            this.lbEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditUser.Name = "lbEditUser";
            this.lbEditUser.Click += new System.EventHandler(this.lbEditUser_Click);
            // 
            // lbDeleteUser
            // 
            resources.ApplyResources(this.lbDeleteUser, "lbDeleteUser");
            this.lbDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteUser.Name = "lbDeleteUser";
            this.lbDeleteUser.Click += new System.EventHandler(this.lbDeleteUser_Click);
            // 
            // lbAddUser
            // 
            resources.ApplyResources(this.lbAddUser, "lbAddUser");
            this.lbAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddUser.Name = "lbAddUser";
            // 
            // btnEditUser
            // 
            resources.ApplyResources(this.btnEditUser, "btnEditUser");
            this.btnEditUser.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            resources.ApplyResources(this.btnDeleteUser, "btnDeleteUser");
            this.btnDeleteUser.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            resources.ApplyResources(this.btnAddUser, "btnAddUser");
            this.btnAddUser.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmUsersList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserGrid);
            this.Controls.Add(this.panelFilamentMenu);
            this.Name = "frmUsersList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsersList_FormClosed);
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            this.panelUserGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.panelFilamentMenu.ResumeLayout(false);
            this.panelCUDFilament.ResumeLayout(false);
            this.panelCUDFilament.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserGrid;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.Panel panelFilamentMenu;
        private System.Windows.Forms.Panel panelCUDFilament;
        private System.Windows.Forms.Label lbEditUser;
        private System.Windows.Forms.Label lbDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lbAddUser;
        private System.Windows.Forms.Button btnAddUser;
    }
}