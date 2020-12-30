using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IProviderListView
    {
        List<Provider> Providers { set; }
        void AttachPresenter(ProviderListPresenter presenter);
        void ShowMessage(string Message);
    }
}
