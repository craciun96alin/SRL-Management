using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class ProviderListPresenter
    {
        private IProviderListView _view;
        public ProviderListPresenter(IProviderListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                _view.Providers = pBLL.GetAllProviders();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProviders(List<Provider> providers)
        {
            try
            {
                ProvidersBLL pBLL = new ProvidersBLL();
                string providersNames = "";
                foreach (Provider p in providers)
                {
                    pBLL.DeleteProvider(p);
                    providersNames += p.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Provider + " " + providersNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
