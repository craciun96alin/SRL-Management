using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using AppContext = FirmaAPP.Common.AppContext;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class UserListPresenter
    {
        private IUsersListView _view;
        public UserListPresenter(IUsersListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            UsersBLL fBLL = new UsersBLL();
            _view.Users = fBLL.GetAllUsers();
        }
        public void DeleteUsers(List<User> Users)
        {
            try
            {
                UsersBLL uBLL = new UsersBLL();
                string UsersNames = "";
                foreach (User u in Users)
                {
                    uBLL.DeleteUser(u);
                    UsersNames += u.FirstName + " " + u.LastName +", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.User + " " + UsersNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetCurrentUser()
        {
            try
            {
                UsersBLL uBLL = new UsersBLL();
                User user = uBLL.GetUserById(AppContext.CurrentUserId);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
