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
    public partial class frm3DPrintsList : Form, I3DPrintListView
    {

        #region private members
        private _3DPrintListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region View
        public List<_3DPrint> _3DPrints
        {
            set
            {
                if (value == null || value.Count == 0) return;
                var sl3DPrints = new SortableList<_3DPrint>(value);

                dataGrid3DPrint.DataSource = sl3DPrints;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "_3DDesignID",
                    "_3DDesign",
                    "_3DPrintOrders",
                    "FileGCode"
                };
                if (dataGrid3DPrint.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGrid3DPrint.Columns[column].Visible = false;
                    }
                }
            }
        }
        public void AttachPresenter(_3DPrintListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion

        #region Constructor
        public frm3DPrintsList()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void frm3DPrintsDetails_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frm3DPrintsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAdd3DPrint_Click(object sender, EventArgs e)
        {
            frm3DPrintDetails childForm = new frm3DPrintDetails();
            _3DPrintDetailsPresenter presenter = new _3DPrintDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm._3DPrint = new _3DPrint();
            childForm.ShowDialog();
        }

        private void btnEdit3DPrint_Click(object sender, EventArgs e)
        {
            if (VerifySelectedRowForEditing())
            {
                edit3DPrint((_3DPrint)dataGrid3DPrint.Rows[dataGrid3DPrint.SelectedRows[0].Index].DataBoundItem);
            }
        }

        private void lbEdit3DPrint_Click(object sender, EventArgs e)
        {
            if (VerifySelectedRowForEditing())
            {
                edit3DPrint((_3DPrint)dataGrid3DPrint.Rows[dataGrid3DPrint.SelectedRows[0].Index].DataBoundItem);
            }
        }

        private void dataGrid3DPrint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                edit3DPrint((_3DPrint)dataGrid3DPrint.Rows[e.RowIndex].DataBoundItem);
        }

        private void btnDelete3DPrint_Click(object sender, EventArgs e)
        {
            delete3DPrint();
        }

        private void lbDelete3DPrint_Click(object sender, EventArgs e)
        {
            delete3DPrint();
        }
        #endregion
        #region private functions
        private void edit3DPrint(_3DPrint _3Dprint)
        {
            frm3DPrintDetails childForm = new frm3DPrintDetails();
            _3DPrintDetailsPresenter presenter = new _3DPrintDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm._3DPrint = _3Dprint;
            childForm.ShowDialog();
        }

        private void delete3DPrint()
        {
            try
            {
                List<_3DPrint> printsToDelete = new List<_3DPrint>();
                foreach (DataGridViewRow row in dataGrid3DPrint.SelectedRows)
                {
                    _3DPrint print = (_3DPrint)dataGrid3DPrint.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(
                        AppTranslations.DeleteQuestion +
                        AppTranslations._3DPrint +
                        print.Name + "?",
                        AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.Yes)
                    {
                        printsToDelete.Add(print);
                    }
                }
                if (printsToDelete.Count > 0)
                    _presenter.Delete3DPrints(printsToDelete);
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
            if (dataGrid3DPrint.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGrid3DPrint.SelectedRows.Count > 1)
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
        #region Grid Style
        private void dataGrid3DPrint_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGrid3DPrint.Rows[e.RowIndex].Cells["FileName"].Value.ToString() != string.Empty)
            {
                dataGrid3DPrint.Rows[e.RowIndex].Cells["FileName"].Style.BackColor = Color.LightGreen;
            }
            else
            {
                dataGrid3DPrint.Rows[e.RowIndex].Cells["_3DDesignName"].Style.BackColor = Color.LightYellow;
            }

            if (dataGrid3DPrint.Rows[e.RowIndex].Cells["_3DDesignName"].Value.ToString() != string.Empty)
            {
                dataGrid3DPrint.Rows[e.RowIndex].Cells["_3DDesignName"].Style.BackColor = Color.LightGreen;
            }
            else
            {
                dataGrid3DPrint.Rows[e.RowIndex].Cells["_3DDesignName"].Style.BackColor = Color.LightYellow;
            }

        }
        #endregion

        private void btnView3DPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifySelectedRowForEditing())
                    _presenter.Open3DPrint((_3DPrint)dataGrid3DPrint.Rows[dataGrid3DPrint.SelectedRows[0].Index].DataBoundItem);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                Refresh();
            }
        }
    }
}
