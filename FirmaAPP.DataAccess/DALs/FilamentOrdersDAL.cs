using System;
using System.Collections.Generic;
using System.Linq;
using FirmaAPP.BusinessObject;

namespace FirmaAPP.DataAccess
{
    public class FilamentOrdersDAL
    {
        DBContext context = new DBContext();

        public int AddFilamentOrder(FilamentOrder FilamentOrder)
        {
            context.Add<FilamentOrder>(FilamentOrder);
            context.SaveChanges();
            return FilamentOrder.FilamentOrderID;
        }

        public List<FilamentOrder> GetFilamentOrdersByOrderID(int orderID)
        {
            var FilamentsOrder = context.FilamentOrders.Where(fo => fo.OrderID == orderID).ToList();
            return FilamentsOrder;
        }
    }
}
