using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Customer
    {
        #region FIELDS AND PROPERTIES
        private string _customerName;
        private DateTime _dateOfBirth;
        private string _phoneNumber;
        private string _address;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Customer(string name, DateTime birthDate, string phone, string address)
        {
            _customerName = name;
            _dateOfBirth = birthDate;
            _phoneNumber = phone;
            _address = address; 
        }

        public Customer(Customer aCustomer)
        {
            _customerName = aCustomer._customerName;
            _dateOfBirth = aCustomer._dateOfBirth;
            _phoneNumber = aCustomer._phoneNumber;
            _address = aCustomer._address; 

        }
        #endregion
    }
}
