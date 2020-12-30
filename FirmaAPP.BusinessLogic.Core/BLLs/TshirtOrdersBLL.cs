using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class TshirtOrdersBLL
    {
        public void AddTshirtOrders(List<TshirtOrder> tshirtOrders, int orderID)
        {
            try
            {
                TshirtOrdersDAL toDAL = new TshirtOrdersDAL();
                foreach (TshirtOrder to in tshirtOrders)
                {
                    to.OrderID = orderID;
                    toDAL.AddTshirtOrder(to);
                }
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
                TshirtOrdersDAL toDAL = new TshirtOrdersDAL();
                var TshirtOrders = toDAL.GetTshirtOrdersByOrderID(orderID);
                return TshirtOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
