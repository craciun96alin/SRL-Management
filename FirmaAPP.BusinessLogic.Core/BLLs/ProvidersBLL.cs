using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class ProvidersBLL
    {
        private bool VerifyInputData(Provider provider)
        {
            ProvidersDAL pDAL = new ProvidersDAL();
            if (provider.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (provider.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);

            Provider t = pDAL.GetProviderByName(provider.Name);
            if (t != null && t.ProviderID != provider.ProviderID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddProvider(Provider provider)
        {
            try
            {
                VerifyInputData(provider);
                ProvidersDAL fDAL = new ProvidersDAL();
                fDAL.AddProvider(provider);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Provider> GetAllProviders()
        {
            try
            {

                ProvidersDAL fDAL = new ProvidersDAL();
                return fDAL.GetAllProviders();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateProvider(Provider provider)
        {
            try
            {
                VerifyInputData(provider);
                ProvidersDAL fDAL = new ProvidersDAL();
                fDAL.UpdateProvider(provider);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Provider GetProviderByName(string providerName)
        {
            try
            {
                ProvidersDAL pDAL = new ProvidersDAL();
                var provider = pDAL.GetProviderByName(providerName);
                return provider;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllProvidersName()
        {
            try
            {
                ProvidersDAL pDAL = new ProvidersDAL();
                var providersName = pDAL.GetAllProvidersName();
                return providersName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProvider(Provider provider)
        {
            try
            {
                ProvidersDAL fDAL = new ProvidersDAL();
                fDAL.RemoveProvider(provider);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Provider GetProviderByID(int? providerID)
        {
            try
            {
                ProvidersDAL pDAL = new ProvidersDAL();
                var provider = pDAL.GetProviderByID(providerID);
                return provider;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
