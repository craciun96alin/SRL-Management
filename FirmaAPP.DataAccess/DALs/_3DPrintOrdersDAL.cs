using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.DataAccess
{
    public class _3DPrintOrdersDAL
    {
        DBContext context = new DBContext();
        public List<_3DPrintOrder> Get3DPrintOrdersByOrderID(int orderID)
        {
            var printsOrder = context._3DPrintOrders.Where(fo => fo.OrderID == orderID).ToList();
            return printsOrder;
        }

        public int Add3DPrintOrder(_3DPrintOrder _3DPrintOrder)
        {
            context.Add<_3DPrintOrder>(_3DPrintOrder);
            context.SaveChanges();
            return _3DPrintOrder._3DPrintOrderID;
        }
    }
}
