using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmAttributeTshirtsTypeList : Form , IAttributeTshirtsTypeListView
    {
        #region private members
        private AttributeTshirtsTypeListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmAttributeTshirtsTypeList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<AttributeTshirtsType> AttributeTshirtsTypes
        {
            set
            {
                if (value == null) return;
                var slTshirtsTypes = new SortableList<AttributeTshirtsType>(value);
                dataGridAttributeTshirts.DataSource = slTshirtsTypes;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "Tshirts"
                };

                if (dataGridAttributeTshirts.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridAttributeTshirts.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(AttributeTshirtsTypeListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events

        private void frmAttributeTshirtsTypeList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }

        private void frmAttributeTshirtsTypeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAttributeTshirtsTypeDetails childForm = new frmAttributeTshirtsTypeDetails();
            AttributeTshirtsTypeDetailsPresenter presenter = new AttributeTshirtsTypeDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.AttributeTshirtsType = new AttributeTshirtsType();
            childForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAttributeTshirts.SelectedRows.Count > 0)
                {
                    editTshirtsType((AttributeTshirtsType)dataGridAttributeTshirts.Rows[dataGridAttributeTshirts.SelectedRows[0].Index].DataBoundItem);
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

        private void dataGridAttributeTshirts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridAttributeTshirts.SelectedRows.Count > 0)
                {
                    editTshirtsType((AttributeTshirtsType)dataGridAttributeTshirts.Rows[e.RowIndex].DataBoundItem);
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

        private void lbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAttributeTshirts.SelectedRows.Count > 0)
                {
                    editTshirtsType((AttributeTshirtsType)dataGridAttributeTshirts.Rows[dataGridAttributeTshirts.SelectedRows[0].Index].DataBoundItem);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteTshirtsType();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            deleteTshirtsType();
        }
        #endregion
        #region private functions
        private void editTshirtsType(AttributeTshirtsType TshirtsType)
        {
            if (VerifySelectedRowForEditing())
            {
                frmAttributeTshirtsTypeDetails childForm = new frmAttributeTshirtsTypeDetails();
                AttributeTshirtsTypeDetailsPresenter presenter = new AttributeTshirtsTypeDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                //childForm.Init();
                childForm.AttributeTshirtsType = TshirtsType;
                childForm.ShowDialog();
            }
        }

        private void deleteTshirtsType()
        {
            try
            {
                List<AttributeTshirtsType> TshirtsTypesToDelete = new List<AttributeTshirtsType>();
                foreach (DataGridViewRow row in dataGridAttributeTshirts.SelectedRows)
                {
                    AttributeTshirtsType TshirtsType = (AttributeTshirtsType)dataGridAttributeTshirts.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations.AttributeTshirtsType + " " + TshirtsType.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        TshirtsTypesToDelete.Add(TshirtsType);
                    }
                }
                if (TshirtsTypesToDelete.Count > 0)
                    _presenter.DeleteAttributeTshirtsTypes(TshirtsTypesToDelete);
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
            if (dataGridAttributeTshirts.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridAttributeTshirts.SelectedRows.Count > 1)
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
