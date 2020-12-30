

using System;
using System.Collections.Generic;
using System.Linq;
using FirmaAPP.BusinessObject;

namespace FirmaAPP.DataAccess
{
    public class OtherPurchaseOrdersDAL
    {
        DBContext context = new DBContext();

        public int AddOtherPurchaseOrder(OtherPurchaseOrder OtherPurchaseOrder)
        {
            var a = context.Add<OtherPurchaseOrder>(OtherPurchaseOrder);
            context.SaveChanges();
            return OtherPurchaseOrder.OtherPurchaseOrderID;
        }

        public List<OtherPurchaseOrder> GetOtherPurchasesOrderByOrderID(int orderID)
        {
            var otherPurchasesOrder = context.OtherPurchaseOrders.Where(opo => opo.OrderID == orderID).ToList();
            return otherPurchasesOrder;
        }
    }
}
