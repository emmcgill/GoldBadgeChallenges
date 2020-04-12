using System;
using System.Collections.Generic;
using System.Text;

namespace Komodo_Email_Problem
{
    class EmailUI
    {
        private EmailRepository _emailRepo = new EmailRepository();

        public void Run()
        {
            EmailMenu();
        }

        public void EmailMenu()
        {
            bool keepProgramRunning = true;
            while (keepProgramRunning)
            {
                Console.Clear();
                Console.WriteLine("Please select an option below:\n" +
                    "1. Add a new customer:\n" +
                    "2. See all customers:\n" +
                    "3. Update an existing customer:\n" +
                    "4. Remove a customer:\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    AddNewCustomer();
                }
                else if (userInput == "2")
                {
                    DisplayAllCustomers();
                }
                else if (userInput == "3")
                {
                    UpdateExistingCustomer();
                }
                else if (userInput == "4")
                {
                    RemoveCustomer();
                }
                else if (userInput == "5")
                {
                    keepProgramRunning = false;
                }
                else
                {
                    Console.WriteLine("Selection unknown. Please try again");
                    EmailMenu();

                }

            }
        }

        //ADD NEW CUSTOMER
        private void AddNewCustomer()
        {
            Console.Clear();
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter the customer's first name:\n");
            newCustomer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the customer's last name:\n");
            newCustomer.LastName = Console.ReadLine();
            Console.WriteLine("Please select the customer type:\n" +
                "1. Potential Customer\n" +
                "2. Current Customer\n" +
                "3. Past Customer");
            string customerTypeAsString = Console.ReadLine();
            int customerTypeAsInt = int.Parse(customerTypeAsString);
            newCustomer.TypeOfCustomer = customerTypeAsInt;

            _emailRepo.AddNewCustomer(newCustomer);
        }

        //SHOW ALL CUSTOMERS
        public void DisplayAllCustomers()
        {
            Console.Clear();
            Console.WriteLine("First Name\tLast Name\tType of Customer\tEmail");
            List<Customer> customerList = _emailRepo.ShowAllCustomers();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName}{customer.LastName}");
                Console.WriteLine($"{customer.ConvertCustomerTypeToString()}{customer.GenerateCustomerEmail()}");
            }
            Console.ReadLine();
        }


        //UPDATE PARTIAL
        private void UpdateExistingCustomer()
        {
            ListOfCustomers();
            Console.WriteLine("Please enter the name of the customer whom you would like to update:\n");
            string priorCustomerInfo = Console.ReadLine();
            Customer newCustomerInfo = new Customer();
            Console.WriteLine("Enter the updated customer first name:\n");
            newCustomerInfo.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the updated customer last name:\n");
            newCustomerInfo.LastName = Console.ReadLine();
            Console.WriteLine("Enter the customer type:\n" +
                "1. Potential Customer\n" +
                "2. Current Customer\n" +
                "3. Past Customer");
            string customerTypeAsString = Console.ReadLine();
            int customerTypeAsInt = int.Parse(customerTypeAsString);
            newCustomerInfo.TypeOfCustomer = customerTypeAsInt;

        }


        private void ListOfCustomers() 
        {
            Console.Clear();
            Console.WriteLine("First Name\tLast Name\tType of Customer");
            List<Customer> customerList = _emailRepo.ShowAllCustomers();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine($"{customer.FirstName}\t\t{customer.LastName}\t\t" +
                    $"{customer.ConvertCustomerTypeToString()}");
            }
            Console.ReadLine();

        }

        private void RemoveCustomer()
        {
            ListOfCustomers();
            Console.WriteLine("Please enter the name of the customer that you would like to remove.\n" +
                "Customer first name:");
            string customerFirstName = Console.ReadLine();
            Console.WriteLine("Customer last name:");
            string customerLastname = Console.ReadLine();
            string customerFullName = customerFirstName + customerLastname;
            bool customerWasDeleted = _emailRepo.DeleteCustomerFromList(customerFullName);
            if (customerWasDeleted == true)
            {
                Console.WriteLine("Item was successfully removed from the menu.");
            }
            else
            {
                Console.WriteLine("This item was not found. Please try again.");
            }
        }
    }
}
