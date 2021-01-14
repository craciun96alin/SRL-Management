using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeColorDetailsPresenter
    {
        #region Private members
        private IAttributeColorDetailsView _view;
        #endregion
        #region Constructor
        public AttributeColorDetailsPresenter(IAttributeColorDetailsView view)
        {
            this._view = view;
        }
        #endregion
        public void AddOrUpdateAttributeColor(AttributeColor attributeColor)
        {

            try
            {
                AttributeColorBLL acBLL = new AttributeColorBLL();
                if (attributeColor.AttributeColorID == 0)
                {
                    acBLL.AddAttributeColor(attributeColor);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeColor + " " + attributeColor.Name + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    acBLL.UpdateAttributeColor(attributeColor);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeColor + " " + attributeColor.Name + " " + AppTranslations.EditWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
