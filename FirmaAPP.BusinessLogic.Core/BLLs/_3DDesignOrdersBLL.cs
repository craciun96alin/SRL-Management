using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.Core
{
    public class _3DDesignOrdersBLL
    {
        public List<_3DDesignOrder> Get3DDesignOrdersByOrderID(int orderID)
        {
            try
            {
                _3DDesignOrdersDAL poDAL = new _3DDesignOrdersDAL();
                var DesignsOrders = poDAL.Get3DDesignOrdersByOrderID(orderID);
                return DesignsOrders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add3DDesignOrders(List<_3DDesignOrder> _3DDesignOrders, int orderID)
        {
            try
            {
                _3DDesignOrdersDAL voDAL = new _3DDesignOrdersDAL();
                foreach (_3DDesignOrder ddo in _3DDesignOrders)
                {
                    ddo.OrderID = orderID;
                    voDAL.Add3DDesignOrder(ddo);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
