using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttribute3DPrintsQualityListView
    {
        List<Attribute3DPrintsQuality> Attribute3DPrintsQualitys { set; }
        void AttachPresenter(Attribute3DPrintsQualityListPresenter presenter);
        void ShowMessage(string Message);
    }
}
