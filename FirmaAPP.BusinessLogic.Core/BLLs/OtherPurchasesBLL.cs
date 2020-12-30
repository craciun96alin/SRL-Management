using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.Core
{
    public class OtherPurchasesBLL
    {
        private bool VerifyInputData(OtherPurchase otherPurchase)
        {
            OtherPurchasesDAL opDAL = new OtherPurchasesDAL();
            if (otherPurchase.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (otherPurchase.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);

            OtherPurchase op = opDAL.GetOtherPurchaseByName(otherPurchase.Name);
            if (op != null && op.OtherPurchaseID != otherPurchase.OtherPurchaseID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddOtherPurchase(OtherPurchase otherPurchase)
        {
            try
            {
                VerifyInputData(otherPurchase);
                OtherPurchasesDAL opDAL = new OtherPurchasesDAL();
                opDAL.AddOtherPurchase(otherPurchase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OtherPurchase> GetAllOtherPurchases()
        {
            try
            {
                OtherPurchasesDAL opDAL = new OtherPurchasesDAL();
                ProvidersDAL pDAL = new ProvidersDAL();
                var otherPruchases = opDAL.GetAllOtherPurchases();
                foreach (OtherPurchase op in otherPruchases)
                {
                    if (op.Provider == null && op.ProviderID != null)
                    {
                        op.Provider = pDAL.GetProviderById(op.ProviderID);
                    }
                }
                return otherPruchases;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateOtherPurchase(OtherPurchase otherPurchase)
        {
            try
            {
                VerifyInputData(otherPurchase);
                OtherPurchasesDAL opDAL = new OtherPurchasesDAL();
                opDAL.UpdateOtherPurchase(otherPurchase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteOtherPurchase(OtherPurchase otherPruchase)
        {
            try
            {
                OtherPurchasesDAL opDAL = new OtherPurchasesDAL();
                opDAL.RemoveOtherPurchase(otherPruchase);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStock(int otherPurchaseID, float quantity)
        {
            try
            {
                //TO DO VerifyInputData
                OtherPurchase op = GetOtherPruchaseByID(otherPurchaseID);
                op.Stock += quantity;
                UpdateOtherPurchase(op);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OtherPurchase> GetOtherPurchasesNameByProvider(Provider provider)
        {
            try
            {
                List<string> OtherPurchasesName = new List<string>();
                OtherPurchasesDAL opDAL = new OtherPurchasesDAL();
                var OtherPurchases = opDAL.GetOtherPurchasesByProviderId(provider.ProviderID);
                return OtherPurchases;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OtherPurchase GetOtherPruchaseByID(int otherPurchaseID)
        {
            try
            {
                OtherPurchasesDAL opDAL = new OtherPurchasesDAL();
                return opDAL.GetOtherPruchaseByID(otherPurchaseID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
