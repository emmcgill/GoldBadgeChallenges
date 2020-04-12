using System;
using System.Collections.Generic;
using System.Text;

namespace Komodo_Email_Problem
{
    class Customer
    {
        public enum CustomerType { Potential = 1, Current, Past }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeOfCustomer { get; set; }

        public string CustomerEmail { get; }


        public Customer()
        {

        }

        public Customer(string firstName, string lastName, int customerType)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOfCustomer = customerType;
        }

        //GENERATE CUSTOMER EMAIL
        public string GenerateCustomerEmail()
        {
            switch (TypeOfCustomer)
            {
                case 1:
                    Console.WriteLine("We currently have the lowest rates on Helicopter Insurance! Please get your free quote from Komodo Insurance today.");
                    break;
                case 2:
                    Console.WriteLine("Thank you for choosing us, we greatly appreciate your loyalty. Here is a free coupon for a yummy pizza from Komodo Cafe.");
                    break;
                case 3:
                    Console.WriteLine("It's been a long time since we have heard from you, we would like you back.");
                    break;
            }

            return null;
        }
       
        //CUSTOMER TYPE CONVERSION TO STRING
        public string ConvertCustomerTypeToString() 
        {
            switch (TypeOfCustomer)
            {
                case 1:
                    Console.WriteLine("Potential Customer");
                    break;
                case 2:
                    Console.WriteLine("Current Customer");
                    break;
                case 3:
                    Console.WriteLine("Past Customer");
                    break;
            }
            return null;
        }


    }
}
