

using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IStartFormView
    {
        List<string> UserNames { set; }
        void AttachPresenter(StartFormPresenter presenter);
    }
}
