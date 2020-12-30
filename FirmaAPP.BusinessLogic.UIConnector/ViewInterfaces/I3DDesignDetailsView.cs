using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface I3DDesignDetailsView
    {
        int _3DDesignID { get; set; }
        _3DDesign _3DDesign { get; set; }
        void AttachPresenter(_3DDesignDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
