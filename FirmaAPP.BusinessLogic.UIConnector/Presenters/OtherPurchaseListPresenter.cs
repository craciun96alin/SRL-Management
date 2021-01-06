using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;


namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class OtherPurchaseListPresenter
    {
        private IOtherPurchaseListView _view;
        public OtherPurchaseListPresenter(IOtherPurchaseListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            try
            {
                OtherPurchasesBLL opBLL = new OtherPurchasesBLL();
                _view.OtherPurchases = opBLL.GetAllOtherPurchases();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteOtherPurchases(List<OtherPurchase> otherPurchases)
        {
            try
            {
                OtherPurchasesBLL opBLL = new OtherPurchasesBLL();
                string otherPurchasesNames = "";
                foreach (OtherPurchase op in otherPurchases)
                {
                    opBLL.DeleteOtherPurchase(op);
                    otherPurchasesNames += op.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Supplie + " " + otherPurchasesNames + AppTranslations.RemoveWithSuccess);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
