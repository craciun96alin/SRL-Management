using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmAttributeColorDetails : Form, IAttributeColorDetailsView
    {
        #region PrivateMembers
        private AttributeColorDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region ViewMembers
        public int AttributeColorID { get; set; }

        private short _rating = 0;
        private AttributeColor _attributeColor;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public AttributeColor AttributeColor
        {
            get
            {
                _attributeColor = new AttributeColor
                {
                    AttributeColorID = this.AttributeColorID,
                    Name = tbName.Text,
                };
                return _attributeColor;
            }
            set
            {
                tbName.Text = value.Name;
                AttributeColorID = value.AttributeColorID;
            }
        }

        public void AttachPresenter(AttributeColorDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmAttributeColorDetails()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(AppTranslations.MessageBoxInfoConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.AddOrUpdateAttributeColor(AttributeColor);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                if (ex.Message.Contains(AppTranslations.SuccesInfoBox))
                    this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppTranslations.CancelConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        #endregion
        #region public functions
        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }

        public void AttachParentForm(Form form)
        {
            _parentForm = form;
        }
        #endregion
    }
}
