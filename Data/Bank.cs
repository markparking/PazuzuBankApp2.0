using System;
using System.Collections.Generic;

namespace PazuzuBankApp.Data
{
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();

        public Bank()
        {
            customers.Add(new Customer("John Smith", "john@smith.com","hej", "1", 1000));
            customers.Add(new Customer("Mary Johnson", "mary@johnson.com", "hej", "2", 1000));
            customers.Add(new Customer("Peter Parker", "peter@parker.com", "hej", "3", 1000));
            customers.Add(new Customer("Tony Stark", "tony@stark.com", "hej", "4", 1000));
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public Customer GetCustomerByUsernameAndPassword(string username, string password)
        {
            return customers.FirstOrDefault(c => c.Name == username && c.Password == password);
        }

    }
}
