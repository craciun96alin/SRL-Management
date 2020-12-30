using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmOtherPurchaseList : Form , IOtherPurchaseListView
    {
        #region private members
        private OtherPurchaseListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmOtherPurchaseList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<OtherPurchase> OtherPurchases
        {
            set
            {
                if (value == null) return;
                var slOtherPurchases = new SortableList<OtherPurchase>(value);

                dataGridOtherPurchase.DataSource = slOtherPurchases;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "OtherPurchaseId",
                    "ProviderId",
                    "Provider",
                    "_otherPurchaseOrders"
                };
                if (dataGridOtherPurchase.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridOtherPurchase.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(OtherPurchaseListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events
        private void frmOtherPurchaseList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frmOtherPurchaseList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOtherPurchaseDetails childForm = new frmOtherPurchaseDetails();
            OtherPurchaseDetailsPresenter presenter = new OtherPurchaseDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.OtherPurchase = new OtherPurchase();
            childForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteOtherPurchase();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            deleteOtherPurchase();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editOtherPurchase((OtherPurchase)dataGridOtherPurchase.Rows[dataGridOtherPurchase.SelectedRows[0].Index].DataBoundItem);
        }

        private void lbEdit_Click(object sender, EventArgs e)
        {
            editOtherPurchase((OtherPurchase)dataGridOtherPurchase.Rows[dataGridOtherPurchase.SelectedRows[0].Index].DataBoundItem);
        }

        private void dataGridVinyl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editOtherPurchase((OtherPurchase)dataGridOtherPurchase.Rows[e.RowIndex].DataBoundItem);
        }
        #endregion
        #region private functions
        private void editOtherPurchase(OtherPurchase otherPurchase)
        {
            if (VerifySelectedRowForEdit())
            {
                frmOtherPurchaseDetails childForm = new frmOtherPurchaseDetails();
                OtherPurchaseDetailsPresenter presenter = new OtherPurchaseDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Init();
                childForm.OtherPurchase = otherPurchase;
                childForm.ShowDialog();
            }
        }

        private void deleteOtherPurchase()
        {
            try
            {
                List<OtherPurchase> otherPurchasesToDelete = new List<OtherPurchase>();
                foreach (DataGridViewRow row in dataGridOtherPurchase.SelectedRows)
                {
                    OtherPurchase otherPurchase = (OtherPurchase)dataGridOtherPurchase.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + " " + otherPurchase.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        otherPurchasesToDelete.Add(otherPurchase);
                    }
                }
                if (otherPurchasesToDelete.Count > 0)
                    _presenter.DeleteOtherPurchases(otherPurchasesToDelete);
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

        private bool VerifySelectedRowForEdit()
        {
            if (dataGridOtherPurchase.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridOtherPurchase.SelectedRows.Count > 1)
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
    }
}
