using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeVinylsTypeListView
    {
        List<AttributeVinylsType> AttributeVinylsTypes { set; }
        void AttachPresenter(AttributeVinylsTypeListPresenter presenter);
        void ShowMessage(string Message);
    }
}
