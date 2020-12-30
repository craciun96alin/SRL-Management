using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System.Drawing;

namespace FirmaAPP
{
    public partial class frm3DDesignsList : Form, I3DDesignListView
    {
        #region private members
        private _3DDesignListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region View
        public List<_3DDesign> _3DDesigns
        {
            set
            {
                if (value == null || value.Count == 0) return;
                var sl3DDesigns = new SortableList<_3DDesign>(value);

                dataGrid3DDesign.DataSource = sl3DDesigns;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "Project",
                    "_3DDesignOrders"
                };
                if (dataGrid3DDesign.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGrid3DDesign.Columns[column].Visible = false;
                    }
                }
            }
        }
        public void AttachPresenter(_3DDesignListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Constructor
        public frm3DDesignsList()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void frm3DDesignsList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frm3DDesignsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAdd3DDesign_Click(object sender, EventArgs e)
        {
            frm3DDesignDetails childForm = new frm3DDesignDetails();
            _3DDesignDetailsPresenter presenter = new _3DDesignDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.Init();
            childForm.AttachPresenter(presenter);
            childForm._3DDesign = new _3DDesign();
            childForm.ShowDialog();
        }

        private void btnDelete3DDesign_Click(object sender, EventArgs e)
        {
            delete3DDesign();
        }

        private void lbDelete3DDesign_Click(object sender, EventArgs e)
        {
            delete3DDesign();
        }
        private void btnEdit3DDesign_Click(object sender, EventArgs e)
        {
            if (VerifySelectedRowForEdit())
            {
                edit3DDesign((_3DDesign)dataGrid3DDesign.Rows[dataGrid3DDesign.SelectedRows[0].Index].DataBoundItem);
            }
        }

        private void lbEdit3DDesign_Click(object sender, EventArgs e)
        {
            if (VerifySelectedRowForEdit())
            {
                edit3DDesign((_3DDesign)dataGrid3DDesign.Rows[dataGrid3DDesign.SelectedRows[0].Index].DataBoundItem);
            }
        }

        private void dataGrid3DDesign_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                edit3DDesign((_3DDesign)dataGrid3DDesign.Rows[e.RowIndex].DataBoundItem);
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
        #region private functions
        private void delete3DDesign()
        {
            try
            {
                List<_3DDesign> _3DDesignsToDelete = new List<_3DDesign>();
                foreach (DataGridViewRow row in dataGrid3DDesign.SelectedRows)
                {
                    _3DDesign _3DDesign = (_3DDesign)dataGrid3DDesign.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations._3DDesign + " " + _3DDesign.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        _3DDesignsToDelete.Add(_3DDesign);
                    }
                }
                if (_3DDesignsToDelete.Count > 0)
                    _presenter.Delete3DDesigns(_3DDesignsToDelete);
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

        private void edit3DDesign(_3DDesign _3DDesign)
        {
            frm3DDesignDetails childForm = new frm3DDesignDetails();
            _3DDesignDetailsPresenter presenter = new _3DDesignDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm._3DDesign = _3DDesign;
            childForm.ShowDialog();
        }

        private bool VerifySelectedRowForEdit()
        {
            if (dataGrid3DDesign.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGrid3DDesign.SelectedRows.Count > 1)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtMostOneRow);
                return false;
            }
            return true;
        }
        #endregion
        #region Grid Style
        private void dataGrid3DDesign_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var designStatus = Enums.ParseEnum<Enums.DesignStatus>(dataGrid3DDesign.Rows[e.RowIndex].Cells["DesignStatus"].Value.ToString());
            if (designStatus == Enums.DesignStatus.Void)
            {
                dataGrid3DDesign.Rows[e.RowIndex].Cells["DesignStatus"].Style.BackColor = Color.Blue;
            }
            if (designStatus == Enums.DesignStatus.În_lucru)
            {
                dataGrid3DDesign.Rows[e.RowIndex].Cells["DesignStatus"].Style.BackColor = Color.Yellow;
            }
            if (designStatus == Enums.DesignStatus.Plănuit)
            {
                dataGrid3DDesign.Rows[e.RowIndex].Cells["DesignStatus"].Style.BackColor = Color.Orange;
            }
            if (designStatus == Enums.DesignStatus.Finlizată)
            {
                dataGrid3DDesign.Rows[e.RowIndex].Cells["DesignStatus"].Style.BackColor = Color.Green;
            }
            if (designStatus == Enums.DesignStatus.În_așteptare)
            {
                dataGrid3DDesign.Rows[e.RowIndex].Cells["DesignStatus"].Style.BackColor = Color.LightYellow;
            }

            if(dataGrid3DDesign.Rows[e.RowIndex].Cells["ProjectName"].Value.ToString() != string.Empty)
            {
                dataGrid3DDesign.Rows[e.RowIndex].Cells["ProjectName"].Style.BackColor = Color.LightGreen;
            }
            else
            {
                dataGrid3DDesign.Rows[e.RowIndex].Cells["ProjectName"].Style.BackColor = Color.LightYellow;
            }

            if (designStatus != Enums.DesignStatus.Finlizată)
            {
                if ((DateTime)dataGrid3DDesign.Rows[e.RowIndex].Cells["DeadLineDate"].Value < DateTime.Today)
                {
                    dataGrid3DDesign.Rows[e.RowIndex].Cells["DeadLineDate"].Style.BackColor = Color.Red;
                }
                if ((DateTime)dataGrid3DDesign.Rows[e.RowIndex].Cells["DeadLineDate"].Value == DateTime.Today)
                {
                    dataGrid3DDesign.Rows[e.RowIndex].Cells["DeadLineDate"].Style.BackColor = Color.Yellow;
                }
            }
        }
        #endregion

        private void btnView3DDesign_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifySelectedRowForEdit())
                    _presenter.Open3DDesign((_3DDesign)dataGrid3DDesign.Rows[dataGrid3DDesign.SelectedRows[0].Index].DataBoundItem);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                Refresh();
            }
        }
    }
}
