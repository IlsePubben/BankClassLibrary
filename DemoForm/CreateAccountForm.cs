using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class CreateAccountForm : Form
    {
        #region FIELDS AND PROPERTIES

        private string PhoneTextInput
        {
            get { return PhoneMaskTextBox.Enabled ? PhoneMaskTextBox.Text : null; } 
        }
        private string AddressTextInput
        {
            get { return AddressRichTextBox.Enabled ? AddressRichTextBox.Text : null; }
        }

        #endregion FIELDS AND PROPERTIES

        #region CONSTRUCTORS
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORS

        #region METHODS

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNameTextBox.Text;
            DateTime birthDate = BirthDatePicker.Value;

            // Validations 
            if (!ValidateCustomerName(customerName))
            {
                MessageBox.Show("Customer name is invalid.");
                return;
            }
            if (!ValidateBirthdate(birthDate))
            {
                MessageBox.Show("Birthdate is invalid.");
                return; 
            }

            string phone = PhoneTextInput;
            string address = AddressTextInput; 

            Account newAccount = new Account(customerName, birthDate, phone, address);

            newAccount.DepositMoney(1000);
            newAccount.WithdrawMoney(500);

            StorageUtilityFunctions.SaveAccount(newAccount);
            Account lastAccount = StorageUtilityFunctions.GetLastAccount(); 
 
            DisplayAccountForm displayAccountForm = new DisplayAccountForm(newAccount);
            this.Hide(); 
            displayAccountForm.ShowDialog();
            this.Show(); 
        }

        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PhoneMaskTextBox.Enabled = PhoneCheckBox.Checked; 
        }

        private void AddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddressRichTextBox.Enabled = AddressCheckBox.Checked; 
        }

        private bool ValidateCustomerName(string aTextToValidate)
        {
            return !string.IsNullOrEmpty(aTextToValidate) && 
                    aTextToValidate.Length > 2 && 
                    aTextToValidate.Length < 25; 
        }

        private bool ValidateBirthdate(DateTime aDateToValidate)
        {
            // Check if customer is at least 18 years old
            return DateTime.Compare(aDateToValidate, new DateTime(DateTime.Now.Year - 18, 12, 31)) <= 0; 
        }

        #endregion METHODS
    }
}
