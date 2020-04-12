using System;
using System.Collections.Generic;
using System.Text;

namespace Komodo_Email_Problem
{
    class EmailRepository
    {
        private List<Customer> _listOfCustomers = new List<Customer>();

        //CREATE
        public void AddNewCustomer(Customer newCustomer)
        {
            _listOfCustomers.Add(newCustomer);
        }

        //READ
        public List<Customer> ShowAllCustomers()
        {
            return _listOfCustomers;
        }

        //UPDATE CUSTOMER
        public bool UpdateExistingCustomer (string customerName, Customer newCustomerInfo)
        {
            Customer priorCustomerInfo = GetCustomerByName(customerName);
                if (priorCustomerInfo !=null)
                {
                    priorCustomerInfo.FirstName = newCustomerInfo.FirstName;
                    priorCustomerInfo.LastName = newCustomerInfo.LastName;
                    priorCustomerInfo.TypeOfCustomer = newCustomerInfo.TypeOfCustomer;
                    return true;
                }
                else
                {
                    return false;
                }
        }


        //GET CUSTOMER BY NAME (HELPER)
        private Customer GetCustomerByName(string name)
        {
            
            foreach (Customer customer in _listOfCustomers)
            {
                string customerFullName = customer.FirstName + customer.LastName;

                if (customerFullName == customer.ToString())
                {
                    return customer;
                }
            }
            return null;
        }

        //DELETE CUSTOMER
        public bool DeleteCustomerFromList(string customerName)
        {
            Customer customerToDelete = GetCustomerByName(customerName);
            if (_listOfCustomers == null)
            {
                return false;
            }

            int initialListCount = _listOfCustomers.Count;
            _listOfCustomers.Remove(customerToDelete);

            if (initialListCount > _listOfCustomers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
