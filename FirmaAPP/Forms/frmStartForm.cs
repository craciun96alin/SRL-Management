using FirmaAPP.BusinessLogic.UIConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppContext = FirmaAPP.Common.AppContext;


namespace FirmaAPP
{
    public partial class frmStartForm : frmBaseForm, IStartFormView
    {
        #region private members
        private StartFormPresenter _presenter;

        #endregion

        public List<string> UserNames
        {
            set
            {
                foreach(string s in value)
                {
                    cbUserName.Items.Add(s);
                }
            }
        }

        public void AttachPresenter(StartFormPresenter presenter)
        {
            _presenter = presenter;
        }

        public frmStartForm()
        {
            InitializeComponent();
        }

        private void frmStartForm_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms = new List<Form>();

            StartFormPresenter presenter = new StartFormPresenter(this);
            this.AttachPresenter(presenter);
            _presenter.GetUsers();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            if (_presenter.VerifyCurrentUser())
            {
                frmMainForm childForm = new frmMainForm();
                _presenter.SetAppSettings();
                childForm.Show();


                this.Enabled = false;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Trebuie să alegi un utilizator înainte!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.SetCurrentUser(cbUserName.SelectedItem.ToString());
        }
    }
}
