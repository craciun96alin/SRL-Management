﻿using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmProviderDetails : Form, IProviderDetailsView
    {
        #region PrivateMembers
        private ProviderDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private short _rating = 0;
        private Form _parentForm;
        #endregion
        #region IFilamentDetailsViewMembers
        public int ProviderId { get; set; }

        private Provider _provider;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public Provider Provider
        {
            get
            {
                _provider = new Provider
                {
                    ProviderID = this.ProviderId,
                    Name = tbName.Text.ToString(),
                    Country = tbCountry.Text.ToString(),
                    County = tbCounty.Text.ToString(),
                    City = tbCity.Text.ToString(),
                    Adress = tbAdress.Text.ToString(),
                    CUI = tbCUI.Text.ToString(),
                    TVAPaying = rbTVAyes.Checked,
                    Phone = tbPhone.Text.ToString(),
                    IBAN = tbIBAN.Text.ToString(),
                    Rating = (Enums.Rating)_rating,
                    Description = tbDescription.Text.ToString()
                };
                return _provider;
            }
            set
            {
                ProviderId = value.ProviderID;
                tbName.Text = value.Name;
                tbCountry.Text = value.Country;
                tbCounty.Text = value.County;
                tbCity.Text = value.City;
                tbAdress.Text = value.Adress;
                tbCUI.Text = value.CUI;
                rbTVAyes.Checked = value.TVAPaying;
                rbTVAno.Checked = !value.TVAPaying;
                tbPhone.Text = value.Phone;
                tbIBAN.Text = value.IBAN;
                Enums.Rating r = Enums.ParseEnum<Enums.Rating>(value.Rating.ToString());
                _rating = (short)r;
                UpdateRating();
                tbDescription.Text = value.Description;
            }
        }

        public void AttachPresenter(ProviderDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmProviderDetails()
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
                    _presenter.AddOrUpdateProvider(Provider);
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
        private void frmProviderDetails_Load(object sender, EventArgs e)
        {
            UpdateRating();
        }
        #endregion
        #region Rating Star Configure
        private void btnStar1_Click(object sender, EventArgs e)
        {
            _rating = 1;
            btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
        }

        private void btnStar2_Click(object sender, EventArgs e)
        {
            _rating = 2;
            btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
        }

        private void btnStar3_Click(object sender, EventArgs e)
        {
            _rating = 3;
            btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
        }

        private void btnStar4_Click(object sender, EventArgs e)
        {
            _rating = 4;
            btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
        }

        private void btnStar5_Click(object sender, EventArgs e)
        {
            _rating = 5;
            btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
        }

        private void UpdateRating()
        {
            if (_rating == 0)
            {
                btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            }
            if (_rating == 1)
            {
                btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            }
            else if (_rating == 2)
            {
                btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            }
            else if (_rating == 3)
            {
                btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
                btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            }
            else if (_rating == 4)
            {
                btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOff;
            }
            else
            {
                btnStar1.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar2.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar3.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar4.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
                btnStar5.BackgroundImage = global::FirmaAPP.Properties.Resources.StarOn;
            }
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
