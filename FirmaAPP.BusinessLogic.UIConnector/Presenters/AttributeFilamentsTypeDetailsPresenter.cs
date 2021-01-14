using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeFilamentsTypeDetailsPresenter
    {
        #region Private members
        private IAttributeFilamentsTypeDetailsView _view;
        #endregion
        #region Constructor
        public AttributeFilamentsTypeDetailsPresenter(IAttributeFilamentsTypeDetailsView view)
        {
            this._view = view;
        }
        #endregion
        public void AddOrUpdateAttributeFilamentsType(AttributeFilamentsType attributeFilamentsType)
        {
            try
            {
                AttributeFilamentsTypeBLL aftBLL = new AttributeFilamentsTypeBLL();
                if (attributeFilamentsType.AttributeFilamentsTypeID == 0)
                {
                    aftBLL.AddAttributeFilamentsType(attributeFilamentsType);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeFilamentsType + " " + attributeFilamentsType.Name + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    aftBLL.UpdateAttributeFilamentsType(attributeFilamentsType);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeFilamentsType + " " + attributeFilamentsType.Name + " " + AppTranslations.EditWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
