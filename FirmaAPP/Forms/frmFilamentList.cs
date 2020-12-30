using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmFilamentList : Form, IFilamentListView
    {
        #region private members
        private FilamentListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion

        public frmFilamentList()
        {
            InitializeComponent();
        }

        #region View

        public List<Filament> Filaments
        {
            set
            {
                if (value == null) return;
                var slFilaments = new SortableList<Filament>(value);
                dataGridFilament.DataSource = slFilaments;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "FilamentId",
                    "ProviderId",
                    "Provider",
                    "_filamentOrders"
                };

                if (dataGridFilament.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridFilament.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(FilamentListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events

        private void frmFilament_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }

        private void frmFilament_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }

        private void btnAddFilament_Click(object sender, EventArgs e)
        {
            frmFilamentDetails childForm = new frmFilamentDetails();
            FilamentDetailsPresenter presenter = new FilamentDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.Filament = new Filament();
            childForm.ShowDialog();
        }

        private void btnEditFilament_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridFilament.SelectedRows.Count > 0)
                {
                    editFilament((Filament)dataGridFilament.Rows[dataGridFilament.SelectedRows[0].Index].DataBoundItem);
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

        private void dataGridFilament_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridFilament.SelectedRows.Count > 0)
                {
                    editFilament((Filament)dataGridFilament.Rows[e.RowIndex].DataBoundItem);
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

        private void lbEditFilament_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridFilament.SelectedRows.Count > 0)
                {
                    editFilament((Filament)dataGridFilament.Rows[dataGridFilament.SelectedRows[0].Index].DataBoundItem);
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

        private void btnDeleteFilament_Click(object sender, EventArgs e)
        {
            deleteFilament();
        }

        private void lbDeleteFilament_Click(object sender, EventArgs e)
        {
            deleteFilament();
        }
        #endregion

        #region private functions
        private void editFilament(Filament filament)
        {
            if (VerifySelectedRowForEditing())
            {
                frmFilamentDetails childForm = new frmFilamentDetails();
                FilamentDetailsPresenter presenter = new FilamentDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Init();
                childForm.Filament = filament;
                childForm.ShowDialog();
            }
        }

        private void deleteFilament()
        {
            try
            {
                List<Filament> filamentsToDelete = new List<Filament>();
                foreach (DataGridViewRow row in dataGridFilament.SelectedRows)
                {
                    Filament filament = (Filament)dataGridFilament.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion +AppTranslations.Filament+" " + filament.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        filamentsToDelete.Add(filament);
                    }
                }
                if (filamentsToDelete.Count > 0)
                    _presenter.DeleteFilaments(filamentsToDelete);
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
            if(dataGridFilament.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridFilament.SelectedRows.Count > 1)
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
