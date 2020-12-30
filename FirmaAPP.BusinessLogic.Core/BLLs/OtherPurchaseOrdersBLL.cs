using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.Core
{
    public class OtherPurchaseOrdersBLL
    {
        public void AddOtherPurchaseOrders(List<OtherPurchaseOrder> OtherPurchaseOrders, int orderID)
        {
            try
            {
                OtherPurchaseOrdersDAL opoDAL = new OtherPurchaseOrdersDAL();
                foreach (OtherPurchaseOrder fo in OtherPurchaseOrders)
                {
                    fo.OrderID = orderID;
                    opoDAL.AddOtherPurchaseOrder(fo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OtherPurchaseOrder> GetOtherPurchasesOrderByOrderID(int orderID)
        {
            try
            {
                OtherPurchaseOrdersDAL opoDAL = new OtherPurchaseOrdersDAL();
                var otherPurchasesOrder = opoDAL.GetOtherPurchasesOrderByOrderID(orderID);
                return otherPurchasesOrder;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
