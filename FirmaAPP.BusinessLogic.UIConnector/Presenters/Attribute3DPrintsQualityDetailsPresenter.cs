using System;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class Attribute3DPrintsQualityDetailsPresenter
    {
        #region Private members
        private IAttribute3DPrintsQualityDetailsView _view;
        #endregion
        #region Constructor
        public Attribute3DPrintsQualityDetailsPresenter(IAttribute3DPrintsQualityDetailsView view)
        {
            this._view = view;
        }
        #endregion
        public void AddOrUpdateAttribute3DPrintQuality(Attribute3DPrintsQuality attribute3DPrintQuality)
        {

            try
            {
                Attribute3DPrintsQualityBLL a3DpqBLL = new Attribute3DPrintsQualityBLL();
                if (attribute3DPrintQuality.Attribute3DPrintsQualityID == 0)
                {
                    a3DpqBLL.AddAttribute3DPrintsQuality(attribute3DPrintQuality);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.Attribute3DPrintsQuality + " " + attribute3DPrintQuality.Name + " " + AppTranslations.AddWithSuccess);
                }
                else
                {
                    a3DpqBLL.UpdateAttribute3DPrintsQuality(attribute3DPrintQuality);
                    throw new Exception(AppTranslations.SuccesInfoBox + " " + AppTranslations.Attribute3DPrintsQuality + " " + attribute3DPrintQuality.Name + " " + AppTranslations.EditWithSuccess);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
