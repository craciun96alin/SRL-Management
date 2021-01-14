using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeColorDetailsView
    {
        int AttributeColorID { get; set; }
        AttributeColor AttributeColor { get; set; }
        void AttachPresenter(AttributeColorDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
