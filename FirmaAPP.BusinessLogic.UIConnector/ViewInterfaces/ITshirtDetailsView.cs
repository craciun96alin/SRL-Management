using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface ITshirtDetailsView
    {
        int TshirtId { get; set; }
        Tshirt Tshirt { get; set; }
        void AttachPresenter(TshirtDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
