using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface ITshirtListView
    {
        List<Tshirt> Tshirts { set; }
        void AttachPresenter(TshirtListPresenter presenter);
        void ShowMessage(string Message);
    }
}
