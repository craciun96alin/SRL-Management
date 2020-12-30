using FirmaAPP.BusinessObject;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class VinylOrdersDAL
    {
        DBContext context = new DBContext();

        public int AddVinylOrder(VinylOrder vinylOrder)
        {
            var a = context.Add<VinylOrder>(vinylOrder);
            context.SaveChanges();
            return vinylOrder.VinylOrderID;
        }

        public List<VinylOrder> GetVinylOrdersByOrderID(int orderID)
        {
            var VinylsOrder = context.VinylOrders.Where(vo => vo.OrderID == orderID).ToList();
            return VinylsOrder;
        }
    }
}
