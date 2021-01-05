using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppContext = FirmaAPP.Common.AppContext;

namespace FirmaAPP
{
    public partial class frmOrderTshirtSalesDetails : Form , IOrderTshirtSalesDetailsView
    {

        #region PrivateMembers
        private OrderTshirtSalesDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        private Order _order;
        #endregion
        #region Constructor
        public frmOrderTshirtSalesDetails()
        {
            InitializeComponent();
            panelVinylDetails.Height -= gbVinyl.Height;
            panelTshirtDetails.Height -= gbTshirt.Height;
        }
        #endregion
        #region View
        #region Order
        public int OrderTshirtSaleId { get; set; }
        public Order Order
        {
            set
            {
                _order = value;
                if (_order.OrderID > 0)
                {
                    OtherPurchases = _presenter.GetOtherPurchasesOrderByOrderID(_order.OrderID);
                    // FilamentOrders = _presenter.GetFilamentOrdersByOrderID(_order.OrderID);
                    VinylOrders = _presenter.GetVinylOrdersByOrderID(_order.OrderID);
                    TshirtOrders = _presenter.GetTshirtOrdersByOrderID(_order.OrderID);
                    Bill = _order.Bill;
                    labelTotalPrice.Text = _order.TotalPrice.ToString();
                    cbOrderStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.OrderStatus>(_order.OrderStatus.ToString());
                    cbCustomer.SelectedIndex = _order.Customer != null ? cbCustomer.FindStringExact(_order.Provider.Name) : 0;
                    dateCreateTime.Value = _order.CreationDate;
                    dateDeadLine.Value = _order.DeadLineDate.HasValue ? _order.DeadLineDate.Value : dateDeadLine.MinDate;
                    dateFinishedTime.Value = _order.FinalizeDate ?? DateTime.Now.Date;
                    this.OrderTshirtSaleId = _order.OrderID;
                    numericShippingPrice.Value = (decimal)_order.ShippingPrice;
                    tbOrderDescription.Text = _order.Description;
                    if (_order != null && _order.OrderID > 0 && _order.OrderStatus != Enums.OrderStatus.Trebuie_plasată)
                    {
                        btnConfirm.Visible = false;
                        btnCancel.Visible = false;
                    }
                }
            }
            get
            {
                _order.OrderID = this.OrderTshirtSaleId;
                _order.OrderType = Common.Enums.OrderType.Vândut_tricou;
                _order.CreationDate = dateCreateTime.Value;
                _order.DeadLineDate = dateDeadLine.Value;
                _order.OrderStatus = Enums.ParseEnum < Enums.OrderStatus > (cbOrderStatus.Text);
                _order.UserID = Common.AppContext.CurrentUserId;
                _order.ShippingPrice = (float)numericShippingPrice.Value;
                _order.TotalPrice = _presenter.GetOrderTotalPriceWithoutShipping() + (float)numericShippingPrice.Value;

                _order.ProviderID = _presenter.GetCustomerIDByName(cbCustomer.Text.ToString()); // TO DO: check this looking  fishy
                _order.Description = tbOrderDescription.Text;
                return _order;
            }
        }
        #endregion

        #region Tshirt
        public List<TshirtOrder> TshirtOrders
        {
            set
            {
                List<string> rowsGrid = _presenter.GetDataSourceForTshirtOrdersGrid(value);
                foreach (string row in rowsGrid)
                {
                    var OtherPurchaseAttributes = row.Split(',').ToList();
                    dataGridTshirt.Rows.Add(OtherPurchaseAttributes.ToArray());
                }
                if (rowsGrid.Count > 0)
                {
                    panelTshirtDetails.Visible = true;
                    gbTshirt.Visible = true;
                    panelTshirtDetails.Height += gbTshirt.Height;

                }
            }
            get
            {
                List<TshirtOrder> _TshirtOrders = new List<TshirtOrder>();
                foreach (DataGridViewRow row in dataGridTshirt.Rows)
                {
                    if (row.Cells["TshirtID"].Value != null)
                    {
                        TshirtOrder _TshirtOrder = new TshirtOrder();
                        _TshirtOrder.TshirtID = Convert.ToInt32(row.Cells["TshirtID"].Value);
                        _TshirtOrder.Quantity = Convert.ToInt32(row.Cells["TshirtQuantity"].Value);
                        _TshirtOrder.TotalPrice = Convert.ToSingle(row.Cells["TshirtPrice"].Value);
                        _TshirtOrders.Add(_TshirtOrder);
                    }
                }
                return _TshirtOrders;
            }
        }
        #endregion

        #region OtherPruchase
        public List<OtherPurchaseOrder> OtherPurchases
        {
            set
            {
                List<string> rowsGrid = _presenter.GetDataSourceForOtherPurchaseGrid(value);
                foreach (string row in rowsGrid)
                {
                    var OtherPurchaseAttributes = row.Split(',').ToList();
                    dataGridOtherPurchase.Rows.Add(OtherPurchaseAttributes.ToArray());
                }
                if (rowsGrid.Count > 0)
                {
                    panelOthersDetails.Visible = true;
                    gbOtherPurchase.Visible = true;
                    panelOthersDetails.Height += gbOtherPurchase.Height;
                }
            }
            get
            {
                List<OtherPurchaseOrder> _OtherPurchaseOrders = new List<OtherPurchaseOrder>();
                foreach (DataGridViewRow row in dataGridOtherPurchase.Rows)
                {
                    if (row.Cells["OtherPurchaseID"].Value != null)
                    {
                        OtherPurchaseOrder _OtherPurchaseOrder = new OtherPurchaseOrder();
                        _OtherPurchaseOrder.OtherPurchaseID = Convert.ToInt32(row.Cells["OtherPurchaseID"].Value);
                        _OtherPurchaseOrder.Quantity = Convert.ToSingle(row.Cells["OtherPurchaseQuantity"].Value);
                   //     _OtherPurchaseOrder.TotalPrice = Convert.ToSingle(row.Cells["OtherPurchasePrice"].Value);
                        _OtherPurchaseOrders.Add(_OtherPurchaseOrder);
                    }
                }

                return _OtherPurchaseOrders;
            }
        }
        #endregion

        #region Vinyl
        public List<VinylOrder> VinylOrders
        {
            set
            {
                List<string> rowsGrid = _presenter.GetDataSourceForVinylOrdersGrid(value);
                foreach (string row in rowsGrid)
                {
                    var OtherPurchaseAttributes = row.Split(',').ToList();
                    dataGridVinyl.Rows.Add(OtherPurchaseAttributes.ToArray());
                }
                if (rowsGrid.Count > 0)
                {
                    panelVinylDetails.Visible = true;
                    gbVinyl.Visible = true;
                    panelVinylDetails.Height += gbVinyl.Height;

                }
            }
            get
            {
                List<VinylOrder> _vinylOrders = new List<VinylOrder>();
                foreach (DataGridViewRow row in dataGridVinyl.Rows)
                {
                    if (row.Cells["VinylID"].Value != null)
                    {
                        VinylOrder _vinylOrder = new VinylOrder();
                        _vinylOrder.VinylID = Convert.ToInt32(row.Cells["VinylID"].Value);
                        _vinylOrder.Quantity = Convert.ToSingle(row.Cells["VinylQuantity"].Value);
                    //    _vinylOrder.TotalPrice = Convert.ToSingle(row.Cells["VinylPrice"].Value);
                        _vinylOrders.Add(_vinylOrder);
                    }
                }

                return _vinylOrders;
            }
        }
        #endregion

        #region Bill
        public int BillID { get; set; }
        private Bill _Bill;
        private byte[] _file;
        public Bill Bill
        {
            get
            {
                if (tbBillFile.Text != string.Empty)
                {
                    _Bill = new Bill
                    {
                        BillID = this.BillID,
                        BillName = tbBillName.Text,
                        BillStatus = Enums.ParseEnum<Enums.BillStatus>(cbBillStatus.SelectedValue.ToString()),
                        Description = tbBillDescription.Text,
                        FileName = tbBillFile.Text,
                        File = _file != null ? _file : File.ReadAllBytes(tbBillFile.Text),
                        BillDate = dateTimeBill.Value
                        // _order = Order

                    };

                    return _Bill;
                }
                else
                    return null;
            }
            set
            {
                if (value != null)
                {
                    cbBillStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.BillStatus>(value.BillStatus.ToString());
                    if(value.BillStatus != Enums.BillStatus.Fără_factură)
                     dateTimeBill.Value = value.BillDate;
                    BillID = value.BillID;
                    tbBillName.Text = value.BillName;
                    tbBillDescription.Text = value.Description;
                    tbBillFile.Text = value.FileName;
                    _file = value.File;
                }
            }
        }
        #endregion
        public void AttachPresenter(OrderTshirtSalesDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion
        #region Events
        private void frmOrderTshirtSalesDetails_Load(object sender, EventArgs e)
        {
            if (cbOrderStatus.SelectedIndex == 0)
                    cbOrderStatus.SelectedIndex = 1; //set to initial status
            panelOthersDetails.Height = panelVinylDetails.Height;
            panelBillDetails.Height -= panelAddBillDetails.Height;
            AppContext.ActiveForms.Add(this);
        }
        private void frmOrderTshirtSalesDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(AppTranslations.MessageBoxInfoConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.AddSaleOrder();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                this.Close();
            }
        }
        #region Order Details
        private void numericShippingPrice_ValueChanged(object sender, EventArgs e)
        {
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }
        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            panelOrderDetails.Visible = !panelOrderDetails.Visible;
            if (panelOrderDetails.Visible)
                btnOrderDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnOrderDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails childForm = new frmCustomerDetails();
            CustomerDetailsPresenter presenter = new CustomerDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Customer = new Customer();
            childForm.ShowDialog();
        }
        #endregion
        #region Tshirt
        private void btnTshirtsDetails_Click(object sender, EventArgs e)
        {
            panelTshirtDetails.Visible = !panelTshirtDetails.Visible;
            if (panelTshirtDetails.Visible)
                btnTshirtsDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnTshirtsDetails.BackColor = Color.FromArgb(12, 7, 18);
        }

        private void btnAddTshirt_Click(object sender, EventArgs e)
        {
            if (gbTshirt.Visible)
                panelTshirtDetails.Height -= gbTshirt.Height;
            else
                panelTshirtDetails.Height += gbTshirt.Height;
            gbTshirt.Visible = !gbTshirt.Visible;
        }

        private void btnRemoveTshirt_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridTshirt.SelectedRows)
                {
                    dataGridTshirt.Rows.Remove(row);
                }
                labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnAddNewTshirt_Click(object sender, EventArgs e)
        {
            addNewTshirt(new Tshirt());
        }

        private void addNewTshirt(Tshirt tshirt)
        {
            frmTshirtDetails childForm = new frmTshirtDetails();
            TshirtDetailsPresenter presenter = new TshirtDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.Tshirt = tshirt;
            childForm.ShowDialog();
        }

        private void btnAddTshirtInGrid_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> TshirtOrderAttributes = new List<string>();
                var tshirtAttributes = cbTshirt.Text.Split(',').ToList();
                string sex = cbTshirtSex.Text.ToString();
                string size = cbTshirtSize.Text.ToString();
                tshirtAttributes.Add(sex);
                tshirtAttributes.Add(size);
                int id = _presenter.GetTshirtIDByAttributes(tshirtAttributes, cbTshirtProvider.Text.ToString());

                TshirtOrderAttributes.Add(id.ToString());
                TshirtOrderAttributes.Add(cbTshirtProvider.Text.ToString());
                TshirtOrderAttributes.AddRange(tshirtAttributes);
                TshirtOrderAttributes.Add(numericTshirtQuantity.Value.ToString());
                TshirtOrderAttributes.Add(numericTshirtPrice.Value.ToString());
                if (id != 0)
                {
                    dataGridTshirt.Rows.Add(TshirtOrderAttributes.ToArray());
                }
                else
                {
                    var result = MessageBox.Show("Tricoul nu este salvat în stoc. Doriți introducerea lui?", "Adăugare tricou nou?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Tshirt tshirt = new Tshirt
                        {
                            Type = Enums.ParseEnum<Enums.TshirtType>(tshirtAttributes[0]),
                            Color = Enums.ParseEnum<Enums.Color>(tshirtAttributes[1]),
                            Rating = Enums.ParseEnum<Enums.Rating>(tshirtAttributes[2]),
                            Sex = Enums.ParseEnum<Enums.Sex>(tshirtAttributes[3]),
                            Size = Enums.ParseEnum<Enums.TshirtSize>(tshirtAttributes[4]),
                            Provider = _presenter.GetProviderByName(cbCustomer.Text.ToString())
                        };
                        addNewTshirt(tshirt);
                    }
                }

                labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;

            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void dataGridTshirt_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveTshirt.Enabled = true;
        }

        private void cbTshirtProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            initTshirt(cbTshirtProvider.SelectedValue.ToString());
        }

        #endregion
        #region Vinyl
        private void btnVinylDetails_Click(object sender, EventArgs e)
        {
            panelVinylDetails.Visible = !panelVinylDetails.Visible;
            if (panelVinylDetails.Visible)
                btnVinylDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnVinylDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAddVinyl_Click(object sender, EventArgs e)
        {
            if (gbVinyl.Visible)
                panelVinylDetails.Height -= gbVinyl.Height;
            else
                panelVinylDetails.Height += gbVinyl.Height;
            gbVinyl.Visible = !gbVinyl.Visible;
        }

        private void btnRemoveVinyl_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridVinyl.SelectedRows)
                {
                    dataGridVinyl.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnAddNewVinyl_Click(object sender, EventArgs e)
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

        private void btnAddVinylInGrid_Click(object sender, EventArgs e)
        {
            if (cbViynl.Items.Count != 0 )
            {
                List<string> vinylOrderAttributes = new List<string>();
                var vinylAttributes = cbViynl.Text.Split(',').ToList();
                string providerName = cbVinylProvider.Text.ToString();
                vinylOrderAttributes.AddRange(vinylAttributes);
                vinylOrderAttributes.Add(numericVinylQuantity.Value.ToString());
                vinylOrderAttributes.Add(providerName);
                dataGridVinyl.Rows.Add(vinylOrderAttributes.ToArray());
            }
        }
        private void dataGridVinyl_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveVinyl.Enabled = true;
        }
        private void cbVinylProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            initVinyl(cbVinylProvider.SelectedValue.ToString());
        }
        #endregion
        #region Other Purchase
        private void btnOtherPurchaseDetails_Click(object sender, EventArgs e)
        {
            panelOthersDetails.Visible = !panelOthersDetails.Visible;
            if (panelOthersDetails.Visible)
                btnOtherPurchaseDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnOtherPurchaseDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAddOtherPurchase_Click(object sender, EventArgs e)
        {
            if (gbOtherPurchase.Visible)
                panelOthersDetails.Height -= gbOtherPurchase.Height;
            else
                panelOthersDetails.Height += gbOtherPurchase.Height;
            gbOtherPurchase.Visible = !gbOtherPurchase.Visible;
        }

        private void btnRemoveOtherPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridOtherPurchase.SelectedRows)
                {
                    dataGridOtherPurchase.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnAddNewOtherPurchase_Click(object sender, EventArgs e)
        {
            frmOtherPurchaseDetails childForm = new frmOtherPurchaseDetails();
            OtherPurchaseDetailsPresenter presenter = new OtherPurchaseDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm.OtherPurchase = new OtherPurchase();
            childForm.ShowDialog();
        }

        private void btnAddOtherPurchaseInGrid_Click(object sender, EventArgs e)
        {
            if (cbOtherPurchase.Items.Count != 0)
            {
                List<string> OtherPurchaseOrderAttributes = new List<string>();
                var OtherPurchaseAttributes = cbOtherPurchase.Text.Split(',').ToList();
                string providerName = cbOtherPuchaseProvider.Text.ToString();
                OtherPurchaseOrderAttributes.AddRange(OtherPurchaseAttributes);
                OtherPurchaseOrderAttributes.Add(numericOtherPurchaseQuantity.Value.ToString());
                OtherPurchaseOrderAttributes.Add(providerName);
                dataGridOtherPurchase.Rows.Add(OtherPurchaseOrderAttributes.ToArray());
            }
        }

        private void dataGridOtherPurchase_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveOtherPurchase.Enabled = true;
        }
        private void cbOtherPuchaseProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            initOtherPurchase(cbOtherPuchaseProvider.SelectedValue.ToString());
        }
        #endregion
        #region Bill
        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            panelBillDetails.Visible = !panelBillDetails.Visible;
            if (panelBillDetails.Visible)
                btnBillDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnBillDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            if (!panelAddBillDetails.Visible)
            {
                panelBillDetails.Height += panelAddBillDetails.Height;
                panelAddBillDetails.Visible = !panelAddBillDetails.Visible;
            }
            else
            {
                panelAddBillDetails.Visible = !panelAddBillDetails.Visible;
                panelBillDetails.Height -= panelAddBillDetails.Height;
            }
        }
        private void btnRemoveBill_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBillFile_Click(object sender, EventArgs e)
        {
                        try
            {
                string path = AppContext.FolderBillPath;
                path += "\\" + AppTranslations.BillSellingType;
                path += "\\" + Bill.BillDate.Year.ToString();
                path += "\\" + Bill.BillDate.Month.ToString();
                path += "\\" + Bill.BillDate.Day.ToString();
                path += "\\" + tbBillFile.Text;

                if (File.Exists(path))
                    Process.Start(path);
                else
                    throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.FileDoNotExist);
                //TO DO Create File if not exist
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnAddBillFile_Click(object sender, EventArgs e)
        {
            DialogResult resultFile = openBillFile.ShowDialog();
            if (resultFile == DialogResult.OK)
            {
                tbBillFile.Text = openBillFile.FileName;
            }
        }
        #endregion
        #endregion
        #region public functions
        public void AttachMainForm(frmMainForm form)
        {
            _mainForm = form;
        }

        public void AttachParentForm(Form form)
        {
            _parentForm = form;
        }

        public void Init()
        {
            try
            {
                if (cbOrderStatus.DataSource == null)
                {
                    cbOrderStatus.DataSource = Enum.GetNames(typeof(Common.Enums.OrderStatus));
                    cbTshirtSex.DataSource = Enum.GetNames(typeof(Common.Enums.Sex));
                    cbTshirtSize.DataSource = Enum.GetNames(typeof(Common.Enums.TshirtSize));
                    cbBillStatus.DataSource = Enum.GetNames(typeof(Common.Enums.BillStatus));
                }

                initCustomer();
                initProviders();
                if(cbVinylProvider.SelectedValue != null)
                    initVinyl(cbVinylProvider.SelectedValue.ToString());
                if (cbOtherPuchaseProvider.SelectedValue != null)
                    initOtherPurchase(cbOtherPuchaseProvider.SelectedValue.ToString());
                if (cbTshirtProvider.SelectedValue != null)
                    initTshirt(cbTshirtProvider.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                this.Close();
            }
        }
        #endregion
        #region private functions
        private void initCustomer()
        {
            try
            {
                if (cbCustomer.DataSource != null)
                {
                    var actualIndex = cbCustomer.SelectedIndex;
                    cbCustomer.DataSource = _presenter.GetAllCustomersName();
                    cbCustomer.SelectedIndex = actualIndex;
                }
                else
                {
                    cbCustomer.DataSource = _presenter.GetAllCustomersName();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void initProviders()
        {
            try
            {
                cbOtherPuchaseProvider.DataSource = _presenter.GetAllProvidersName();
                cbTshirtProvider.DataSource = _presenter.GetAllProvidersName();
                cbVinylProvider.DataSource = _presenter.GetAllProvidersName();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void clearDataGrids()
        {
            try
            {
                dataGridVinyl.DataSource = null;
                dataGridVinyl.Rows.Clear();
                dataGridTshirt.DataSource = null;
                dataGridTshirt.Rows.Clear();
                dataGridOtherPurchase.DataSource = null;
                dataGridOtherPurchase.Rows.Clear();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        private void initVinyl(string providerName)
        {
            try
            {
                cbViynl.Text = string.Empty;
                cbViynl.DataSource = _presenter.GetVinylsNameByProvider(providerName);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void initTshirt(string providerName)
        {
            try
            {
                cbTshirt.Text = string.Empty;
                cbTshirt.DataSource = _presenter.GetTshirtsNameByProvider(providerName);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void initOtherPurchase(string providerName)
        {
            try
            {
                cbOtherPurchase.Text = string.Empty;
                cbOtherPurchase.DataSource = _presenter.GetOtherPurchasesNameByProvider(providerName);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        #endregion
        #region override functions
        public override void Refresh()
        {
            this.Init();
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(AppTranslations.CancelConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
