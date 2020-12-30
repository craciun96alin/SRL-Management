using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.Core
{
    public class _3DPrintOrdersBLL
    {
        public List<_3DPrintOrder> Get3DPrintOrdersByOrderID(int orderID)
        {
            try
            {
                _3DPrintOrdersDAL poDAL = new _3DPrintOrdersDAL();
                var printsOrders = poDAL.Get3DPrintOrdersByOrderID(orderID);
                return printsOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add3DPrintOrders(List<_3DPrintOrder> _3DPrintOrders, int orderID)
        {
            try
            {
                _3DPrintOrdersDAL voDAL = new _3DPrintOrdersDAL();
                foreach (_3DPrintOrder po in _3DPrintOrders)
                {
                    po.OrderID = orderID;
                    voDAL.Add3DPrintOrder(po);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
