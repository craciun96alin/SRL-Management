using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeFilamentsTypeListPresenter
    {
        #region private members
        private IAttributeFilamentsTypeListView _view;
        #endregion
        #region Constructor
        public AttributeFilamentsTypeListPresenter(IAttributeFilamentsTypeListView view)
        {
            this._view = view;
        }
        #endregion
        #region Methods
        public void Init()
        {
            AttributeFilamentsTypeBLL avtBLL = new AttributeFilamentsTypeBLL();
            _view.AttributeFilamentsTypes = avtBLL.GetAllAttributeFilamentsTypes();
        }
        public void DeleteAttributeFilamentsTypes(List<AttributeFilamentsType> AttributeFilamentsTypes)
        {
            try
            {
                AttributeFilamentsTypeBLL avtBLL = new AttributeFilamentsTypeBLL();
                string AttributeFilamentsTypesNames = "";
                foreach (AttributeFilamentsType avt in AttributeFilamentsTypes)
                {
                    avtBLL.DeleteAttributeFilamentsType(avt);
                    AttributeFilamentsTypesNames += avt.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.AttributeFilamentsType + " " + AttributeFilamentsTypesNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
