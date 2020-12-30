using System;
using System.Collections.Generic;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class _3DPrintDetailsPresenter
    {
        #region Private members
        private I3DPrintDetailsView _view;
        #endregion
        #region Constructor
        public _3DPrintDetailsPresenter(I3DPrintDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Functions
        public _3DDesign Get3DDesignByName(string printName)
        {
            try
            {
                _3DDesignsBLL dBLL = new _3DDesignsBLL();
                var _3DDesign = dBLL.Get3DPrintByName(printName);
                return _3DDesign;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddOrUpdate3DPrint(_3DPrint _3DPrint)
        {
            try
            {
                _3DPrintsBLL pBLL = new _3DPrintsBLL();
                if (_3DPrint._3DPrintID == 0)
                {
                    pBLL.Add3DPrint(_3DPrint);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations._3DPrint + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    pBLL.Update3DPrint(_3DPrint);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations._3DPrint + " " + AppTranslations.EditWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAll3DDesigns()
        {
            try
            {
                _3DDesignsBLL dBLL = new _3DDesignsBLL();
                var designsName = dBLL.GetAll3DDesignsName();
                return designsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
