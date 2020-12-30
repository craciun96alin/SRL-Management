using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class OtherPurchaseDetailsPresenter
    {
        #region Private members
        private IOtherPurchaseDetailsView _view;
        #endregion
        #region Constructor
        public OtherPurchaseDetailsPresenter(IOtherPurchaseDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Functions
        public void AddOrUpdateOtherPurchase(OtherPurchase otherPurchase)
        {
            try
            {
                OtherPurchasesBLL opBLL = new OtherPurchasesBLL();
                if (otherPurchase.OtherPurchaseID == 0)
                {
                    opBLL.AddOtherPurchase(otherPurchase);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.OtherPurchase +" "+ otherPurchase.Name +" "+ AppTranslations.AddWithSuccess);
                }
                else
                {
                    opBLL.UpdateOtherPurchase(otherPurchase);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.OtherPurchase + " " + otherPurchase.Name + " " + AppTranslations.EditWithSuccess);
                }
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
                ProvidersBLL pBLL = new ProvidersBLL();
                var provider = pBLL.GetProviderByName(providerName);
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
                ProvidersBLL pBLL = new ProvidersBLL();
                var providersName = pBLL.GetAllProvidersName();
                return providersName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
