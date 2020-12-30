using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class OrderAcquisitionListPresenter
    {
        private IOrderAcquisitionListView _view;
        public OrderAcquisitionListPresenter(IOrderAcquisitionListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            OrdersBLL oBLL = new OrdersBLL();
            _view.Orders = oBLL.GetAllAcquisitionOrders();
        }

        public void DeleteOrders(List<Order> ordersToDelete)
        {
            //TO DO: delete file too and bill in db
            try
            {
                OrdersBLL oBLL = new OrdersBLL();
                string ordersIDs = "";
                foreach (Order o in ordersToDelete)
                {
                    oBLL.DeleteOrder(o);
                    ordersIDs += o.OrderID + ", ";
                }
                throw new Exception("Succes: Comanda " + ordersIDs + " a fost ștearsă!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStocksAndStatus(Order order)
        {
            try
            {
                OtherPurchasesBLL opBLL = new OtherPurchasesBLL();
                VinylBLL vBLL = new VinylBLL();
                TshirtsBLL tBLL = new TshirtsBLL();
                FilamentsBLL fBLL = new FilamentsBLL();
                OrdersBLL oBLL = new OrdersBLL();

                order._otherPurchaseOrders = getOtherPurchasesOrderByOrderID(order.OrderID);
                order._vinylOrders = getVinylOrdersByOrderID(order.OrderID);
                order._tshirtOrders = getTshirtOrdersByOrderID(order.OrderID);
                order._filamentOrders = getFilamentOrdersByOrderID(order.OrderID);

                foreach (OtherPurchaseOrder opo in order._otherPurchaseOrders)
                {
                    opBLL.UpdateStock(opo.OtherPurchaseID, opo.Quantity);
                }
                foreach (VinylOrder vo in order._vinylOrders)
                {
                    vBLL.UpdateStock(vo.VinylID, vo.Quantity);
                }
                foreach (TshirtOrder to in order._tshirtOrders)
                {
                    tBLL.UpdateStock(to.TshirtID, to.Quantity);
                }
                foreach (FilamentOrder fo in order._filamentOrders)
                {
                    fBLL.UpdateStock(fo.FilamentID, fo.Quantity);
                }

                oBLL.UpdateOrderStatus(order.OrderID, Enums.OrderStatus.Finalizată);

                throw new Exception(AppTranslations.SuccesInfoBox);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        #region private functions
        private List<OtherPurchaseOrder> getOtherPurchasesOrderByOrderID(int orderID)
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
        private List<TshirtOrder> getTshirtOrdersByOrderID(int orderID)
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
        private List<FilamentOrder> getFilamentOrdersByOrderID(int orderID)
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
        private List<VinylOrder> getVinylOrdersByOrderID(int orderID)
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
        #endregion

        public void UpdateDetailsMoneyAndStatus(Order order, Enums.MoneyFrom moneyFrom)
        {
            try
            {
                BusinessDetailsBLL bdBLL = new BusinessDetailsBLL();
                OrdersBLL oBLL = new OrdersBLL();
                bdBLL.UpdateMoney(moneyFrom, order.TotalPrice, order.OrderType);
                oBLL.UpdateOrderStatus(order.OrderID, Enums.OrderStatus.În_lucru);

                throw new Exception(AppTranslations.SuccesInfoBox);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
