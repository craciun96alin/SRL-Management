using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmAttributeVinylsTypeList : Form, IAttributeVinylsTypeListView
    {
        #region private members
        private AttributeVinylsTypeListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmAttributeVinylsTypeList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<AttributeVinylsType> AttributeVinylsTypes
        {
            set
            {
                if (value == null) return;
                var slVinylsTypes = new SortableList<AttributeVinylsType>(value);
                dataGridAttributeVinyls.DataSource = slVinylsTypes;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "Vinyls"
                };

                if (dataGridAttributeVinyls.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridAttributeVinyls.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(AttributeVinylsTypeListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events

        private void frmAttributeVinylsTypeList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }

        private void frmAttributeVinylsTypeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAttributeVinylsTypeDetails childForm = new frmAttributeVinylsTypeDetails();
            AttributeVinylsTypeDetailsPresenter presenter = new AttributeVinylsTypeDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.AttributeVinylsType = new AttributeVinylsType();
            childForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAttributeVinyls.SelectedRows.Count > 0)
                {
                    editVinylsType((AttributeVinylsType)dataGridAttributeVinyls.Rows[dataGridAttributeVinyls.SelectedRows[0].Index].DataBoundItem);
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

        private void dataGridAttributeVinyls_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridAttributeVinyls.SelectedRows.Count > 0)
                {
                    editVinylsType((AttributeVinylsType)dataGridAttributeVinyls.Rows[e.RowIndex].DataBoundItem);
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
                if (dataGridAttributeVinyls.SelectedRows.Count > 0)
                {
                    editVinylsType((AttributeVinylsType)dataGridAttributeVinyls.Rows[dataGridAttributeVinyls.SelectedRows[0].Index].DataBoundItem);
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
            deleteVinylsType();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            deleteVinylsType();
        }
        #endregion
        #region private functions
        private void editVinylsType(AttributeVinylsType VinylsType)
        {
            if (VerifySelectedRowForEditing())
            {
                frmAttributeVinylsTypeDetails childForm = new frmAttributeVinylsTypeDetails();
                AttributeVinylsTypeDetailsPresenter presenter = new AttributeVinylsTypeDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                //childForm.Init();
                childForm.AttributeVinylsType = VinylsType;
                childForm.ShowDialog();
            }
        }

        private void deleteVinylsType()
        {
            try
            {
                List<AttributeVinylsType> VinylsTypesToDelete = new List<AttributeVinylsType>();
                foreach (DataGridViewRow row in dataGridAttributeVinyls.SelectedRows)
                {
                    AttributeVinylsType VinylsType = (AttributeVinylsType)dataGridAttributeVinyls.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations.AttributeVinylsType + " " + VinylsType.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        VinylsTypesToDelete.Add(VinylsType);
                    }
                }
                if (VinylsTypesToDelete.Count > 0)
                    _presenter.DeleteAttributeVinylsTypes(VinylsTypesToDelete);
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
            if (dataGridAttributeVinyls.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridAttributeVinyls.SelectedRows.Count > 1)
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
