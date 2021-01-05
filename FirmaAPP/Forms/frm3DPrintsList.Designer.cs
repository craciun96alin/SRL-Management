namespace FirmaAPP
{
    partial class frm3DPrintsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3DPrintsList));
            this.panel3DPrintMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView3DPrint = new System.Windows.Forms.Button();
            this.panelCUDCustomer = new System.Windows.Forms.Panel();
            this.lbEdit3DPrint = new System.Windows.Forms.Label();
            this.lbDelete3DPrint = new System.Windows.Forms.Label();
            this.btnEdit3DPrint = new System.Windows.Forms.Button();
            this.btnDelete3DPrint = new System.Windows.Forms.Button();
            this.lbAdd3DPrint = new System.Windows.Forms.Label();
            this.btnAdd3DPrint = new System.Windows.Forms.Button();
            this.panelProviderGrid = new System.Windows.Forms.Panel();
            this.dataGrid3DPrint = new System.Windows.Forms.DataGridView();
            this.panel3DPrintMenu.SuspendLayout();
            this.panelCUDCustomer.SuspendLayout();
            this.panelProviderGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3DPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3DPrintMenu
            // 
            resources.ApplyResources(this.panel3DPrintMenu, "panel3DPrintMenu");
            this.panel3DPrintMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panel3DPrintMenu.Controls.Add(this.label1);
            this.panel3DPrintMenu.Controls.Add(this.btnView3DPrint);
            this.panel3DPrintMenu.Controls.Add(this.panelCUDCustomer);
            this.panel3DPrintMenu.Name = "panel3DPrintMenu";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // btnView3DPrint
            // 
            resources.ApplyResources(this.btnView3DPrint, "btnView3DPrint");
            this.btnView3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.ViewIcon;
            this.btnView3DPrint.Name = "btnView3DPrint";
            this.btnView3DPrint.UseVisualStyleBackColor = true;
            this.btnView3DPrint.Click += new System.EventHandler(this.btnView3DPrint_Click);
            // 
            // panelCUDCustomer
            // 
            resources.ApplyResources(this.panelCUDCustomer, "panelCUDCustomer");
            this.panelCUDCustomer.Controls.Add(this.lbEdit3DPrint);
            this.panelCUDCustomer.Controls.Add(this.lbDelete3DPrint);
            this.panelCUDCustomer.Controls.Add(this.btnEdit3DPrint);
            this.panelCUDCustomer.Controls.Add(this.btnDelete3DPrint);
            this.panelCUDCustomer.Controls.Add(this.lbAdd3DPrint);
            this.panelCUDCustomer.Controls.Add(this.btnAdd3DPrint);
            this.panelCUDCustomer.Name = "panelCUDCustomer";
            // 
            // lbEdit3DPrint
            // 
            resources.ApplyResources(this.lbEdit3DPrint, "lbEdit3DPrint");
            this.lbEdit3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEdit3DPrint.Name = "lbEdit3DPrint";
            this.lbEdit3DPrint.Click += new System.EventHandler(this.lbEdit3DPrint_Click);
            // 
            // lbDelete3DPrint
            // 
            resources.ApplyResources(this.lbDelete3DPrint, "lbDelete3DPrint");
            this.lbDelete3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDelete3DPrint.Name = "lbDelete3DPrint";
            this.lbDelete3DPrint.Click += new System.EventHandler(this.lbDelete3DPrint_Click);
            // 
            // btnEdit3DPrint
            // 
            resources.ApplyResources(this.btnEdit3DPrint, "btnEdit3DPrint");
            this.btnEdit3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEdit3DPrint.Name = "btnEdit3DPrint";
            this.btnEdit3DPrint.UseVisualStyleBackColor = true;
            this.btnEdit3DPrint.Click += new System.EventHandler(this.btnEdit3DPrint_Click);
            // 
            // btnDelete3DPrint
            // 
            resources.ApplyResources(this.btnDelete3DPrint, "btnDelete3DPrint");
            this.btnDelete3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDelete3DPrint.Name = "btnDelete3DPrint";
            this.btnDelete3DPrint.UseVisualStyleBackColor = true;
            this.btnDelete3DPrint.Click += new System.EventHandler(this.btnDelete3DPrint_Click);
            // 
            // lbAdd3DPrint
            // 
            resources.ApplyResources(this.lbAdd3DPrint, "lbAdd3DPrint");
            this.lbAdd3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAdd3DPrint.Name = "lbAdd3DPrint";
            // 
            // btnAdd3DPrint
            // 
            resources.ApplyResources(this.btnAdd3DPrint, "btnAdd3DPrint");
            this.btnAdd3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAdd3DPrint.Name = "btnAdd3DPrint";
            this.btnAdd3DPrint.UseVisualStyleBackColor = true;
            this.btnAdd3DPrint.Click += new System.EventHandler(this.btnAdd3DPrint_Click);
            // 
            // panelProviderGrid
            // 
            resources.ApplyResources(this.panelProviderGrid, "panelProviderGrid");
            this.panelProviderGrid.Controls.Add(this.dataGrid3DPrint);
            this.panelProviderGrid.Name = "panelProviderGrid";
            // 
            // dataGrid3DPrint
            // 
            resources.ApplyResources(this.dataGrid3DPrint, "dataGrid3DPrint");
            this.dataGrid3DPrint.AllowUserToAddRows = false;
            this.dataGrid3DPrint.AllowUserToDeleteRows = false;
            this.dataGrid3DPrint.AllowUserToOrderColumns = true;
            this.dataGrid3DPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid3DPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid3DPrint.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid3DPrint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3DPrint.Name = "dataGrid3DPrint";
            this.dataGrid3DPrint.ReadOnly = true;
            this.dataGrid3DPrint.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DPrint.RowTemplate.Height = 24;
            this.dataGrid3DPrint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid3DPrint_CellDoubleClick);
            this.dataGrid3DPrint.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid3DPrint_CellFormatting);
            // 
            // frm3DPrintsList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panel3DPrintMenu);
            this.Name = "frm3DPrintsList";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm3DPrintsList_FormClosed);
            this.Load += new System.EventHandler(this.frm3DPrintsDetails_Load);
            this.panel3DPrintMenu.ResumeLayout(false);
            this.panel3DPrintMenu.PerformLayout();
            this.panelCUDCustomer.ResumeLayout(false);
            this.panelCUDCustomer.PerformLayout();
            this.panelProviderGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3DPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3DPrintMenu;
        private System.Windows.Forms.Panel panelCUDCustomer;
        private System.Windows.Forms.Label lbEdit3DPrint;
        private System.Windows.Forms.Label lbDelete3DPrint;
        private System.Windows.Forms.Button btnEdit3DPrint;
        private System.Windows.Forms.Button btnDelete3DPrint;
        private System.Windows.Forms.Label lbAdd3DPrint;
        private System.Windows.Forms.Button btnAdd3DPrint;
        private System.Windows.Forms.Panel panelProviderGrid;
        private System.Windows.Forms.DataGridView dataGrid3DPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView3DPrint;
    }
}