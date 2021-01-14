using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class FilamentListPresenter
    {
        #region private members
        private IFilamentListView _view;
        #endregion
        #region Constructor
        public FilamentListPresenter(IFilamentListView view)
        {
            this._view = view;
        }
        #endregion
        public void Init()
        {
            FilamentsBLL fBLL = new FilamentsBLL();
            _view.Filaments = fBLL.GetAllFilaments();
        }
        public void DeleteFilaments(List<Filament> filaments)
        {
            try
            {
                FilamentsBLL fBLL = new FilamentsBLL();
                string filamentsNames = "";
                foreach (Filament f in filaments)
                {
                    fBLL.DeleteFilament(f);
                    filamentsNames += f.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Filament + " " + filamentsNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
