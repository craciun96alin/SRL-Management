using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IVinylDetailsView
    {
        int VinylId { get; set; }
        Vinyl Vinyl { get; set; }
        void AttachPresenter(VinylDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
