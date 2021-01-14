using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;
using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP
{
    public partial class frmAttributeColorsList : Form, IAttributeColorsListView
    {
        #region private members
        private AttributeColorListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmAttributeColorsList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<AttributeColor> AttributeColors
        {
            set
            {
                if (value == null) return;
                var slColors = new SortableList<AttributeColor>(value);
                dataGridAttributeColors.DataSource = slColors;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "Tshirts",
                    "Filaments",
                    "Vinyls"
                };

                if (dataGridAttributeColors.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridAttributeColors.Columns[column].Visible = false;
                    }
                }
            }
        }

        public void AttachPresenter(AttributeColorListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events

        private void frmAttributeColorList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }

        private void frmAttributeColorList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAttributeColorDetails childForm = new frmAttributeColorDetails();
            AttributeColorDetailsPresenter presenter = new AttributeColorDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            //childForm.Init();
            childForm.AttributeColor = new AttributeColor();
            childForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridAttributeColors.SelectedRows.Count > 0)
                {
                    editColor((AttributeColor)dataGridAttributeColors.Rows[dataGridAttributeColors.SelectedRows[0].Index].DataBoundItem);
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

        private void dataGridAttributeColors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridAttributeColors.SelectedRows.Count > 0)
                {
                    editColor((AttributeColor)dataGridAttributeColors.Rows[e.RowIndex].DataBoundItem);
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
                if (dataGridAttributeColors.SelectedRows.Count > 0)
                {
                    editColor((AttributeColor)dataGridAttributeColors.Rows[dataGridAttributeColors.SelectedRows[0].Index].DataBoundItem);
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
            deleteColor();
        }

        private void lbDelete_Click(object sender, EventArgs e)
        {
            deleteColor();
        }
        #endregion
        #region private functions
        private void editColor(AttributeColor Color)
        {
            if (VerifySelectedRowForEditing())
            {
                frmAttributeColorDetails childForm = new frmAttributeColorDetails();
                AttributeColorDetailsPresenter presenter = new AttributeColorDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                //childForm.Init();
                childForm.AttributeColor = Color;
                childForm.ShowDialog();
            }
        }

        private void deleteColor()
        {
            try
            {
                List<AttributeColor> ColorsToDelete = new List<AttributeColor>();
                foreach (DataGridViewRow row in dataGridAttributeColors.SelectedRows)
                {
                    AttributeColor Color = (AttributeColor)dataGridAttributeColors.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations.AttributeColor + " " + Color.Name + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        ColorsToDelete.Add(Color);
                    }
                }
                if (ColorsToDelete.Count > 0)
                    _presenter.DeleteAttributeColors(ColorsToDelete);
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
            if (dataGridAttributeColors.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridAttributeColors.SelectedRows.Count > 1)
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
