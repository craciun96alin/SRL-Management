using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class CustomerListPresenter
    {
        private ICustomerListView _view;
        public CustomerListPresenter(ICustomerListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            try
            {
                CustomersBLL cBLL = new CustomersBLL();
                _view.Customers = cBLL.GetAllCustomers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCustomers(List<Customer> customers)
        {
            try
            {
                CustomersBLL cBLL = new CustomersBLL();
                string customersNames = "";
                foreach (Customer c in customers)
                {
                    cBLL.DeleteCustomer(c);
                    customersNames += c.LastName + " " + c.FirstName + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox +AppTranslations.Customer + " " + customersNames +" "+ AppTranslations.RemoveWithSuccess);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
