using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class FilamentListPresenter
    {
        private IFilamentListView _view;
        public FilamentListPresenter(IFilamentListView view)
        {
            this._view = view;
        }
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
                throw new Exception("Succes: Filamentul " + filamentsNames + " a fost șters!");

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
