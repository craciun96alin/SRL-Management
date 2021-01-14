using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeVinylsTypeListPresenter
    {
        #region private members
        private IAttributeVinylsTypeListView _view;
        #endregion
        #region Constructor
        public AttributeVinylsTypeListPresenter(IAttributeVinylsTypeListView view)
        {
            this._view = view;
        }
        #endregion
        #region Methods
        public void Init()
        {
            AttributeVinylsTypeBLL avtBLL = new AttributeVinylsTypeBLL();
            _view.AttributeVinylsTypes = avtBLL.GetAllAttributeVinylsTypes();
        }
        public void DeleteAttributeVinylsTypes(List<AttributeVinylsType> AttributeVinylsTypes)
        {
            try
            {
                AttributeVinylsTypeBLL avtBLL = new AttributeVinylsTypeBLL();
                string AttributeVinylsTypesNames = "";
                foreach (AttributeVinylsType avt in AttributeVinylsTypes)
                {
                    avtBLL.DeleteAttributeVinylsType(avt);
                    AttributeVinylsTypesNames += avt.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.AttributeVinylsType + " " + AttributeVinylsTypesNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
