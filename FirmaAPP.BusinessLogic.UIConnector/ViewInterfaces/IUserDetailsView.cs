using FirmaAPP.BusinessObject;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IUserDetailsView
    {
        int UserId { get; set; }
        User User { get; set; }
        void AttachPresenter(UserDetailsPresenter presenter);
        //void ShowMessage(string Message);
    }
}
