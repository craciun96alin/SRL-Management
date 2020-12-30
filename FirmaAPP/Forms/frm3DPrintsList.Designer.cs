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
            this.panel3DPrintMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCUDCustomer = new System.Windows.Forms.Panel();
            this.lbEdit3DPrint = new System.Windows.Forms.Label();
            this.lbDelete3DPrint = new System.Windows.Forms.Label();
            this.lbAdd3DPrint = new System.Windows.Forms.Label();
            this.panelProviderGrid = new System.Windows.Forms.Panel();
            this.dataGrid3DPrint = new System.Windows.Forms.DataGridView();
            this.btnView3DPrint = new System.Windows.Forms.Button();
            this.btnEdit3DPrint = new System.Windows.Forms.Button();
            this.btnDelete3DPrint = new System.Windows.Forms.Button();
            this.btnAdd3DPrint = new System.Windows.Forms.Button();
            this.panel3DPrintMenu.SuspendLayout();
            this.panelCUDCustomer.SuspendLayout();
            this.panelProviderGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3DPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3DPrintMenu
            // 
            this.panel3DPrintMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.panel3DPrintMenu.Controls.Add(this.label1);
            this.panel3DPrintMenu.Controls.Add(this.btnView3DPrint);
            this.panel3DPrintMenu.Controls.Add(this.panelCUDCustomer);
            this.panel3DPrintMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3DPrintMenu.Location = new System.Drawing.Point(0, 0);
            this.panel3DPrintMenu.Name = "panel3DPrintMenu";
            this.panel3DPrintMenu.Size = new System.Drawing.Size(1198, 100);
            this.panel3DPrintMenu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(281, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vezi piesa";
            // 
            // panelCUDCustomer
            // 
            this.panelCUDCustomer.Controls.Add(this.lbEdit3DPrint);
            this.panelCUDCustomer.Controls.Add(this.lbDelete3DPrint);
            this.panelCUDCustomer.Controls.Add(this.btnEdit3DPrint);
            this.panelCUDCustomer.Controls.Add(this.btnDelete3DPrint);
            this.panelCUDCustomer.Controls.Add(this.lbAdd3DPrint);
            this.panelCUDCustomer.Controls.Add(this.btnAdd3DPrint);
            this.panelCUDCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCUDCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCUDCustomer.Name = "panelCUDCustomer";
            this.panelCUDCustomer.Size = new System.Drawing.Size(262, 100);
            this.panelCUDCustomer.TabIndex = 0;
            // 
            // lbEdit3DPrint
            // 
            this.lbEdit3DPrint.AutoSize = true;
            this.lbEdit3DPrint.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdit3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEdit3DPrint.Location = new System.Drawing.Point(144, 53);
            this.lbEdit3DPrint.Margin = new System.Windows.Forms.Padding(0);
            this.lbEdit3DPrint.Name = "lbEdit3DPrint";
            this.lbEdit3DPrint.Size = new System.Drawing.Size(111, 30);
            this.lbEdit3DPrint.TabIndex = 5;
            this.lbEdit3DPrint.Text = "Modifică";
            this.lbEdit3DPrint.Click += new System.EventHandler(this.lbEdit3DPrint_Click);
            // 
            // lbDelete3DPrint
            // 
            this.lbDelete3DPrint.AutoSize = true;
            this.lbDelete3DPrint.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDelete3DPrint.Location = new System.Drawing.Point(144, 12);
            this.lbDelete3DPrint.Margin = new System.Windows.Forms.Padding(0);
            this.lbDelete3DPrint.Name = "lbDelete3DPrint";
            this.lbDelete3DPrint.Size = new System.Drawing.Size(90, 30);
            this.lbDelete3DPrint.TabIndex = 4;
            this.lbDelete3DPrint.Text = "Șterge";
            this.lbDelete3DPrint.Click += new System.EventHandler(this.lbDelete3DPrint_Click);
            // 
            // lbAdd3DPrint
            // 
            this.lbAdd3DPrint.AutoSize = true;
            this.lbAdd3DPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAdd3DPrint.Location = new System.Drawing.Point(29, 78);
            this.lbAdd3DPrint.Name = "lbAdd3DPrint";
            this.lbAdd3DPrint.Size = new System.Drawing.Size(57, 18);
            this.lbAdd3DPrint.TabIndex = 1;
            this.lbAdd3DPrint.Text = "Adaugă";
            // 
            // panelProviderGrid
            // 
            this.panelProviderGrid.Controls.Add(this.dataGrid3DPrint);
            this.panelProviderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProviderGrid.Location = new System.Drawing.Point(0, 100);
            this.panelProviderGrid.Name = "panelProviderGrid";
            this.panelProviderGrid.Size = new System.Drawing.Size(1198, 554);
            this.panelProviderGrid.TabIndex = 5;
            // 
            // dataGrid3DPrint
            // 
            this.dataGrid3DPrint.AllowUserToAddRows = false;
            this.dataGrid3DPrint.AllowUserToDeleteRows = false;
            this.dataGrid3DPrint.AllowUserToOrderColumns = true;
            this.dataGrid3DPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid3DPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid3DPrint.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid3DPrint.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3DPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid3DPrint.Location = new System.Drawing.Point(0, 0);
            this.dataGrid3DPrint.Name = "dataGrid3DPrint";
            this.dataGrid3DPrint.ReadOnly = true;
            this.dataGrid3DPrint.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGrid3DPrint.RowTemplate.Height = 24;
            this.dataGrid3DPrint.Size = new System.Drawing.Size(1198, 554);
            this.dataGrid3DPrint.TabIndex = 0;
            this.dataGrid3DPrint.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid3DPrint_CellDoubleClick);
            this.dataGrid3DPrint.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGrid3DPrint_CellFormatting);
            // 
            // btnView3DPrint
            // 
            this.btnView3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.ViewIcon;
            this.btnView3DPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView3DPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView3DPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView3DPrint.Location = new System.Drawing.Point(279, 6);
            this.btnView3DPrint.Name = "btnView3DPrint";
            this.btnView3DPrint.Size = new System.Drawing.Size(79, 72);
            this.btnView3DPrint.TabIndex = 2;
            this.btnView3DPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView3DPrint.UseVisualStyleBackColor = true;
            this.btnView3DPrint.Click += new System.EventHandler(this.btnView3DPrint_Click);
            // 
            // btnEdit3DPrint
            // 
            this.btnEdit3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.EditIcon;
            this.btnEdit3DPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit3DPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit3DPrint.Location = new System.Drawing.Point(106, 49);
            this.btnEdit3DPrint.Name = "btnEdit3DPrint";
            this.btnEdit3DPrint.Size = new System.Drawing.Size(46, 42);
            this.btnEdit3DPrint.TabIndex = 3;
            this.btnEdit3DPrint.UseVisualStyleBackColor = true;
            this.btnEdit3DPrint.Click += new System.EventHandler(this.btnEdit3DPrint_Click);
            // 
            // btnDelete3DPrint
            // 
            this.btnDelete3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.DeleteIcon;
            this.btnDelete3DPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete3DPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete3DPrint.Location = new System.Drawing.Point(108, 10);
            this.btnDelete3DPrint.Name = "btnDelete3DPrint";
            this.btnDelete3DPrint.Size = new System.Drawing.Size(44, 36);
            this.btnDelete3DPrint.TabIndex = 2;
            this.btnDelete3DPrint.UseVisualStyleBackColor = true;
            this.btnDelete3DPrint.Click += new System.EventHandler(this.btnDelete3DPrint_Click);
            // 
            // btnAdd3DPrint
            // 
            this.btnAdd3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.AddIcon;
            this.btnAdd3DPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd3DPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd3DPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd3DPrint.Location = new System.Drawing.Point(3, 3);
            this.btnAdd3DPrint.Name = "btnAdd3DPrint";
            this.btnAdd3DPrint.Size = new System.Drawing.Size(102, 78);
            this.btnAdd3DPrint.TabIndex = 0;
            this.btnAdd3DPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd3DPrint.UseVisualStyleBackColor = true;
            this.btnAdd3DPrint.Click += new System.EventHandler(this.btnAdd3DPrint_Click);
            // 
            // frm3DPrintsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.panelProviderGrid);
            this.Controls.Add(this.panel3DPrintMenu);
            this.Name = "frm3DPrintsList";
            this.Text = "Piese 3D";
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