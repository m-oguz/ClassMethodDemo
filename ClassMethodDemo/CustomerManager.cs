using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager : ICustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine(customer.firstName + " " + customer.lastName + " added to the database with a balance of " + customer.balance);
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Customer  " + customer.firstName + " " + customer.lastName + " removed successfully.");
        }

        public void List()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Listing Customers");

            foreach (var customer in customers)
            {
                Console.WriteLine("ID: " + customer.id + "\t" + customer.firstName + "\t " + customer.lastName + "\t " + customer.balance);
            }

            Console.WriteLine("-----------------------------------------------------");
        }

    }
}
