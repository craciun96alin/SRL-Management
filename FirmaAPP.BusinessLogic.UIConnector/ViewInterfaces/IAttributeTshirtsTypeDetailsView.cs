using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttributeTshirtsTypeDetailsView
    {
        int AttributeTshirtsTypeID { get; set; }
        AttributeTshirtsType AttributeTshirtsType { get; set; }
        void AttachPresenter(AttributeTshirtsTypeDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
