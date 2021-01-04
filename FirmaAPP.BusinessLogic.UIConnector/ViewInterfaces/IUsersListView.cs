using FirmaAPP.BusinessObject;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public interface IUsersListView
    {
        List<User> Users { set; }
        void AttachPresenter(UserListPresenter presenter);
        //void ShowMessage(string Message);
    }
}
