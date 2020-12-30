using FirmaAPP.BusinessObject;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class TshirtOrdersDAL
    {
        DBContext context = new DBContext();
        public int AddTshirtOrder(TshirtOrder tshirtOrder)
        {
            var a = context.Add<TshirtOrder>(tshirtOrder);
            context.SaveChanges();
            return tshirtOrder.TshirtOrderID;
        }

        public List<TshirtOrder> GetTshirtOrdersByOrderID(int orderID)
        {
            var TshirtsOrder = context.TshirtOrders.Where(fo => fo.OrderID == orderID).ToList();
            return TshirtsOrder;
        }
    }
}
