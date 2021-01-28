using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmVinylList : Form , IVinylListView
    {
        #region private members
        private VinylListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmVinylList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<Vinyl> Vinyls
        {
            set
            {
                if (value == null) return;
                var slFilaments = new SortableList<Vinyl>(value);

                dataGridVinyl.DataSource = slFilaments;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "VinylId",
                    "ProviderId",
                    "Provider",
                    "_vinylOrders",
                    "AttributeVinylsTypeID",
                    "AttributeColorID",
                    "Color",
                    "Type"
                };
                if (dataGridVinyl.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridVinyl.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(VinylListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events
        private void frmVinylList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frmVinylList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmVinylDetails childForm = new frmVinylDetails();
            VinylDetailsPresenter presenter = new VinylDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.Vinyl = new Vinyl();
            childForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteVinyl();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            deleteVinyl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editVinyl((Vinyl)dataGridVinyl.Rows[dataGridVinyl.SelectedRows[0].Index].DataBoundItem);
        }

        private void lbEdit_Click(object sender, EventArgs e)
        {
            editVinyl((Vinyl)dataGridVinyl.Rows[dataGridVinyl.SelectedRows[0].Index].DataBoundItem);
        }

        private void dataGridVinyl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editVinyl((Vinyl)dataGridVinyl.Rows[e.RowIndex].DataBoundItem);
        }
        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            if (VerifySelectedRowForEdit())
            {
                Vinyl v = (Vinyl)dataGridVinyl.Rows[dataGridVinyl.SelectedRows[0].Index].DataBoundItem;
                v.VinylID = 0;
                frmVinylDetails childForm = new frmVinylDetails();
                VinylDetailsPresenter presenter = new VinylDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Init();
                childForm.Vinyl = v;
                childForm.ShowDialog();
            }
        }
        #endregion
        #region private functions
        private void editVinyl(Vinyl vinyl)
        {
            if (VerifySelectedRowForEdit())
            {
                frmVinylDetails childForm = new frmVinylDetails();
                VinylDetailsPresenter presenter = new VinylDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Init();
                childForm.Vinyl = vinyl;
                childForm.ShowDialog();
            }
        }

        private void deleteVinyl()
        {
            try
            {
                List<Vinyl> vinylsToDelete = new List<Vinyl>();
                foreach (DataGridViewRow row in dataGridVinyl.SelectedRows)
                {
                    Vinyl vinyl = (Vinyl)dataGridVinyl.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion+" "+AppTranslations.Vinyl + " " +vinyl.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        vinylsToDelete.Add(vinyl);
                    }
                }
                if (vinylsToDelete.Count > 0)
                    _presenter.DeleteVinyls(vinylsToDelete);
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
            if (dataGridVinyl.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridVinyl.SelectedRows.Count > 1)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtMostOneRow);
                return false;
            }
            return true;
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
    }
}
