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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3DDesignsList));
            this.panelProviderGrid = new System.Windows.Forms.Panel();
            this.dataGrid3DDesign = new System.Windows.Forms.DataGridView();
            this.panel3DDesignMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCUDCustomer = new System.Windows.Forms.Panel();
            this.lbEdit3DDesign = new System.Windows.Forms.Label();
            this.lbDelete3DDesign = new System.Windows.Forms.Label();
            this.lbAdd3DDesign = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.panelProviderGrid, "panelProviderGrid");
            this.panelProviderGrid.Controls.Add(this.dataGrid3DDesign);
            this.panelProviderGrid.Name = "panelProviderGrid";
            // 
            // dataGrid3DDesign
            // 
            resources.ApplyResources(this.dataGrid3DDesign, "dataGrid3DDesign");
            this.dataGrid3DDesign.AllowUserToAddRows = false;
            this.dataGrid3DDesign.AllowUserToDeleteRows = false;
            this.dataGrid3DDesign.AllowUserToOrderColumns = true;
            this.dataGrid3DDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid3DDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid3DDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid3DDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3DDesign.Name = "dataGrid3DDesign";
            this.dataGrid3DDesign.ReadOnly = true;
            this.dataGrid3DDesign.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DDesign.RowTemplate.Height = 24;
            this.dataGrid3DDesign.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid3DDesign_CellDoubleClick);
            this.dataGrid3DDesign.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid3DDesign_CellFormatting);
            // 
            // panel3DDesignMenu
            // 
            resources.ApplyResources(this.panel3DDesignMenu, "panel3DDesignMenu");
            this.panel3DDesignMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panel3DDesignMenu.Controls.Add(this.label1);
            this.panel3DDesignMenu.Controls.Add(this.btnView3DDesign);
            this.panel3DDesignMenu.Controls.Add(this.panelCUDCustomer);
            this.panel3DDesignMenu.Name = "panel3DDesignMenu";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // panelCUDCustomer
            // 
            resources.ApplyResources(this.panelCUDCustomer, "panelCUDCustomer");
            this.panelCUDCustomer.Controls.Add(this.lbEdit3DDesign);
            this.panelCUDCustomer.Controls.Add(this.lbDelete3DDesign);
            this.panelCUDCustomer.Controls.Add(this.btnEdit3DDesign);
            this.panelCUDCustomer.Controls.Add(this.btnDelete3DDesign);
            this.panelCUDCustomer.Controls.Add(this.lbAdd3DDesign);
            this.panelCUDCustomer.Controls.Add(this.btnAdd3DDesign);
            this.panelCUDCustomer.Name = "panelCUDCustomer";
            // 
            // lbEdit3DDesign
            // 
            resources.ApplyResources(this.lbEdit3DDesign, "lbEdit3DDesign");
            this.lbEdit3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEdit3DDesign.Name = "lbEdit3DDesign";
            this.lbEdit3DDesign.Click += new System.EventHandler(this.lbEdit3DDesign_Click);
            // 
            // lbDelete3DDesign
            // 
            resources.ApplyResources(this.lbDelete3DDesign, "lbDelete3DDesign");
            this.lbDelete3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDelete3DDesign.Name = "lbDelete3DDesign";
            this.lbDelete3DDesign.Click += new System.EventHandler(this.lbDelete3DDesign_Click);
            // 
            // lbAdd3DDesign
            // 
            resources.ApplyResources(this.lbAdd3DDesign, "lbAdd3DDesign");
            this.lbAdd3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAdd3DDesign.Name = "lbAdd3DDesign";
            // 
            // btnView3DDesign
            // 
            resources.ApplyResources(this.btnView3DDesign, "btnView3DDesign");
            this.btnView3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.ViewDirectoryIcon;
            this.btnView3DDesign.Name = "btnView3DDesign";
            this.btnView3DDesign.UseVisualStyleBackColor = true;
            this.btnView3DDesign.Click += new System.EventHandler(this.btnView3DDesign_Click);
            // 
            // btnEdit3DDesign
            // 
            resources.ApplyResources(this.btnEdit3DDesign, "btnEdit3DDesign");
            this.btnEdit3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEdit3DDesign.Name = "btnEdit3DDesign";
            this.btnEdit3DDesign.UseVisualStyleBackColor = true;
            this.btnEdit3DDesign.Click += new System.EventHandler(this.btnEdit3DDesign_Click);
            // 
            // btnDelete3DDesign
            // 
            resources.ApplyResources(this.btnDelete3DDesign, "btnDelete3DDesign");
            this.btnDelete3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDelete3DDesign.Name = "btnDelete3DDesign";
            this.btnDelete3DDesign.UseVisualStyleBackColor = true;
            this.btnDelete3DDesign.Click += new System.EventHandler(this.btnDelete3DDesign_Click);
            // 
            // btnAdd3DDesign
            // 
            resources.ApplyResources(this.btnAdd3DDesign, "btnAdd3DDesign");
            this.btnAdd3DDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAdd3DDesign.Name = "btnAdd3DDesign";
            this.btnAdd3DDesign.UseVisualStyleBackColor = true;
            this.btnAdd3DDesign.Click += new System.EventHandler(this.btnAdd3DDesign_Click);
            // 
            // frm3DDesignsList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panel3DDesignMenu);
            this.Name = "frm3DDesignsList";
            this.ShowIcon = false;
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