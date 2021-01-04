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
            this.panelUserGrid = new System.Windows.Forms.Panel();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.panelFilamentMenu = new System.Windows.Forms.Panel();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.lbEditUser = new System.Windows.Forms.Label();
            this.lbDeleteUser = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lbAddUser = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panelUserGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.panelFilamentMenu.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserGrid
            // 
            this.panelUserGrid.Controls.Add(this.dataGridUser);
            this.panelUserGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserGrid.Location = new System.Drawing.Point(0, 100);
            this.panelUserGrid.Name = "panelUserGrid";
            this.panelUserGrid.Size = new System.Drawing.Size(1198, 554);
            this.panelUserGrid.TabIndex = 3;
            // 
            // dataGridUser
            // 
            this.dataGridUser.AllowUserToAddRows = false;
            this.dataGridUser.AllowUserToDeleteRows = false;
            this.dataGridUser.AllowUserToOrderColumns = true;
            this.dataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.ReadOnly = true;
            this.dataGridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridUser.RowTemplate.Height = 24;
            this.dataGridUser.Size = new System.Drawing.Size(1198, 554);
            this.dataGridUser.TabIndex = 0;
            this.dataGridUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellClick);
            this.dataGridUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUser_CellDoubleClick);
            // 
            // panelFilamentMenu
            // 
            this.panelFilamentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelFilamentMenu.Controls.Add(this.panelCUDFilament);
            this.panelFilamentMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilamentMenu.Location = new System.Drawing.Point(0, 0);
            this.panelFilamentMenu.Name = "panelFilamentMenu";
            this.panelFilamentMenu.Size = new System.Drawing.Size(1198, 100);
            this.panelFilamentMenu.TabIndex = 2;
            // 
            // panelCUDFilament
            // 
            this.panelCUDFilament.Controls.Add(this.lbEditUser);
            this.panelCUDFilament.Controls.Add(this.lbDeleteUser);
            this.panelCUDFilament.Controls.Add(this.btnEditUser);
            this.panelCUDFilament.Controls.Add(this.btnDeleteUser);
            this.panelCUDFilament.Controls.Add(this.lbAddUser);
            this.panelCUDFilament.Controls.Add(this.btnAddUser);
            this.panelCUDFilament.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDFilament.Location = new System.Drawing.Point(0, 0);
            this.panelCUDFilament.Name = "panelCUDFilament";
            this.panelCUDFilament.Size = new System.Drawing.Size(262, 100);
            this.panelCUDFilament.TabIndex = 0;
            // 
            // lbEditUser
            // 
            this.lbEditUser.AutoSize = true;
            this.lbEditUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEditUser.Location = new System.Drawing.Point(144, 53);
            this.lbEditUser.Margin = new System.Windows.Forms.Padding(0);
            this.lbEditUser.Name = "lbEditUser";
            this.lbEditUser.Size = new System.Drawing.Size(111, 30);
            this.lbEditUser.TabIndex = 5;
            this.lbEditUser.Text = "Modifică";
            this.lbEditUser.Click += new System.EventHandler(this.lbEditUser_Click);
            // 
            // lbDeleteUser
            // 
            this.lbDeleteUser.AutoSize = true;
            this.lbDeleteUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDeleteUser.Location = new System.Drawing.Point(144, 12);
            this.lbDeleteUser.Margin = new System.Windows.Forms.Padding(0);
            this.lbDeleteUser.Name = "lbDeleteUser";
            this.lbDeleteUser.Size = new System.Drawing.Size(90, 30);
            this.lbDeleteUser.TabIndex = 4;
            this.lbDeleteUser.Text = "Șterge";
            this.lbDeleteUser.Click += new System.EventHandler(this.lbDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Location = new System.Drawing.Point(106, 49);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(46, 42);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Location = new System.Drawing.Point(108, 10);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(44, 36);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lbAddUser
            // 
            this.lbAddUser.AutoSize = true;
            this.lbAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAddUser.Location = new System.Drawing.Point(25, 78);
            this.lbAddUser.Name = "lbAddUser";
            this.lbAddUser.Size = new System.Drawing.Size(57, 18);
            this.lbAddUser.TabIndex = 1;
            this.lbAddUser.Text = "Adaugă";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(3, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(102, 78);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelUserGrid);
            this.Controls.Add(this.panelFilamentMenu);
            this.Name = "frmUsersList";
            this.Text = "Listă useri";
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