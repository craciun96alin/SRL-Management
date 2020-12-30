using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.Core
{
    public class VinylOrdersBLL
    {
        public void AddVinylOrders(List<VinylOrder> vinylOrders, int orderID)
        {
            try
            {
                VinylOrdersDAL voDAL = new VinylOrdersDAL();
                foreach (VinylOrder vo in vinylOrders)
                {
                    vo.OrderID = orderID;
                    voDAL.AddVinylOrder(vo);
                }
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
                VinylOrdersDAL voDAL = new VinylOrdersDAL();
                var VinylOrders = voDAL.GetVinylOrdersByOrderID(orderID);
                return VinylOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
