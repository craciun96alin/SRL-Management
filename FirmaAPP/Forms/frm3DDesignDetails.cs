using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frm3DDesignDetails : Form, I3DDesignDetailsView
    {
        #region private members
        private _3DDesignDetailsPresenter _presenter;
        private short _rating;
        private Form _parentForm;
        private frmMainForm _mainForm;
        private _3DDesign _3dDesign;
        private byte[] _project;
        #endregion

        #region View 
        public int _3DDesignID { get; set; }
        public _3DDesign _3DDesign 
        {
            get
            {
                var designStatus = Enums.ParseEnum<Enums.DesignStatus>(cb3DDesignStatus.SelectedValue.ToString());
                _3dDesign = new _3DDesign
                {
                    _3DDesignID = _3DDesignID,
                    Name = tbName.Text.ToString(),
                    DesignStatus = designStatus,
                    ProjectName = tbProjectName.Text.ToString(),
                    HoursOfWork = (int)numericUpDownHoursOfWork.Value,
                    Rating = (Enums.Rating)_rating,
                    Description = tbDescription.Text,
                    CreationDate = dateCreateTime.Value,
                    DeadLineDate = dateDeadLine.Value
                };
                if (tbProjectName.Text != string.Empty)
                {
                    if (_project != null && !tbProjectName.Text.Contains("\\"))
                    {
                        _3dDesign.Project =   _project ;
                    }
                    else
                    {
                        _3dDesign.Project = File.ReadAllBytes(tbProjectName.Text);
                    }
                }
                else
                {
                    _3dDesign.Project = null;
                }
                if (designStatus == Enums.DesignStatus.Finlizată)
                {
                    _3dDesign.FinalizeDate = DateTime.Today;
                }

                return _3dDesign;
            }
            set
            {
                _3DDesignID = value._3DDesignID;
                tbName.Text = value.Name;
                cb3DDesignStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.DesignStatus>(value.DesignStatus.ToString());
                numericUpDownHoursOfWork.Value = value.HoursOfWork;
                Enums.Rating r = Enums.ParseEnum<Enums.Rating>(value.Rating.ToString());
                _rating = (short)r;
                UpdateRating();
                _project = value.Project;
                tbProjectName.Text = value.ProjectName;
                tbDescription.Text = value.Description;
                dateCreateTime.Value = value.CreationDate < dateCreateTime.MinDate ? DateTime.Now.Date : value.CreationDate;
                dateDeadLine.Value = value.DeadLineDate < dateDeadLine.MinDate ? DateTime.Now.Date : value.DeadLineDate;
                if (value.FinalizeDate != null)
                {
                    dateFinishedTime.Value = value.FinalizeDate ?? dateFinishedTime.MinDate;
                }
                else
                {
                    dateFinishedTime.CustomFormat = " ";
                    dateFinishedTime.Format = DateTimePickerFormat.Custom;
                }
            }
            
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public void AttachPresenter(_3DDesignDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion

        #region Constructor
        public frm3DDesignDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void frm3DDesignDetails_Load(object sender, EventArgs e)
        {
            UpdateRating();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(AppTranslations.MessageBoxInfoConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.AddOrUpdate3DDesign(_3DDesign);
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppTranslations.CancelConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private void btnAdd3DDesign_Click(object sender, EventArgs e)
        {
            DialogResult resultFile = openFile.ShowDialog();
            if (resultFile == DialogResult.OK)
            {
                tbProjectName.Text = openFile.FileName;
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

        public void Init()
        {
            try
            {
                cb3DDesignStatus.DataSource = Enum.GetNames(typeof(Common.Enums.DesignStatus));
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                this.Close();
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
                _rating = 3;
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
    }
}

