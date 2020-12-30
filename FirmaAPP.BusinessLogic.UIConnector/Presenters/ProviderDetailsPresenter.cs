using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class ProviderDetailsPresenter
    {
        #region Private members
        private IProviderDetailsView _view;
        #endregion
        #region Constructor
        public ProviderDetailsPresenter(IProviderDetailsView view)
        {
            this._view = view;
        }

        public void AddOrUpdateProvider(Provider provider)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                if (provider.ProviderID == 0)
                {
                    pBLL.AddProvider(provider);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Provider +" "+provider.Name +" "+AppTranslations.AddWithSuccess);
                }
                else
                {
                    pBLL.UpdateProvider(provider);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Provider + " " + provider.Name + " " + AppTranslations.EditWithSuccess);

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
