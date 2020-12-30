using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class OtherPurchasesDAL
    {
        DBContext context = new DBContext();

        public void AddOtherPurchase(OtherPurchase otherPurchase)
        {
            context.Add<OtherPurchase>(otherPurchase);
            context.SaveChanges();
        }

        public void UpdateOtherPurchase(OtherPurchase otherPurchase)
        {
            context.Update<OtherPurchase>(otherPurchase);
            context.SaveChanges();
        }

        public void RemoveOtherPurchase(OtherPurchase orherPurchase)
        {
            context.Remove<OtherPurchase>(orherPurchase);
            context.SaveChanges();
        }

        public OtherPurchase GetOtherPurchaseByName(string name)
        {
            var otherPurchase = context.OtherPurchases.Where(op => op.Name == name).FirstOrDefault();
            return otherPurchase;
        }

        public List<OtherPurchase> GetAllOtherPurchases()
        {
            var otherPurchases = context.OtherPurchases.ToList();
            return otherPurchases;
        }

        public List<OtherPurchase> GetOtherPurchasesByProviderId(int providerID)
        {
            var otherPurchases = context.OtherPurchases.Where(op => op.ProviderID == providerID).ToList();
            return otherPurchases;
        }

        public OtherPurchase GetOtherPruchaseByID(int otherPurchaseID)
        {
            var otherPurchase = context.OtherPurchases.Where(op => op.OtherPurchaseID == otherPurchaseID).FirstOrDefault();
            return otherPurchase;
        }
    }
}
