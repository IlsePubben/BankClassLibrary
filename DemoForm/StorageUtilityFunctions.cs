using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    // Methods and properties to use file system as database
    public static class StorageUtilityFunctions
    {
        #region FIELDS AND PROPERTIES 
        private const string _mainStorageDir = @"C:\temp";
        private const string _customerStorageDir = @"C:\temp2";
        private const string _dateStringFormat = "yyyy:MM:dd HH:mm"; 
        #endregion

        #region CONSTRUCTORS
        static StorageUtilityFunctions()
        {
            if (!CheckDirectories())
            {
                Directory.CreateDirectory(_mainStorageDir);
                Directory.CreateDirectory(_customerStorageDir); 
            }

        }
        #endregion

        #region METHODS
        static bool CheckDirectories()
        {
            return Directory.Exists(_mainStorageDir) && Directory.Exists(_customerStorageDir); 
        }

        public static Account GetLastAccount()
        {
            Account lastAccount = new Account();

            DirectoryInfo dirInfo = new DirectoryInfo(_mainStorageDir);
            FileInfo[] fileInfoArray = dirInfo.GetFiles();

            if (fileInfoArray.Length == 0)
                return null;

            FileInfo lastFileInfo = fileInfoArray.OrderByDescending(f => f.LastWriteTime).First();

            string filePath = lastFileInfo.FullName;
            //string fileName = Path.GetFileNameWithoutExtension(filePath); //account ID because of how it is saved 

            int accountID;
            string customerName; 

            using (StreamReader sr = File.OpenText(filePath))
            {
                string headerLine = sr.ReadLine(); // accountId_CustomerName
                string[] headerParts = headerLine.Split('_');
                accountID = Convert.ToInt32(headerParts[0]);
                customerName = headerParts[1];
                DateTime birthDate;
                string phoneNumber;
                string address = "";

                string nextLine; 

                // Extract customer
                using (StreamReader srCustomer = File.OpenText(_customerStorageDir + "\\" + customerName + ".dat")) 
                {
                    headerLine = srCustomer.ReadLine(); //CustomerName_birthdate_phone

                    headerParts = headerLine.Split('_');
                    birthDate = DateTime.ParseExact(headerParts[1], _dateStringFormat, null);
                    phoneNumber = headerParts[2];

                    nextLine = srCustomer.ReadLine();
                    while (!String.IsNullOrEmpty(nextLine))
                    {
                        address += nextLine + '\n';
                        nextLine = srCustomer.ReadLine(); 
                    }
                }

                lastAccount = new Account(accountID, customerName, birthDate, phoneNumber, address); 

                // Extract transactions 
                nextLine = sr.ReadLine(); 
                while (!String.IsNullOrEmpty(nextLine))
                {
                    string transactionLine = nextLine;
                    nextLine = sr.ReadLine();

                    string[] transactionParts = transactionLine.Split('_'); //TransactionType_TransactionAmount_TransactionDate_Location
                    string transactionType = transactionParts[0];
                    double transactionAmount = Convert.ToDouble(transactionParts[1]);
                    DateTime transactionDate = DateTime.ParseExact(transactionParts[2], _dateStringFormat, null);
                    string transactionLocation = transactionParts[3];

                    Transaction transaction = new Transaction(transactionAmount, transactionType, transactionDate, transactionLocation);
                    lastAccount.addTransaction(transaction); 
                }
            }

            return lastAccount; 
        }

        public static bool SaveAccount(Account aAccount)
        {
            // FileName         AccountId.dat
            // HeaderLine       AccountId_CustomerName
            // DataLines        TransactionType_TransactionAmount_TransactionDate_Location
            using (StreamWriter sw =
                File.CreateText(_mainStorageDir + "\\" + aAccount.AccountNumber + ".dat"))
            {
                string headerLine = aAccount.AccountNumber + "_" + aAccount.CustomerName;
                Console.WriteLine(headerLine); 
                sw.WriteLine(headerLine); 

                foreach (Transaction aTransaction in aAccount.TransactionList)
                {
                    string transactionLine = aTransaction.TransactionTypeString + '_' + aTransaction.MoneyAmount + '_' + 
                        aTransaction.TransactionDate.ToString(_dateStringFormat) + '_' + aTransaction.Location;
                    sw.WriteLine(transactionLine); 
                }
            }

            // FileName         CustomerName.dat
            // HeaderLine       CustomerName_birthdate_phone
            // DataLines        AddressLine1\nAddressline2\nAdressLine3 ...
            FileInfo fileInfoObject = new FileInfo(_customerStorageDir + '\\' + aAccount.CustomerName + ".dat");
            using (StreamWriter sw = fileInfoObject.CreateText())
            {
                sw.WriteLine(aAccount.CustomerName + '_' + aAccount.CustomerBirthDate.ToString(_dateStringFormat) + '_' + aAccount.CustomerPhone);

                string[] addressLines = aAccount.CustomerAddress.Split(new char[] { '\r', '\n' }); 
                foreach (string addressLine in addressLines)
                {
                    sw.WriteLine(addressLine); 
                }
            }

                return false; 
        }
        #endregion
    }
}
