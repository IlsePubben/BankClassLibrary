using System;
using System.Collections.Generic;
using System.Text;

namespace BankClassLibrary
{
    public class Transaction
    {
        #region FIELDS AND PROPERTIES

        private double _moneyAmount;
        public double MoneyAmount
        {
            get { return _moneyAmount; }
        }

        private DateTime _transactionDate;
        public DateTime TransactionDate
        {
            get { return _transactionDate; }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
        }

        TransactionType _typeOfTransaction;

        public string Summary
        {
            get
            {
                return TransactionTypeString + " " +
                  _moneyAmount + " " + DateString;
            }
        }

        public string TransactionTypeString
        {
            get { return (_typeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw"); }
        }

        public string DateString
        {
            get { return _transactionDate.ToString("yyyy/MM/dd hh:mm:dd"); }
        }

        #endregion FIELDS AND PROPERTIES

        #region CONSTRUCTORS

        public Transaction(Transaction aTransaction)
        {
            _moneyAmount = aTransaction._moneyAmount;
            _transactionDate = aTransaction._transactionDate;
            _location = aTransaction._location;
            _typeOfTransaction = aTransaction._typeOfTransaction;
        }

        public Transaction(double aAmount, TransactionType aType)
        {
            _moneyAmount = aAmount;
            _transactionDate = DateTime.Today;
            _location = "EARTH";
            _typeOfTransaction = aType;
        }

        public Transaction(double aAmount, string aTransactionTypeString, DateTime aTransactionDate, string aLocation)
        {
            _moneyAmount = aAmount;
            _transactionDate = aTransactionDate;
            _location = aLocation; 

            switch (aTransactionTypeString)
            {
                case "Deposit":
                    _typeOfTransaction = TransactionType.DEPOSIT;
                    break;
                case "Withdrawel":
                    _typeOfTransaction = TransactionType.WITHDRAWEL;
                    break; 
            }
        }

        #endregion CONSTRUCTORS

        #region METHODS 



        #endregion METHODS
    }

    public enum TransactionType
    {
        DEPOSIT,
        WITHDRAWEL
    }
}
