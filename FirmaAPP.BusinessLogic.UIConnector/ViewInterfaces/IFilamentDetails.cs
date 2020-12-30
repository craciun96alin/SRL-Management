using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IFilamentDetailsView
    {
        int FilamentId { get; set; }
        Filament Filament { get; set; }
        void AttachPresenter(FilamentDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
