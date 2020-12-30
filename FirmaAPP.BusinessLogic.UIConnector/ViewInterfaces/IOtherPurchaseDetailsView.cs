using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOtherPurchaseDetailsView
    {
        int OtherPurchaseId { get; set; }
        OtherPurchase OtherPurchase { get; set; }
        void AttachPresenter(OtherPurchaseDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
