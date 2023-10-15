using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    internal class Customer
    {
        public string customerName {  get; set; }
        public int customerAge { get; set; }
        public string customerAddress {  get; set; }
        public string customerEmail { get; set; }
        public string customerPhoneNumber { get; set; }

        public Customer(string customerName, int customerAge, string customerAddress, string customerEmail, string customerPhoneNumber)
        {
            this.customerName = customerName;
            this.customerAge = customerAge;
            this.customerAddress = customerAddress;
            this.customerEmail = customerEmail;
            this.customerPhoneNumber = customerPhoneNumber;
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine($"Customer's Name: {customerName}\n" + 
                $" Age: {customerAge}\n" +  
                $" Address: {customerAddress} \n" + 
                $" Email: {customerEmail}\n" + 
                $" Phone number: {customerPhoneNumber} \n");
        }

        public void UpdateCustomerInfo(string newName, int newAge, string newAddress, string newEmail, string newPhoneNumber)
        {
            customerName = newName;
            customerAge = newAge;
            customerAddress = newAddress;
            customerEmail = newEmail;
            customerPhoneNumber = newPhoneNumber;
            Console.WriteLine($"Customer's Info has been updated.\n" + 
                $" Name: {newName}\n" +
                $" Age: {newAge}\n" +
                $" Address: {newAddress} \n" +
                $" Email: {newEmail}\n" +
                $" Phone number: {newPhoneNumber} \n");
        }

        public void PlaceOrder(string product, int quantity)
        {
            string orderedProduct = product;
            int orderQuantity = quantity;
            Console.WriteLine($"The order has been placed: {orderedProduct}, quantity: {orderQuantity}\n");
        }

        public void RequestSupport(string supportRequest)
        {
            string request = supportRequest;
            Console.WriteLine($"Your request has been placed: {request}\n");
        }
        public void SendFeedback(string feedback)
        {
            string customerFeedback = feedback;
            Console.WriteLine($"Your feeedback has been sent: {customerFeedback}\n");
        }
    }
}
