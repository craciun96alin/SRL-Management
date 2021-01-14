using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmAttributeTshirtsTypeDetails : Form, IAttributeTshirtsTypeDetailsView
    {
        #region PrivateMembers
        private AttributeTshirtsTypeDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region ViewMembers
        public int AttributeTshirtsTypeID { get; set; }

        private short _rating = 0;
        private AttributeTshirtsType _attributeTshirtsType;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public AttributeTshirtsType AttributeTshirtsType
        {
            get
            {
                _attributeTshirtsType = new AttributeTshirtsType
                {
                    AttributeTshirtsTypeID = this.AttributeTshirtsTypeID,
                    Name = tbName.Text,
                };
                return _attributeTshirtsType;
            }
            set
            {
                tbName.Text = value.Name;
                AttributeTshirtsTypeID = value.AttributeTshirtsTypeID;
            }
        }

        public void AttachPresenter(AttributeTshirtsTypeDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmAttributeTshirtsTypeDetails()
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
                    _presenter.AddOrUpdateAttributeTshirtsType(AttributeTshirtsType);
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
