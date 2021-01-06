using System;
using AppContext = FirmaAPP.Common.AppContext;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AppSettingsPresenter
    {
        #region Private members
        private IAppSettingsView _view;
        #endregion
        #region Constructor
        public AppSettingsPresenter(IAppSettingsView view)
        {
            this._view = view;
        }
        #endregion
        public void AddUpdateSettings(AppSettings appSettings)
        {
            try
            {
                AppSettingsBLL asBLL = new AppSettingsBLL();
                AppContext.FolderBillPath = appSettings.BillFolder;
                AppContext.Folder3DDesignPath = appSettings._3DDesignFolder;
                AppContext.Folder3DPrintPath = appSettings._3DPrintFolder;
                if (appSettings.AppSettingsID == 0)
                {
                    asBLL.AddAppSettings(appSettings);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Settings + AppTranslations.AddWithSuccess); 
                }
                else
                {
                    asBLL.UpdateAppSettings(appSettings);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Settings + AppTranslations.AddWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetIDByUserID(int currentUserId)
        {
            AppSettingsBLL asBLL = new AppSettingsBLL();
            int appSettingsID = asBLL.GetAppSettingsIDByUserID(currentUserId);
            return appSettingsID;
        }

        public void Init()
        {
            try
            {
                _view.AppSettings = new AppSettings();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
