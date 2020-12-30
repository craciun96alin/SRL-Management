using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOtherPurchaseListView
    {
        List<OtherPurchase> OtherPurchases { set; }
        void AttachPresenter(OtherPurchaseListPresenter presenter);
        void ShowMessage(string Message);
    }
}
