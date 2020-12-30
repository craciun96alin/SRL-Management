using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOrderTshirtSalesDetailsView
    {
        int OrderTshirtSaleId { get; set; }
        Order Order { get; set; }
        List<OtherPurchaseOrder> OtherPurchases { get; set; }
        List<VinylOrder> VinylOrders { get; set; }
        List<TshirtOrder> TshirtOrders { get; set; }
        Bill Bill { get; set; }
        void AttachPresenter(OrderTshirtSalesDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
