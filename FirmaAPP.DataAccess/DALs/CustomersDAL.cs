using System;
using System.Collections.Generic;
using System.Linq;
using FirmaAPP.BusinessObject;

namespace FirmaAPP.DataAccess
{
    public class CustomersDAL
    {
        DBContext context = new DBContext();

        public void AddCustomer(Customer customer)
        {
            context.Add<Customer>(customer);
            context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Update<Customer>(customer);
            context.SaveChanges();
        }

        public void RemoveCustomer(Customer customer)
        {
            context.Remove<Customer>(customer);
            context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            var customers = context.Customers.ToList();
            return customers;
        }

        public List<string> GetAllProvidersName()
        {
            var customersName = context.Customers.Select(p => p.FirstName +" "+ p.LastName).ToList();
            return customersName;
        }

        public Customer GetCustomerByName(string customerName)
        {
            var fullName = customerName.Split(' ');
            var customer = context.Customers.Where(n => n.FirstName == fullName[0] && n.LastName == fullName[1]).FirstOrDefault();
            return customer;
        }

        public Customer GetCustomerById(int? customerID)
        {
            var customer = context.Customers.Where(n => n.CustomerID == customerID).FirstOrDefault();
            return customer;
        }
    }
}
