using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IVinylListView
    {
        List<Vinyl> Vinyls { set; }
        void AttachPresenter(VinylListPresenter presenter);
        void ShowMessage(string Message);
    }
}
