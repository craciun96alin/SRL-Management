using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.Core
{
    public class FilamentOrdersBLL
    {
        public void AddFilamentOrders(List<FilamentOrder> FilamentOrders, int orderID)
        {
            try
            {
                FilamentOrdersDAL voDAL = new FilamentOrdersDAL();
                foreach (FilamentOrder fo in FilamentOrders)
                {
                    fo.OrderID = orderID;
                    voDAL.AddFilamentOrder(fo);
                }
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
                FilamentOrdersDAL foDAL = new FilamentOrdersDAL();
                var filamentOrders = foDAL.GetFilamentOrdersByOrderID(orderID);
                return filamentOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
