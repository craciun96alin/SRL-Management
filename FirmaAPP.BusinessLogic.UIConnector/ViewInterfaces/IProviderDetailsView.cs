using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IProviderDetailsView
    {
        int ProviderId { get; set; }
        Provider Provider { get; set; }
        void AttachPresenter(ProviderDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
