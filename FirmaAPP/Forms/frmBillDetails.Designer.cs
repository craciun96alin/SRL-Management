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
            this.panelBillInformations = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimeBill = new System.Windows.Forms.DateTimePicker();
            this.btnAddBill = new System.Windows.Forms.Button();
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
            this.panelBillInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBillInformations
            // 
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
            this.panelBillInformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillInformations.Location = new System.Drawing.Point(0, 0);
            this.panelBillInformations.Name = "panelBillInformations";
            this.panelBillInformations.Size = new System.Drawing.Size(558, 502);
            this.panelBillInformations.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label29.Location = new System.Drawing.Point(12, 246);
            this.label29.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 33);
            this.label29.TabIndex = 85;
            this.label29.Text = "*Dată:";
            // 
            // dateTimeBill
            // 
            this.dateTimeBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBill.Location = new System.Drawing.Point(171, 252);
            this.dateTimeBill.Name = "dateTimeBill";
            this.dateTimeBill.Size = new System.Drawing.Size(329, 22);
            this.dateTimeBill.TabIndex = 84;
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackgroundImage = global::FirmaAPP.Properties.Resources.Add3Icon;
            this.btnAddBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddBill.FlatAppearance.BorderSize = 0;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBill.Location = new System.Drawing.Point(511, 204);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(31, 33);
            this.btnAddBill.TabIndex = 62;
            this.btnAddBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // tbFile
            // 
            this.tbFile.Enabled = false;
            this.tbFile.Location = new System.Drawing.Point(171, 210);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(329, 22);
            this.tbFile.TabIndex = 24;
            this.tbFile.TextChanged += new System.EventHandler(this.tbFile_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "*Fișier:";
            // 
            // cbBillStatus
            // 
            this.cbBillStatus.FormattingEnabled = true;
            this.cbBillStatus.Location = new System.Drawing.Point(171, 164);
            this.cbBillStatus.Name = "cbBillStatus";
            this.cbBillStatus.Size = new System.Drawing.Size(329, 24);
            this.cbBillStatus.TabIndex = 22;
            this.cbBillStatus.SelectedIndexChanged += new System.EventHandler(this.cbBillStatus_SelectedIndexChanged);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbColor.Location = new System.Drawing.Point(12, 156);
            this.lbColor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(110, 34);
            this.lbColor.TabIndex = 21;
            this.lbColor.Text = "*Status:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(138, 28);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(307, 57);
            this.lbTitle.TabIndex = 20;
            this.lbTitle.Text = "Detalii factură";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(421, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Renunță";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(314, 448);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 32);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirmă";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(171, 119);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(329, 22);
            this.tbName.TabIndex = 7;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(171, 291);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(329, 140);
            this.tbDescription.TabIndex = 6;
            this.tbDescription.Text = "";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDescription.Location = new System.Drawing.Point(12, 291);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(128, 33);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = "Descriere:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbName.Location = new System.Drawing.Point(12, 113);
            this.lbName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(103, 33);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "*Nume:";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // frmBillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 502);
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