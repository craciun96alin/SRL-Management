using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeTshirtsTypeDetailsPresenter
    {
        #region Private members
        private IAttributeTshirtsTypeDetailsView _view;
        #endregion
        #region Constructor
        public AttributeTshirtsTypeDetailsPresenter(IAttributeTshirtsTypeDetailsView view)
        {
            this._view = view;
        }
        #endregion
        public void AddOrUpdateAttributeTshirtsType(AttributeTshirtsType attributeTshirtsType)
        {
            {
                try
                {
                    AttributeTshirtsTypeBLL aftBLL = new AttributeTshirtsTypeBLL();
                    if (attributeTshirtsType.AttributeTshirtsTypeID == 0)
                    {
                        aftBLL.AddAttributeTshirtsType(attributeTshirtsType);
                        throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeTshirtsType + " " + attributeTshirtsType.Name + " " + AppTranslations.AddWithSuccess);
                    }
                    else
                    {
                        aftBLL.UpdateAttributeTshirtsType(attributeTshirtsType);
                        throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.AttributeTshirtsType + " " + attributeTshirtsType.Name + " " + AppTranslations.EditWithSuccess);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
