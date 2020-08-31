using BankClassLibrary; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopCondition = true;

            Account myAccount = CreateAccount();

            while (loopCondition)
            {
                DepositMoney(myAccount);
                myAccount.LastTransaction.DisplayTransaction();
                WithdrawMoney(myAccount);
                myAccount.LastTransaction.DisplayTransaction();
                DisplayMoney(myAccount);

                UtilityMethods.PressAnyKeyToContinue();
            }
        }

        private static void DepositMoney(Account aAcount)
        {
            aAcount.DepositMoney(UtilityMethods.ReadNumericInput("Enter amount of money to deposit:")); 
        }

        private static void WithdrawMoney(Account aAcount)
        {
            aAcount.WithdrawMoney(UtilityMethods.ReadNumericInput("Enter amount of money to withdraw:")); 
        }

        private static void DisplayMoney(Account aAcount)
        {
            aAcount.DisplayBalance(); 
        }

        private static Account CreateAccount()
        {
            string customerName = UtilityMethods.ReadTextInput("Please enter your name:");

            int day = UtilityMethods.ReadNumericInput("Please enter your day of birth:");
            int month = UtilityMethods.ReadNumericInput("Please enter your birth month");
            int year = UtilityMethods.ReadNumericInput("Please enter your birth year");

            string phone = UtilityMethods.ReadTextInput("Please enter your phone number:");
            string address = UtilityMethods.ReadTextInput("Please enter your address:");

            return new Account(customerName, new DateTime(year, month, day), phone, address);
        }
    }
}
