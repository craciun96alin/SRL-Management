using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class TshirtDetailsPresenter
    {
        #region Private members
        private ITshirtDetailsView _view;
        #endregion
        #region Constructor
        public TshirtDetailsPresenter(ITshirtDetailsView view)
        {
            this._view = view;
        }
        #endregion

        public void AddOrUpdateTshirt(Tshirt tshirt)
        {
            try
            {
                TshirtsBLL tBLL = new TshirtsBLL();
                if (tshirt.TshirtID == 0)
                {
                    tBLL.AddTshirt(tshirt);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Tshirt +" " +tshirt.Name+ " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    tBLL.UpdateTshirt(tshirt);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Tshirt + " " + tshirt.Name + " " + AppTranslations.EditWithSuccess);
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
    }
}
