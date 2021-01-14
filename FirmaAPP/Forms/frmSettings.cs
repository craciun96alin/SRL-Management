using System;
using AppContext = FirmaAPP.Common.AppContext;
using System.Collections.Generic;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using System.Drawing;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmSettings : Form , IAppSettingsView, IBusinessDetailsView
    {
        #region private members
        private AppSettingsPresenter _AppSettingsPresenter;
        private BusinessDetailsPresenter _BusinessDetailsPresenter;
        private frmMainForm _mainForm;
        #endregion
        #region IAppSettingsDetailsViewMembers
        public int AppSettingsId { get; set; }
        private AppSettings _AppSettings;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public AppSettings AppSettings
        {
            get
            {
                _AppSettings = new AppSettings
                {
                    _3DDesignFolder = tb3DDesignFolderPath.Text,
                    _3DPrintFolder= tb3DPrintFolderPath.Text,
                    BillFolder = tbBillFolderPath.Text,
                    UserID = AppContext.CurrentUserId,
                    AppSettingsID = _AppSettingsPresenter.GetIDByUserID(AppContext.CurrentUserId)
                    
                };
                return _AppSettings;
            }
            set
            {
                tbBillFolderPath.Text = AppContext.FolderBillPath;
                tb3DPrintFolderPath.Text = AppContext.Folder3DPrintPath;
                tb3DDesignFolderPath.Text = AppContext.Folder3DDesignPath;
            }
        }

        public void AttachPresenter(AppSettingsPresenter presenter)
        {
            _AppSettingsPresenter = presenter;
        }
        #endregion
        #region IBusinessDetailsView
        public int BusinessDetailsId { get; set; }
        private BusinessDetails _BusinessDetails;
        public void AttachBusinessDetailsPresenter(BusinessDetailsPresenter presenter)
        {
            _BusinessDetailsPresenter = presenter;
        }
        public BusinessDetails BusinessDetails
        {
            get
            {
                _BusinessDetails = new BusinessDetails
                {
                    Name = tbBusinessName.Text,
                    CUI = tbCUI.Text,
                    IBAN = tbIBAN.Text,
                    Country = tbCountry.Text,
                    City = tbCity.Text,
                    County = tbCounty.Text,
                    Address = tbAddress.Text,
                    NrReg = tbNrReg.Text,
                    TVAPaying = rbTVAyes.Checked,
                    DigitalMoney = (float)numericDigitalMoney.Value,
                    CashMoney = (float)numericCashMoney.Value,
                    ExtraMoney = (float)numericExtraMoney.Value,
                    UserID = AppContext.CurrentUserId,
                    BusinessDetailsID = _BusinessDetailsPresenter.GetIDByUserID(AppContext.CurrentUserId)
                };
                return _BusinessDetails;
            }
            set
            {
                if(value != null)
                {
                    tbBusinessName.Text = value.Name;
                    tbCUI.Text = value.CUI;
                    tbIBAN.Text = value.IBAN;
                    tbCountry.Text = value.Country;
                    tbCity.Text = value.City;
                    tbCounty.Text = value.County;
                    tbAddress.Text = value.Address;
                    tbNrReg.Text = value.NrReg;
                    rbTVAyes.Checked = value.TVAPaying;
                    rbTVAno.Checked = !value.TVAPaying;
                    numericDigitalMoney.Value = (decimal)value.DigitalMoney;
                    numericCashMoney.Value = (decimal)value.CashMoney;
                    numericExtraMoney.Value = (decimal)value.ExtraMoney;
                }
            }
        }
        #endregion
        #region constructor
        public frmSettings()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        #region Bill
        private void btnBillSettings_Click(object sender, EventArgs e)
        {
            panelBillDetails.Visible = !panelBillDetails.Visible;
            if (panelBillDetails.Visible)
                btnBillSettings.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnBillSettings.BackColor = Color.FromArgb(12, 7, 18);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultFile = openFolder.ShowDialog();
                if (resultFile == DialogResult.OK)
                {
                    tbBillFolderPath.Text = openFolder.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        #endregion
        #region BusinessDetails
        private void btnBusinessDetails_Click(object sender, EventArgs e)
        {
            panelBusinessDetails.Visible = !panelBusinessDetails.Visible;
            if (panelBusinessDetails.Visible)
                btnBusinessDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnBusinessDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        #endregion
        #region 3D
        private void btn3DSettings_Click(object sender, EventArgs e)
        {
            panel3DDetails.Visible = !panel3DDetails.Visible;
            if (panel3DDetails.Visible)
                btn3DSettings.BackColor = Color.FromArgb(26, 117, 255);
            else
                btn3DSettings.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAdd3DDesignFolder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultFile = openFolder.ShowDialog();
                if (resultFile == DialogResult.OK)
                {
                    tb3DDesignFolderPath.Text = openFolder.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btn3DPrintFolder_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultFile = openFolder.ShowDialog();
                if (resultFile == DialogResult.OK)
                {
                    tb3DPrintFolderPath.Text = openFolder.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        #endregion
        #region AppSettings
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _BusinessDetailsPresenter.AddUpdateBusinessDetails(BusinessDetails);
                _AppSettingsPresenter.AddUpdateSettings(AppSettings);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                AppContext.ActiveForms.Add(this);
                _AppSettingsPresenter.Init();
                _BusinessDetailsPresenter.Init();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        #endregion
        #endregion

        #region public functions
        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }

        #endregion


        private void btnColors_Click(object sender, EventArgs e)
        {
            frmAttributeColorsList childForm = new frmAttributeColorsList();
            AttributeColorListPresenter presenter = new AttributeColorListPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            //childForm.AttachParentForm();
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.ShowDialog();
        }

        private void btnVinylsType_Click(object sender, EventArgs e)
        {
            frmAttributeVinylsTypeList childForm = new frmAttributeVinylsTypeList();
            AttributeVinylsTypeListPresenter presenter = new AttributeVinylsTypeListPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            //childForm.AttachParentForm();
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.ShowDialog();
        }

        private void btnAttributes_Click(object sender, EventArgs e)
        {
            panelAttribute.Visible = !panelAttribute.Visible;
            if (panelAttribute.Visible)
                btnAttributes.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnAttributes.BackColor = Color.FromArgb(12, 7, 18);
        }

        private void btnTshirtsType_Click(object sender, EventArgs e)
        {
            frmAttributeTshirtsTypeList childForm = new frmAttributeTshirtsTypeList();
            AttributeTshirtsTypeListPresenter presenter = new AttributeTshirtsTypeListPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            //childForm.AttachParentForm();
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.ShowDialog();
        }

        private void btnFilamentsType_Click(object sender, EventArgs e)
        {
            frmAttributeFilamentsTypeList childForm = new frmAttributeFilamentsTypeList();
            AttributeFilamentsTypeListPresenter presenter = new AttributeFilamentsTypeListPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            //childForm.AttachParentForm();
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.ShowDialog();
        }

        private void btn3DPrintsQuality_Click(object sender, EventArgs e)
        {
            frmAttribute3DPrintsQualityList childForm = new frmAttribute3DPrintsQualityList();
            Attribute3DPrintsQualityListPresenter presenter = new Attribute3DPrintsQualityListPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            //childForm.AttachParentForm();
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppTranslations.CancelConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
