using FirmaAPP.BusinessObject;
using System;
using System.Linq;
using AppContext = FirmaAPP.Common.AppContext;

namespace FirmaAPP.DataAccess
{
    public class BusinessDetailsDAL
    {
        DBContext context = new DBContext();
        public void AddBusinessDetails(BusinessDetails BusinessDetails)
        {
            try
            {
                context.Add<BusinessDetails>(BusinessDetails);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateBusinessDetails(BusinessDetails BusinessDetails)
        {
            try
            {
                context.Update<BusinessDetails>(BusinessDetails);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetBusinessDetailsIDByUserID(int currentUserId)
        {
            try
            {
                int BusinessDetailsID = context.BusinessDetails.Where(u => u.UserID == currentUserId).Select(b => b.BusinessDetailsID).FirstOrDefault();
                return BusinessDetailsID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BusinessDetails GetBusinessDetailsByUserID()
        {
            try
            {
                return context.BusinessDetails.Where(bd => bd.UserID == AppContext.CurrentUserId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
