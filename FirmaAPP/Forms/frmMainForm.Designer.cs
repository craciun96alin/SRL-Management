using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    partial class frmMainForm
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
            this.components = new System.ComponentModel.Container();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.pnlSubMenu3D = new System.Windows.Forms.Panel();
            this.btn3DDesign = new System.Windows.Forms.Button();
            this.btn3DPrint = new System.Windows.Forms.Button();
            this.btn3D = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlSubMenuOrders = new System.Windows.Forms.Panel();
            this.pnlSubMenuSellingOrders = new System.Windows.Forms.Panel();
            this.btnSelling3DOrders = new System.Windows.Forms.Button();
            this.btnSellingTshirtOrders = new System.Windows.Forms.Button();
            this.btnOrderForSell = new System.Windows.Forms.Button();
            this.btnOrderForBuy = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.pnlSubMenuProvidersCustomers = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProvider = new System.Windows.Forms.Button();
            this.btnProvidersCustomers = new System.Windows.Forms.Button();
            this.panelMessageBox = new System.Windows.Forms.Panel();
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripInfoBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSubMenuSupplies = new System.Windows.Forms.Panel();
            this.btnOtherPurchase = new System.Windows.Forms.Button();
            this.btnVinyl = new System.Windows.Forms.Button();
            this.BtnFilament = new System.Windows.Forms.Button();
            this.btnTshirt = new System.Windows.Forms.Button();
            this.btnSupplies = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.panelChildForms = new System.Windows.Forms.Panel();
            this.MainMenuPanel.SuspendLayout();
            this.pnlSubMenu3D.SuspendLayout();
            this.pnlSubMenuOrders.SuspendLayout();
            this.pnlSubMenuSellingOrders.SuspendLayout();
            this.pnlSubMenuProvidersCustomers.SuspendLayout();
            this.panelMessageBox.SuspendLayout();
            this.contextMenuStripInfoBox.SuspendLayout();
            this.pnlSubMenuSupplies.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.AutoScroll = true;
            this.MainMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(11)))));
            this.MainMenuPanel.Controls.Add(this.pnlSubMenu3D);
            this.MainMenuPanel.Controls.Add(this.btn3D);
            this.MainMenuPanel.Controls.Add(this.btnSettings);
            this.MainMenuPanel.Controls.Add(this.pnlSubMenuOrders);
            this.MainMenuPanel.Controls.Add(this.btnOrders);
            this.MainMenuPanel.Controls.Add(this.pnlSubMenuProvidersCustomers);
            this.MainMenuPanel.Controls.Add(this.btnProvidersCustomers);
            this.MainMenuPanel.Controls.Add(this.panelMessageBox);
            this.MainMenuPanel.Controls.Add(this.pnlSubMenuSupplies);
            this.MainMenuPanel.Controls.Add(this.btnSupplies);
            this.MainMenuPanel.Controls.Add(this.LogoPanel);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(252, 701);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // pnlSubMenu3D
            // 
            this.pnlSubMenu3D.Controls.Add(this.btn3DDesign);
            this.pnlSubMenu3D.Controls.Add(this.btn3DPrint);
            this.pnlSubMenu3D.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenu3D.Location = new System.Drawing.Point(0, 533);
            this.pnlSubMenu3D.Name = "pnlSubMenu3D";
            this.pnlSubMenu3D.Size = new System.Drawing.Size(231, 65);
            this.pnlSubMenu3D.TabIndex = 9;
            this.pnlSubMenu3D.Visible = false;
            // 
            // btn3DDesign
            // 
            this.btn3DDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btn3DDesign.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn3DDesign.FlatAppearance.BorderSize = 0;
            this.btn3DDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3DDesign.Location = new System.Drawing.Point(0, 29);
            this.btn3DDesign.Name = "btn3DDesign";
            this.btn3DDesign.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn3DDesign.Size = new System.Drawing.Size(231, 29);
            this.btn3DDesign.TabIndex = 2;
            this.btn3DDesign.Text = "Proiectări 3D";
            this.btn3DDesign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3DDesign.UseVisualStyleBackColor = false;
            this.btn3DDesign.Click += new System.EventHandler(this.btn3DDesign_Click);
            // 
            // btn3DPrint
            // 
            this.btn3DPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btn3DPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn3DPrint.FlatAppearance.BorderSize = 0;
            this.btn3DPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3DPrint.Location = new System.Drawing.Point(0, 0);
            this.btn3DPrint.Name = "btn3DPrint";
            this.btn3DPrint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn3DPrint.Size = new System.Drawing.Size(231, 29);
            this.btn3DPrint.TabIndex = 1;
            this.btn3DPrint.Text = "Piese 3D";
            this.btn3DPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3DPrint.UseVisualStyleBackColor = false;
            this.btn3DPrint.Click += new System.EventHandler(this.btn3DPrint_Click);
            // 
            // btn3D
            // 
            this.btn3D.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn3D.FlatAppearance.BorderSize = 0;
            this.btn3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3D.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3D.Location = new System.Drawing.Point(0, 496);
            this.btn3D.Name = "btn3D";
            this.btn3D.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn3D.Size = new System.Drawing.Size(231, 37);
            this.btn3D.TabIndex = 8;
            this.btn3D.Text = "3D";
            this.btn3D.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3D.UseVisualStyleBackColor = true;
            this.btn3D.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Location = new System.Drawing.Point(0, 598);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(231, 42);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Setări";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSubMenuOrders
            // 
            this.pnlSubMenuOrders.Controls.Add(this.pnlSubMenuSellingOrders);
            this.pnlSubMenuOrders.Controls.Add(this.btnOrderForSell);
            this.pnlSubMenuOrders.Controls.Add(this.btnOrderForBuy);
            this.pnlSubMenuOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuOrders.Location = new System.Drawing.Point(0, 376);
            this.pnlSubMenuOrders.Name = "pnlSubMenuOrders";
            this.pnlSubMenuOrders.Size = new System.Drawing.Size(231, 120);
            this.pnlSubMenuOrders.TabIndex = 6;
            this.pnlSubMenuOrders.Visible = false;
            // 
            // pnlSubMenuSellingOrders
            // 
            this.pnlSubMenuSellingOrders.Controls.Add(this.btnSelling3DOrders);
            this.pnlSubMenuSellingOrders.Controls.Add(this.btnSellingTshirtOrders);
            this.pnlSubMenuSellingOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuSellingOrders.Location = new System.Drawing.Point(0, 58);
            this.pnlSubMenuSellingOrders.Name = "pnlSubMenuSellingOrders";
            this.pnlSubMenuSellingOrders.Size = new System.Drawing.Size(231, 56);
            this.pnlSubMenuSellingOrders.TabIndex = 8;
            this.pnlSubMenuSellingOrders.Visible = false;
            // 
            // btnSelling3DOrders
            // 
            this.btnSelling3DOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnSelling3DOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelling3DOrders.FlatAppearance.BorderSize = 0;
            this.btnSelling3DOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling3DOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelling3DOrders.Location = new System.Drawing.Point(0, 29);
            this.btnSelling3DOrders.Name = "btnSelling3DOrders";
            this.btnSelling3DOrders.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnSelling3DOrders.Size = new System.Drawing.Size(231, 29);
            this.btnSelling3DOrders.TabIndex = 2;
            this.btnSelling3DOrders.Text = "3D";
            this.btnSelling3DOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelling3DOrders.UseVisualStyleBackColor = false;
            this.btnSelling3DOrders.Click += new System.EventHandler(this.btnSelling3DOrders_Click);
            // 
            // btnSellingTshirtOrders
            // 
            this.btnSellingTshirtOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnSellingTshirtOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSellingTshirtOrders.FlatAppearance.BorderSize = 0;
            this.btnSellingTshirtOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellingTshirtOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellingTshirtOrders.Location = new System.Drawing.Point(0, 0);
            this.btnSellingTshirtOrders.Name = "btnSellingTshirtOrders";
            this.btnSellingTshirtOrders.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnSellingTshirtOrders.Size = new System.Drawing.Size(231, 29);
            this.btnSellingTshirtOrders.TabIndex = 1;
            this.btnSellingTshirtOrders.Text = "Tricouri";
            this.btnSellingTshirtOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellingTshirtOrders.UseVisualStyleBackColor = false;
            this.btnSellingTshirtOrders.Click += new System.EventHandler(this.btnSellingTshirtOrders_Click);
            // 
            // btnOrderForSell
            // 
            this.btnOrderForSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnOrderForSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderForSell.FlatAppearance.BorderSize = 0;
            this.btnOrderForSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderForSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderForSell.Location = new System.Drawing.Point(0, 29);
            this.btnOrderForSell.Name = "btnOrderForSell";
            this.btnOrderForSell.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOrderForSell.Size = new System.Drawing.Size(231, 29);
            this.btnOrderForSell.TabIndex = 2;
            this.btnOrderForSell.Text = "Vânzări";
            this.btnOrderForSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderForSell.UseVisualStyleBackColor = false;
            this.btnOrderForSell.Click += new System.EventHandler(this.btnOrderForSell_Click);
            // 
            // btnOrderForBuy
            // 
            this.btnOrderForBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnOrderForBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderForBuy.FlatAppearance.BorderSize = 0;
            this.btnOrderForBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderForBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderForBuy.Location = new System.Drawing.Point(0, 0);
            this.btnOrderForBuy.Name = "btnOrderForBuy";
            this.btnOrderForBuy.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOrderForBuy.Size = new System.Drawing.Size(231, 29);
            this.btnOrderForBuy.TabIndex = 1;
            this.btnOrderForBuy.Text = "Cumpărare";
            this.btnOrderForBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderForBuy.UseVisualStyleBackColor = false;
            this.btnOrderForBuy.Click += new System.EventHandler(this.btnOrderForBuy_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrders.Location = new System.Drawing.Point(0, 338);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(231, 38);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Comenzi";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // pnlSubMenuProvidersCustomers
            // 
            this.pnlSubMenuProvidersCustomers.Controls.Add(this.btnCustomer);
            this.pnlSubMenuProvidersCustomers.Controls.Add(this.btnProvider);
            this.pnlSubMenuProvidersCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuProvidersCustomers.Location = new System.Drawing.Point(0, 273);
            this.pnlSubMenuProvidersCustomers.Name = "pnlSubMenuProvidersCustomers";
            this.pnlSubMenuProvidersCustomers.Size = new System.Drawing.Size(231, 65);
            this.pnlSubMenuProvidersCustomers.TabIndex = 4;
            this.pnlSubMenuProvidersCustomers.Visible = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomer.Location = new System.Drawing.Point(0, 29);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(231, 29);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Clienți";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProvider
            // 
            this.btnProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProvider.FlatAppearance.BorderSize = 0;
            this.btnProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProvider.Location = new System.Drawing.Point(0, 0);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProvider.Size = new System.Drawing.Size(231, 29);
            this.btnProvider.TabIndex = 1;
            this.btnProvider.Text = "Furnizori";
            this.btnProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvider.UseVisualStyleBackColor = false;
            this.btnProvider.Click += new System.EventHandler(this.btnProvider_Click);
            // 
            // btnProvidersCustomers
            // 
            this.btnProvidersCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProvidersCustomers.FlatAppearance.BorderSize = 0;
            this.btnProvidersCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvidersCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvidersCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProvidersCustomers.Location = new System.Drawing.Point(0, 235);
            this.btnProvidersCustomers.Name = "btnProvidersCustomers";
            this.btnProvidersCustomers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProvidersCustomers.Size = new System.Drawing.Size(231, 38);
            this.btnProvidersCustomers.TabIndex = 4;
            this.btnProvidersCustomers.Text = "Furnizori/Clienți";
            this.btnProvidersCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProvidersCustomers.UseVisualStyleBackColor = true;
            this.btnProvidersCustomers.Click += new System.EventHandler(this.btnProvidersCustomers_Click);
            // 
            // panelMessageBox
            // 
            this.panelMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.panelMessageBox.Controls.Add(this.tbInfo);
            this.panelMessageBox.Controls.Add(this.label1);
            this.panelMessageBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMessageBox.Location = new System.Drawing.Point(0, 640);
            this.panelMessageBox.Name = "panelMessageBox";
            this.panelMessageBox.Size = new System.Drawing.Size(231, 208);
            this.panelMessageBox.TabIndex = 3;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.Lavender;
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.ContextMenuStrip = this.contextMenuStripInfoBox;
            this.tbInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInfo.Location = new System.Drawing.Point(0, 17);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(231, 191);
            this.tbInfo.TabIndex = 1;
            this.tbInfo.Text = "";
            // 
            // contextMenuStripInfoBox
            // 
            this.contextMenuStripInfoBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripInfoBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStripInfoBox.Name = "contextMenuStripInfoBox";
            this.contextMenuStripInfoBox.Size = new System.Drawing.Size(128, 28);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesaje informaționale:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSubMenuSupplies
            // 
            this.pnlSubMenuSupplies.Controls.Add(this.btnOtherPurchase);
            this.pnlSubMenuSupplies.Controls.Add(this.btnVinyl);
            this.pnlSubMenuSupplies.Controls.Add(this.BtnFilament);
            this.pnlSubMenuSupplies.Controls.Add(this.btnTshirt);
            this.pnlSubMenuSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuSupplies.Location = new System.Drawing.Point(0, 111);
            this.pnlSubMenuSupplies.Name = "pnlSubMenuSupplies";
            this.pnlSubMenuSupplies.Size = new System.Drawing.Size(231, 124);
            this.pnlSubMenuSupplies.TabIndex = 2;
            this.pnlSubMenuSupplies.Visible = false;
            // 
            // btnOtherPurchase
            // 
            this.btnOtherPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnOtherPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOtherPurchase.FlatAppearance.BorderSize = 0;
            this.btnOtherPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherPurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtherPurchase.Location = new System.Drawing.Point(0, 87);
            this.btnOtherPurchase.Name = "btnOtherPurchase";
            this.btnOtherPurchase.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOtherPurchase.Size = new System.Drawing.Size(231, 29);
            this.btnOtherPurchase.TabIndex = 3;
            this.btnOtherPurchase.Text = "Altele";
            this.btnOtherPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtherPurchase.UseVisualStyleBackColor = false;
            this.btnOtherPurchase.Click += new System.EventHandler(this.btnOtherPurchase_Click);
            // 
            // btnVinyl
            // 
            this.btnVinyl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnVinyl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVinyl.FlatAppearance.BorderSize = 0;
            this.btnVinyl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVinyl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVinyl.Location = new System.Drawing.Point(0, 58);
            this.btnVinyl.Name = "btnVinyl";
            this.btnVinyl.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVinyl.Size = new System.Drawing.Size(231, 29);
            this.btnVinyl.TabIndex = 2;
            this.btnVinyl.Text = "Vinyl";
            this.btnVinyl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVinyl.UseVisualStyleBackColor = false;
            this.btnVinyl.Click += new System.EventHandler(this.btnVinyl_Click);
            // 
            // BtnFilament
            // 
            this.BtnFilament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.BtnFilament.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFilament.FlatAppearance.BorderSize = 0;
            this.BtnFilament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFilament.Location = new System.Drawing.Point(0, 29);
            this.BtnFilament.Name = "BtnFilament";
            this.BtnFilament.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnFilament.Size = new System.Drawing.Size(231, 29);
            this.BtnFilament.TabIndex = 1;
            this.BtnFilament.Text = "Filament";
            this.BtnFilament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFilament.UseVisualStyleBackColor = false;
            this.BtnFilament.Click += new System.EventHandler(this.BtnFilament_Click);
            // 
            // btnTshirt
            // 
            this.btnTshirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.btnTshirt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTshirt.FlatAppearance.BorderSize = 0;
            this.btnTshirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTshirt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTshirt.Location = new System.Drawing.Point(0, 0);
            this.btnTshirt.Name = "btnTshirt";
            this.btnTshirt.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTshirt.Size = new System.Drawing.Size(231, 29);
            this.btnTshirt.TabIndex = 0;
            this.btnTshirt.Text = "Tricou";
            this.btnTshirt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTshirt.UseVisualStyleBackColor = false;
            this.btnTshirt.Click += new System.EventHandler(this.btnTshirt_Click);
            // 
            // btnSupplies
            // 
            this.btnSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplies.FlatAppearance.BorderSize = 0;
            this.btnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplies.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupplies.Location = new System.Drawing.Point(0, 73);
            this.btnSupplies.Name = "btnSupplies";
            this.btnSupplies.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSupplies.Size = new System.Drawing.Size(231, 38);
            this.btnSupplies.TabIndex = 1;
            this.btnSupplies.Text = "Consumabile";
            this.btnSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplies.UseVisualStyleBackColor = true;
            this.btnSupplies.Click += new System.EventHandler(this.btnSupplies_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(27)))));
            this.LogoPanel.BackgroundImage = global::FirmaAPP.Properties.Resources.pidped_logo_alb;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(231, 73);
            this.LogoPanel.TabIndex = 0;
            // 
            // panelChildForms
            // 
            this.panelChildForms.BackColor = System.Drawing.Color.White;
            this.panelChildForms.BackgroundImage = global::FirmaAPP.Properties.Resources.etisst_logo_negru;
            this.panelChildForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForms.Location = new System.Drawing.Point(252, 0);
            this.panelChildForms.Name = "panelChildForms";
            this.panelChildForms.Size = new System.Drawing.Size(1216, 701);
            this.panelChildForms.TabIndex = 1;
            this.panelChildForms.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmMainForm_LayoutChange);
            this.panelChildForms.Resize += new System.EventHandler(this.panelChildForms_Resize);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 701);
            this.Controls.Add(this.panelChildForms);
            this.Controls.Add(this.MainMenuPanel);
            this.IsMdiContainer = true;
            this.Name = "frmMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainForm_FormClosed);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.MainMenuPanel.ResumeLayout(false);
            this.pnlSubMenu3D.ResumeLayout(false);
            this.pnlSubMenuOrders.ResumeLayout(false);
            this.pnlSubMenuSellingOrders.ResumeLayout(false);
            this.pnlSubMenuProvidersCustomers.ResumeLayout(false);
            this.panelMessageBox.ResumeLayout(false);
            this.panelMessageBox.PerformLayout();
            this.contextMenuStripInfoBox.ResumeLayout(false);
            this.pnlSubMenuSupplies.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel pnlSubMenuSupplies;
        private System.Windows.Forms.Button btnSupplies;
        private System.Windows.Forms.Button btnOtherPurchase;
        private System.Windows.Forms.Button btnVinyl;
        private System.Windows.Forms.Button BtnFilament;
        private System.Windows.Forms.Button btnTshirt;
        private System.Windows.Forms.Panel panelChildForms;
        private Panel panelMessageBox;
        private RichTextBox tbInfo;
        private Label label1;
        private Button btnProvidersCustomers;
        private Panel pnlSubMenuProvidersCustomers;
        private Button btnCustomer;
        private Button btnProvider;
        private Panel pnlSubMenuOrders;
        private Button btnOrderForSell;
        private Button btnOrderForBuy;
        private Button btnOrders;
        private Button btnSettings;
        private Panel pnlSubMenu3D;
        private Button btn3DDesign;
        private Button btn3DPrint;
        private Button btn3D;
        private Panel pnlSubMenuSellingOrders;
        private Button btnSelling3DOrders;
        private Button btnSellingTshirtOrders;
        private ContextMenuStrip contextMenuStripInfoBox;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}