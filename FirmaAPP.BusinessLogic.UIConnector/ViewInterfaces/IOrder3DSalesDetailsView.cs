using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IOrder3DSalesDetailsView
    {
        int Order3DSaleId { get; set; }
        Order Order { get; set; }
        List<OtherPurchaseOrder> OtherPurchases { get; set; }
        List<_3DPrintOrder> _3DPrintOrders { get; set; }
        List<FilamentOrder> FilamentOrders { get; set; }
        List<_3DDesignOrder> _3DDesignOrders { get; set; }
        Bill Bill { get; set; }
        void AttachPresenter(Order3DSalesDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
