using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IFilamentListView
    {
        List<Filament> Filaments { set; }
        void AttachPresenter(FilamentListPresenter presenter);
        void ShowMessage(string Message);
    }
}
