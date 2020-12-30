using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class _3DDesignOrdersDAL
    {
        DBContext context = new DBContext();
        public List<_3DDesignOrder> Get3DDesignOrdersByOrderID(int orderID)
        {
            var DesignsOrder = context._3DDesignOrders.Where(fo => fo.OrderID == orderID).ToList();
            return DesignsOrder;
        }

        public int Add3DDesignOrder(_3DDesignOrder _3DDesignOrder)
        {
            context.Add<_3DDesignOrder>(_3DDesignOrder);
            context.SaveChanges();
            return _3DDesignOrder._3DDesignOrderID;
        }
    }
}
