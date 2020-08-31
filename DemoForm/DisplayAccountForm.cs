using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankClassLibrary.Account;

namespace DemoForm
{
    public partial class DisplayAccountForm : Form
    {
        #region FIELDS AND PROPERTIES

        private Account _myAccount;

        #endregion FIELDS AND PRPOERTIES


        #region CONSTRUCTORS
        private DisplayAccountForm() { }            //Disables default constructor 
        public DisplayAccountForm(Account aAccount)
        {
            InitializeComponent();
            _myAccount = aAccount;
            TransactionListBox.DataSource = _myAccount.TransactionList;
            TransactionListBox.DisplayMember = "Summary";
            BalancePanel.TextInput = _myAccount.CurrentBalance.ToString();
            CustomerNamePanel.TextInput = _myAccount.CustomerName;
        }
        #endregion CONSTRUCTORS

        private void TransactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TransactionListBox.SelectedIndex;

            Transaction selectedTransaction = _myAccount.TransactionList[index];

            TransactionTypePanel.TextInput = selectedTransaction.TransactionTypeString;
            TransactionDatePanel.TextInput = selectedTransaction.DateString;
            TransactionAmountPanel.TextInput = selectedTransaction.MoneyAmount.ToString();
            LocationPanel.TextInput = selectedTransaction.Location;
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            double depositAmount = Convert.ToDouble(DepositAmountTextBox.Text);
            _myAccount.DepositMoney(depositAmount);

            BalancePanel.TextInput = _myAccount.CurrentBalance.ToString(); 
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double withdrawAmount = Convert.ToDouble(WithdrawAmountTextBox.Text);
            _myAccount.WithdrawMoney(withdrawAmount);

            BalancePanel.TextInput = _myAccount.CurrentBalance.ToString(); 
        }
    }
}
