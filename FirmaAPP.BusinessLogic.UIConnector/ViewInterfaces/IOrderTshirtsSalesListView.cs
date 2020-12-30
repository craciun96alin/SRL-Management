using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOrderTshirtsSalesListView
    {
        List<Order> Orders { set; }
        void AttachPresenter(OrderTshirtsSalesListPresenter presenter);
        void ShowMessage(string Message);
    }
}
