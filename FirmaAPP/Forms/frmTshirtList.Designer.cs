namespace FirmaAPP
{
    partial class frmTshirtsList
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
            this.panelVinylMenu = new System.Windows.Forms.Panel();
            this.panelCUDFilament = new System.Windows.Forms.Panel();
            this.lbEdit = new System.Windows.Forms.Label();
            this.lbDelete = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelFilamentGrid = new System.Windows.Forms.Panel();
            this.dataGridTshirts = new System.Windows.Forms.DataGridView();
            this.panelVinylMenu.SuspendLayout();
            this.panelCUDFilament.SuspendLayout();
            this.panelFilamentGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTshirts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVinylMenu
            // 
            this.panelVinylMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panelVinylMenu.Controls.Add(this.panelCUDFilament);
            this.panelVinylMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVinylMenu.Location = new System.Drawing.Point(0, 0);
            this.panelVinylMenu.Name = "panelVinylMenu";
            this.panelVinylMenu.Size = new System.Drawing.Size(1198, 100);
            this.panelVinylMenu.TabIndex = 2;
            // 
            // panelCUDFilament
            // 
            this.panelCUDFilament.Controls.Add(this.lbEdit);
            this.panelCUDFilament.Controls.Add(this.lbDelete);
            this.panelCUDFilament.Controls.Add(this.btnEdit);
            this.panelCUDFilament.Controls.Add(this.btnDelete);
            this.panelCUDFilament.Controls.Add(this.lbAdd);
            this.panelCUDFilament.Controls.Add(this.btnAdd);
            this.panelCUDFilament.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDFilament.Location = new System.Drawing.Point(0, 0);
            this.panelCUDFilament.Name = "panelCUDFilament";
            this.panelCUDFilament.Size = new System.Drawing.Size(262, 100);
            this.panelCUDFilament.TabIndex = 0;
            // 
            // lbEdit
            // 
            this.lbEdit.AutoSize = true;
            this.lbEdit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEdit.Location = new System.Drawing.Point(144, 53);
            this.lbEdit.Margin = new System.Windows.Forms.Padding(0);
            this.lbEdit.Name = "lbEdit";
            this.lbEdit.Size = new System.Drawing.Size(111, 30);
            this.lbEdit.TabIndex = 5;
            this.lbEdit.Text = "Modifică";
            this.lbEdit.Click += new System.EventHandler(this.lbEdit_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDelete.Location = new System.Drawing.Point(144, 12);
            this.lbDelete.Margin = new System.Windows.Forms.Padding(0);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(90, 30);
            this.lbDelete.TabIndex = 4;
            this.lbDelete.Text = "Șterge";
            this.lbDelete.Click += new System.EventHandler(this.lbDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(106, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 42);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(108, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAdd.Location = new System.Drawing.Point(25, 78);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(57, 18);
            this.lbAdd.TabIndex = 1;
            this.lbAdd.Text = "Adaugă";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 78);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelFilamentGrid
            // 
            this.panelFilamentGrid.Controls.Add(this.dataGridTshirts);
            this.panelFilamentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilamentGrid.Location = new System.Drawing.Point(0, 100);
            this.panelFilamentGrid.Name = "panelFilamentGrid";
            this.panelFilamentGrid.Size = new System.Drawing.Size(1198, 554);
            this.panelFilamentGrid.TabIndex = 3;
            // 
            // dataGridTshirts
            // 
            this.dataGridTshirts.AllowUserToAddRows = false;
            this.dataGridTshirts.AllowUserToDeleteRows = false;
            this.dataGridTshirts.AllowUserToOrderColumns = true;
            this.dataGridTshirts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTshirts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridTshirts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridTshirts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridTshirts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTshirts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTshirts.Location = new System.Drawing.Point(0, 0);
            this.dataGridTshirts.Name = "dataGridTshirts";
            this.dataGridTshirts.ReadOnly = true;
            this.dataGridTshirts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridTshirts.RowTemplate.Height = 24;
            this.dataGridTshirts.Size = new System.Drawing.Size(1198, 554);
            this.dataGridTshirts.TabIndex = 0;
            this.dataGridTshirts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTshirts_CellDoubleClick);
            // 
            // frmTshirtsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelFilamentGrid);
            this.Controls.Add(this.panelVinylMenu);
            this.Name = "frmTshirtsList";
            this.Text = "Listă furnizori";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTshirtsList_FormClosed);
            this.Load += new System.EventHandler(this.frmTshirtsList_Load);
            this.panelVinylMenu.ResumeLayout(false);
            this.panelCUDFilament.ResumeLayout(false);
            this.panelCUDFilament.PerformLayout();
            this.panelFilamentGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTshirts)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridTshirts;
    }
}