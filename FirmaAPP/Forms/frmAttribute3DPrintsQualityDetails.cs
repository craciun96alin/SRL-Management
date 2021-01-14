using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmAttribute3DPrintsQualityDetails : Form, IAttribute3DPrintsQualityDetailsView
    {
        #region PrivateMembers
        private Attribute3DPrintsQualityDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region ViewMembers
        public int Attribute3DPrintsQualityID { get; set; }

        private short _rating = 0;
        private Attribute3DPrintsQuality _attribute3DPrintsQuality;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public Attribute3DPrintsQuality Attribute3DPrintsQuality
        {
            get
            {
                _attribute3DPrintsQuality = new Attribute3DPrintsQuality
                {
                    Attribute3DPrintsQualityID = this.Attribute3DPrintsQualityID,
                    Name = tbName.Text,
                };
                return _attribute3DPrintsQuality;
            }
            set
            {
                tbName.Text = value.Name;
                Attribute3DPrintsQualityID = value.Attribute3DPrintsQualityID;
            }
        }

        public void AttachPresenter(Attribute3DPrintsQualityDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmAttribute3DPrintsQualityDetails()
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
                    _presenter.AddOrUpdateAttribute3DPrintQuality(Attribute3DPrintsQuality);
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

        private void frmAttribute3DPrintsQualityDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
