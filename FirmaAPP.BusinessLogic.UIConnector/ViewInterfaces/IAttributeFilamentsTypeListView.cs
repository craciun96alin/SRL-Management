using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeFilamentsTypeListView
    {
        List<AttributeFilamentsType> AttributeFilamentsTypes { set; }
        void AttachPresenter(AttributeFilamentsTypeListPresenter presenter);
        void ShowMessage(string Message);
    }
}
