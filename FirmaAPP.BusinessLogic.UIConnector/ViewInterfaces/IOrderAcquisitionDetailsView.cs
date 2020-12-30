using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOrderAcquisitionDetailsView
    {
        int OrderAcquisitionId { get; set; }
        Order Order { get; set; }
        List<OtherPurchaseOrder> OtherPurchases { get; set; }
        List<VinylOrder> VinylOrders { get; set; }
        List<FilamentOrder> FilamentOrders { get; set; }
        List<TshirtOrder> TshirtOrders { get; set; }
        Bill Bill { get; set; }
        void AttachPresenter(OrderAcquisitionDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
