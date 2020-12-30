using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.IO;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frm3DPrintDetails : Form, I3DPrintDetailsView
    {
        #region private members
        private _3DPrintDetailsPresenter _presenter;
        private short _rating;
        private Form _parentForm;
        private frmMainForm _mainForm;
        private _3DPrint _3dPrint;
        private byte[] _GCode;
        #endregion
        #region View
        public int _3DPrintID { get; set; }
        public _3DPrint _3DPrint
        {
            get
            {
                _3dPrint = new _3DPrint
                {
                    _3DPrintID = this._3DPrintID,
                    Name = tbName.Text.ToString(),
                    CreationDate = dateTime3DPrint.Value,
                    FileName = tbGCode.Text.ToString(),
                    Rating = (Enums.Rating)_rating,
                    Description = tbDescription.Text.ToString(),
                    FileGCode = (tbGCode.Text != string.Empty) ? _GCode != null ? _GCode : File.ReadAllBytes(tbGCode.Text) : null
                };
                if (cb3DDesign.SelectedValue != null)
                {
                    _3DDesign _3DDesign = _presenter.Get3DDesignByName(cb3DDesign.SelectedValue.ToString());
                    _3dPrint._3DDesign = _3DDesign;
                    _3dPrint._3DDesignID = _3DDesign._3DDesignID;
                }
                return _3dPrint;
            }
            set
            {
                if (value != null && value._3DPrintID != 0)
                {
                    _3DPrintID = value._3DPrintID;
                    cb3DDesign.SelectedIndex = value._3DDesign != null ? cb3DDesign.FindStringExact(value._3DDesign.Name) : -1;
                    tbName.Text = value.Name;
                    tbGCode.Text = value.FileName;
                    Enums.Rating r = Enums.ParseEnum<Enums.Rating>(value.Rating.ToString());
                    _rating = (short)r;
                    UpdateRating();
                    tbDescription.Text = value.Description;
                    _GCode = value.FileGCode;
                    dateTime3DPrint.Value = value.CreationDate < dateTime3DPrint.MinDate ? DateTime.Now.Date : value.CreationDate;
                }
            }
        }
        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public void AttachPresenter(_3DPrintDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frm3DPrintDetails()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void frm3DPrintDetails_Load(object sender, EventArgs e)
        {
            UpdateRating();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(AppTranslations.MessageBoxInfoConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.AddOrUpdate3DPrint(_3DPrint);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                if (ex.Message.Contains(AppTranslations.SuccesInfoBox))
                    this.Close();
            }
        }

        private void btnAdd3DPrint_Click(object sender, EventArgs e)
        {
            DialogResult resultFile = openFile.ShowDialog();
            if (resultFile == DialogResult.OK)
            {
                tbGCode.Text = openFile.FileName;
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

        public void Init()
        {
            try
            {
                cb3DDesign.DataSource = _presenter.GetAll3DDesigns();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
            }
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

        private void btnNoDesign_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb3DDesign.Enabled == true)
                {
                    cb3DDesign.DataSource = null;
                    cb3DDesign.Enabled = false;
                }
                else
                {
                    cb3DDesign.DataSource = _presenter.GetAll3DDesigns();
                    cb3DDesign.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
            }
        }
    }
}
