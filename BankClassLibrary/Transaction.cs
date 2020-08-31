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

        TransactionType TypeOfTransaction;

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
            get { return (TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw"); }
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
            TypeOfTransaction = aTransaction.TypeOfTransaction;
        }

        public Transaction(double aAmount, TransactionType aType)
        {
            _moneyAmount = aAmount;
            _transactionDate = DateTime.Today;
            _location = "EARTH";
            TypeOfTransaction = aType;
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
