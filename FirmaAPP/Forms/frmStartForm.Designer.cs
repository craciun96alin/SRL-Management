namespace FirmaAPP
{
    partial class frmStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartForm));
            this.cbUserName = new MetroFramework.Controls.MetroComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.btnEng = new MetroFramework.Controls.MetroButton();
            this.btnRo = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbUserName
            // 
            resources.ApplyResources(this.cbUserName, "cbUserName");
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Tag = "";
            this.cbUserName.UseSelectable = true;
            this.cbUserName.SelectedIndexChanged += new System.EventHandler(this.cbUserName_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::FirmaAPP.Properties.Resources.FinalizeIcon;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // btnEng
            // 
            this.btnEng.BackgroundImage = global::FirmaAPP.Properties.Resources.uk_flag;
            resources.ApplyResources(this.btnEng, "btnEng");
            this.btnEng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEng.Name = "btnEng";
            this.btnEng.UseSelectable = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnRo
            // 
            this.btnRo.BackgroundImage = global::FirmaAPP.Properties.Resources.Flag_of_Romania;
            resources.ApplyResources(this.btnRo, "btnRo");
            this.btnRo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRo.Name = "btnRo";
            this.btnRo.UseSelectable = true;
            this.btnRo.Click += new System.EventHandler(this.btnRo_Click);
            // 
            // frmStartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnRo);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbUserName);
            this.MaximizeBox = false;
            this.Name = "frmStartForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.frmStartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbUserName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private MetroFramework.Controls.MetroButton btnRo;
        private MetroFramework.Controls.MetroButton btnEng;
    }
}