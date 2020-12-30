
using AppContext = FirmaAPP.Common.AppContext;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using System;

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

        public bool VerifyCurrentUser()
        {
            if(AppContext.CurrentUserId != null)
            {
                UsersBLL usersBLL = new UsersBLL();
                usersBLL.UpdateLastLogin(AppContext.CurrentUserId);
                return true;
            }
            return false;
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
