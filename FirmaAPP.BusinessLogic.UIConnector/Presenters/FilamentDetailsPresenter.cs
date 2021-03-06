﻿using System;
using System.Collections.Generic;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class FilamentDetailsPresenter
    {
        #region Private members
        private IFilamentDetailsView _view;
        #endregion
        #region Constructor
        public FilamentDetailsPresenter(IFilamentDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Public functions
        public void AddOrUpdateFilament(Filament filament)
        {
            try
            {
                FilamentsBLL fBLL = new FilamentsBLL();
                if (filament.FilamentID == 0)
                {
                    fBLL.AddFilament(filament);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.Filament + " " + filament.Name + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    fBLL.UpdateFilament(filament);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.Filament + " " + filament.Name + " " + AppTranslations.EditWithSuccess);
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

        public List<string> GetAllAttributeFilamentsTypeNames()
        {
            try
            {
                AttributeFilamentsTypeBLL pBLL = new AttributeFilamentsTypeBLL();
                var FilamentsTypeName = pBLL.GetAllAttributeFilamentsTypeNames();
                return FilamentsTypeName;
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

        public AttributeFilamentsType GetFilamentsTypeAttributeByName(string name)
        {
            try
            {
                AttributeFilamentsTypeBLL aBLL = new AttributeFilamentsTypeBLL();
                var FilamentsType = aBLL.GetAttributeFilamentsTypeByName(name);
                return FilamentsType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
