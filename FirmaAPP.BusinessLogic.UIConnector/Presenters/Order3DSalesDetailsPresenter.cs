using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class Order3DSalesDetailsPresenter
    {
        #region Private members
        private IOrder3DSalesDetailsView _view;
        #endregion
        #region Constructor
        public Order3DSalesDetailsPresenter(IOrder3DSalesDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Customer
        public List<string> GetAllCustomersName()
        {
            try
            {
                CustomersBLL cBLL = new CustomersBLL();
                var customersName = cBLL.GetAllCustomersName();
                return customersName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int? GetCustomerIDByName(string customerName)
        {
            try
            {
                CustomersBLL pBLL = new CustomersBLL();
                var customer = pBLL.GetCustomerByName(customerName);
                return customer.CustomerID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<_3DDesignOrder> Get3DDesignOrdersByOrderID(int orderID)
        {
            try
            {
                _3DDesignOrdersBLL ddoBLL = new _3DDesignOrdersBLL();
                var designs = ddoBLL.Get3DDesignOrdersByOrderID(orderID);
                return designs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion
        #region Filament
        public object GetFilamentsNameByProvider(string providerName)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                FilamentsBLL fBLL = new FilamentsBLL();
                var provider = pBLL.GetProviderByName(providerName);
                List<string> filamentsName = new List<string>();
                if (provider != null)
                {
                    filamentsName = fBLL.GetFilamentsNameByProvider(provider);
                }
                return filamentsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FilamentOrder> GetFilamentOrdersByOrderID(int orderID)
        {
            try
            {
                FilamentOrdersBLL foBLL = new FilamentOrdersBLL();
                var filamentOrders = foBLL.GetFilamentOrdersByOrderID(orderID);
                return filamentOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetDataSourceForFilamentOrdersGrid(List<FilamentOrder> filamentOrders)
        {
            try
            {
                FilamentsBLL fBLL = new FilamentsBLL();
                List<string> filamentsName = new List<string>();
                foreach (FilamentOrder fo in filamentOrders)
                {
                    Filament filament = fBLL.GetFilamentByID(fo.FilamentID);
                    string filamentName = filament.FilamentID + "," + filament.Name + "," + filament.Type + "," + filament.Color + "," + filament.Rating + "," + fo.Quantity.ToString() + "," + filament.ProviderName;
                    filamentsName.Add(filamentName);
                }
                return filamentsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllFilaments()
        {
            try
            {
                FilamentsBLL fBLL = new FilamentsBLL();
                return fBLL.GetFilamentsName();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetFilamentIDByFilamentName(string filamentName)
        {
            try
            {
                FilamentsBLL fBLL = new FilamentsBLL();
                return fBLL.GetFilamentIDByName(filamentName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region Provider
        public List<string> GetAllProvidersName()
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                var providersName = pBLL.GetAllProvidersName();
                return providersName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region 3DPrints
        public List<string> GetAll3DPrints()
        {
            try
            {
                _3DPrintsBLL pBLL = new _3DPrintsBLL();
                return pBLL.GetAll3DPrintsName();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetDataSourceFor3DPrintOrdersGrid(List<_3DPrintOrder> _3DPrintOrders)
        {
            try
            {
                _3DPrintsBLL pBLL = new _3DPrintsBLL();
                FilamentsBLL fBLL = new FilamentsBLL();
                List<string> _3DPrintsName = new List<string>();
                foreach (_3DPrintOrder po in _3DPrintOrders)
                {
                    _3DPrint _3DP = pBLL.Get3DPrintByID(po._3DPrintID);
                    Filament f = fBLL.GetFilamentByID(po.FilamentID);
                    string _3DPrintName = _3DP._3DPrintID + "," + _3DP.Name + "," + f.Name + "," + po.PrintingTimeInMin
                        + "," + po.Wheight + "," + po.Infill + "," + po.Quality + "," + po.PrintsQuantity + "," + po.TotalPrice;
                    _3DPrintsName.Add(_3DPrintName);
                }
                return _3DPrintsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<_3DPrintOrder> Get3DPrintOrdersByOrderID(int orderID)
        {
            try
            {
                _3DPrintOrdersBLL poBLL = new _3DPrintOrdersBLL();
                var _3dPrintOrders = poBLL.Get3DPrintOrdersByOrderID(orderID);
                return _3dPrintOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region 3DDesign
        public List<string> GetAll3DDesigns()
        {
            try
            {
                List<string> _3DDesignNames = new List<string>();
                _3DDesignsBLL dBLL = new _3DDesignsBLL();
                var _3DDesigns = dBLL.GetAll3DDesigns();
                foreach(_3DDesign dd in _3DDesigns)
                {
                    string name = dd._3DDesignID + "," + dd.Name;
                    _3DDesignNames.Add(name);
                }
                return _3DDesignNames;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetDataSourceFor3DDesignOrdersGrid(List<_3DDesignOrder> _3DDesignsOrders)
        {
            try
            {
                _3DDesignsBLL pBLL = new _3DDesignsBLL();
                List<string> _3DDesignsName = new List<string>();
                foreach (_3DDesignOrder ddo in _3DDesignsOrders)
                {
                    _3DDesign _3DP = pBLL.Get3DDesignByID(ddo._3DDesignID);
                    string _3DDesignName = _3DP._3DDesignID + "," + _3DP.Name + "," + ddo.Price;
                    _3DDesignsName.Add(_3DDesignName);
                }
                return _3DDesignsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region OtherPurchase
        public object GetOtherPurchasesNameByProvider(string providerName)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                OtherPurchasesBLL fBLL = new OtherPurchasesBLL();
                var provider = pBLL.GetProviderByName(providerName);
                List<OtherPurchase> otherPurchases = new List<OtherPurchase>();
                if (provider != null)
                {
                    otherPurchases = fBLL.GetOtherPurchasesNameByProvider(provider);
                }
                List<string> OtherPurchasesName = GetOtherPurchaseForGrid(otherPurchases);
                return OtherPurchasesName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<string> GetOtherPurchaseForGrid(List<OtherPurchase> otherPurchases)
        {
            List<string> otherPurchasesName = new List<string>();
            foreach (OtherPurchase op in otherPurchases)
            {
                var otherPurchaseName = op.OtherPurchaseID + ", " + op.Name + ", " + op.Rating + ", " + op.Description + ", " + op.ProviderName;
                otherPurchasesName.Add(otherPurchaseName);
            }
            return otherPurchasesName;
        }
        public List<OtherPurchaseOrder> GetOtherPurchasesOrderByOrderID(int orderID)
        {
            try
            {
                OtherPurchaseOrdersBLL opoBLL = new OtherPurchaseOrdersBLL();
                var otherPurchasesOrder = opoBLL.GetOtherPurchasesOrderByOrderID(orderID);
                return otherPurchasesOrder;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetDataSourceForOtherPurchaseGrid(List<OtherPurchaseOrder> otherPurchaseOrder)
        {
            try
            {
                OtherPurchasesBLL opBLL = new OtherPurchasesBLL();
                ProvidersBLL pBLL = new ProvidersBLL();
                List<string> otherPurchasesName = new List<string>();
                foreach (OtherPurchaseOrder opo in otherPurchaseOrder)
                {
                    OtherPurchase op = opBLL.GetOtherPruchaseByID(opo.OtherPurchaseID);
                    var provider = pBLL.GetProviderByID(op.ProviderID);
                    string otherPurchaseName = op.OtherPurchaseID + "," + op.Name + "," + op.Rating + "," + op.Description + "," + opo.Quantity.ToString() + "," + provider.Name;
                    otherPurchasesName.Add(otherPurchaseName);
                }
                return otherPurchasesName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public float GetOrderTotalPriceWithoutShipping()
        {
            try
            {
                float totalPrice = 0;
                foreach (_3DDesignOrder ddo in _view._3DDesignOrders)
                {
                    totalPrice += ddo.Price;
                }
                foreach (_3DPrintOrder dpo in _view._3DPrintOrders)
                {
                    totalPrice += dpo.TotalPrice;
                }
                return totalPrice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Order
        public void AddSaleOrder()
        {
            try
            {
                OrdersBLL oBLL = new OrdersBLL();
                FilamentOrdersBLL foBLL = new FilamentOrdersBLL();
                _3DPrintOrdersBLL dpoBLL = new _3DPrintOrdersBLL();
                _3DDesignOrdersBLL ddoBLL = new _3DDesignOrdersBLL();
                OtherPurchaseOrdersBLL opoBLL = new OtherPurchaseOrdersBLL();
                int orderID = oBLL.AddOrder(_view.Order);

                _view.Order3DSaleId = orderID;
                foBLL.AddFilamentOrders(_view.FilamentOrders, orderID);
                dpoBLL.Add3DPrintOrders(_view._3DPrintOrders, orderID);
                ddoBLL.Add3DDesignOrders(_view._3DDesignOrders, orderID);
                opoBLL.AddOtherPurchaseOrders(_view.OtherPurchases, orderID);
                if (_view.Bill != null)
                {
                    this.AddBillToSellingOrder(_view.Bill);
                }

                throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AcquisitionOrder + " " + AppTranslations.AddWithSuccess);
            }
            catch (Exception ex)
            {
                //remove orderid cascade
                throw ex;
            }
        }
        #endregion
        #region Bill
        private void AddBillToSellingOrder(Bill bill)
        {
            try
            {
                BillsBLL tBLL = new BillsBLL();
                OrdersBLL oBLL = new OrdersBLL();
                if (bill.BillStatus != Enums.BillStatus.Fără_factură)
                {
                    int billId = tBLL.AddSellingBill(bill);
                    _view.Order.BillID = billId;
                }
                else
                {
                    _view.Order.BillID = AppTranslations.BillForNoBillIndex;
                }
                oBLL.UpdateOrder(_view.Order);
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Bill + " " + bill.BillName + AppTranslations.AddWithSuccess);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
