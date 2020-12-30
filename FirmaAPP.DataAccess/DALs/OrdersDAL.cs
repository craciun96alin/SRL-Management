using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class OrdersDAL
    {
        DBContext context = new DBContext();

        public List<Order> GetAllAcquisitionOrders()
        {
            var acquisitionOrders = context.Orders.Where(o => o.OrderType == Enums.OrderType.Achiziție).ToList();
            return acquisitionOrders;
        }

        public int AddOrder(Order order)
        {
            var a = context.Add<Order>(order);
            context.SaveChanges();
            return order.OrderID;
        }

        public void UpdateOrder(Order order)
        {
            var a = context.Update<Order>(order);
            context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            var a = context.Remove<Order>(order);
            context.SaveChanges();
        }

        public void AddBillToOrder(int billID, int orderID)
        {
            Order order = new Order { OrderID = orderID, BillID = billID};
            context.Attach(order);
            context.Entry(order).Property(b => b.BillID).IsModified = true;
            context.SaveChanges();
        }

        public void UpdateOrderStatus(int orderID , Enums.OrderStatus status)
        {
            Order order = new Order { OrderID = orderID, OrderStatus = status };
            context.Attach(order);
            context.Entry(order).Property(b => b.OrderStatus).IsModified = true;
            context.SaveChanges();

        }

        public List<Order> GetAllOrdersForSale()
        {
            var acquisitionOrders = context.Orders.ToList();
            return acquisitionOrders;
        }

        public List<Order> GetAllTshirtOrdersForSale()
        {
            var acquisitionOrders = context.Orders.Where(o => o.OrderType == Enums.OrderType.Vândut_tricou).ToList();
            return acquisitionOrders;
        }

        public List<Order> GetAll3DOrdersForSale()
        {
            var acquisitionOrders = context.Orders.Where(o => o.OrderType == Enums.OrderType.Vândut_3D).ToList();
            return acquisitionOrders;
        }
    }
}
