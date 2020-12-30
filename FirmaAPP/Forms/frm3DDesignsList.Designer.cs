namespace FirmaAPP
{
    partial class frm3DDesignsList
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
            this.panelProviderGrid = new System.Windows.Forms.Panel();
            this.dataGrid3DDesign = new System.Windows.Forms.DataGridView();
            this.panel3DDesignMenu = new System.Windows.Forms.Panel();
            this.panelCUDCustomer = new System.Windows.Forms.Panel();
            this.lbEdit3DDesign = new System.Windows.Forms.Label();
            this.lbDelete3DDesign = new System.Windows.Forms.Label();
            this.lbAdd3DDesign = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView3DDesign = new System.Windows.Forms.Button();
            this.btnEdit3DDesign = new System.Windows.Forms.Button();
            this.btnDelete3DDesign = new System.Windows.Forms.Button();
            this.btnAdd3DDesign = new System.Windows.Forms.Button();
            this.panelProviderGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3DDesign)).BeginInit();
            this.panel3DDesignMenu.SuspendLayout();
            this.panelCUDCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProviderGrid
            // 
            this.panelProviderGrid.Controls.Add(this.dataGrid3DDesign);
            this.panelProviderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProviderGrid.Location = new System.Drawing.Point(0, 100);
            this.panelProviderGrid.Name = "panelProviderGrid";
            this.panelProviderGrid.Size = new System.Drawing.Size(1198, 554);
            this.panelProviderGrid.TabIndex = 7;
            // 
            // dataGrid3DDesign
            // 
            this.dataGrid3DDesign.AllowUserToAddRows = false;
            this.dataGrid3DDesign.AllowUserToDeleteRows = false;
            this.dataGrid3DDesign.AllowUserToOrderColumns = true;
            this.dataGrid3DDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid3DDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid3DDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid3DDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3DDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid3DDesign.Location = new System.Drawing.Point(0, 0);
            this.dataGrid3DDesign.Name = "dataGrid3DDesign";
            this.dataGrid3DDesign.ReadOnly = true;
            this.dataGrid3DDesign.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DDesign.RowTemplate.Height = 24;
            this.dataGrid3DDesign.Size = new System.Drawing.Size(1198, 554);
            this.dataGrid3DDesign.TabIndex = 0;
            this.dataGrid3DDesign.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid3DDesign_CellDoubleClick);
            this.dataGrid3DDesign.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid3DDesign_CellFormatting);
            // 
            // panel3DDesignMenu
            // 
            this.panel3DDesignMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panel3DDesignMenu.Controls.Add(this.label1);
            this.panel3DDesignMenu.Controls.Add(this.btnView3DDesign);
            this.panel3DDesignMenu.Controls.Add(this.panelCUDCustomer);
            this.panel3DDesignMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3DDesignMenu.Location = new System.Drawing.Point(0, 0);
            this.panel3DDesignMenu.Name = "panel3DDesignMenu";
            this.panel3DDesignMenu.Size = new System.Drawing.Size(1198, 100);
            this.panel3DDesignMenu.TabIndex = 6;
            // 
            // panelCUDCustomer
            // 
            this.panelCUDCustomer.Controls.Add(this.lbEdit3DDesign);
            this.panelCUDCustomer.Controls.Add(this.lbDelete3DDesign);
            this.panelCUDCustomer.Controls.Add(this.btnEdit3DDesign);
            this.panelCUDCustomer.Controls.Add(this.btnDelete3DDesign);
            this.panelCUDCustomer.Controls.Add(this.lbAdd3DDesign);
            this.panelCUDCustomer.Controls.Add(this.btnAdd3DDesign);
            this.panelCUDCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCUDCustomer.Name = "panelCUDCustomer";
            this.panelCUDCustomer.Size = new System.Drawing.Size(262, 100);
            this.panelCUDCustomer.TabIndex = 0;
            // 
            // lbEdit3DDesign
            // 
            this.lbEdit3DDesign.AutoSize = true;
            this.lbEdit3DDesign.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdit3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEdit3DDesign.Location = new System.Drawing.Point(144, 53);
            this.lbEdit3DDesign.Margin = new System.Windows.Forms.Padding(0);
            this.lbEdit3DDesign.Name = "lbEdit3DDesign";
            this.lbEdit3DDesign.Size = new System.Drawing.Size(111, 30);
            this.lbEdit3DDesign.TabIndex = 5;
            this.lbEdit3DDesign.Text = "Modifică";
            this.lbEdit3DDesign.Click += new System.EventHandler(this.lbEdit3DDesign_Click);
            // 
            // lbDelete3DDesign
            // 
            this.lbDelete3DDesign.AutoSize = true;
            this.lbDelete3DDesign.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDelete3DDesign.Location = new System.Drawing.Point(144, 12);
            this.lbDelete3DDesign.Margin = new System.Windows.Forms.Padding(0);
            this.lbDelete3DDesign.Name = "lbDelete3DDesign";
            this.lbDelete3DDesign.Size = new System.Drawing.Size(90, 30);
            this.lbDelete3DDesign.TabIndex = 4;
            this.lbDelete3DDesign.Text = "Șterge";
            this.lbDelete3DDesign.Click += new System.EventHandler(this.lbDelete3DDesign_Click);
            // 
            // lbAdd3DDesign
            // 
            this.lbAdd3DDesign.AutoSize = true;
            this.lbAdd3DDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAdd3DDesign.Location = new System.Drawing.Point(25, 78);
            this.lbAdd3DDesign.Name = "lbAdd3DDesign";
            this.lbAdd3DDesign.Size = new System.Drawing.Size(57, 18);
            this.lbAdd3DDesign.TabIndex = 1;
            this.lbAdd3DDesign.Text = "Adaugă";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(268, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vezi proiectul";
            // 
            // btnView3DDesign
            // 
            this.btnView3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.ViewDirectoryIcon;
            this.btnView3DDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView3DDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView3DDesign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView3DDesign.Location = new System.Drawing.Point(276, 6);
            this.btnView3DDesign.Name = "btnView3DDesign";
            this.btnView3DDesign.Size = new System.Drawing.Size(79, 72);
            this.btnView3DDesign.TabIndex = 4;
            this.btnView3DDesign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView3DDesign.UseVisualStyleBackColor = true;
            this.btnView3DDesign.Click += new System.EventHandler(this.btnView3DDesign_Click);
            // 
            // btnEdit3DDesign
            // 
            this.btnEdit3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEdit3DDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit3DDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit3DDesign.Location = new System.Drawing.Point(106, 49);
            this.btnEdit3DDesign.Name = "btnEdit3DDesign";
            this.btnEdit3DDesign.Size = new System.Drawing.Size(46, 42);
            this.btnEdit3DDesign.TabIndex = 3;
            this.btnEdit3DDesign.UseVisualStyleBackColor = true;
            this.btnEdit3DDesign.Click += new System.EventHandler(this.btnEdit3DDesign_Click);
            // 
            // btnDelete3DDesign
            // 
            this.btnDelete3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDelete3DDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete3DDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete3DDesign.Location = new System.Drawing.Point(108, 10);
            this.btnDelete3DDesign.Name = "btnDelete3DDesign";
            this.btnDelete3DDesign.Size = new System.Drawing.Size(44, 36);
            this.btnDelete3DDesign.TabIndex = 2;
            this.btnDelete3DDesign.UseVisualStyleBackColor = true;
            this.btnDelete3DDesign.Click += new System.EventHandler(this.btnDelete3DDesign_Click);
            // 
            // btnAdd3DDesign
            // 
            this.btnAdd3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAdd3DDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd3DDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd3DDesign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd3DDesign.Location = new System.Drawing.Point(3, 3);
            this.btnAdd3DDesign.Name = "btnAdd3DDesign";
            this.btnAdd3DDesign.Size = new System.Drawing.Size(102, 78);
            this.btnAdd3DDesign.TabIndex = 0;
            this.btnAdd3DDesign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd3DDesign.UseVisualStyleBackColor = true;
            this.btnAdd3DDesign.Click += new System.EventHandler(this.btnAdd3DDesign_Click);
            // 
            // frm3DDesignsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panel3DDesignMenu);
            this.Name = "frm3DDesignsList";
            this.Text = "Proiectare 3D";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm3DDesignsList_FormClosed);
            this.Load += new System.EventHandler(this.frm3DDesignsList_Load);
            this.panelProviderGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3DDesign)).EndInit();
            this.panel3DDesignMenu.ResumeLayout(false);
            this.panel3DDesignMenu.PerformLayout();
            this.panelCUDCustomer.ResumeLayout(false);
            this.panelCUDCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProviderGrid;
        private System.Windows.Forms.DataGridView dataGrid3DDesign;
        private System.Windows.Forms.Panel panel3DDesignMenu;
        private System.Windows.Forms.Panel panelCUDCustomer;
        private System.Windows.Forms.Label lbEdit3DDesign;
        private System.Windows.Forms.Label lbDelete3DDesign;
        private System.Windows.Forms.Button btnEdit3DDesign;
        private System.Windows.Forms.Button btnDelete3DDesign;
        private System.Windows.Forms.Label lbAdd3DDesign;
        private System.Windows.Forms.Button btnAdd3DDesign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView3DDesign;
    }
}