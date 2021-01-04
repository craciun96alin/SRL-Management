using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.Forms;

namespace FirmaAPP
{ 
    public partial class frmUsersList : Form, IUsersListView
    {
        #region private members
        private UserListPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        #endregion
        #region Constructor
        public frmUsersList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<User> Users
        {
            set
            {
                if (value == null) return;
                var slUsers = new SortableList<User>(value);
                dataGridUser.DataSource = slUsers;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "UserId",
                    "Password",
                    "AppSettings",
                    "BusinessDetails",
                    "Orders"
                };

                if (dataGridUser.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridUser.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(UserListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Events

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();

            VerifyIfItIsFirstLogIn();
        }

        private void VerifyIfItIsFirstLogIn()
        {
            User user = _presenter.GetCurrentUser();
            if (user.Password == null || user.Password == string.Empty)
            {
                editUser(user);
            }
        }

        private void frmUsersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
            _parentForm.Refresh();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUserDetails childForm = new frmUserDetails();
            UserDetailsPresenter presenter = new UserDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.User = new User();
            childForm.ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUser.SelectedRows.Count > 0)
                {
                    editUser((User)dataGridUser.Rows[dataGridUser.SelectedRows[0].Index].DataBoundItem);
                }
                else
                {
                    throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void dataGridUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridUser.SelectedRows.Count > 0)
                {
                    editUser((User)dataGridUser.Rows[e.RowIndex].DataBoundItem);
                }

                else
                {
                    throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void lbEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUser.SelectedRows.Count > 0)
                {
                    editUser((User)dataGridUser.Rows[dataGridUser.SelectedRows[0].Index].DataBoundItem);
                }

                else
                {
                    throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void lbDeleteUser_Click(object sender, EventArgs e)
        {
            deleteUser();
        }
        private void dataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    Enums.UserRole userRole = Enums.ParseEnum<Enums.UserRole>(dataGridUser.Rows[e.RowIndex].Cells["UserRole"].Value.ToString());
                    if (userRole == Enums.UserRole.Admin)
                    {
                        btnDeleteUser.Visible = false;
                        lbDeleteUser.Visible = false;
                    }
                    else
                    {
                        btnDeleteUser.Visible = true;
                        lbDeleteUser.Visible = true;
                    }

                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

        }
        #endregion
        #region private functions
        private void editUser(User User)
        {
            if (User != null || VerifySelectedRowForEditing())
            {
                frmUserDetails childForm = new frmUserDetails();
                UserDetailsPresenter presenter = new UserDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Init();
                childForm.User = User;
                childForm.ShowDialog();
            }
        }

        private void deleteUser()
        {
            try
            {
                List<User> UsersToDelete = new List<User>();
                foreach (DataGridViewRow row in dataGridUser.SelectedRows)
                {
                    User User = (User)dataGridUser.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations.User + " " + User.FirstName + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        UsersToDelete.Add(User);
                    }
                }
                if (UsersToDelete.Count > 0)
                    _presenter.DeleteUsers(UsersToDelete);
                else
                    throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                Refresh();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                Refresh();
            }
        }

        private bool VerifySelectedRowForEditing()
        {
            if (dataGridUser.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridUser.SelectedRows.Count > 1)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtMostOneRow);
                return false;
            }
            return true;

        }

        #endregion
        #region public functions
        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }
        #endregion
        #region override functions
        public override void Refresh()
        {
            _presenter.Init();
        }
        #endregion
        public void AttachParentForm(Form form)
        {
            _parentForm = form;
        }
        
    }
}
