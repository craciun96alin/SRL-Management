using System;
using System.Collections.Generic;
using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class BillDetailsPresenter
    {
        #region Private members
        private IBillDetailsView _view;
        #endregion
        #region Constructor
        public BillDetailsPresenter(IBillDetailsView view)
        {
            this._view = view;
        }

        public void AddUpdateBill(Bill bill)
        {
            try
            {
                BillsBLL tBLL = new BillsBLL();
                OrdersBLL oBLL = new OrdersBLL();
                if (bill.BillID == 0)
                {
                    int billID = 2; //Bill id for without order
                    if (bill.BillStatus != Enums.BillStatus.Fără_factură)
                    {
                        billID = tBLL.AddAcquisitionBill(bill);
                    }
                    oBLL.AddBillToOrder(billID, _view.OrderID);
                    oBLL.UpdateOrderStatus(_view.OrderID, Enums.OrderStatus.Plasată);
                    throw new Exception(AppTranslations.SuccesInfoBox+AppTranslations.Bill +" "+ bill.BillName +" "+AppTranslations.AddWithSuccess);
                }
                else
                {
                    //tBLL.UpdateBill(bill);
                    //throw new Exception("Succes: Factura " + bill.BillName + " a fost editată!");
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
