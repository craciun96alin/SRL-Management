using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmaAPP.BusinessObject;

namespace FirmaAPP.DataAccess
{
    public class AppSettingsDAL
    {
    DBContext context = new DBContext();
        public string GetBillFolderPath(int userID)
        {
            try
            {
                var path = context.AppSettings.Where(u => u.UserID == userID).Select(b => b.BillFolder).FirstOrDefault();
                return path;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Get3DDesignFolderPath(int userID)
        {
            try
            {
                var path = context.AppSettings.Where(u => u.UserID == userID).Select(b => b._3DDesignFolder).FirstOrDefault();
                return path;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Get3DPrintFolderPath(int userID)
        {
            try
            {
                var path = context.AppSettings.Where(u => u.UserID == userID).Select(b => b._3DPrintFolder).FirstOrDefault();
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
                context.Add<AppSettings>(appSettings);
                context.SaveChanges();
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
                context.Update<AppSettings>(appSettings);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetAppSettingsIDByUserID(int currentUserId)
        {
            try
            {
                int appSettingsID = context.AppSettings.Where(u => u.UserID == currentUserId).Select(b => b.AppSettingsID).FirstOrDefault();
                return appSettingsID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
