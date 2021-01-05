namespace FirmaAPP.Forms
{
    partial class frmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetails));
            this.panelUserInformations = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPaswordAgain = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbUserRole = new System.Windows.Forms.ComboBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panelUserInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserInformations
            // 
            resources.ApplyResources(this.panelUserInformations, "panelUserInformations");
            this.panelUserInformations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.panelUserInformations.Controls.Add(this.tbPassword);
            this.panelUserInformations.Controls.Add(this.label11);
            this.panelUserInformations.Controls.Add(this.tbPaswordAgain);
            this.panelUserInformations.Controls.Add(this.label12);
            this.panelUserInformations.Controls.Add(this.tbLastName);
            this.panelUserInformations.Controls.Add(this.label10);
            this.panelUserInformations.Controls.Add(this.lbTitle);
            this.panelUserInformations.Controls.Add(this.btnCancel);
            this.panelUserInformations.Controls.Add(this.btnConfirm);
            this.panelUserInformations.Controls.Add(this.cbUserRole);
            this.panelUserInformations.Controls.Add(this.tbFirstName);
            this.panelUserInformations.Controls.Add(this.lbType);
            this.panelUserInformations.Controls.Add(this.lbName);
            this.panelUserInformations.Name = "panelUserInformations";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Name = "label11";
            // 
            // tbPaswordAgain
            // 
            resources.ApplyResources(this.tbPaswordAgain, "tbPaswordAgain");
            this.tbPaswordAgain.Name = "tbPaswordAgain";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Name = "label12";
            // 
            // tbLastName
            // 
            resources.ApplyResources(this.tbLastName, "tbLastName");
            this.tbLastName.Name = "tbLastName";
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
            // cbUserRole
            // 
            resources.ApplyResources(this.cbUserRole, "cbUserRole");
            this.cbUserRole.FormattingEnabled = true;
            this.cbUserRole.Name = "cbUserRole";
            // 
            // tbFirstName
            // 
            resources.ApplyResources(this.tbFirstName, "tbFirstName");
            this.tbFirstName.Name = "tbFirstName";
            // 
            // lbType
            // 
            resources.ApplyResources(this.lbType, "lbType");
            this.lbType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbType.Name = "lbType";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbName.Name = "lbName";
            // 
            // frmUserDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserInformations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.panelUserInformations.ResumeLayout(false);
            this.panelUserInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserInformations;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPaswordAgain;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cbUserRole;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbName;
    }
}