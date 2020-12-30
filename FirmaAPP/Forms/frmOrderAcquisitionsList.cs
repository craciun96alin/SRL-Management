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
    public partial class frmOrderAcquisitionsList : Form, IOrderAcquisitionListView
    {
        #region private members
        private OrderAcquisitionListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion

        public frmOrderAcquisitionsList()
        {
            InitializeComponent();
        }

        #region View

        public List<Order> Orders
        {
            set
            {
                if (value == null) return;
                var slAcquisitions = new SortableList<Order>(value);

                dataGridAcquistionsList.DataSource = slAcquisitions;
                List<string> lstColumnsToBeRemoved = new List<string>()
                {
                    "OrderType",
                    "CustomerID",
                    "ProviderID", // add new field
                    "BillID", // add new field
                    "DeadLineDate",
                    "UserID",
                    "Customer",
                    "Provider",
                    "Bill",
                    "User", // new field maybe
                    "_tshirtOrders",
                    "_3DPrintOrders",
                    "_3DDesignOrders",
                    "_filamentOrders",
                    "_vinylOrders",
                    "_otherPurchaseOrders",
                    "CustomerName"
                };
                if (dataGridAcquistionsList.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridAcquistionsList.Columns[column].Visible = false;
                    }
                }


            }
        }

        public void AttachPresenter(OrderAcquisitionListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion

        #region Events
        private void btnAddAcquisition_Click(object sender, EventArgs e)
        {
            frmOrderAcquisitionDetails childForm = new frmOrderAcquisitionDetails();
            OrderAcquisitionDetailsPresenter presenter = new OrderAcquisitionDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.Order = new Order();
            childForm.Show();
        }
        private void btnEditAcquisition_Click(object sender, EventArgs e)
        {
            if (VerifySelectedRowForEdit())
            {
                editAcquisitionOrder((Order)dataGridAcquistionsList.Rows[dataGridAcquistionsList.SelectedRows[0].Index].DataBoundItem);
            }
        }

        private void lbEditAcquisition_Click(object sender, EventArgs e)
        {
            if (VerifySelectedRowForEdit())
            {
                editAcquisitionOrder((Order)dataGridAcquistionsList.Rows[dataGridAcquistionsList.SelectedRows[0].Index].DataBoundItem);
            }
        }

        private void dataGridAcquistionsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            editAcquisitionOrder((Order)dataGridAcquistionsList.Rows[e.RowIndex].DataBoundItem);
        }
        private void btnDeleteAcquisition_Click(object sender, EventArgs e)
        {
            deleteOrder();
        }
        private void lbDeleteAcquisition_Click(object sender, EventArgs e)
        {
            deleteOrder();
        }
        #endregion

        private void frmOrderAcquisitionsList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }

        private void frmOrderAcquisitionsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        #region public functions
        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }

        #endregion
        #region private functions
        private void deleteOrder()
        {
            try
            {
                List<Order> OrdersToDelete = new List<Order>();
                foreach (DataGridViewRow row in dataGridAcquistionsList.SelectedRows)
                {
                    Order Order = (Order)dataGridAcquistionsList.Rows[row.Index].DataBoundItem;
                    var result = MessageBox.Show(AppTranslations.DeleteQuestion + AppTranslations.AcquisitionOrder + " " + Order.OrderID + "?", AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.Yes)
                    {
                        OrdersToDelete.Add(Order);
                    }
                }
                if (OrdersToDelete.Count > 0)
                    _presenter.DeleteOrders(OrdersToDelete);
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
        private void editAcquisitionOrder(Order order)
        {
            frmOrderAcquisitionDetails childForm = new frmOrderAcquisitionDetails();
            OrderAcquisitionDetailsPresenter presenter = new OrderAcquisitionDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.Order = order;
            childForm.ShowDialog();
        }
        private bool VerifySelectedRowForEdit()
        {
            if (dataGridAcquistionsList.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridAcquistionsList.SelectedRows.Count > 1)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtMostOneRow);
                return false;
            }
            return true;
        }
        #endregion
        #region override functions
        public override void Refresh()
        {
            _presenter.Init();
        }
        #endregion
        #region DataGridStyle
        private void dataGridAcquistionsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var orderStatus = Enums.ParseEnum<Enums.OrderStatus>(dataGridAcquistionsList.Rows[e.RowIndex].Cells["OrderStatus"].Value.ToString());
            if (orderStatus == Enums.OrderStatus.Trebuie_plasată)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Red;
            }
            if (orderStatus == Enums.OrderStatus.Plasată)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Yellow;
            }
            if (orderStatus == Enums.OrderStatus.Finalizată)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Green;
            }
            if (orderStatus == Enums.OrderStatus.În_lucru)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Orange;
            }
            if (orderStatus == Enums.OrderStatus.În_asteptare)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.LightYellow;
            }

            var billStatus = Enums.ParseEnum<Enums.BillStatus>(dataGridAcquistionsList.Rows[e.RowIndex].Cells["BillStatus"].Value.ToString());
            if (billStatus == Enums.BillStatus.Void)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Blue;
            }
            if (billStatus == Enums.BillStatus.Fără_factură)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Red;
            }
            if (billStatus == Enums.BillStatus.Neemisă)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Yellow;
            }
            if (billStatus == Enums.BillStatus.Emisă)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Orange;
            }
            if (billStatus == Enums.BillStatus.Finalizată)
            {
                dataGridAcquistionsList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Green;
            }
        }

        private void dataGridAcquistionsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    gbOrderStatus.Visible = true;

                    var orderStatus = Enums.ParseEnum<Enums.OrderStatus>(dataGridAcquistionsList.Rows[e.RowIndex].Cells["OrderStatus"].Value.ToString());
                    if (orderStatus == Enums.OrderStatus.Trebuie_plasată)
                    {
                        btnBackOrderStatus.Visible = false;
                        labelBackOrderStatus.Visible = false;
                        btnNextOrderStatus.BackgroundImage = global::FirmaAPP.Properties.Resources.NextIcon;
                    }
                    else if (orderStatus == Enums.OrderStatus.În_lucru)
                    {
                        btnBackOrderStatus.Visible = true;
                        labelBackOrderStatus.Visible = true;
                        btnNextOrderStatus.BackgroundImage = global::FirmaAPP.Properties.Resources.FinalizeIcon;
                    }
                    else
                    {
                        btnBackOrderStatus.Visible = true;
                        labelBackOrderStatus.Visible = true;
                        btnNextOrderStatus.BackgroundImage = global::FirmaAPP.Properties.Resources.NextIcon;
                    }
                    if(orderStatus == Enums.OrderStatus.Finalizată)
                    {
                        gbOrderStatus.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }

        }
        #endregion

        private void btnNextOrderStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifySelectedRowForEdit())
                {
                    var order = (Order)dataGridAcquistionsList.Rows[dataGridAcquistionsList.SelectedCells[0].RowIndex].DataBoundItem;
                    if (order.OrderStatus == Enums.OrderStatus.Trebuie_plasată)
                    {
                        frmBillDetails childForm = new frmBillDetails();
                        BillDetailsPresenter presenter = new BillDetailsPresenter(childForm);
                        childForm.MdiParent = this.MdiParent;
                        childForm.AttachMainForm(_mainForm);
                        childForm.AttachParentForm(this);
                        childForm.AttachPresenter(presenter);
                        childForm.OrderID = order.OrderID;
                        childForm.Init();
                        childForm.Bill = new Bill();
                        childForm.Show();
                    }
                    else if(order.OrderStatus == Enums.OrderStatus.Plasată)
                    {
                        var result = MessageBox.Show(AppTranslations.QPayWithExtraMoney, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Yes)
                        {
                            _presenter.UpdateDetailsMoneyAndStatus(order,Enums.MoneyFrom.Extra);
                        }
                        else
                        {
                            result = MessageBox.Show(AppTranslations.QPayWithCreditCart, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if(result == DialogResult.Yes)
                            {
                                _presenter.UpdateDetailsMoneyAndStatus(order, Enums.MoneyFrom.Digital);
                            }
                            else
                            result = MessageBox.Show(AppTranslations.QPayWithCash, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.Yes)
                            {
                                _presenter.UpdateDetailsMoneyAndStatus(order, Enums.MoneyFrom.Cash);
                            }
                        }
                    }
                    else if(order.OrderStatus == Enums.OrderStatus.În_lucru)
                    {
                        _presenter.UpdateStocksAndStatus(order);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                Refresh();
            }
        }


    }
}
