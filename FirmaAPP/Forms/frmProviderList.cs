using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmProviderList : Form , IProviderListView
    {
        #region private members
        private ProviderListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region View

        public List<Provider> Providers
        {
            set
            {
                if (value == null) return;
                var slProviders = new SortableList<Provider>(value);

                dataGridProvider.DataSource = slProviders;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "Orders",
                    "ProviderID",
                    "Vinyls",
                    "Tshirts",
                    "Filaments",
                    "OtherPurchases"
                };
                if (dataGridProvider.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridProvider.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(ProviderListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Constructor
        public frmProviderList()
        {
            InitializeComponent();
        }
        #endregion
        #region public functions
        override public void Refresh()
        {
            _presenter.Init();
        }
        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }
        #endregion
        #region Events
        private void frmProviderList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frmProviderList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAddProvider_Click(object sender, EventArgs e)
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

        private void lbEditProvider_Click(object sender, EventArgs e)
        {
            editFilament((Provider)dataGridProvider.Rows[dataGridProvider.SelectedRows[0].Index].DataBoundItem);
        }

        private void btnEditProvider_Click(object sender, EventArgs e)
        {
            editFilament((Provider)dataGridProvider.Rows[dataGridProvider.SelectedRows[0].Index].DataBoundItem);
        }

        private void lbDeleteProvider_Click(object sender, EventArgs e)
        {
            deleteProvider();
        }

        private void btnDeleteProvider_Click(object sender, EventArgs e)
        {
            deleteProvider();
        }
        private void dataGridProvider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editFilament((Provider)dataGridProvider.Rows[e.RowIndex].DataBoundItem);
        }
        #endregion
        #region private functions
        private void editFilament(Provider provider)
        {
            if (VerifySelectedRowForEditing())
            {
                frmProviderDetails childForm = new frmProviderDetails();
                ProviderDetailsPresenter presenter = new ProviderDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Provider = provider;
                childForm.ShowDialog();
            }
        }

        private void deleteProvider()
        {
            try
            {
                List<Provider> providersToDelete = new List<Provider>();
                foreach (DataGridViewRow row in dataGridProvider.SelectedRows)
                {
                    Provider provider = (Provider)dataGridProvider.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion +" "+ AppTranslations.Provider +" " + provider.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        providersToDelete.Add(provider);
                    }
                }
                if (providersToDelete.Count > 0)
                    _presenter.DeleteProviders(providersToDelete);
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
            if (dataGridProvider.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridProvider.SelectedRows.Count > 1)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtMostOneRow);
                return false;
            }
            return true;
        }
        #endregion
    }
}
