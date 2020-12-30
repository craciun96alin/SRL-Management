using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IBillDetailsView
    {
        int OrderID { get; set; }
        int BillID { get; set; }
        Bill Bill { get; set; }
        void AttachPresenter(BillDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
