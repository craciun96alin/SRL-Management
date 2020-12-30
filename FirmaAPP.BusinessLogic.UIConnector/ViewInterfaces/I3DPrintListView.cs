using FirmaAPP.BusinessObject;
using System.Collections.Generic;
namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface I3DPrintListView
    {
        List<_3DPrint> _3DPrints { set; }
        void AttachPresenter(_3DPrintListPresenter presenter);
        void ShowMessage(string Message);
    }
}
