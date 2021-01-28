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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
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
            resources.ApplyResources(this.MainMenuPanel, "MainMenuPanel");
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
            this.MainMenuPanel.Name = "MainMenuPanel";
            // 
            // pnlSubMenu3D
            // 
            this.pnlSubMenu3D.Controls.Add(this.btn3DDesign);
            this.pnlSubMenu3D.Controls.Add(this.btn3DPrint);
            resources.ApplyResources(this.pnlSubMenu3D, "pnlSubMenu3D");
            this.pnlSubMenu3D.Name = "pnlSubMenu3D";
            // 
            // btn3DDesign
            // 
            this.btn3DDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btn3DDesign, "btn3DDesign");
            this.btn3DDesign.FlatAppearance.BorderSize = 0;
            this.btn3DDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3DDesign.Name = "btn3DDesign";
            this.btn3DDesign.UseVisualStyleBackColor = false;
            this.btn3DDesign.Click += new System.EventHandler(this.btn3DDesign_Click);
            // 
            // btn3DPrint
            // 
            this.btn3DPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btn3DPrint, "btn3DPrint");
            this.btn3DPrint.FlatAppearance.BorderSize = 0;
            this.btn3DPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3DPrint.Name = "btn3DPrint";
            this.btn3DPrint.UseVisualStyleBackColor = false;
            this.btn3DPrint.Click += new System.EventHandler(this.btn3DPrint_Click);
            // 
            // btn3D
            // 
            resources.ApplyResources(this.btn3D, "btn3D");
            this.btn3D.FlatAppearance.BorderSize = 0;
            this.btn3D.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3D.Name = "btn3D";
            this.btn3D.UseVisualStyleBackColor = true;
            this.btn3D.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSubMenuOrders
            // 
            this.pnlSubMenuOrders.Controls.Add(this.pnlSubMenuSellingOrders);
            this.pnlSubMenuOrders.Controls.Add(this.btnOrderForSell);
            this.pnlSubMenuOrders.Controls.Add(this.btnOrderForBuy);
            resources.ApplyResources(this.pnlSubMenuOrders, "pnlSubMenuOrders");
            this.pnlSubMenuOrders.Name = "pnlSubMenuOrders";
            // 
            // pnlSubMenuSellingOrders
            // 
            this.pnlSubMenuSellingOrders.Controls.Add(this.btnSelling3DOrders);
            this.pnlSubMenuSellingOrders.Controls.Add(this.btnSellingTshirtOrders);
            resources.ApplyResources(this.pnlSubMenuSellingOrders, "pnlSubMenuSellingOrders");
            this.pnlSubMenuSellingOrders.Name = "pnlSubMenuSellingOrders";
            // 
            // btnSelling3DOrders
            // 
            this.btnSelling3DOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnSelling3DOrders, "btnSelling3DOrders");
            this.btnSelling3DOrders.FlatAppearance.BorderSize = 0;
            this.btnSelling3DOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelling3DOrders.Name = "btnSelling3DOrders";
            this.btnSelling3DOrders.UseVisualStyleBackColor = false;
            this.btnSelling3DOrders.Click += new System.EventHandler(this.btnSelling3DOrders_Click);
            // 
            // btnSellingTshirtOrders
            // 
            this.btnSellingTshirtOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnSellingTshirtOrders, "btnSellingTshirtOrders");
            this.btnSellingTshirtOrders.FlatAppearance.BorderSize = 0;
            this.btnSellingTshirtOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellingTshirtOrders.Name = "btnSellingTshirtOrders";
            this.btnSellingTshirtOrders.UseVisualStyleBackColor = false;
            this.btnSellingTshirtOrders.Click += new System.EventHandler(this.btnSellingTshirtOrders_Click);
            // 
            // btnOrderForSell
            // 
            this.btnOrderForSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnOrderForSell, "btnOrderForSell");
            this.btnOrderForSell.FlatAppearance.BorderSize = 0;
            this.btnOrderForSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderForSell.Name = "btnOrderForSell";
            this.btnOrderForSell.UseVisualStyleBackColor = false;
            this.btnOrderForSell.Click += new System.EventHandler(this.btnOrderForSell_Click);
            // 
            // btnOrderForBuy
            // 
            this.btnOrderForBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnOrderForBuy, "btnOrderForBuy");
            this.btnOrderForBuy.FlatAppearance.BorderSize = 0;
            this.btnOrderForBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrderForBuy.Name = "btnOrderForBuy";
            this.btnOrderForBuy.UseVisualStyleBackColor = false;
            this.btnOrderForBuy.Click += new System.EventHandler(this.btnOrderForBuy_Click);
            // 
            // btnOrders
            // 
            resources.ApplyResources(this.btnOrders, "btnOrders");
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // pnlSubMenuProvidersCustomers
            // 
            this.pnlSubMenuProvidersCustomers.Controls.Add(this.btnCustomer);
            this.pnlSubMenuProvidersCustomers.Controls.Add(this.btnProvider);
            resources.ApplyResources(this.pnlSubMenuProvidersCustomers, "pnlSubMenuProvidersCustomers");
            this.pnlSubMenuProvidersCustomers.Name = "pnlSubMenuProvidersCustomers";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnCustomer, "btnCustomer");
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProvider
            // 
            this.btnProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnProvider, "btnProvider");
            this.btnProvider.FlatAppearance.BorderSize = 0;
            this.btnProvider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.UseVisualStyleBackColor = false;
            this.btnProvider.Click += new System.EventHandler(this.btnProvider_Click);
            // 
            // btnProvidersCustomers
            // 
            resources.ApplyResources(this.btnProvidersCustomers, "btnProvidersCustomers");
            this.btnProvidersCustomers.FlatAppearance.BorderSize = 0;
            this.btnProvidersCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProvidersCustomers.Name = "btnProvidersCustomers";
            this.btnProvidersCustomers.UseVisualStyleBackColor = true;
            this.btnProvidersCustomers.Click += new System.EventHandler(this.btnProvidersCustomers_Click);
            // 
            // panelMessageBox
            // 
            this.panelMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.panelMessageBox.Controls.Add(this.tbInfo);
            this.panelMessageBox.Controls.Add(this.label1);
            resources.ApplyResources(this.panelMessageBox, "panelMessageBox");
            this.panelMessageBox.Name = "panelMessageBox";
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.Lavender;
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInfo.ContextMenuStrip = this.contextMenuStripInfoBox;
            this.tbInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.tbInfo, "tbInfo");
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            // 
            // contextMenuStripInfoBox
            // 
            this.contextMenuStripInfoBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripInfoBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStripInfoBox.Name = "contextMenuStripInfoBox";
            resources.ApplyResources(this.contextMenuStripInfoBox, "contextMenuStripInfoBox");
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // pnlSubMenuSupplies
            // 
            this.pnlSubMenuSupplies.Controls.Add(this.btnOtherPurchase);
            this.pnlSubMenuSupplies.Controls.Add(this.btnVinyl);
            this.pnlSubMenuSupplies.Controls.Add(this.BtnFilament);
            this.pnlSubMenuSupplies.Controls.Add(this.btnTshirt);
            resources.ApplyResources(this.pnlSubMenuSupplies, "pnlSubMenuSupplies");
            this.pnlSubMenuSupplies.Name = "pnlSubMenuSupplies";
            // 
            // btnOtherPurchase
            // 
            this.btnOtherPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnOtherPurchase, "btnOtherPurchase");
            this.btnOtherPurchase.FlatAppearance.BorderSize = 0;
            this.btnOtherPurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtherPurchase.Name = "btnOtherPurchase";
            this.btnOtherPurchase.UseVisualStyleBackColor = false;
            this.btnOtherPurchase.Click += new System.EventHandler(this.btnOtherPurchase_Click);
            // 
            // btnVinyl
            // 
            this.btnVinyl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnVinyl, "btnVinyl");
            this.btnVinyl.FlatAppearance.BorderSize = 0;
            this.btnVinyl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVinyl.Name = "btnVinyl";
            this.btnVinyl.UseVisualStyleBackColor = false;
            this.btnVinyl.Click += new System.EventHandler(this.btnVinyl_Click);
            // 
            // BtnFilament
            // 
            this.BtnFilament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.BtnFilament, "BtnFilament");
            this.BtnFilament.FlatAppearance.BorderSize = 0;
            this.BtnFilament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFilament.Name = "BtnFilament";
            this.BtnFilament.UseVisualStyleBackColor = false;
            this.BtnFilament.Click += new System.EventHandler(this.BtnFilament_Click);
            // 
            // btnTshirt
            // 
            this.btnTshirt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            resources.ApplyResources(this.btnTshirt, "btnTshirt");
            this.btnTshirt.FlatAppearance.BorderSize = 0;
            this.btnTshirt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTshirt.Name = "btnTshirt";
            this.btnTshirt.UseVisualStyleBackColor = false;
            this.btnTshirt.Click += new System.EventHandler(this.btnTshirt_Click);
            // 
            // btnSupplies
            // 
            resources.ApplyResources(this.btnSupplies, "btnSupplies");
            this.btnSupplies.FlatAppearance.BorderSize = 0;
            this.btnSupplies.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupplies.Name = "btnSupplies";
            this.btnSupplies.UseVisualStyleBackColor = true;
            this.btnSupplies.Click += new System.EventHandler(this.btnSupplies_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(27)))));
            this.LogoPanel.BackgroundImage = global::FirmaAPP.Properties.Resources.pidped_logo_alb;
            resources.ApplyResources(this.LogoPanel, "LogoPanel");
            this.LogoPanel.Name = "LogoPanel";
            // 
            // panelChildForms
            // 
            this.panelChildForms.BackColor = System.Drawing.Color.White;
            this.panelChildForms.BackgroundImage = global::FirmaAPP.Properties.Resources.etisst_logo_negru;
            resources.ApplyResources(this.panelChildForms, "panelChildForms");
            this.panelChildForms.Name = "panelChildForms";
            this.panelChildForms.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmMainForm_LayoutChange);
            this.panelChildForms.Resize += new System.EventHandler(this.panelChildForms_Resize);
            // 
            // frmMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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