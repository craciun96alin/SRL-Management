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
    public partial class frmOrderAcquisitionDetails : Form, IOrderAcquisitionDetailsView
    {
        // TO DO Open where exists data in grids
        #region PrivateMembers
        private OrderAcquisitionDetailsPresenter _presenter;
        private frmMainForm _mainForm;
        private Form _parentForm;
        private Order _order;
        #endregion
        #region Constructor
        public frmOrderAcquisitionDetails()
        {
            InitializeComponent();
            panelVinylDetails.Height -= gbVinyl.Height;
        }
        #endregion
        #region ViewMembers
        public int OrderAcquisitionId { get; set; }
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
                if(rowsGrid.Count > 0)
                {
                    panelOtherPurchaseDetails.Visible = true;
                    gbOtherPurchase.Visible = true;
                    panelOtherPurchaseDetails.Height += gbOtherPurchase.Height;
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
                        _OtherPurchaseOrder.TotalPrice = Convert.ToSingle(row.Cells["OtherPurchasePrice"].Value);
                        _OtherPurchaseOrders.Add(_OtherPurchaseOrder);
                    }
                }

                return _OtherPurchaseOrders;
            }
        }
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
                        _vinylOrder.TotalPrice =  Convert.ToSingle(row.Cells["VinylPrice"].Value);
                        _vinylOrders.Add(_vinylOrder);
                    }
                }

                return _vinylOrders;
            }
        }
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
                List<FilamentOrder> _filamentOrders = new List<FilamentOrder>();
                foreach (DataGridViewRow row in dataGridFilament.Rows)
                {
                    if (row.Cells["FilamentID"].Value != null)
                    {
                        FilamentOrder _filamentOrder = new FilamentOrder();
                        _filamentOrder.FilamentID = Convert.ToInt32(row.Cells["FilamentID"].Value); 
                        _filamentOrder.Quantity = Convert.ToSingle(row.Cells["FilamentQuantity"].Value);
                        _filamentOrder.TotalPrice = Convert.ToSingle(row.Cells["FilamentPrice"].Value);
                        _filamentOrders.Add(_filamentOrder);
                    }
                }
                return _filamentOrders;
            }
        }
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
                    dateTimeBill.Value = value.BillID != 2 ? value.BillDate : dateTimeBill.MinDate;
                    BillID = value.BillID;
                    tbBillName.Text = value.BillName;
                    tbBillDescription.Text = value.Description;
                    tbBillFile.Text = value.FileName;
                    _file = value.File;
                }
            }
        }
        public void ShowMessage(string message)
        {
            _mainForm.ShowMessage(message);
        }
        public Order Order
        {
            set
            {
                _order = value;
                if (_order.OrderID > 0)
                {
                    OtherPurchases = _presenter.GetOtherPurchasesOrderByOrderID(_order.OrderID);
                    FilamentOrders = _presenter.GetFilamentOrdersByOrderID(_order.OrderID);
                    VinylOrders    = _presenter.GetVinylOrdersByOrderID(_order.OrderID);
                    TshirtOrders   = _presenter.GetTshirtOrdersByOrderID(_order.OrderID);
                    Bill           = _order.Bill;
                    labelTotalPrice.Text = _order.TotalPrice.ToString();
                    cbOrderStatus.SelectedIndex = (short)Enums.ParseEnum<Enums.OrderStatus>(_order.OrderStatus.ToString());
                    cbProvider.SelectedIndex = _order.Provider != null ? cbProvider.FindStringExact(_order.Provider.Name) : 0;
                    OrderAcquisitionId = _order.OrderID;
                    dateCreateTime.Value = _order.CreationDate;
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
                _order.OrderID = this.OrderAcquisitionId;
                _order.OrderType = Common.Enums.OrderType.Achiziție;
                _order.CreationDate = dateCreateTime.Value;
                _order.OrderStatus = Enums.ParseEnum<Enums.OrderStatus>(cbOrderStatus.Text);
                _order.UserID = Common.AppContext.CurrentUserId;
                _order.ShippingPrice = (float)numericShippingPrice.Value;
                _order.TotalPrice = _presenter.GetOrderTotalPrice() + (float)numericShippingPrice.Value;
                if (cbProvider.SelectedValue != null)
                    _order.ProviderID = _presenter.GetProviderIDByName(cbProvider.Text.ToString());
                _order.Description = tbOrderDescription.Text;
                return _order;
            }

        }



        public void AttachPresenter(OrderAcquisitionDetailsPresenter presenter)
        {
            _presenter = presenter;
        }
        #endregion
        #region Events
        #region Order
        private void btnAddNewProvider_Click(object sender, EventArgs e)
        {
            frmProviderDetails childForm = new frmProviderDetails();
            ProviderDetailsPresenter presenter = new ProviderDetailsPresenter(childForm);
            childForm.MdiParent = this.MdiParent;
            childForm.AttachMainForm(_mainForm);
            childForm.AttachParentForm(this);
            childForm.AttachPresenter(presenter);
            childForm.Provider = new Provider();
            childForm.ShowDialog();
        }
        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            panelOrderDetails.Visible = !panelOrderDetails.Visible;
            if (panelOrderDetails.Visible)
                btnOrderDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnOrderDetails.BackColor = Color.FromArgb(12, 7, 18);
        }

        private void frmOrderAcquisitionDetails_Load(object sender, EventArgs e)
        {
            if(cbOrderStatus.SelectedIndex == 0)
                   cbOrderStatus.SelectedIndex = 1;
            panelFilamentDetails.Height = panelVinylDetails.Height;
            panelOtherPurchaseDetails.Height = panelVinylDetails.Height;
            panelBillDetails.Height -= panelAddBillDetails.Height;
            AppContext.ActiveForms.Add(this);


        }

        private void cbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            initVinyl(cbProvider.SelectedValue.ToString());
            initFilament(cbProvider.SelectedValue.ToString());
            initTshirt(cbProvider.SelectedValue.ToString());
            initOtherPurchase(cbProvider.SelectedValue.ToString());
            if (cbProvider.Focused)
            {
                clearDataGrids();
            }
        }
        #endregion
        #region OtherPurchase
        private void btnAddOtherPurchase_Click(object sender, EventArgs e)
        {
            if (gbOtherPurchase.Visible)
                panelOtherPurchaseDetails.Height -= gbOtherPurchase.Height;
            else
                panelOtherPurchaseDetails.Height += gbOtherPurchase.Height;
            gbOtherPurchase.Visible = !gbOtherPurchase.Visible;
        }
        private void btnOtherPurchaseDetails_Click(object sender, EventArgs e)
        {
            panelOtherPurchaseDetails.Visible = !panelOtherPurchaseDetails.Visible;
            if (panelOtherPurchaseDetails.Visible)
                btnOtherPurchaseDetails.BackColor = Color.FromArgb(26, 117, 255);
            else
                btnOtherPurchaseDetails.BackColor = Color.FromArgb(12, 7, 18);
        }

        private void btnRemoveOtherPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridOtherPurchase.SelectedRows)
                {
                    dataGridOtherPurchase.Rows.Remove(row);
                }
                labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
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
            List<string> OtherPurchaseOrderAttributes = new List<string>();
            var OtherPurchaseAttributes = cbOtherPurchase.Text.Split(',').ToList();
            string providerName = cbProvider.Text.ToString();
            OtherPurchaseOrderAttributes.AddRange(OtherPurchaseAttributes);
            OtherPurchaseOrderAttributes.Add(numericOtherPurchaseQuantity.Value.ToString());
            OtherPurchaseOrderAttributes.Add(numericOtherPurchasePrice.Value.ToString());
            dataGridOtherPurchase.Rows.Add(OtherPurchaseOrderAttributes.ToArray());

            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;

        }
        private void dataGridOtherPurchase_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveOtherPurchase.Enabled = true;
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
                int id = _presenter.GetTshirtIDByAttributes(tshirtAttributes, cbProvider.Text.ToString());

                TshirtOrderAttributes.Add(id.ToString());
                TshirtOrderAttributes.AddRange(tshirtAttributes);
                TshirtOrderAttributes.Add(numericTshirtQuantity.Value.ToString());
                TshirtOrderAttributes.Add(numericTshirtPrice.Value.ToString());
                if (id != 0)
                {
                    dataGridTshirt.Rows.Add(TshirtOrderAttributes.ToArray());
                }
                else
                {
                    var result = MessageBox.Show(AppTranslations.TshirtIsNotInStock, AppTranslations.QAddNewTshirt , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Tshirt tshirt = new Tshirt
                        {
                          //  Type = Enums.ParseEnum<Enums.TshirtType>(tshirtAttributes[0]),
                          //  Color = Enums.ParseEnum<Enums.Color>(tshirtAttributes[1]),
                            Rating = Enums.ParseEnum<Enums.Rating>(tshirtAttributes[2]),
                            Sex = Enums.ParseEnum<Enums.Sex>(tshirtAttributes[3]),
                            Size = Enums.ParseEnum<Enums.TshirtSize>(tshirtAttributes[4]),
                            Provider = _presenter.GetProviderByName(cbProvider.Text.ToString())
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
        #endregion
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
                labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
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
            childForm.Init();
            childForm.Filament = new Filament();
            childForm.ShowDialog();
        }
        private void btnAddFilamentInGrid_Click(object sender, EventArgs e)
        {
            List<string> filamentOrderAttributes = new List<string>();
            var filamentAttributes = cbFilament.Text.Split(',').ToList();
            string providerName = cbProvider.Text.ToString();
            filamentOrderAttributes.AddRange(filamentAttributes);
            filamentOrderAttributes.Add(numericFilamentQuantity.Value.ToString());
            filamentOrderAttributes.Add(numericFilamentPrice.Value.ToString());
            dataGridFilament.Rows.Add(filamentOrderAttributes.ToArray());

            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }
        private void dataGridFilament_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveFilament.Enabled = true;
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
                labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;

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
            List<string> vinylOrderAttributes = new List<string>();
            var vinylAttributes = cbViynl.Text.Split(',').ToList();
            string providerName = cbProvider.Text.ToString();
            vinylOrderAttributes.AddRange(vinylAttributes);
            vinylOrderAttributes.Add(numericVinylQuantity.Value.ToString());
            vinylOrderAttributes.Add(numericVinylPrice.Value.ToString());
            dataGridVinyl.Rows.Add(vinylOrderAttributes.ToArray());
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }
        private void dataGridVinyl_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnRemoveVinyl.Enabled = true;
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
            // frmBillDetails childForm = new frmBillDetails();
            // BillDetailsPresenter presenter = new BillDetailsPresenter(childForm);
            // childForm.MdiParent = this.MdiParent;
            // childForm.AttachMainForm(_mainForm);
            // childForm.AttachParentForm(this);
            // childForm.AttachPresenter(presenter);
            //// childForm.Init();
            // childForm.Bill = new Bill();
            // childForm.ShowDialog();
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
        private void btnAddBillFile_Click(object sender, EventArgs e)
        {
            DialogResult resultFile = openBillFile.ShowDialog();
            if (resultFile == DialogResult.OK)
            {
                tbBillFile.Text = openBillFile.FileName;
            }
        }

        private void cbBillStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBillStatus.SelectedIndex == 1)
            {
                tbBillName.Text = AppTranslations.NoBill;
                tbBillName.Enabled = false;
                btnAddBillFile.Enabled = false;
                tbBillFile.Text = "";
                tbBillDescription.Enabled = false;
            }
            else
            {
                tbBillName.Enabled = true;
                btnAddBillFile.Enabled = true;
                tbBillDescription.Enabled = true;
            }
        }

        private void btnViewBillFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = AppContext.FolderBillPath;
                path += "\\" + AppTranslations.BillAcquisitionType;
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
            catch(Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }

        private void tbBillFile_TextChanged(object sender, EventArgs e)
        {
            btnViewBillFile.Enabled = true;
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

                initProvider();
                if (cbProvider.Items.Count > 0)
                {
                    initVinyl(cbProvider.SelectedValue.ToString());
                    initFilament(cbProvider.SelectedValue.ToString());
                    initTshirt(cbProvider.SelectedValue.ToString());
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
        #region private functions
        private void initProvider()
        {
            try
            {
                if (cbProvider.DataSource != null)
                {
                    var actualIndex = cbProvider.SelectedIndex;
                    cbProvider.DataSource = _presenter.GetAllProvidersName();
                    cbProvider.SelectedIndex = actualIndex;
                }
                else
                {
                    cbProvider.DataSource = _presenter.GetAllProvidersName();
                }
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
        private void clearDataGrids()
        {
            try
            {
                dataGridFilament.DataSource = null;
                dataGridFilament.Rows.Clear();
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
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(AppTranslations.MessageBoxInfoConfirmation, AppTranslations.WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _presenter.AddAcquisitionOrder();
                }

            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
                _parentForm.Refresh();
                if (ex.Message.Contains(AppTranslations.SuccesInfoBox))
                    this.Close();
            }
        }

        private void numericShippingPrice_ValueChanged(object sender, EventArgs e)
        {
            labelTotalPrice.Text = this.Order.TotalPrice.ToString() + AppTranslations.RON;
        }

        private void frmOrderAcquisitionDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppContext.ActiveForms.Remove(this);
        }


        #endregion
        #region override functions
        public override void Refresh()
        {
            this.Init();
        }
        #endregion

    }
}
