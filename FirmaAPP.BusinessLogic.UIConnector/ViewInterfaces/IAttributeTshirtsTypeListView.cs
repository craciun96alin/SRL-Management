using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeTshirtsTypeListView
    {
        List<AttributeTshirtsType> AttributeTshirtsTypes { set; }
        void AttachPresenter(AttributeTshirtsTypeListPresenter presenter);
        void ShowMessage(string Message);
    }
}
