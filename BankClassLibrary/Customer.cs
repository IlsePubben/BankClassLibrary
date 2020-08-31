using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        public string CustomerName;
        DateTime DateOfBirth;
        public string PhoneNumber;
        public string Address;

        public Customer(string name, DateTime birthDate, string phone, string address)
        {
            CustomerName = name;
            DateOfBirth = birthDate;
            PhoneNumber = phone;
            Address = address; 
        }

        public Customer(Customer aCustomer)
        {
            CustomerName = aCustomer.CustomerName;
            DateOfBirth = aCustomer.DateOfBirth;
            PhoneNumber = aCustomer.PhoneNumber;
            Address = aCustomer.Address; 

        }
    }
}
