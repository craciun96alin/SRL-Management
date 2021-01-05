namespace FirmaAPP
{
    partial class frmBillDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillDetails));
            this.panelBillInformations = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimeBill = new System.Windows.Forms.DateTimePicker();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBillStatus = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.panelBillInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBillInformations
            // 
            resources.ApplyResources(this.panelBillInformations, "panelBillInformations");
            this.panelBillInformations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.panelBillInformations.Controls.Add(this.label29);
            this.panelBillInformations.Controls.Add(this.dateTimeBill);
            this.panelBillInformations.Controls.Add(this.btnAddBill);
            this.panelBillInformations.Controls.Add(this.tbFile);
            this.panelBillInformations.Controls.Add(this.label1);
            this.panelBillInformations.Controls.Add(this.cbBillStatus);
            this.panelBillInformations.Controls.Add(this.lbColor);
            this.panelBillInformations.Controls.Add(this.lbTitle);
            this.panelBillInformations.Controls.Add(this.btnCancel);
            this.panelBillInformations.Controls.Add(this.btnConfirm);
            this.panelBillInformations.Controls.Add(this.tbName);
            this.panelBillInformations.Controls.Add(this.tbDescription);
            this.panelBillInformations.Controls.Add(this.lbDescription);
            this.panelBillInformations.Controls.Add(this.lbName);
            this.panelBillInformations.Name = "panelBillInformations";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label29.Name = "label29";
            // 
            // dateTimeBill
            // 
            resources.ApplyResources(this.dateTimeBill, "dateTimeBill");
            this.dateTimeBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBill.Name = "dateTimeBill";
            // 
            // tbFile
            // 
            resources.ApplyResources(this.tbFile, "tbFile");
            this.tbFile.Name = "tbFile";
            this.tbFile.TextChanged += new System.EventHandler(this.tbFile_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // cbBillStatus
            // 
            resources.ApplyResources(this.cbBillStatus, "cbBillStatus");
            this.cbBillStatus.FormattingEnabled = true;
            this.cbBillStatus.Name = "cbBillStatus";
            this.cbBillStatus.SelectedIndexChanged += new System.EventHandler(this.cbBillStatus_SelectedIndexChanged);
            // 
            // lbColor
            // 
            resources.ApplyResources(this.lbColor, "lbColor");
            this.lbColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbColor.Name = "lbColor";
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Name = "lbTitle";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            resources.ApplyResources(this.btnConfirm, "btnConfirm");
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // tbDescription
            // 
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.Name = "tbDescription";
            // 
            // lbDescription
            // 
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDescription.Name = "lbDescription";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbName.Name = "lbName";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFile, "openFile");
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
            // frmBillDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBillInformations);
            this.Name = "frmBillDetails";
            this.Load += new System.EventHandler(this.frmBillDetails_Load);
            this.panelBillInformations.ResumeLayout(false);
            this.panelBillInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBillInformations;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBillStatus;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dateTimeBill;
    }
}