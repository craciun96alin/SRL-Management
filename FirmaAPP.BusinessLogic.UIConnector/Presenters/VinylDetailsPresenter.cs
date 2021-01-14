using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class VinylDetailsPresenter
    {
        #region Private members
        private IVinylDetailsView _view;
        #endregion
        #region Constructor
        public VinylDetailsPresenter(IVinylDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Functions
        public void AddOrUpdateVinyl(Vinyl vinyl)
        {
            try
            {
                VinylBLL vBLL = new VinylBLL();
                if (vinyl.VinylID == 0)
                {
                    vBLL.AddVinyl(vinyl);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.Vinyl + " " + vinyl.Name + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    vBLL.UpdateVinyl(vinyl);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.Vinyl + " "+ vinyl.Name + " " + AppTranslations.EditWithSuccess);
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

        public List<string> GetAllAttributeVinylsTypeNames()
        {
            try
            {
                AttributeVinylsTypeBLL pBLL = new AttributeVinylsTypeBLL();
                var VinylsTypeName = pBLL.GetAllAttributeVinylsTypeNames();
                return VinylsTypeName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllAttributeColorNames()
        {
            try
            {
                AttributeColorBLL aBLL = new AttributeColorBLL();
                var colorsName = aBLL.GetAllAttributeColorNames();
                return colorsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AttributeColor GetColorAttributeByName(string name)
        {
            try
            {
                AttributeColorBLL aBLL = new AttributeColorBLL();
                var color = aBLL.GetAttributeColorByName(name);
                return color;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AttributeVinylsType GetVinylsTypeAttributeByName(string name)
        {
            try
            {
                AttributeVinylsTypeBLL aBLL = new AttributeVinylsTypeBLL();
                var VinylsType = aBLL.GetAttributeVinylsTypeByName(name);
                return VinylsType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
