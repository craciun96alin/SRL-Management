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
    public class OrderTshirtsSalesListPresenter
    {
        #region Private members
        private IOrderTshirtsSalesListView _view;
        #endregion
        #region Constructor
        public OrderTshirtsSalesListPresenter(IOrderTshirtsSalesListView view)
        {
            this._view = view;
        }
        #endregion

        public void Init()
        {
            OrdersBLL oBLL = new OrdersBLL();
            _view.Orders = oBLL.GetAllTshirtOrdersForSale();
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
                OrdersBLL oBLL = new OrdersBLL();

                order._otherPurchaseOrders = getOtherPurchasesOrderByOrderID(order.OrderID);
                order._vinylOrders = getVinylOrdersByOrderID(order.OrderID);
                order._tshirtOrders = getTshirtOrdersByOrderID(order.OrderID);

                foreach (OtherPurchaseOrder opo in order._otherPurchaseOrders)
                {
                    opBLL.UpdateStock(opo.OtherPurchaseID, -opo.Quantity);
                }
                foreach (VinylOrder vo in order._vinylOrders)
                {
                    vBLL.UpdateStock(vo.VinylID, -vo.Quantity);
                }
                foreach (TshirtOrder to in order._tshirtOrders)
                {
                    tBLL.UpdateStock(to.TshirtID, -to.Quantity);
                }
                oBLL.UpdateOrderStatus(order.OrderID, Enums.OrderStatus.Finalizată);

                throw new Exception(AppTranslations.SuccesInfoBox);
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
    }
}
