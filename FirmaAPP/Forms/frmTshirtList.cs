using System;
using AppContext = FirmaAPP.Common.AppContext;
using System.Collections.Generic;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmTshirtsList : Form, ITshirtListView
    {
        #region private members
        private TshirtListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmTshirtsList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<Tshirt> Tshirts
        {
            set
            {
                if (value == null) return;
                var slTshirts = new SortableList<Tshirt>(value);

                dataGridTshirts.DataSource = slTshirts;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "TshirtID",
                    "ProviderID",
                    "Provider",
                    "_tshirtOrders"
                };
                if (dataGridTshirts.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridTshirts.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(TshirtListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events
        private void frmTshirtsList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frmTshirtsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmTshirtDetails childForm = new frmTshirtDetails();
            TshirtDetailsPresenter presenter = new TshirtDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.Tshirt = new Tshirt();
            childForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteTshirt();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            deleteTshirt();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                editTshirt((Tshirt)dataGridTshirts.Rows[dataGridTshirts.SelectedRows[0].Index].DataBoundItem);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void lbEdit_Click(object sender, EventArgs e)
        {
            editTshirt((Tshirt)dataGridTshirts.Rows[dataGridTshirts.SelectedRows[0].Index].DataBoundItem);
        }

        private void dataGridTshirts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editTshirt((Tshirt)dataGridTshirts.Rows[e.RowIndex].DataBoundItem);
        }
        #endregion
        #region private functions
        private void editTshirt(Tshirt tshirt)
        {
            if (VerifySelectedRowForEdit())
            {
                frmTshirtDetails childForm = new frmTshirtDetails();
                TshirtDetailsPresenter presenter = new TshirtDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Init();
                childForm.Tshirt = tshirt;
                childForm.ShowDialog();
            }
        }

        private void deleteTshirt()
        {
            try
            {
                List<Tshirt> tshirtsToDelete = new List<Tshirt>();
                foreach (DataGridViewRow row in dataGridTshirts.SelectedRows)
                {
                    Tshirt tshirt = (Tshirt)dataGridTshirts.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion +" " +AppTranslations.Tshirt + " " + tshirt.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        tshirtsToDelete.Add(tshirt);
                    }
                }
                if (tshirtsToDelete.Count > 0)
                    _presenter.DeleteTshirts(tshirtsToDelete);
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
            if (dataGridTshirts.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridTshirts.SelectedRows.Count > 1)
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
