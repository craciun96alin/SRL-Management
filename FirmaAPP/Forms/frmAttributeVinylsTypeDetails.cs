using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmAttributeVinylsTypeDetails : Form, IAttributeVinylsTypeDetailsView
    {
        #region PrivateMembers
        private AttributeVinylsTypeDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region ViewMembers
        public int AttributeVinylsTypeID { get; set; }

        private short _rating = 0;
        private AttributeVinylsType _attributeVinylsType;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public AttributeVinylsType AttributeVinylsType
        {
            get
            {
                _attributeVinylsType = new AttributeVinylsType
                {
                    AttributeVinylsTypeID = this.AttributeVinylsTypeID,
                    Name = tbName.Text,
                };
                return _attributeVinylsType;
            }
            set
            {
                tbName.Text = value.Name;
                AttributeVinylsTypeID = value.AttributeVinylsTypeID;
            }
        }

        public void AttachPresenter(AttributeVinylsTypeDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmAttributeVinylsTypeDetails()
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
                    _presenter.AddOrUpdateAttributeVinylsType(AttributeVinylsType);
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
