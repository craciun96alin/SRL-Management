using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class _3DDesignDetailsPresenter
    {
        #region Private members
        private I3DDesignDetailsView _view;
        #endregion
        #region Constructor
        public _3DDesignDetailsPresenter(I3DDesignDetailsView view)
        {
            this._view = view;
        }
        #endregion
        #region Functions
        public void AddOrUpdate3DDesign(_3DDesign _3DDesign)
        {
            try
            {
                _3DDesignsBLL dBLL = new _3DDesignsBLL();
                if (_view._3DDesignID == 0)
                {
                    dBLL.Add3DDesign(_3DDesign);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations._3DDesign + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    dBLL.Update3DDesign(_3DDesign);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations._3DDesign + " " + AppTranslations.EditWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
