using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class VinylListPresenter
    {
        private IVinylListView _view;
        public VinylListPresenter(IVinylListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            VinylBLL vBLL = new VinylBLL();
            _view.Vinyls = vBLL.GetAllVinyls();
        }
        public void DeleteVinyls(List<Vinyl> vinyls)
        {
            try
            {
                VinylBLL fBLL = new VinylBLL();
                string vinylsNames = "";
                foreach (Vinyl v in vinyls)
                {
                    fBLL.DeleteVinyl(v);
                    vinylsNames += v.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Vinyl +" " + vinylsNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
