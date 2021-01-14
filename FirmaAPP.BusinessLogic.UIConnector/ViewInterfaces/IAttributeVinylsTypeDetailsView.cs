using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeVinylsTypeDetailsView
    {
        int AttributeVinylsTypeID { get; set; }
        AttributeVinylsType AttributeVinylsType { get; set; }
        void AttachPresenter(AttributeVinylsTypeDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
