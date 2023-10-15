using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1st test customer
            Customer test = new Customer("Kovács István", 60, "Budapest", "kovacs.istvan@levelezo.hu", "06-1-123-4567");
            BankAccount kIstvanAccount = new BankAccount(test.customerName, 50000, "12345678-00000000-12345678", "Personal",DateTime.Now, true);

            //Printing test customer's info
            test.PrintCustomerInfo();
            //Updating test customer' info
            test.UpdateCustomerInfo("Kovács István", 61, "Dunakeszi", "kovacs.istvan@levelezo.hu", "06-27-123-4567");
            //Ordering a product
            test.PlaceOrder("Life Insurance",1);
            //Placing request
            test.RequestSupport("I can't access online banking. I need technical support. Thanks.");
            //Sending feedback
            test.SendFeedback("All good.");
            //Printing test customer's account info
            kIstvanAccount.PrintAccountInfo();

            //2nd test customer:
            Customer test2 = new Customer("Kovács Istvánné", 55, "Dunakeszi", "kovacs.istvanne@levelezo.hu", "06-27-123-4567");
            BankAccount kIstvanneAccount = new BankAccount(test2.customerName, 120000, "12345678-12345678-12345678", "Personal", DateTime.Now, true);
            //Printing 2nd customer's info
            test2.PrintCustomerInfo();
            //Printing 2nd customer's account info
            kIstvanneAccount.PrintAccountInfo();
            //Transfering fund from test2 to test customer
            kIstvanneAccount.TransferFundsTo(kIstvanAccount, 20000);
            //Checking if the funds arrived to test customer
            kIstvanAccount.PrintAccountInfo();
            //Updating test2's account type
            kIstvanneAccount.UpdateAccountType("Private");
            //Printing test2's account info to check if the account type has been updated
            kIstvanneAccount.PrintAccountInfo();
            //Closing test's account
            kIstvanAccount.CloseAccount();
            //Printing test's account info to check if the account has benn closed
            kIstvanAccount.PrintAccountInfo();
            Console.ReadLine();

        }
    }
}
