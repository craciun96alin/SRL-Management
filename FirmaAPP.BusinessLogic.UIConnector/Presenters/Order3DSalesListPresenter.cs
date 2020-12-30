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
    public class Order3DSalesListPresenter
    {
        #region Private members
        private IOrder3DSalesListView _view;
        #endregion
        #region Constructor
        public Order3DSalesListPresenter(IOrder3DSalesListView view)
        {
            this._view = view;
        }
        #endregion
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
        #endregion
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

        public void Init()
        {
            OrdersBLL oBLL = new OrdersBLL();
            _view.Orders = oBLL.GetAll3DOrdersForSale();
        }

        public void UpdateStatus(Order order, Enums.OrderStatus orderStatus)
        {
            try
            {
                OrdersBLL oBLL = new OrdersBLL();
                oBLL.UpdateOrderStatus(order.OrderID, orderStatus);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateDetailsMoney(Order order, Enums.MoneyFrom moneyFrom)
        {
            try
            {
                BusinessDetailsBLL bdBLL = new BusinessDetailsBLL();
                OrdersBLL oBLL = new OrdersBLL();
                bdBLL.UpdateMoney(moneyFrom, order.TotalPrice, order.OrderType);
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
                order._filamentOrders = getFilamentOrdersByOrderID(order.OrderID);

                foreach (OtherPurchaseOrder opo in order._otherPurchaseOrders)
                {
                    opBLL.UpdateStock(opo.OtherPurchaseID, -opo.Quantity);
                }
                foreach (FilamentOrder fo in order._filamentOrders)
                {
                    fBLL.UpdateStock(fo.FilamentID, -fo.Quantity);
                }
                oBLL.UpdateOrderStatus(order.OrderID, Enums.OrderStatus.Finalizată);
                throw new Exception(AppTranslations.SuccesInfoBox);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
