using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class CustomerDetailsPresenter
    {
        #region Private members
        private ICustomerDetailsView _view;
        #endregion
        #region Constructor
        public CustomerDetailsPresenter(ICustomerDetailsView view)
        {
            this._view = view;
        }

        public void AddOrUpdateCustomer(Customer customer)
        {
            try
            {
                CustomersBLL cBLL = new CustomersBLL();
                if (customer.CustomerID == 0)
                {
                    cBLL.AddCustomer(customer);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Customer +" " + customer.LastName +" "+customer.FirstName + " " +AppTranslations.AddWithSuccess);
                }
                else
                {
                    cBLL.UpdateCustomer(customer);
                    throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations.Customer + " " + customer.LastName + " " + customer.FirstName + " " + AppTranslations.EditWithSuccess);
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
