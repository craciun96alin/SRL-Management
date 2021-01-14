using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeTshirtsTypeListPresenter
    {
        #region private members
        private IAttributeTshirtsTypeListView _view;
        #endregion
        #region Constructor
        public AttributeTshirtsTypeListPresenter(IAttributeTshirtsTypeListView view)
        {
            this._view = view;
        }
        #endregion
        #region Methods
        public void Init()
        {
            AttributeTshirtsTypeBLL avtBLL = new AttributeTshirtsTypeBLL();
            _view.AttributeTshirtsTypes = avtBLL.GetAllAttributeTshirtsTypes();
        }
        public void DeleteAttributeTshirtsTypes(List<AttributeTshirtsType> AttributeTshirtsTypes)
        {
            try
            {
                AttributeTshirtsTypeBLL avtBLL = new AttributeTshirtsTypeBLL();
                string AttributeTshirtsTypesNames = "";
                foreach (AttributeTshirtsType avt in AttributeTshirtsTypes)
                {
                    avtBLL.DeleteAttributeTshirtsType(avt);
                    AttributeTshirtsTypesNames += avt.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.AttributeTshirtsType + " " + AttributeTshirtsTypesNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
