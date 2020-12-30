using FirmaAPP.BusinessObject;
using System.Collections.Generic;


namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOrder3DSalesListView
    {
        List<Order> Orders { set; }
        void AttachPresenter(Order3DSalesListPresenter presenter);
        void ShowMessage(string Message);
    }
}
