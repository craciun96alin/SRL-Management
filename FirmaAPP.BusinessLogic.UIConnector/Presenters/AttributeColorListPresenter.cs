using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class AttributeColorListPresenter
    {
        #region private members
        private IAttributeColorsListView _view;
        #endregion
        #region Constructor
        public AttributeColorListPresenter(IAttributeColorsListView view)
        {
            this._view = view;
        }
        #endregion
        public void Init()
        {
            AttributeColorBLL avtBLL = new AttributeColorBLL();
            _view.AttributeColors = avtBLL.GetAllAttributeColors();
        }
        public void DeleteAttributeColors(List<AttributeColor> AttributeColors)
        {
            try
            {
                AttributeColorBLL avtBLL = new AttributeColorBLL();
                string AttributeColorsNames = "";
                foreach (AttributeColor avt in AttributeColors)
                {
                    avtBLL.DeleteAttributeColor(avt);
                    AttributeColorsNames += avt.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.AttributeColor + " " + AttributeColorsNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
