using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class CustomersBLL
    {
        private bool VerifyInputData(Customer customer)
        {
            CustomersDAL pDAL = new CustomersDAL();
            if (customer.FirstName == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (customer.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);

            Customer t = pDAL.GetCustomerByName(customer.FirstName +" "+ customer.LastName);
            if (t != null && t.CustomerID != customer.CustomerID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                VerifyInputData(customer);

                CustomersDAL cDAL = new CustomersDAL();
                cDAL.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            try
            {
                CustomersDAL cDAL = new CustomersDAL();
                return cDAL.GetAllCustomers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                VerifyInputData(customer);
                CustomersDAL cDAL = new CustomersDAL();
                cDAL.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            try
            {
                CustomersDAL cDAL = new CustomersDAL();
                cDAL.RemoveCustomer(customer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllCustomersName()
        {
            try
            {
                CustomersDAL cDAL = new CustomersDAL();
                var customersName = cDAL.GetAllProvidersName();
                return customersName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customer GetCustomerByName(string customerName)
        {
            try
            {
                CustomersDAL pDAL = new CustomersDAL();
                var customer = pDAL.GetCustomerByName(customerName);
                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
