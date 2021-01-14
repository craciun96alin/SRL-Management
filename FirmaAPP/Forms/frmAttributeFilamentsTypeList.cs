using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmAttributeFilamentsTypeList : Form, IAttributeFilamentsTypeListView
    {
        #region private members
        private AttributeFilamentsTypeListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmAttributeFilamentsTypeList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<AttributeFilamentsType> AttributeFilamentsTypes
        {
            set
            {
                if (value == null) return;
                var slFilamentsTypes = new SortableList<AttributeFilamentsType>(value);
                dataGridAttributeFilaments.DataSource = slFilamentsTypes;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "Filaments"
                };

                if (dataGridAttributeFilaments.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridAttributeFilaments.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(AttributeFilamentsTypeListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events

        private void frmAttributeFilamentsTypeList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }

        private void frmAttributeFilamentsTypeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAttributeFilamentsTypeDetails childForm = new frmAttributeFilamentsTypeDetails();
            AttributeFilamentsTypeDetailsPresenter presenter = new AttributeFilamentsTypeDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.AttributeFilamentsType = new AttributeFilamentsType();
            childForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAttributeFilaments.SelectedRows.Count > 0)
                {
                    editFilamentsType((AttributeFilamentsType)dataGridAttributeFilaments.Rows[dataGridAttributeFilaments.SelectedRows[0].Index].DataBoundItem);
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

        private void dataGridAttributeFilaments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridAttributeFilaments.SelectedRows.Count > 0)
                {
                    editFilamentsType((AttributeFilamentsType)dataGridAttributeFilaments.Rows[e.RowIndex].DataBoundItem);
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
                if (dataGridAttributeFilaments.SelectedRows.Count > 0)
                {
                    editFilamentsType((AttributeFilamentsType)dataGridAttributeFilaments.Rows[dataGridAttributeFilaments.SelectedRows[0].Index].DataBoundItem);
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
            deleteFilamentsType();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            deleteFilamentsType();
        }
        #endregion
        #region private functions
        private void editFilamentsType(AttributeFilamentsType FilamentsType)
        {
            if (VerifySelectedRowForEditing())
            {
                frmAttributeFilamentsTypeDetails childForm = new frmAttributeFilamentsTypeDetails();
                AttributeFilamentsTypeDetailsPresenter presenter = new AttributeFilamentsTypeDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                //childForm.Init();
                childForm.AttributeFilamentsType = FilamentsType;
                childForm.ShowDialog();
            }
        }

        private void deleteFilamentsType()
        {
            try
            {
                List<AttributeFilamentsType> FilamentsTypesToDelete = new List<AttributeFilamentsType>();
                foreach (DataGridViewRow row in dataGridAttributeFilaments.SelectedRows)
                {
                    AttributeFilamentsType FilamentsType = (AttributeFilamentsType)dataGridAttributeFilaments.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations.AttributeFilamentsType + " " + FilamentsType.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        FilamentsTypesToDelete.Add(FilamentsType);
                    }
                }
                if (FilamentsTypesToDelete.Count > 0)
                    _presenter.DeleteAttributeFilamentsTypes(FilamentsTypesToDelete);
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
            if (dataGridAttributeFilaments.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridAttributeFilaments.SelectedRows.Count > 1)
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
