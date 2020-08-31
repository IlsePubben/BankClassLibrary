using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public class TransactionController
    {
        #region FIELDS AND PROPERTIES
        private Transaction _model;
        #endregion

        #region CONSTRUCTORS
        public TransactionController(Transaction aTransaction)
        {
            _model = aTransaction; 
        }
        #endregion

        #region METHODS
        public void DisplayTransaction()
        {
            Console.WriteLine(_model.TransactionDate.Date.ToString("d") + ": " + _model.TransactionTypeString + " of " + _model.MoneyAmount + " euro at " + _model.Location);
        }
        #endregion
    }
}
