using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAttribute3DPrintsQualityDetailsView
    {
        int Attribute3DPrintsQualityID { get; set; }
        Attribute3DPrintsQuality Attribute3DPrintsQuality { get; set; }
        void AttachPresenter(Attribute3DPrintsQualityDetailsPresenter presenter);
        void ShowMessage(string Message);
    }
}
