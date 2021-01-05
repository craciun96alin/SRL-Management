namespace FirmaAPP
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.panelMainSettings = new System.Windows.Forms.Panel();
            this.panelAddCancelButtons = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelBusinessDetails = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numericExtraMoney = new System.Windows.Forms.NumericUpDown();
            this.numericCashMoney = new System.Windows.Forms.NumericUpDown();
            this.numericDigitalMoney = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNrReg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbTVAno = new System.Windows.Forms.RadioButton();
            this.rbTVAyes = new System.Windows.Forms.RadioButton();
            this.tbAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCUI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBusinessName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBusinessDetails = new System.Windows.Forms.Button();
            this.panel3DDetails = new System.Windows.Forms.Panel();
            this.tb3DPrintFolderPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb3DDesignFolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn3DSettings = new System.Windows.Forms.Button();
            this.panelBillDetails = new System.Windows.Forms.Panel();
            this.tbBillFolderPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBillSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btn3DPrintFolder = new System.Windows.Forms.Button();
            this.btnAdd3DDesignFolder = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.panelMainSettings.SuspendLayout();
            this.panelAddCancelButtons.SuspendLayout();
            this.panelBusinessDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExtraMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCashMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDigitalMoney)).BeginInit();
            this.panel3DDetails.SuspendLayout();
            this.panelBillDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainSettings
            // 
            resources.ApplyResources(this.panelMainSettings, "panelMainSettings");
            this.panelMainSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.panelMainSettings.Controls.Add(this.panelAddCancelButtons);
            this.panelMainSettings.Controls.Add(this.panelBusinessDetails);
            this.panelMainSettings.Controls.Add(this.btnBusinessDetails);
            this.panelMainSettings.Controls.Add(this.panel3DDetails);
            this.panelMainSettings.Controls.Add(this.btn3DSettings);
            this.panelMainSettings.Controls.Add(this.panelBillDetails);
            this.panelMainSettings.Controls.Add(this.btnBillSettings);
            this.panelMainSettings.Controls.Add(this.panel1);
            this.panelMainSettings.Name = "panelMainSettings";
            // 
            // panelAddCancelButtons
            // 
            resources.ApplyResources(this.panelAddCancelButtons, "panelAddCancelButtons");
            this.panelAddCancelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.panelAddCancelButtons.Controls.Add(this.btnConfirm);
            this.panelAddCancelButtons.Controls.Add(this.btnCancel);
            this.panelAddCancelButtons.Name = "panelAddCancelButtons";
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // panelBusinessDetails
            // 
            resources.ApplyResources(this.panelBusinessDetails, "panelBusinessDetails");
            this.panelBusinessDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.panelBusinessDetails.Controls.Add(this.label18);
            this.panelBusinessDetails.Controls.Add(this.label17);
            this.panelBusinessDetails.Controls.Add(this.label16);
            this.panelBusinessDetails.Controls.Add(this.numericExtraMoney);
            this.panelBusinessDetails.Controls.Add(this.numericCashMoney);
            this.panelBusinessDetails.Controls.Add(this.numericDigitalMoney);
            this.panelBusinessDetails.Controls.Add(this.label13);
            this.panelBusinessDetails.Controls.Add(this.label14);
            this.panelBusinessDetails.Controls.Add(this.label15);
            this.panelBusinessDetails.Controls.Add(this.tbNrReg);
            this.panelBusinessDetails.Controls.Add(this.label12);
            this.panelBusinessDetails.Controls.Add(this.tbIBAN);
            this.panelBusinessDetails.Controls.Add(this.label9);
            this.panelBusinessDetails.Controls.Add(this.label7);
            this.panelBusinessDetails.Controls.Add(this.rbTVAno);
            this.panelBusinessDetails.Controls.Add(this.rbTVAyes);
            this.panelBusinessDetails.Controls.Add(this.tbAddress);
            this.panelBusinessDetails.Controls.Add(this.label5);
            this.panelBusinessDetails.Controls.Add(this.tbCity);
            this.panelBusinessDetails.Controls.Add(this.label6);
            this.panelBusinessDetails.Controls.Add(this.tbCounty);
            this.panelBusinessDetails.Controls.Add(this.label8);
            this.panelBusinessDetails.Controls.Add(this.tbCountry);
            this.panelBusinessDetails.Controls.Add(this.label11);
            this.panelBusinessDetails.Controls.Add(this.tbCUI);
            this.panelBusinessDetails.Controls.Add(this.label3);
            this.panelBusinessDetails.Controls.Add(this.tbBusinessName);
            this.panelBusinessDetails.Controls.Add(this.label4);
            this.panelBusinessDetails.Name = "panelBusinessDetails";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Name = "label17";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Name = "label16";
            // 
            // numericExtraMoney
            // 
            resources.ApplyResources(this.numericExtraMoney, "numericExtraMoney");
            this.numericExtraMoney.DecimalPlaces = 2;
            this.numericExtraMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericExtraMoney.Name = "numericExtraMoney";
            // 
            // numericCashMoney
            // 
            resources.ApplyResources(this.numericCashMoney, "numericCashMoney");
            this.numericCashMoney.DecimalPlaces = 2;
            this.numericCashMoney.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericCashMoney.Name = "numericCashMoney";
            // 
            // numericDigitalMoney
            // 
            resources.ApplyResources(this.numericDigitalMoney, "numericDigitalMoney");
            this.numericDigitalMoney.DecimalPlaces = 2;
            this.numericDigitalMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericDigitalMoney.Name = "numericDigitalMoney";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Name = "label15";
            // 
            // tbNrReg
            // 
            resources.ApplyResources(this.tbNrReg, "tbNrReg");
            this.tbNrReg.Name = "tbNrReg";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Name = "label12";
            // 
            // tbIBAN
            // 
            resources.ApplyResources(this.tbIBAN, "tbIBAN");
            this.tbIBAN.Name = "tbIBAN";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            // 
            // rbTVAno
            // 
            resources.ApplyResources(this.rbTVAno, "rbTVAno");
            this.rbTVAno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbTVAno.Name = "rbTVAno";
            this.rbTVAno.TabStop = true;
            this.rbTVAno.UseVisualStyleBackColor = true;
            // 
            // rbTVAyes
            // 
            resources.ApplyResources(this.rbTVAyes, "rbTVAyes");
            this.rbTVAyes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbTVAyes.Name = "rbTVAyes";
            this.rbTVAyes.TabStop = true;
            this.rbTVAyes.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            resources.ApplyResources(this.tbAddress, "tbAddress");
            this.tbAddress.Name = "tbAddress";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            // 
            // tbCity
            // 
            resources.ApplyResources(this.tbCity, "tbCity");
            this.tbCity.Name = "tbCity";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Name = "label6";
            // 
            // tbCounty
            // 
            resources.ApplyResources(this.tbCounty, "tbCounty");
            this.tbCounty.Name = "tbCounty";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Name = "label8";
            // 
            // tbCountry
            // 
            resources.ApplyResources(this.tbCountry, "tbCountry");
            this.tbCountry.Name = "tbCountry";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Name = "label11";
            // 
            // tbCUI
            // 
            resources.ApplyResources(this.tbCUI, "tbCUI");
            this.tbCUI.Name = "tbCUI";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // tbBusinessName
            // 
            resources.ApplyResources(this.tbBusinessName, "tbBusinessName");
            this.tbBusinessName.Name = "tbBusinessName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // btnBusinessDetails
            // 
            resources.ApplyResources(this.btnBusinessDetails, "btnBusinessDetails");
            this.btnBusinessDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.btnBusinessDetails.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusinessDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(102)))));
            this.btnBusinessDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBusinessDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusinessDetails.Name = "btnBusinessDetails";
            this.btnBusinessDetails.UseVisualStyleBackColor = false;
            this.btnBusinessDetails.Click += new System.EventHandler(this.btnBusinessDetails_Click);
            // 
            // panel3DDetails
            // 
            resources.ApplyResources(this.panel3DDetails, "panel3DDetails");
            this.panel3DDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.panel3DDetails.Controls.Add(this.btn3DPrintFolder);
            this.panel3DDetails.Controls.Add(this.tb3DPrintFolderPath);
            this.panel3DDetails.Controls.Add(this.label2);
            this.panel3DDetails.Controls.Add(this.btnAdd3DDesignFolder);
            this.panel3DDetails.Controls.Add(this.tb3DDesignFolderPath);
            this.panel3DDetails.Controls.Add(this.label1);
            this.panel3DDetails.Name = "panel3DDetails";
            // 
            // tb3DPrintFolderPath
            // 
            resources.ApplyResources(this.tb3DPrintFolderPath, "tb3DPrintFolderPath");
            this.tb3DPrintFolderPath.Name = "tb3DPrintFolderPath";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // tb3DDesignFolderPath
            // 
            resources.ApplyResources(this.tb3DDesignFolderPath, "tb3DDesignFolderPath");
            this.tb3DDesignFolderPath.Name = "tb3DDesignFolderPath";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // btn3DSettings
            // 
            resources.ApplyResources(this.btn3DSettings, "btn3DSettings");
            this.btn3DSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.btn3DSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3DSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(102)))));
            this.btn3DSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btn3DSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3DSettings.Name = "btn3DSettings";
            this.btn3DSettings.UseVisualStyleBackColor = false;
            this.btn3DSettings.Click += new System.EventHandler(this.btn3DSettings_Click);
            // 
            // panelBillDetails
            // 
            resources.ApplyResources(this.panelBillDetails, "panelBillDetails");
            this.panelBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.panelBillDetails.Controls.Add(this.btnAddBill);
            this.panelBillDetails.Controls.Add(this.tbBillFolderPath);
            this.panelBillDetails.Controls.Add(this.label10);
            this.panelBillDetails.Name = "panelBillDetails";
            // 
            // tbBillFolderPath
            // 
            resources.ApplyResources(this.tbBillFolderPath, "tbBillFolderPath");
            this.tbBillFolderPath.Name = "tbBillFolderPath";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Name = "label10";
            // 
            // btnBillSettings
            // 
            resources.ApplyResources(this.btnBillSettings, "btnBillSettings");
            this.btnBillSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBillSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBillSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(102)))));
            this.btnBillSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBillSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBillSettings.Name = "btnBillSettings";
            this.btnBillSettings.UseVisualStyleBackColor = false;
            this.btnBillSettings.Click += new System.EventHandler(this.btnBillSettings_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Name = "panel1";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Name = "lbTitle";
            // 
            // openFolder
            // 
            resources.ApplyResources(this.openFolder, "openFolder");
            // 
            // btn3DPrintFolder
            // 
            resources.ApplyResources(this.btn3DPrintFolder, "btn3DPrintFolder");
            this.btn3DPrintFolder.BackgroundImage = global::FirmaAPP.Properties.Resources.Add3Icon;
            this.btn3DPrintFolder.FlatAppearance.BorderSize = 0;
            this.btn3DPrintFolder.Name = "btn3DPrintFolder";
            this.btn3DPrintFolder.UseVisualStyleBackColor = true;
            this.btn3DPrintFolder.Click += new System.EventHandler(this.btn3DPrintFolder_Click);
            // 
            // btnAdd3DDesignFolder
            // 
            resources.ApplyResources(this.btnAdd3DDesignFolder, "btnAdd3DDesignFolder");
            this.btnAdd3DDesignFolder.BackgroundImage = global::FirmaAPP.Properties.Resources.Add3Icon;
            this.btnAdd3DDesignFolder.FlatAppearance.BorderSize = 0;
            this.btnAdd3DDesignFolder.Name = "btnAdd3DDesignFolder";
            this.btnAdd3DDesignFolder.UseVisualStyleBackColor = true;
            this.btnAdd3DDesignFolder.Click += new System.EventHandler(this.btnAdd3DDesignFolder_Click);
            // 
            // btnAddBill
            // 
            resources.ApplyResources(this.btnAddBill, "btnAddBill");
            this.btnAddBill.BackgroundImage = global::FirmaAPP.Properties.Resources.Add3Icon;
            this.btnAddBill.FlatAppearance.BorderSize = 0;
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // frmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMainSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSettings_FormClosed);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panelMainSettings.ResumeLayout(false);
            this.panelAddCancelButtons.ResumeLayout(false);
            this.panelBusinessDetails.ResumeLayout(false);
            this.panelBusinessDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExtraMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCashMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDigitalMoney)).EndInit();
            this.panel3DDetails.ResumeLayout(false);
            this.panel3DDetails.PerformLayout();
            this.panelBillDetails.ResumeLayout(false);
            this.panelBillDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelBillDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBillSettings;
        private System.Windows.Forms.TextBox tbBillFolderPath;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Panel panel3DDetails;
        private System.Windows.Forms.Button btn3DPrintFolder;
        private System.Windows.Forms.TextBox tb3DPrintFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd3DDesignFolder;
        private System.Windows.Forms.TextBox tb3DDesignFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn3DSettings;
        private System.Windows.Forms.FolderBrowserDialog openFolder;
        private System.Windows.Forms.Panel panelBusinessDetails;
        private System.Windows.Forms.TextBox tbCUI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBusinessName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBusinessDetails;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericExtraMoney;
        private System.Windows.Forms.NumericUpDown numericCashMoney;
        private System.Windows.Forms.NumericUpDown numericDigitalMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNrReg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbTVAno;
        private System.Windows.Forms.RadioButton rbTVAyes;
        private System.Windows.Forms.RichTextBox tbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelAddCancelButtons;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}