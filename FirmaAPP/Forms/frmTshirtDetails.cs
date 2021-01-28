using System;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmTshirtDetails : Form, ITshirtDetailsView
    {
        #region PrivateMembers
        private TshirtDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region IVinylDetailsViewMembers
        public int TshirtId { get; set; }

        private short _rating = 0;
        private Tshirt _tshirt;

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public Tshirt Tshirt
        {
            get
            {
                _tshirt = new Tshirt
                {
                    Name = tbName.Text,
                    TshirtID = this.TshirtId,
                    Size = Enums.ParseEnum<Enums.TshirtSize>(cbSize.SelectedValue.ToString()),
                    Sex = Enums.ParseEnum<Enums.Sex>(cbSex.SelectedValue.ToString()),
                    Stock = (int)numericUpDownStock.Value,
                    Rating = (Enums.Rating)_rating,
                    Description = tbDescription.Text
                };
                if (cbProvider.SelectedValue != null)
                    _tshirt.Provider = _presenter.GetProviderByName(cbProvider.SelectedValue.ToString());
                _tshirt.ProviderID = _tshirt.Provider != null ? _tshirt.Provider.ProviderID : (int?)null;

                if (cbColor.SelectedValue != null)
                    _tshirt.Color = _presenter.GetColorAttributeByName(cbColor.SelectedValue.ToString());
                _tshirt.AttributeColorID = _tshirt.Color != null ? _tshirt.Color.AttributeColorID : (int?)null;

                if (cbType.SelectedValue != null)
                    _tshirt.Type = _presenter.GetTshirtsTypeAttributeByName(cbType.SelectedValue.ToString());
                _tshirt.AttributeTshirtsTypeID = _tshirt.Type != null ? _tshirt.Type.AttributeTshirtsTypeID : (int?)null;

                return _tshirt;
            }
            set
            {
                tbName.Text = value.Name;
                cbSize.SelectedIndex = (short)Enums.ParseEnum<Enums.TshirtSize>(value.Size.ToString());
                cbSex.SelectedIndex = (short)Enums.ParseEnum<Enums.Sex>(value.Sex.ToString());
                numericUpDownStock.Value = (decimal)value.Stock;
                Enums.Rating r = Enums.ParseEnum<Enums.Rating>(value.Rating.ToString());
                _rating = (short)r;
                UpdateRating();
                tbDescription.Text = value.Description;
                TshirtId = value.TshirtID;

                if(cbProvider.Items.Count > 0)
                    cbProvider.SelectedIndex = value.Provider != null ? cbProvider.FindStringExact(value.Provider.Name) : 0;

                if (cbColor.Items.Count > 0)
                    cbColor.SelectedIndex = value.Color != null ? cbColor.FindStringExact(value.Color.Name) : 0;

                if (cbType.Items.Count > 0)
                    cbType.SelectedIndex = value.Type != null ? cbType.FindStringExact(value.Type.Name) : 0;
            }
        }

        public void AttachPresenter(TshirtDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmTshirtDetails()
        {
            InitializeComponent();
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
        #region Events
        private void frmTshirtDetails_Load(object sender, EventArgs e)
        {
            UpdateRating();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppTranslations.CancelConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(AppTranslations.MessageBoxInfoConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.AddOrUpdateTshirt(Tshirt);
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
        private void btnAddNewProvider_Click(object sender, EventArgs e)
        {
            frmProviderDetails childForm = new frmProviderDetails();
            ProviderDetailsPresenter presenter = new ProviderDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Provider = new Provider();
            childForm.ShowDialog();
        }
        private void btnAddNewTshirtsType_Click(object sender, EventArgs e)
        {
            frmAttributeTshirtsTypeDetails childForm = new frmAttributeTshirtsTypeDetails();
            AttributeTshirtsTypeDetailsPresenter presenter = new AttributeTshirtsTypeDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.AttributeTshirtsType = new AttributeTshirtsType();
            childForm.ShowDialog();
        }

        private void btnAddNewColor_Click(object sender, EventArgs e)
        {
            frmAttributeColorDetails childForm = new frmAttributeColorDetails();
            AttributeColorDetailsPresenter presenter = new AttributeColorDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.AttributeColor = new AttributeColor();
            childForm.ShowDialog();
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
        public void Init()
        {
            try
            {
                cbSize.DataSource = Enum.GetNames(typeof(Common.Enums.TshirtSize));
                cbSex.DataSource = Enum.GetNames(typeof(Common.Enums.Sex));
                cbType.DataSource = _presenter.GetAllAttributeTshirtsTypeNames();
                cbColor.DataSource = _presenter.GetAllAttributeColorNames();
                cbProvider.DataSource = _presenter.GetAllProvidersName();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                this.Close();
            }
        }
        #endregion
        #region override functions
        public override void Refresh()
        {
            this.Init();
        }
        #endregion
    }
}
