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
    public class OrderAcquisitionDetailsPresenter
    {
        #region Private members
        private IOrderAcquisitionDetailsView _view;
        #endregion
        #region Constructor
        public OrderAcquisitionDetailsPresenter(IOrderAcquisitionDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Acquisition Order
        public void AddAcquisitionOrder()
        {
            try
            {
                OrdersBLL oBLL = new OrdersBLL();
                VinylOrdersBLL voBLL = new VinylOrdersBLL();
                FilamentOrdersBLL foBLL = new FilamentOrdersBLL();
                TshirtOrdersBLL toBLL = new TshirtOrdersBLL();
                OtherPurchaseOrdersBLL opoBLL = new OtherPurchaseOrdersBLL();
                int orderID = oBLL.AddOrder(_view.Order);

                _view.OrderAcquisitionId = orderID;
                voBLL.AddVinylOrders(_view.VinylOrders, orderID);
                foBLL.AddFilamentOrders(_view.FilamentOrders, orderID);
                toBLL.AddTshirtOrders(_view.TshirtOrders, orderID);
                opoBLL.AddOtherPurchaseOrders(_view.OtherPurchases, orderID);
                this.AddBillToAcquisitionOrder(_view.Bill);

                throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AcquisitionOrder + " " + AppTranslations.AddWithSuccess);
            }
            catch (Exception ex)
            {
                //remove orderid cascade
                throw ex;
            }
        }

        public float GetOrderTotalPrice()
        {
            try
            {
                float totalPrice = 0;
                foreach (VinylOrder vo in _view.VinylOrders)
                {
                    totalPrice += vo.TotalPrice;
                }
                foreach (FilamentOrder fo in _view.FilamentOrders)
                {
                    totalPrice += fo.TotalPrice;
                }
                foreach (TshirtOrder to in _view.TshirtOrders)
                {
                    totalPrice += to.TotalPrice;
                }
                foreach (OtherPurchaseOrder opo in _view.OtherPurchases)
                {
                    totalPrice += opo.TotalPrice;
                }
                return totalPrice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion
        #region Provider
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
        public int? GetProviderIDByName(string providerName)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                var provider = pBLL.GetProviderByName(providerName);
                return provider.ProviderID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
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
        #region Vinyl
        public List<string> GetDataSourceForVinylOrdersGrid(List<VinylOrder> vinylOrders)
        {
            try
            {
                VinylBLL vBLL = new VinylBLL();
                List<string> vinylsName = new List<string>();
                foreach (VinylOrder vo in vinylOrders)
                {
                    Vinyl vinyl = vBLL.GetVinylByID(vo.VinylID);
                    string VinylName = vinyl.VinylID + "," + vinyl.Name + "," + vinyl.Type + "," + vinyl.Color + "," + vinyl.Rating + "," + vo.Quantity.ToString() + "," + vo.TotalPrice.ToString();
                    vinylsName.Add(VinylName);
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
                VinylOrdersBLL foBLL = new VinylOrdersBLL();
                var otherVinylOrders = foBLL.GetVinylOrdersByOrderID(orderID);
                return otherVinylOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetVinylIDByNameAndProvider(string vinylName, string providerName)
        {
            try
            {
                VinylBLL vBLL = new VinylBLL();
                var vinyl = vBLL.GetVinylByNameAndProvider(vinylName, providerName);
                return vinyl.VinylID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetVinylsNameByProvider(string providerName)
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


        #endregion
        #region Filament
        public List<string> GetDataSourceForFilamentOrdersGrid(List<FilamentOrder> filamentOrders)
        {
            FilamentsBLL opBLL = new FilamentsBLL();
            List<string> filamentsName = new List<string>();
            foreach (FilamentOrder fo in filamentOrders)
            {
                Filament filament = opBLL.GetFilamentByID(fo.FilamentID);
                string FilamentName = filament.FilamentID + "," + filament.Name + "," + filament.Type + "," + filament.Color + "," + filament.Rating + "," + fo.Quantity.ToString() + "," + fo.TotalPrice.ToString();
                filamentsName.Add(FilamentName);
            }
            return filamentsName;
        }
        public List<FilamentOrder> GetFilamentOrdersByOrderID(int orderID)
        {
            try
            {
                FilamentOrdersBLL foBLL = new FilamentOrdersBLL();
                var otherFilamentOrders = foBLL.GetFilamentOrdersByOrderID(orderID);
                return otherFilamentOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetFilamentIDByNameAndProvider(string filamentName, string providerName)
        {
            try
            {
                FilamentsBLL vBLL = new FilamentsBLL();
                var filament = vBLL.GetFilamentByNameAndProvider(filamentName, providerName);
                return filament.FilamentID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetFilamentsNameByProvider(string providerName)
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
        #endregion
        #region Tshirt
        public List<string> GetDataSourceForTshirtOrdersGrid(List<TshirtOrder> tshirtOrders)
        {
            TshirtsBLL tBLL = new TshirtsBLL();
            List<string> tshirtsName = new List<string>();
            foreach (TshirtOrder to in tshirtOrders)
            {
                Tshirt tshirt = tBLL.GetTshirtByID(to.TshirtID);
                string tshirtName = tshirt.TshirtID + "," + tshirt.Type + "," + tshirt.Color + "," + tshirt.Rating + "," + tshirt.Sex + "," + tshirt.Size + "," + to.Quantity.ToString() + "," + to.TotalPrice.ToString();
                tshirtsName.Add(tshirtName);
            }
            return tshirtsName;
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
        #endregion
        #region Other Purchase
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
                    string otherPurchaseName = op.OtherPurchaseID + "," + op.Name + "," + op.Rating + "," + op.Description + "," + opo.Quantity.ToString() + "," + opo.TotalPrice.ToString();
                    otherPurchasesName.Add(otherPurchaseName);
                }
                return otherPurchasesName;
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



    }
}
