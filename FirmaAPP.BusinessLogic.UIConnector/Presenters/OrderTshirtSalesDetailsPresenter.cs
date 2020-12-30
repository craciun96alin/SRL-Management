using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class OrderTshirtSalesDetailsPresenter
    {
        #region Private members
        private IOrderTshirtSalesDetailsView _view;
        #endregion
        #region Constructor
        public OrderTshirtSalesDetailsPresenter(IOrderTshirtSalesDetailsView view)
        {
            this._view = view;
        }
        #endregion

        #region Order
        public void AddSaleOrder()
        {
            try
            {
                OrdersBLL oBLL = new OrdersBLL();
                VinylOrdersBLL voBLL = new VinylOrdersBLL();
                TshirtOrdersBLL toBLL = new TshirtOrdersBLL();
                OtherPurchaseOrdersBLL opoBLL = new OtherPurchaseOrdersBLL();
                int orderID = oBLL.AddOrder(_view.Order);

                _view.OrderTshirtSaleId = orderID;
                voBLL.AddVinylOrders(_view.VinylOrders, orderID);
                toBLL.AddTshirtOrders(_view.TshirtOrders, orderID);
                opoBLL.AddOtherPurchaseOrders(_view.OtherPurchases, orderID);
                if (_view.Bill != null)
                {
                    this.AddBillToAcquisitionOrder(_view.Bill);
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
        public Provider GetProviderByName(string providerName)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                var provider = pBLL.GetProviderByName(providerName);
                return provider;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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


        #endregion

        #region Tshirt
        public int GetTshirtIDByAttributes(List<string> tshirtAttributes, string providerName)
        {
            try
            {
                TshirtsBLL tBLL = new TshirtsBLL();
                var tshirtID = tBLL.GetTshirtIDByAttributes(tshirtAttributes, providerName);
                return tshirtID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetTshirtsNameByProvider(string providerName)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                TshirtsBLL tBLL = new TshirtsBLL();
                var provider = pBLL.GetProviderByName(providerName);
                List<string> TshirtsName = new List<string>();
                if (provider != null)
                {
                    TshirtsName = tBLL.GetTshirtsNameByProvider(provider);
                }
                return TshirtsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TshirtOrder> GetTshirtOrdersByOrderID(int orderID)
        {
            try
            {
                TshirtOrdersBLL foBLL = new TshirtOrdersBLL();
                var otherTshirtOrders = foBLL.GetTshirtOrdersByOrderID(orderID);
                return otherTshirtOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetDataSourceForTshirtOrdersGrid(List<TshirtOrder> tshirtOrders)
        {
            try
            {
                TshirtsBLL tBLL = new TshirtsBLL();
                ProvidersBLL pBLL = new ProvidersBLL();
                List<string> tshirtsName = new List<string>();
                foreach (TshirtOrder to in tshirtOrders)
                {
                    Tshirt tshirt = tBLL.GetTshirtByID(to.TshirtID);
                    Provider provider = pBLL.GetProviderByID(tshirt.ProviderID);
                    string tshirtName = tshirt.TshirtID + "," + provider.Name +","+ tshirt.Type + "," + tshirt.Color + "," + tshirt.Rating + "," + tshirt.Sex + "," + tshirt.Size + "," + to.Quantity.ToString() + "," + to.TotalPrice.ToString();
                    tshirtsName.Add(tshirtName);
                }
                return tshirtsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        #endregion
        #region Vinyl
        public object GetVinylsNameByProvider(string providerName)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                VinylBLL vBLL = new VinylBLL();
                var provider = pBLL.GetProviderByName(providerName);
                List<string> vinylsName = new List<string>();
                if (provider != null)
                {
                    vinylsName = vBLL.GetVinylsNameByProvider(provider);
                }
                return vinylsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<VinylOrder> GetVinylOrdersByOrderID(int orderID)
        {
            try
            {
                VinylOrdersBLL voBLL = new VinylOrdersBLL();
                var vinylOrders = voBLL.GetVinylOrdersByOrderID(orderID);
                return vinylOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> GetDataSourceForVinylOrdersGrid(List<VinylOrder> vinylOrders)
        {
            try
            {
                VinylBLL vBLL = new VinylBLL();
                List<string> vinylsName = new List<string>();
                foreach (VinylOrder vo in vinylOrders)
                {
                    Vinyl vinyl = vBLL.GetVinylByID(vo.VinylID);
                    string VinylName = vinyl.VinylID + "," + vinyl.Name + "," + vinyl.Type + "," + vinyl.Color + "," + vinyl.Rating + "," + vo.Quantity.ToString() + "," +vinyl.ProviderName;
                    vinylsName.Add(VinylName);
                }
                return vinylsName;
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
                var otherPurchaseName = op.OtherPurchaseID + ", " + op.Name + ", " + op.Rating + ", " + op.Description;
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
                List<string> otherPurchasesName = new List<string>();
                foreach (OtherPurchaseOrder opo in otherPurchaseOrder)
                {
                    OtherPurchase op = opBLL.GetOtherPruchaseByID(opo.OtherPurchaseID);
                    string otherPurchaseName = op.OtherPurchaseID + "," + op.Name + "," + op.Rating + "," + op.Description + "," + opo.Quantity.ToString() + "," + op.ProviderName;
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

        #region Bill
        private void AddBillToAcquisitionOrder(Bill bill)
        {
            try
            {
                BillsBLL tBLL = new BillsBLL();
                OrdersBLL oBLL = new OrdersBLL();
                if (bill.BillStatus != Enums.BillStatus.Fără_factură)
                {
                    int billId = tBLL.AddAcquisitionBill(bill);
                    _view.Order.BillID = billId;
                }
                else
                {
                    _view.Order.BillID = AppTranslations.BillForNoBillIndex;
                }
                oBLL.UpdateOrder(_view.Order);
                throw new Exception("Succes: Factura " + bill.BillName + " a fost adăugată!");
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
                foreach (TshirtOrder to in _view.TshirtOrders)
                {
                    totalPrice += to.TotalPrice;
                }

                return totalPrice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
