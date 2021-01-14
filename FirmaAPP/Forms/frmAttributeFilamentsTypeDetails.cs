using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmAttributeFilamentsTypeDetails : Form, IAttributeFilamentsTypeDetailsView
    {
        #region PrivateMembers
        private AttributeFilamentsTypeDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region ViewMembers
        public int AttributeFilamentsTypeID { get; set; }

        private short _rating = 0;
        private AttributeFilamentsType _attributeFilamentsType;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public AttributeFilamentsType AttributeFilamentsType
        {
            get
            {
                _attributeFilamentsType = new AttributeFilamentsType
                {
                    AttributeFilamentsTypeID = this.AttributeFilamentsTypeID,
                    Name = tbName.Text,
                };
                return _attributeFilamentsType;
            }
            set
            {
                tbName.Text = value.Name;
                AttributeFilamentsTypeID = value.AttributeFilamentsTypeID;
            }
        }

        public void AttachPresenter(AttributeFilamentsTypeDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmAttributeFilamentsTypeDetails()
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
                    _presenter.AddOrUpdateAttributeFilamentsType(AttributeFilamentsType);
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
