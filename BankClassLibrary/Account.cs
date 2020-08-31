using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;

namespace BankClassLibrary
{
    public class Account
    {
        #region FIELDS AND PROPERTIES

        public static double ExchangeRate = 1.1d;    // Exchange rate to foreign currency
        private const string EMPTY_ADDRESS = "Unknown";
        private const string EMPTY_PHONE = "#####"; 

        Customer _accountCustomer;                    // Account holder
        public string CustomerName
        {
            get { return _accountCustomer.CustomerName; }
        }

        public string CustomerPhone
        {
            get { return _accountCustomer.PhoneNumber; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    _accountCustomer.PhoneNumber = EMPTY_PHONE; 
                else
                    _accountCustomer.PhoneNumber = value; 
            }
        }

        public string CustomerAddress
        {
            get { return _accountCustomer.Address; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    _accountCustomer.Address = EMPTY_ADDRESS; 
                else
                    _accountCustomer.Address = value; 
            }
        }

        private int _accountNumber;
        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        private double _currentBalance;
        public double CurrentBalance
        {
            get { return _currentBalance; }
        }

        public double BalanceInForeignCurrency
        {
            get { return _currentBalance * ExchangeRate; }
        }

        BindingList<Transaction> _transactionList;
        public BindingList<Transaction> TransactionList
        {
            get { return _transactionList; }
        }

        public Transaction LastTransaction
        {
            get 
            {
                if (_transactionList.Count > 0)
                    return _transactionList[_transactionList.Count - 1];
                else
                    return null; 
            }
        }
        #endregion FIELDS AND PROPERTIES

        #region CONSTRUCTORS

        public Account()
        {
            _accountCustomer = new Customer("Admin", new DateTime(2000,1,1), null, null);
            _accountNumber = Guid.NewGuid().GetHashCode();
            _currentBalance = 0; //doesn't need to be defind, is zero by default
            _transactionList = new BindingList<Transaction>();
        }

        public Account(Account aAccountToCopy)
        {
            _accountNumber = aAccountToCopy._accountNumber;
            _currentBalance = aAccountToCopy._currentBalance;

            _transactionList = new BindingList<Transaction>(aAccountToCopy._transactionList);

            _accountCustomer = new Customer(aAccountToCopy._accountCustomer);
        }

        public Account(string customerName, DateTime dateOfBirth, string phoneNumber = null, string address = null)
        {
            _accountCustomer = new Customer(customerName, dateOfBirth, phoneNumber, address); 
            _accountNumber = Guid.NewGuid().GetHashCode();
            _currentBalance = 0; //doesn't need to be defind, is zero by default
            _transactionList = new BindingList<Transaction>(); 
        }
        #endregion CONSTRUCTORS

        #region METHODS
        
        public bool DepositMoney(double amount)
        {
            bool isSuccess = false;

            _currentBalance += amount;

            Transaction transaction = new Transaction(amount, TransactionType.DEPOSIT);
            _transactionList.Add(transaction);  

            return isSuccess; 
        }

        public bool WithdrawMoney(double amount)
        {
            bool isSuccesful = false;

            _currentBalance -= amount;

            Transaction transaction = new Transaction(amount, TransactionType.WITHDRAWEL);
            _transactionList.Add(transaction);

            return isSuccesful; 
        }
        #endregion METHODS
    }
}
