using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Windows.Forms;

namespace FirmaAPP.Forms
{
    public partial class frmUserDetails : Form , IUserDetailsView
    {
        #region PrivateMembers
        private UserDetailsPresenter _presenter;
        private Form _parentForm;
        #endregion
        #region IUserDetailsViewMembers
        public int UserId { get; set; }

        private User _User;

        public User User
        {
            get
            {
                _User = new User
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    UserID = this.UserId,
                    Password = AppHelper.Encrypt(tbPassword.Text,AppTranslations.PassPhrase),
                    UserRole = Enums.ParseEnum<Enums.UserRole>(cbUserRole.SelectedValue.ToString()),
                };
                return _User;
            }
            set
            {
                tbFirstName.Text = value.FirstName;
                tbLastName.Text = value.LastName;
                cbUserRole.SelectedIndex = (short)Enums.ParseEnum<Enums.UserRole>(value.UserRole.ToString());
                UserId = value.UserID;
                if(value.Password != null)
                    tbPassword.Text = AppHelper.Decrypt(value.Password, AppTranslations.PassPhrase);
                if (value.UserID == 0)
                {
                    value.UserRole = Enums.UserRole.Normal;
                    cbUserRole.SelectedIndex = (short)Enums.ParseEnum<Enums.UserRole>(Enums.UserRole.Normal.ToString());
                }
                if (value.UserRole == Enums.UserRole.Admin)
                {
                    tbFirstName.Enabled = false;
                    tbLastName.Enabled = false;
                }

            }
        }

        public void AttachPresenter(UserDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmUserDetails()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if(tbPassword.Text != tbPaswordAgain.Text)
                {
                    throw new Exception("Parolele introduse nu sunt similare!");
                }
                if (MessageBox.Show(AppTranslations.MessageBoxInfoConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.AddOrUpdateUser(User);
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
        #endregion
        #region public functions


        public void AttachParentForm(Form form)
        {
            _parentForm = form;
        }

        public void Init()
        {
            try
            {
                cbUserRole.DataSource = Enum.GetNames(typeof(Common.Enums.UserRole));
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                this.Close();
            }
        }
        #endregion
    }
}
