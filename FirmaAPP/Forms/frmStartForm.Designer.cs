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
            this.cbUserName = new MetroFramework.Controls.MetroComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cbUserName
            // 
            this.cbUserName.AccessibleDescription = "";
            this.cbUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.ItemHeight = 24;
            this.cbUserName.Location = new System.Drawing.Point(23, 85);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(229, 30);
            this.cbUserName.TabIndex = 0;
            this.cbUserName.Tag = "";
            this.cbUserName.UseSelectable = true;
            this.cbUserName.SelectedIndexChanged += new System.EventHandler(this.cbUserName_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("SWSimp", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(287, 99);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(161, 53);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Înainte";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(23, 130);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(229, 22);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 186);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbUserName);
            this.MaximizeBox = false;
            this.Name = "frmStartForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Bine ai venit: ";
            this.Load += new System.EventHandler(this.frmStartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbUserName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ToolTip toolTipPassword;
    }
}