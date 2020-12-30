using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class ProvidersDAL
    {
        DBContext context = new DBContext();

        public void AddProvider(Provider provider)
        {
            context.Add<Provider>(provider);
            context.SaveChanges();
        }

        public void UpdateProvider(Provider provider)
        {
            context.Update<Provider>(provider);
            context.SaveChanges();
        }

        public void RemoveProvider(Provider provider)
        {
            context.Remove<Provider>(provider);
            context.SaveChanges();
        }

        public List<Provider> GetAllProviders()
        {
            var providers = context.Providers.ToList();
            return providers;
        }

        public Provider GetProviderByName(string providerName)
        {
            var provider = context.Providers.Where(n => n.Name == providerName).FirstOrDefault();
            return provider;
        }

        public List<string> GetAllProvidersName()
        {
            var providersName = context.Providers.Select(p => p.Name).ToList();
            return providersName;
        }

        public Provider GetProviderById(int? providerID)
        {
            var provider = context.Providers.Where(n => n.ProviderID == providerID).FirstOrDefault();
            return provider;
        }

        public Provider GetProviderByID(int? providerID)
        {
            var provider = context.Providers.Where(n => n.ProviderID == providerID).FirstOrDefault();
            return provider;
        }
    }
}
