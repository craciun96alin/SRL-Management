using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface ICustomerDetailsView
    {
        int CustomerId { get; set; }
        Customer Customer { get; set; }
        void AttachPresenter(CustomerDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
