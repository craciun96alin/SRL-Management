using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class Attribute3DPrintsQualityListPresenter
    {
        #region private members
        private IAttribute3DPrintsQualityListView _view;
        #endregion
        #region Constructor
        public Attribute3DPrintsQualityListPresenter(IAttribute3DPrintsQualityListView view)
        {
            this._view = view;
        }
        #endregion
        #region Methods
        public void Init()
        {
            Attribute3DPrintsQualityBLL avtBLL = new Attribute3DPrintsQualityBLL();
            _view.Attribute3DPrintsQualitys = avtBLL.GetAllAttribute3DPrintsQualitys();
        }
        public void DeleteAttribute3DPrintsQualitys(List<Attribute3DPrintsQuality> Attribute3DPrintsQualitys)
        {
            try
            {
                Attribute3DPrintsQualityBLL avtBLL = new Attribute3DPrintsQualityBLL();
                string Attribute3DPrintsQualitysNames = "";
                foreach (Attribute3DPrintsQuality avt in Attribute3DPrintsQualitys)
                {
                    avtBLL.DeleteAttribute3DPrintsQuality(avt);
                    Attribute3DPrintsQualitysNames += avt.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Attribute3DPrintsQuality + " " + Attribute3DPrintsQualitysNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
