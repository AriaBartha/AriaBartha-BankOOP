using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    internal class BankAccount
    {
        public string ownerName { get; set; }
        public decimal balance { get; set; }
        public string accountNumber { get; set; }
        public string accountType { get; set; }
        public DateTime accountOpeningDate { get; set; }
        public bool isAccountActive { get; set; }

        public BankAccount(string ownerName, decimal balance, string accountNumber, string accountType, DateTime accountOpeningDate, bool isAccountActive)
        {
            this.ownerName = ownerName;
            this.balance = balance;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.accountOpeningDate = accountOpeningDate;
            this.isAccountActive = true;
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine($"Account infos:\n" +
                $" Owner Name: {ownerName}\n" +
                $" Balance: {balance}\n" +
                $" Account Number: {accountNumber}\n" +
                $" Type: {accountType}\n" +
                $" Opening Date: {accountOpeningDate}\n" +
                $" Account active: {isAccountActive}\n");
        }

        public void CloseAccount()
        {
            this.isAccountActive = false;
            Console.WriteLine("The account has been closed.\n");
        }

        public void TransferFundsTo(BankAccount destinationAccount, decimal amount)
        {
                balance -= amount;
                destinationAccount.balance += amount;
                Console.WriteLine($"The transfer was succesfull. Your new balance: {balance} \n");

        }

        public void UpdateAccountType(string newAccountType)
        {
            accountType = newAccountType;
            Console.WriteLine($"Account type has been updated to {newAccountType}.\n");
        }



    }
}
