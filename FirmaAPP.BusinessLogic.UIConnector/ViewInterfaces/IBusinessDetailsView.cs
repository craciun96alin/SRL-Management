using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IBusinessDetailsView
    {
        int BusinessDetailsId { get; set; }
        BusinessDetails BusinessDetails { get; set; }
        void AttachBusinessDetailsPresenter(BusinessDetailsPresenter presenter);
        //void ShowBusinessDetailsMessage(string Message);
    }
}
