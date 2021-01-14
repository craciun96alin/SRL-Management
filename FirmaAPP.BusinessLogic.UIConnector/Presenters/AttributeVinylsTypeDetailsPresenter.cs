using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeVinylsTypeDetailsPresenter
    {
        #region Private members
        private IAttributeVinylsTypeDetailsView _view;
        #endregion
        #region Constructor
        public AttributeVinylsTypeDetailsPresenter(IAttributeVinylsTypeDetailsView view)
        {
            this._view = view;
        }
        #endregion
        public void AddOrUpdateAttributeVinylsType(AttributeVinylsType attributeVinylsType)
        {
            try
            {
                AttributeVinylsTypeBLL avtBLL = new AttributeVinylsTypeBLL();
                if (attributeVinylsType.AttributeVinylsTypeID == 0)
                {
                    avtBLL.AddAttributeVinylsType(attributeVinylsType);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeVinylsType + " " + attributeVinylsType.Name + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    avtBLL.UpdateAttributeVinylsType(attributeVinylsType);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeVinylsType + " " + attributeVinylsType.Name + " " + AppTranslations.EditWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
