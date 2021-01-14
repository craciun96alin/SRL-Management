using FirmaAPP.BusinessObject;
using System.Collections.Generic;
namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeColorsListView
    {
        List<AttributeColor> AttributeColors { set; }
        void AttachPresenter(AttributeColorListPresenter presenter);
        void ShowMessage(string Message);
    }
}
