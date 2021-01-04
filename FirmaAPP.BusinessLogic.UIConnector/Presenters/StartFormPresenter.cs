
using AppContext = FirmaAPP.Common.AppContext;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using System;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class StartFormPresenter
    {
        #region  View
        private IStartFormView _view;
        #endregion

        #region Constructors
        public StartFormPresenter(IStartFormView view)
        {
            this._view = view;
        }
        #endregion

        public void GetUsers()
        {
            UsersBLL usersBLL = new UsersBLL();
            
            var userNames = usersBLL.GetAllUsersName();
            _view.UserNames = userNames;
        }

        public void SetCurrentUser(string userName)
        {
            UsersBLL usersBLL = new UsersBLL();

            User currentUser = usersBLL.GetUserByName(userName);
            AppContext.CurrentUserId = currentUser.UserID;
            
        }

        public bool VerifyIfCurrentUserIsAdmin(string password)
        {
            try
            {
                UsersBLL usersBLL = new UsersBLL();
                if(AppContext.CurrentUserId == null)
                {
                    throw new Exception("Numele si parola");
                }
                User user = usersBLL.GetUserById(AppContext.CurrentUserId);
                if (!VerifyUserCredentials(user, password)) 
                {
                    throw new Exception("Numele si parola");
                }
                usersBLL.UpdateLastLogin(AppContext.CurrentUserId);
                if (user.UserRole == Enums.UserRole.Admin)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerifyUserCredentials(User user, string password)
        {
            if (user.Password != null)
            {
                if (password != AppHelper.Decrypt(user.Password, AppTranslations.PassPhrase))
                {
                    return false;
                }
            }
            return true;
        }

        public void SetAppSettings()
        {
            AppSettingsBLL asBLL = new AppSettingsBLL();
            AppContext.FolderBillPath = asBLL.GetBillFolder(AppContext.CurrentUserId);
            AppContext.Folder3DDesignPath = asBLL.Get3DDesignFolder(AppContext.CurrentUserId);
            AppContext.Folder3DPrintPath = asBLL.Get3DPrintFolder(AppContext.CurrentUserId);
        }
    }
}
