using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.Core
{
    public class OrdersBLL
    {
        public List<Order> GetAllAcquisitionOrders()
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                ProvidersDAL pDAL = new ProvidersDAL();
                BillsDAL bDAL = new BillsDAL();
                UsersDAL uDAL = new UsersDAL();
                var orders = oDAL.GetAllAcquisitionOrders();
                foreach (Order o in orders)
                {
                    if (o.Provider == null && o.ProviderID != null)
                    {
                        o.Provider = pDAL.GetProviderById(o.ProviderID);
                    }
                    if (o.Bill == null && o.BillID != null)
                    {
                        o.Bill = bDAL.GetBillById(o.BillID);
                    }
                    if (o.User == null && o.UserID != null)
                    {
                        o.User = uDAL.GetUserById(o.UserID);
                    }
                }
                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Order> GetAllTshirtOrdersForSale()
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                CustomersDAL cDAL = new CustomersDAL();
                BillsDAL bDAL = new BillsDAL();
                UsersDAL uDAL = new UsersDAL();
                var orders = oDAL.GetAllTshirtOrdersForSale();
                foreach (Order o in orders)
                {
                    if (o.Provider == null && o.ProviderID != null)
                    {
                        o.Customer = cDAL.GetCustomerById(o.CustomerID);
                    }
                    if (o.Bill == null && o.BillID != null)
                    {
                        o.Bill = bDAL.GetBillById(o.BillID);
                    }
                    if (o.User == null && o.UserID != null)
                    {
                        o.User = uDAL.GetUserById(o.UserID);
                    }
                }
                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Order> GetAll3DOrdersForSale()
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                CustomersDAL cDAL = new CustomersDAL();
                BillsDAL bDAL = new BillsDAL();
                UsersDAL uDAL = new UsersDAL();
                var orders = oDAL.GetAll3DOrdersForSale();
                foreach (Order o in orders)
                {
                    if (o.Provider == null && o.ProviderID != null)
                    {
                        o.Customer = cDAL.GetCustomerById(o.CustomerID);
                    }
                    if (o.Bill == null && o.BillID != null)
                    {
                        o.Bill = bDAL.GetBillById(o.BillID);
                    }
                    if (o.User == null && o.UserID != null)
                    {
                        o.User = uDAL.GetUserById(o.UserID);
                    }
                }
                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddBillToOrder(int billID, int orderID)
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                oDAL.AddBillToOrder(billID, orderID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddOrder(Order order)
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                int orderID = oDAL.AddOrder(order);
                return orderID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                oDAL.DeleteOrder(order);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                oDAL.UpdateOrder(order);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateOrderStatus(int orderID, Enums.OrderStatus status)
        {
            try
            {
                OrdersDAL oDAL = new OrdersDAL();
                oDAL.UpdateOrderStatus(orderID, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

