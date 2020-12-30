using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface ICustomerListView
    {
        List<Customer> Customers { set; }
        void AttachPresenter(CustomerListPresenter presenter);
        void ShowMessage(string Message);
    }
}
