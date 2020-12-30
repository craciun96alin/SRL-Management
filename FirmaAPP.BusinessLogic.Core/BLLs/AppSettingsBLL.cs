using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.Core
{
    public class AppSettingsBLL
    {
        public string GetBillFolder(int userID)
        {
            try
            {
                AppSettingsDAL asDAL = new AppSettingsDAL();
                string path = asDAL.GetBillFolderPath(userID);
                return path;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Get3DDesignFolder(int userID)
        {
            try
            {
                AppSettingsDAL asDAL = new AppSettingsDAL();
                string path = asDAL.Get3DDesignFolderPath(userID);
                return path;
            }
            catch (Exception ex)
            {
                throw ex;// TO DO: Database prob;
            }
        }

        public string Get3DPrintFolder(int userID)
        {
            try
            {
                AppSettingsDAL asDAL = new AppSettingsDAL();
                string path = asDAL.Get3DPrintFolderPath(userID);
                return path;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddAppSettings(AppSettings appSettings)
        {
            try
            {
                AppSettingsDAL asDAL = new AppSettingsDAL();
                //verify path
                asDAL.AddAppSettings(appSettings);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int GetAppSettingsIDByUserID(int currentUserId)
        {
            try
            {
                AppSettingsDAL asDAL = new AppSettingsDAL();
                //verify path
                int appSettingsID = asDAL.GetAppSettingsIDByUserID(currentUserId);
                return appSettingsID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAppSettings(AppSettings appSettings)
        {
            try
            {
                AppSettingsDAL asDAL = new AppSettingsDAL();
                //verify path
                asDAL.UpdateAppSettings(appSettings);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
