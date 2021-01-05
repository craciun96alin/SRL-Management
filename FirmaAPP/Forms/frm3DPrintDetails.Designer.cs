namespace FirmaAPP
{
    partial class frm3DPrintDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3DPrintDetails));
            this.panel3DPrintInformations = new System.Windows.Forms.Panel();
            this.dateTime3DPrint = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb3DDesign = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbRating = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnNoDesign = new System.Windows.Forms.Button();
            this.btnAdd3DPrint = new System.Windows.Forms.Button();
            this.btnStar5 = new System.Windows.Forms.Button();
            this.btnStar4 = new System.Windows.Forms.Button();
            this.btnStar3 = new System.Windows.Forms.Button();
            this.btnStar2 = new System.Windows.Forms.Button();
            this.btnStar1 = new System.Windows.Forms.Button();
            this.panel3DPrintInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3DPrintInformations
            // 
            resources.ApplyResources(this.panel3DPrintInformations, "panel3DPrintInformations");
            this.panel3DPrintInformations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.panel3DPrintInformations.Controls.Add(this.btnNoDesign);
            this.panel3DPrintInformations.Controls.Add(this.dateTime3DPrint);
            this.panel3DPrintInformations.Controls.Add(this.label2);
            this.panel3DPrintInformations.Controls.Add(this.btnAdd3DPrint);
            this.panel3DPrintInformations.Controls.Add(this.tbGCode);
            this.panel3DPrintInformations.Controls.Add(this.label1);
            this.panel3DPrintInformations.Controls.Add(this.cb3DDesign);
            this.panel3DPrintInformations.Controls.Add(this.label10);
            this.panel3DPrintInformations.Controls.Add(this.lbTitle);
            this.panel3DPrintInformations.Controls.Add(this.btnCancel);
            this.panel3DPrintInformations.Controls.Add(this.btnConfirm);
            this.panel3DPrintInformations.Controls.Add(this.btnStar5);
            this.panel3DPrintInformations.Controls.Add(this.btnStar4);
            this.panel3DPrintInformations.Controls.Add(this.btnStar3);
            this.panel3DPrintInformations.Controls.Add(this.btnStar2);
            this.panel3DPrintInformations.Controls.Add(this.btnStar1);
            this.panel3DPrintInformations.Controls.Add(this.tbName);
            this.panel3DPrintInformations.Controls.Add(this.tbDescription);
            this.panel3DPrintInformations.Controls.Add(this.lbDescription);
            this.panel3DPrintInformations.Controls.Add(this.lbRating);
            this.panel3DPrintInformations.Controls.Add(this.lbName);
            this.panel3DPrintInformations.Name = "panel3DPrintInformations";
            // 
            // dateTime3DPrint
            // 
            resources.ApplyResources(this.dateTime3DPrint, "dateTime3DPrint");
            this.dateTime3DPrint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime3DPrint.Name = "dateTime3DPrint";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // tbGCode
            // 
            resources.ApplyResources(this.tbGCode, "tbGCode");
            this.tbGCode.Name = "tbGCode";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // cb3DDesign
            // 
            resources.ApplyResources(this.cb3DDesign, "cb3DDesign");
            this.cb3DDesign.FormattingEnabled = true;
            this.cb3DDesign.Name = "cb3DDesign";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Name = "label10";
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // lbRating
            // 
            resources.ApplyResources(this.lbRating, "lbRating");
            this.lbRating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRating.Name = "lbRating";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbName.Name = "lbName";
            // 
            // openFile
            // 
            resources.ApplyResources(this.openFile, "openFile");
            // 
            // btnNoDesign
            // 
            resources.ApplyResources(this.btnNoDesign, "btnNoDesign");
            this.btnNoDesign.BackgroundImage = global::FirmaAPP.Properties.Resources.none_icon;
            this.btnNoDesign.FlatAppearance.BorderSize = 0;
            this.btnNoDesign.Name = "btnNoDesign";
            this.btnNoDesign.UseVisualStyleBackColor = true;
            this.btnNoDesign.Click += new System.EventHandler(this.btnNoDesign_Click);
            // 
            // btnAdd3DPrint
            // 
            resources.ApplyResources(this.btnAdd3DPrint, "btnAdd3DPrint");
            this.btnAdd3DPrint.BackgroundImage = global::FirmaAPP.Properties.Resources.Add3Icon;
            this.btnAdd3DPrint.FlatAppearance.BorderSize = 0;
            this.btnAdd3DPrint.Name = "btnAdd3DPrint";
            this.btnAdd3DPrint.UseVisualStyleBackColor = true;
            this.btnAdd3DPrint.Click += new System.EventHandler(this.btnAdd3DPrint_Click);
            // 
            // btnStar5
            // 
            resources.ApplyResources(this.btnStar5, "btnStar5");
            this.btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            this.btnStar5.Name = "btnStar5";
            this.btnStar5.UseVisualStyleBackColor = true;
            this.btnStar5.Click += new System.EventHandler(this.btnStar5_Click);
            // 
            // btnStar4
            // 
            resources.ApplyResources(this.btnStar4, "btnStar4");
            this.btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            this.btnStar4.Name = "btnStar4";
            this.btnStar4.UseVisualStyleBackColor = true;
            this.btnStar4.Click += new System.EventHandler(this.btnStar4_Click);
            // 
            // btnStar3
            // 
            resources.ApplyResources(this.btnStar3, "btnStar3");
            this.btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            this.btnStar3.Name = "btnStar3";
            this.btnStar3.UseVisualStyleBackColor = true;
            this.btnStar3.Click += new System.EventHandler(this.btnStar3_Click);
            // 
            // btnStar2
            // 
            resources.ApplyResources(this.btnStar2, "btnStar2");
            this.btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            this.btnStar2.Name = "btnStar2";
            this.btnStar2.UseVisualStyleBackColor = true;
            this.btnStar2.Click += new System.EventHandler(this.btnStar2_Click);
            // 
            // btnStar1
            // 
            resources.ApplyResources(this.btnStar1, "btnStar1");
            this.btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            this.btnStar1.Name = "btnStar1";
            this.btnStar1.UseVisualStyleBackColor = true;
            this.btnStar1.Click += new System.EventHandler(this.btnStar1_Click);
            // 
            // frm3DPrintDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3DPrintInformations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm3DPrintDetails";
            this.Load += new System.EventHandler(this.frm3DPrintDetails_Load);
            this.panel3DPrintInformations.ResumeLayout(false);
            this.panel3DPrintInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3DPrintInformations;
        private System.Windows.Forms.ComboBox cb3DDesign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnStar5;
        private System.Windows.Forms.Button btnStar4;
        private System.Windows.Forms.Button btnStar3;
        private System.Windows.Forms.Button btnStar2;
        private System.Windows.Forms.Button btnStar1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbGCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd3DPrint;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTime3DPrint;
        private System.Windows.Forms.Button btnNoDesign;
    }
}