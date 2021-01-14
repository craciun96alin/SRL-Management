using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmAttribute3DPrintsQualityList : Form, IAttribute3DPrintsQualityListView
    {
        #region private members
        private Attribute3DPrintsQualityListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmAttribute3DPrintsQualityList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<Attribute3DPrintsQuality> Attribute3DPrintsQualitys
        {
            set
            {
                if (value == null) return;
                var sl3DPrintsQualitys = new SortableList<Attribute3DPrintsQuality>(value);
                dataGridAttribute3DPrintsQuality.DataSource = sl3DPrintsQualitys;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "_3DPrintOrders"
                };

                if (dataGridAttribute3DPrintsQuality.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridAttribute3DPrintsQuality.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(Attribute3DPrintsQualityListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events

        private void frmAttribute3DPrintsQualityList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }

        private void frmAttribute3DPrintsQualityList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAttribute3DPrintsQualityDetails childForm = new frmAttribute3DPrintsQualityDetails();
            Attribute3DPrintsQualityDetailsPresenter presenter = new Attribute3DPrintsQualityDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.Attribute3DPrintsQuality = new Attribute3DPrintsQuality();
            childForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAttribute3DPrintsQuality.SelectedRows.Count > 0)
                {
                    edit3DPrintsQuality((Attribute3DPrintsQuality)dataGridAttribute3DPrintsQuality.Rows[dataGridAttribute3DPrintsQuality.SelectedRows[0].Index].DataBoundItem);
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

        private void dataGridAttribute3DPrintsQuality_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridAttribute3DPrintsQuality.SelectedRows.Count > 0)
                {
                    edit3DPrintsQuality((Attribute3DPrintsQuality)dataGridAttribute3DPrintsQuality.Rows[e.RowIndex].DataBoundItem);
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
                if (dataGridAttribute3DPrintsQuality.SelectedRows.Count > 0)
                {
                    edit3DPrintsQuality((Attribute3DPrintsQuality)dataGridAttribute3DPrintsQuality.Rows[dataGridAttribute3DPrintsQuality.SelectedRows[0].Index].DataBoundItem);
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
            delete3DPrintsQuality();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            delete3DPrintsQuality();
        }
        #endregion
        #region private functions
        private void edit3DPrintsQuality(Attribute3DPrintsQuality _3DPrintsQuality)
        {
            if (VerifySelectedRowForEditing())
            {
                frmAttribute3DPrintsQualityDetails childForm = new frmAttribute3DPrintsQualityDetails();
                Attribute3DPrintsQualityDetailsPresenter presenter = new Attribute3DPrintsQualityDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                //childForm.Init();
                childForm.Attribute3DPrintsQuality = _3DPrintsQuality;
                childForm.ShowDialog();
            }
        }

        private void delete3DPrintsQuality()
        {
            try
            {
                List<Attribute3DPrintsQuality> _3DPrintsQualitysToDelete = new List<Attribute3DPrintsQuality>();
                foreach (DataGridViewRow row in dataGridAttribute3DPrintsQuality.SelectedRows)
                {
                    Attribute3DPrintsQuality _3DPrintsQuality = (Attribute3DPrintsQuality)dataGridAttribute3DPrintsQuality.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations.Attribute3DPrintsQuality + " " + _3DPrintsQuality.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        _3DPrintsQualitysToDelete.Add(_3DPrintsQuality);
                    }
                }
                if (_3DPrintsQualitysToDelete.Count > 0)
                    _presenter.DeleteAttribute3DPrintsQualitys(_3DPrintsQualitysToDelete);
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
            if (dataGridAttribute3DPrintsQuality.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridAttribute3DPrintsQuality.SelectedRows.Count > 1)
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
