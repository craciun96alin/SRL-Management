using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeFilamentsTypeDetailsView
    {
        int AttributeFilamentsTypeID { get; set; }
        AttributeFilamentsType AttributeFilamentsType { get; set; }
        void AttachPresenter(AttributeFilamentsTypeDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
