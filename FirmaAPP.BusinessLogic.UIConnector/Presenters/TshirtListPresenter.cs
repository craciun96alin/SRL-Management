using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class TshirtListPresenter
    {
        private ITshirtListView _view;
        public TshirtListPresenter(ITshirtListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            try
            {
                TshirtsBLL tBLL = new TshirtsBLL();
                _view.Tshirts = tBLL.GetAllTshirts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTshirts(List<Tshirt> providers)
        {
            try
            {
                TshirtsBLL tBLL = new TshirtsBLL();
                string tshirtsNames = "";
                foreach (Tshirt t in providers)
                {
                    tBLL.DeleteTshirt(t);
                    tshirtsNames += t.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Tshirt + " " + tshirtsNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
