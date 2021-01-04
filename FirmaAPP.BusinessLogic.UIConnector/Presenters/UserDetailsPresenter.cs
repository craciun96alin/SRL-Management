using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class UserDetailsPresenter
    {
        #region Private members
        private IUserDetailsView _view;
        #endregion
        #region Constructor
        public UserDetailsPresenter(IUserDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Public functions
        public void AddOrUpdateUser(User User)
        {
            try
            {
                UsersBLL uBLL = new UsersBLL();
                if (User.UserID == 0)
                {
                    uBLL.AddUser(User);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.User + " " + User.FirstName + " " + User.LastName + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    uBLL.UpdateUser(User);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.User + " " + User.FirstName + " " + User.LastName + " " + AppTranslations.EditWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
