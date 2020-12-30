using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IAppSettingsView
    {
        int AppSettingsId { get; set; }
        AppSettings AppSettings { get; set; }
        void AttachPresenter(AppSettingsPresenter presenter);
        void ShowMessage(string Message);
    }
}
