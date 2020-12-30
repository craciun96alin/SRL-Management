using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface I3DPrintDetailsView
    {
        int _3DPrintID { get; set; }
        _3DPrint _3DPrint { get; set; }
        void AttachPresenter(_3DPrintDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
