using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface I3DDesignListView
    {
        List<_3DDesign> _3DDesigns { set; }
        void AttachPresenter(_3DDesignListPresenter presenter);
        void ShowMessage(string Message);
    }
}
