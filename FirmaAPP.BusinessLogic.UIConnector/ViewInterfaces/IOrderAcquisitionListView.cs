using FirmaAPP.BusinessObject;
using System.Collections.Generic;


namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOrderAcquisitionListView
    {
        List<Order> Orders { set; }
        void AttachPresenter(OrderAcquisitionListPresenter presenter);
        void ShowMessage(string Message);
    }
}
