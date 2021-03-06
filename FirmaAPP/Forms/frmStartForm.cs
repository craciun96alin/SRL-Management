﻿using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;
using FirmaAPP.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using AppContext = FirmaAPP.Common.AppContext;


namespace FirmaAPP
{
    public partial class frmStartForm : frmBaseForm, IStartFormView
    {
        #region private members
        private StartFormPresenter _presenter;

        #endregion
        #region View
        public List<string> UserNames
        {
            set
            {
                cbUserName.Items.Clear();
                foreach(string userName in value)
                {
                    cbUserName.Items.Add(userName);
                }
            }
        }

        public void AttachPresenter(StartFormPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Constructor
        public frmStartForm()
        {

            InitializeComponent();
        }
        #endregion
        #region Events
        private void frmStartForm_Load(object sender, EventArgs e)
        {


            using (var client = new DBContext())
            {
                client.Database.EnsureCreated();
            }

            AppContext.ActiveForms = new List<Form>();
            StartFormPresenter presenter = new StartFormPresenter(this);
            this.AttachPresenter(presenter);
            _presenter.GetUsers();
            toolTipPassword.SetToolTip(tbPassword, "Password");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (_presenter.VerifyIfCurrentUserIsAdmin(tbPassword.Text))
                {
                    frmUsersList childForm = new frmUsersList();
                    UserListPresenter UserListPresenter = new UserListPresenter(childForm);
                    childForm.AttachPresenter(UserListPresenter);
                    childForm.AttachParentForm(this);
                    childForm.Show();
                }
                else
                {
                    frmMainForm childForm = new frmMainForm();
                    _presenter.SetAppSettings();
                    childForm.Show();
                    this.Enabled = false;
                    this.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.SetCurrentUser(cbUserName.SelectedItem.ToString());
        }
        #endregion
        #region override functions
        public override void Refresh()
        {
            _presenter.GetUsers();
        }
        #endregion

        private void btnRo_Click(object sender, EventArgs e)
        {
 
            CultureInfo info = CultureInfo.CreateSpecificCulture("ro-RO");
            Thread.CurrentThread.CurrentUICulture = info;
            Thread.CurrentThread.CurrentCulture = info;
            Refresh();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            CultureInfo info = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentUICulture = info;
            Thread.CurrentThread.CurrentCulture = info;
            Refresh();
        }

        private void btnRo_MouseClick(object sender, MouseEventArgs e)
        {
            this.ResetText();
            this.Text = "Bine ai venit:";//AppTranslations.Welcome;
        }

        private void btnEng_MouseClick(object sender, MouseEventArgs e)
        {
            this.ResetText();
            this.Text = "Welcome:"; //AppTranslations.Welcome;
        }

        private void frmStartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
