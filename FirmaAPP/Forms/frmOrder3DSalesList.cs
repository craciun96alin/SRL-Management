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
    public partial class frmOrder3DSalesList : Form, IOrder3DSalesListView
    {
        #region private members
        private Order3DSalesListPresenter _presenter;
        private frmMainForm _mainForm;
        #endregion
        #region Constructor
        public frmOrder3DSalesList()
        {
            InitializeComponent();
        }
        #endregion
        #region View

        public List<Order> Orders
        {
            set
            {
                if (value == null) return;
                var slAcquisitions = new SortableList<Order>(value);

                dataGridSalesList.DataSource = slAcquisitions;
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
                if (dataGridSalesList.Columns.Count > 0)
                {
                    foreach (string column in lstColumnsToBeRemoved)
                    {
                        dataGridSalesList.Columns[column].Visible = false;
                    }
                }


            }
        }

        public void AttachPresenter(Order3DSalesListPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events
        private void frmOrderSales3DList_Load(object sender, EventArgs e)
        {
            AppContext.ActiveForms.Add(this);
            _presenter.Init();
        }
        private void frmOrder3DSalesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrder3DSalesDetails childForm = new frmOrder3DSalesDetails();
                Order3DSalesDetailsPresenter presenter = new Order3DSalesDetailsPresenter(childForm);
                childForm.MdiParent = this.MdiParent;
                childForm.AttachMainForm(_mainForm);
                childForm.AttachParentForm(this);
                childForm.AttachPresenter(presenter);
                childForm.Init();
                childForm.Order = new Order();
                childForm.Show();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                Refresh();
            }
        }
        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            deleteOrder();
        }

        private void lbDeleteSale_Click(object sender, EventArgs e)
        {
            deleteOrder();
        }
        #endregion
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
                foreach (DataGridViewRow row in dataGridSalesList.SelectedRows)
                {
                    Order Order = (Order)dataGridSalesList.Rows[row.Index].DataBoundItem;
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
        private void editSale3DOrder(Order order)
        {
            try
            {
                if (VerifySelectedRowForEdit())
                {
                    frmOrder3DSalesDetails childForm = new frmOrder3DSalesDetails();
                    Order3DSalesDetailsPresenter presenter = new Order3DSalesDetailsPresenter(childForm);
                    childForm.MdiParent = this.MdiParent;
                    childForm.AttachMainForm(_mainForm);
                    childForm.AttachParentForm(this);
                    childForm.AttachPresenter(presenter);
                    childForm.Init();
                    childForm.Order = order;
                    childForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                Refresh();
            }
        }
        private bool VerifySelectedRowForEdit()
        {
            if (dataGridSalesList.SelectedRows.Count == 0)
            {
                ShowMessage(AppTranslations.WarningInfoBox + AppTranslations.SelectAtLeastOneRow);
                return false;
            }
            else if (dataGridSalesList.SelectedRows.Count > 1)
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
        private void dataGridSalesList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var orderStatus = Enums.ParseEnum<Enums.OrderStatus>(dataGridSalesList.Rows[e.RowIndex].Cells["OrderStatus"].Value.ToString());
            if (orderStatus == Enums.OrderStatus.Trebuie_plasată)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Red;
            }
            if (orderStatus == Enums.OrderStatus.Plasată)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Yellow;
            }
            if (orderStatus == Enums.OrderStatus.Finalizată)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Green;
            }
            if (orderStatus == Enums.OrderStatus.În_lucru)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.Orange;
            }
            if (orderStatus == Enums.OrderStatus.În_asteptare)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["OrderStatus"].Style.BackColor = Color.LightYellow;
            }

            var billStatus = Enums.ParseEnum<Enums.BillStatus>(dataGridSalesList.Rows[e.RowIndex].Cells["BillStatus"].Value.ToString());
            if (billStatus == Enums.BillStatus.Void)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Blue;
            }
            if (billStatus == Enums.BillStatus.Fără_factură)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Red;
            }
            if (billStatus == Enums.BillStatus.Neemisă)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Yellow;
            }
            if (billStatus == Enums.BillStatus.Emisă)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Orange;
            }
            if (billStatus == Enums.BillStatus.Finalizată)
            {
                dataGridSalesList.Rows[e.RowIndex].Cells["BillStatus"].Style.BackColor = Color.Green;
            }
        }

        private void dataGridSalesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    gbOrderStatus.Visible = true;

                    var orderStatus = Enums.ParseEnum<Enums.OrderStatus>(dataGridSalesList.Rows[e.RowIndex].Cells["OrderStatus"].Value.ToString());
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
                    if (orderStatus == Enums.OrderStatus.Finalizată)
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
        private void dataGridSalesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                editSale3DOrder((Order)dataGridSalesList.Rows[e.RowIndex].DataBoundItem);
        }

        private void btnNextOrderStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifySelectedRowForEdit())
                {
                    var order = (Order)dataGridSalesList.Rows[dataGridSalesList.SelectedCells[0].RowIndex].DataBoundItem;
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
                    else if (order.OrderStatus == Enums.OrderStatus.Plasată)
                    {
                        _presenter.UpdateStatus(order, Enums.OrderStatus.În_lucru);
                        Refresh();
                    }
                    else if (order.OrderStatus == Enums.OrderStatus.În_lucru)
                    {
                        var result = MessageBox.Show(AppTranslations.QPayWithExtraMoney, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (result == DialogResult.Yes)
                        {
                            _presenter.UpdateDetailsMoney(order, Enums.MoneyFrom.Extra);
                        }
                        else
                        {
                            result = MessageBox.Show(AppTranslations.QPayWithCreditCart, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.Yes)
                            {
                                _presenter.UpdateDetailsMoney(order, Enums.MoneyFrom.Digital);
                            }
                            else
                                result = MessageBox.Show(AppTranslations.QPayWithCash, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.Yes)
                            {
                                _presenter.UpdateDetailsMoney(order, Enums.MoneyFrom.Cash);
                            }
                        }
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
