using FirmaAPP.BusinessLogic.UIConnector;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using AppContext = FirmaAPP.Common.AppContext;
using System.Windows.Forms;

namespace FirmaAPP
{
    public partial class frmOrder3DSalesDetails : Form , IOrder3DSalesDetailsView
    {

        #region PrivateMembers
        private Order3DSalesDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        private Order _order;
        #endregion

        #region Constructor
        public frmOrder3DSalesDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region View
        #region Order
        public int Order3DSaleId { get; set; }
        public Order Order
        {
            set
            {
                _order = value;
                if (_order.OrderID > 0)
                {
                    Order3DSaleId = _order.OrderID;
                    OtherPurchases = _presenter.GetOtherPurchasesOrderByOrderID(_order.OrderID);
                    FilamentOrders = _presenter.GetFilamentOrdersByOrderID(_order.OrderID);
                    _3DPrintOrders = _presenter.Get3DPrintOrdersByOrderID(_order.OrderID); 
                    _3DDesignOrders = _presenter.Get3DDesignOrdersByOrderID(_order.OrderID);
                    Bill = _order.Bill;
                    labelTotalPrice.Text = _order.TotalPrice.ToString();
                    cbOrderStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.OrderStatus>(_order.OrderStatus.ToString());
                    cbCustomer.SelectedIndex = _order.Customer != null ? cbCustomer.FindStringExact(_order.Provider.Name) : 0;
                    dateCreateTime.Value = _order.CreationDate;
                    dateDeadLine.Value = _order.DeadLineDate.HasValue ? _order.DeadLineDate.Value : dateDeadLine.MinDate;
                    dateFinishedTime.Value = _order.FinalizeDate ?? DateTime.Now.Date;
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
                _order.OrderID = this.Order3DSaleId;
                _order.OrderType = Common.Enums.OrderType.Vândut_3D;
                _order.CreationDate = dateCreateTime.Value;
                _order.DeadLineDate = dateDeadLine.Value;
                _order.OrderStatus = Enums.ParseEnum<Enums.OrderStatus>(cbOrderStatus.Text);
                _order.UserID = Common.AppContext.CurrentUserId;
                _order.ShippingPrice = (float)numericShippingPrice.Value;
                _order.TotalPrice = _presenter.GetOrderTotalPriceWithoutShipping() + (float)numericShippingPrice.Value;
                _order.ProviderID = _presenter.GetCustomerIDByName(cbCustomer.Text.ToString()); //To Do: check this too
                _order.Description = tbOrderDescription.Text;
                return _order;
            }
        }
        #endregion
        #region Filament
        public List<FilamentOrder> FilamentOrders
        {
            set
            {
                List<string> rowsGrid = _presenter.GetDataSourceForFilamentOrdersGrid(value);
                foreach (string row in rowsGrid)
                {
                    var OtherPurchaseAttributes = row.Split(',').ToList();
                    dataGridFilament.Rows.Add(OtherPurchaseAttributes.ToArray());
                }
                if (rowsGrid.Count > 0)
                {
                    panelFilamentDetails.Visible = true;
                    gbFilament.Visible = true;
                    panelFilamentDetails.Height += gbFilament.Height;

                }
            }
            get
            {
                List<FilamentOrder> _FilamentOrders = new List<FilamentOrder>();
                foreach (DataGridViewRow row in dataGridFilament.Rows)
                {
                    if (row.Cells["FilamentID"].Value != null)
                    {
                        FilamentOrder _FilamentOrder = new FilamentOrder();
                        _FilamentOrder.FilamentID = Convert.ToInt32(row.Cells["FilamentID"].Value);
                        _FilamentOrder.Quantity = Convert.ToSingle(row.Cells["FilamentQuantity"].Value);
                        _FilamentOrders.Add(_FilamentOrder);
                    }
                }

                return _FilamentOrders;
            }
        }
        #endregion
        #region 3DPrintOrders
        public List<_3DPrintOrder> _3DPrintOrders
        {
            set
            {
                List<string> rowsGrid = _presenter.GetDataSourceFor3DPrintOrdersGrid(value);
                foreach (string row in rowsGrid)
                {
                    var _3DPrintAttributes = row.Split(',').ToList();
                    dataGrid3DPrint.Rows.Add(_3DPrintAttributes.ToArray());
                }
                if (rowsGrid.Count > 0)
                {
                    panel3DPrintDetails.Visible = true;
                    gb3DPrint.Visible = true;
                    panel3DPrintDetails.Height += gb3DPrint.Height;
                }
            }
            get
            {
                List<_3DPrintOrder> _3DPrintOrders = new List<_3DPrintOrder>();
                foreach (DataGridViewRow row in dataGrid3DPrint.Rows)
                {
                    if (row.Cells["_3DPrintID"].Value != null)
                    {
                        _3DPrintOrder _3DPrintOrder = new _3DPrintOrder();
                        _3DPrintOrder._3DPrintID = Convert.ToInt32(row.Cells["_3DPrintID"].Value);
                        // _3DPrintOrder._3DPrint.Name = Convert.ToInt32(row.Cells["_3DPrintID"].Value);
                        _3DPrintOrder.FilamentID = _presenter.GetFilamentIDByFilamentName(row.Cells["_3DPrintFilament"].Value.ToString());
                        _3DPrintOrder.PrintingTimeInMin = Convert.ToInt32(row.Cells["PrintingTimeInMin"].Value);
                        _3DPrintOrder.Wheight = Convert.ToInt32(row.Cells["_3DPrintWeight"].Value);
                        _3DPrintOrder.Infill = Convert.ToInt32(row.Cells["_3DPrintInfill"].Value);
                        _3DPrintOrder.Quality = Enums.ParseEnum<Enums._3DPrintQuality>(row.Cells["_3DPrintQuality"].Value.ToString());
                        _3DPrintOrder.PrintsQuantity = Convert.ToInt32(row.Cells["_3DPrintsQuantity"].Value);    
                        _3DPrintOrder.TotalPrice = Convert.ToInt32(row.Cells["_3DPrintPrice"].Value);

                        _3DPrintOrders.Add(_3DPrintOrder);
                    }
                }

                return _3DPrintOrders;
            }
        }
        #endregion
        #region 3DDesignOrders
        public List<_3DDesignOrder> _3DDesignOrders
        {
            set
            {
                List<string> rowsGrid = _presenter.GetDataSourceFor3DDesignOrdersGrid(value);
                foreach (string row in rowsGrid)
                {
                    var _3DDesignAttributes = row.Split(',').ToList();
                    dataGrid3DDesign.Rows.Add(_3DDesignAttributes.ToArray());
                }
                if (rowsGrid.Count > 0)
                {
                    panel3DDesignDetails.Visible = true;
                    gb3DDesign.Visible = true;
                    panel3DDesignDetails.Height += gb3DDesign.Height;
                }
            }
            get
            {
                List<_3DDesignOrder> _3DDesignOrders = new List<_3DDesignOrder>();
                foreach (DataGridViewRow row in dataGrid3DDesign.Rows)
                {
                    if (row.Cells["_3DDesignID"].Value != null)
                    {
                        _3DDesignOrder _3DDesignOrder = new _3DDesignOrder();
                        _3DDesignOrder._3DDesignID = Convert.ToInt32(row.Cells["_3DDesignID"].Value);
                        //_3DDesignOrder._3DDesign.Name = row.Cells["_3DDesignID"].Value);

                        _3DDesignOrder.Price = Convert.ToInt32(row.Cells["_3DDesignPrice"].Value);

                        _3DDesignOrders.Add(_3DDesignOrder);
                    }
                }

                return _3DDesignOrders;
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

        #region Bill
        public int BillID { get; set; }
        private Bill _Bill;
        private byte[] _file;
        public Bill Bill
        {
            get
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
            set
            {
                if (value != null)
                {
                    cbBillStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.BillStatus>(value.BillStatus.ToString());
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

        public void AttachPresenter(Order3DSalesDetailsPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        #endregion

        #region Events
        private void frmOrder3DSalesDetails_Load(object sender, EventArgs e)
        {
            if (cbOrderStatus.SelectedIndex == 0)
                cbOrderStatus.SelectedIndex = 1; //set to initial status
            panel3DPrintDetails.Height -= gb3DPrint.Height;
            panelFilamentDetails.Height -= gbFilament.Height;
            panel3DDesignDetails.Height -= gb3DDesign.Height;
            panelOthersDetails.Height -= gbOtherPurchase.Height;
            panelBillDetails.Height -= panelAddBillDetails.Height;
        }

        #region Filament
        private void btnFilamentDetails_Click(object sender, EventArgs e)
        {
            panelFilamentDetails.Visible = !panelFilamentDetails.Visible;
            if (panelFilamentDetails.Visible)
                btnFilamentDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnFilamentDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAddFilament_Click(object sender, EventArgs e)
        {
            if (gbFilament.Visible)
                panelFilamentDetails.Height -= gbFilament.Height;
            else
                panelFilamentDetails.Height += gbFilament.Height;
            gbFilament.Visible = !gbFilament.Visible;
        }
        private void btnRemoveFilament_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridFilament.SelectedRows)
                {
                    dataGridFilament.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        private void btnAddNewFilament_Click(object sender, EventArgs e)
        {
            frmFilamentDetails childForm = new frmFilamentDetails();
            FilamentDetailsPresenter presenter = new FilamentDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Filament = new Filament();
            childForm.ShowDialog();
        }
        private void btnAddFilamentInGrid_Click(object sender, EventArgs e)
        {
            List<string> filamentOrderAttributes = new List<string>();
            var filamentAttributes = cbFilament.Text.Split(',').ToList();
            string providerName = cbFilamentProvider.Text.ToString();
            filamentOrderAttributes.AddRange(filamentAttributes);
            filamentOrderAttributes.Add(numericFilamentQuantity.Value.ToString());
            dataGridFilament.Rows.Add(filamentOrderAttributes.ToArray());
        }
        private void dataGridFilament_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveFilament.Enabled = true;
        }
        private void cbFilamentProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            initFilament(cbFilamentProvider.SelectedValue.ToString());
        }
        #endregion
        #region 3DPrint
        private void btn3DPrintDetails_Click(object sender, EventArgs e)
        {
            panel3DPrintDetails.Visible = !panel3DPrintDetails.Visible;
            if (panel3DPrintDetails.Visible)
                btn3DPrintDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btn3DPrintDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAdd3DPrint_Click(object sender, EventArgs e)
        {
            if (gb3DPrint.Visible)
                panel3DPrintDetails.Height -= gb3DPrint.Height;
            else
                panel3DPrintDetails.Height += gb3DPrint.Height;
            gb3DPrint.Visible = !gb3DPrint.Visible;
        }
        private void btnRemove3DPrint_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGrid3DPrint.SelectedRows)
                {
                    dataGrid3DPrint.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        private void btnAddNew3DPrint_Click(object sender, EventArgs e)
        {
            frm3DPrintDetails childForm = new frm3DPrintDetails();
            _3DPrintDetailsPresenter presenter = new _3DPrintDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm._3DPrint = new _3DPrint();
            childForm.ShowDialog();
        }
        private void dataGrid3DPrint_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemove3DPrint.Enabled = true;
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }
        private void dataGrid3DPrint_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }
        private void btnAdd3DPrintInGrid_Click(object sender, EventArgs e)
        {
            List<string> _3dPrintsOrderAttributes = new List<string>();
            //string filamentID = _3DPrint
            var _3DPrintAttributes = cb3DPrint.Text.Split(',').ToList();
            var filamentName = cb3DPrintFilament.Text.Substring(0, cb3DPrintFilament.Text.IndexOf(','));
            _3dPrintsOrderAttributes.AddRange(_3DPrintAttributes);
            _3dPrintsOrderAttributes.Add(filamentName);
            _3dPrintsOrderAttributes.Add(numeric3DPrintingTimeInMin.Value.ToString());
            _3dPrintsOrderAttributes.Add(numeric3DPrintWheight.Value.ToString());
            _3dPrintsOrderAttributes.Add(numeric3DPrintInfill.Value.ToString());
            _3dPrintsOrderAttributes.Add(cb3DPrintQuality.Text.ToString());
            _3dPrintsOrderAttributes.Add(numeric3DPrintQuantity.Value.ToString());
            _3dPrintsOrderAttributes.Add(numeric3DPrintTotalPrice.Value.ToString());

            dataGrid3DPrint.Rows.Add(_3dPrintsOrderAttributes.ToArray());
        }
        #endregion
        #region 3DDesign
        private void btn3DDesignDetails_Click(object sender, EventArgs e)
        {
            panel3DDesignDetails.Visible = !panel3DDesignDetails.Visible;
            if (panel3DDesignDetails.Visible)
                btn3DDesignDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btn3DDesignDetails.BackColor = Color.FromArgb(12, 7, 18);
        }
        private void btnAdd3DDesign_Click(object sender, EventArgs e)
        {
            if (gb3DDesign.Visible)
                panel3DDesignDetails.Height -= gb3DDesign.Height;
            else
                panel3DDesignDetails.Height += gb3DDesign.Height;
            gb3DDesign.Visible = !gb3DDesign.Visible;
        }
        private void btnRemove3DDesign_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGrid3DDesign.SelectedRows)
                {
                    dataGrid3DDesign.Rows.Remove(row);
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void btnAddNew3DDesign_Click(object sender, EventArgs e)
        {
            frm3DDesignDetails childForm = new frm3DDesignDetails();
            _3DDesignDetailsPresenter presenter = new _3DDesignDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Init();
            childForm._3DDesign = new _3DDesign();
            childForm.ShowDialog();
        }

        private void btnAdd3DDesignInGrid_Click(object sender, EventArgs e)
        {
            List<string> _3DDesignOrderAttributes = new List<string>();
            var _3DDesignAttributes = cb3DDesign.Text.Split(',').ToList();
            _3DDesignOrderAttributes.AddRange(_3DDesignAttributes);
            _3DDesignOrderAttributes.Add(numeric3DDesignPrice.Value.ToString());
            dataGrid3DDesign.Rows.Add(_3DDesignOrderAttributes.ToArray());
        }
        private void dataGrid3DDesign_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemove3DDesign.Enabled = true;
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }
        private void dataGrid3DDesign_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }
        #endregion
        #region Customer
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
            }
            else
            {
                panelBillDetails.Height -= panelAddBillDetails.Height;
            }
            panelAddBillDetails.Visible = !panelAddBillDetails.Visible;

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
        private void numericShippingPrice_ValueChanged(object sender, EventArgs e)
        {
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
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
        #endregion
        #region Order Details
        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            panelOrderDetails.Visible = !panelOrderDetails.Visible;
            if (panelOrderDetails.Visible)
                btnOrderDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnOrderDetails.BackColor = Color.FromArgb(12, 7, 18);
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
                    cbBillStatus.DataSource = Enum.GetNames(typeof(Common.Enums.BillStatus));
                }
                initCustomer();
                initProviders();
                init3DPrint();
                init3DDesign();

                if(cbFilamentProvider.SelectedValue != null)
                    initFilament(cbFilamentProvider.SelectedValue.ToString());
                if (cbFilamentProvider.SelectedValue != null)
                    initOtherPurchase(cbOtherPuchaseProvider.SelectedValue.ToString());
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
        private void init3DPrint()
        {
            try
            {
                cb3DPrintFilament.DataSource = _presenter.GetAllFilaments();
                cb3DPrint.DataSource = _presenter.GetAll3DPrints();
                cb3DPrintQuality.DataSource = Enum.GetNames(typeof(Common.Enums._3DPrintQuality));
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        private void init3DDesign()
        {
            try
            {
                cb3DDesign.DataSource = _presenter.GetAll3DDesigns();
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
        private void initProviders()
        {
            try
            {
                cbFilamentProvider.DataSource = _presenter.GetAllProvidersName();
                cbOtherPuchaseProvider.DataSource = _presenter.GetAllProvidersName();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        private void initFilament(string providerName)
        {
            try
            {
                cbFilament.Text = string.Empty;
                cbFilament.DataSource = _presenter.GetFilamentsNameByProvider(providerName);
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
