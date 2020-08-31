using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public class AccountController
    {
        private Account _model;

        #region CONSTRUCTORS

        public AccountController(Account aAccount)
        {
            _model = aAccount; 
        }

        #endregion CONSTRUCTORS

        #region METHODS
        public void DisplayBalance()
        {
            Console.WriteLine("Current balance is:" + _model.CurrentBalance);
        }
        #endregion METHODS


    }
}
