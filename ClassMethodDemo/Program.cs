using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer() { id = 1, firstName = "Mehmet", lastName = "Oguz", balance = 9400.00, };
            customerManager.Add(customer1);
            Customer customer2 = new Customer() { id = 2, firstName = "Joe", lastName = "Spare", balance = 2500.00, };
            customerManager.Add(customer2);
            Customer customer3 = new Customer() { id = 3, firstName = "Kate", lastName = "Hill", balance = 3400.00, };
            customerManager.Add(customer3);
            Customer customer4 = new Customer() { id = 4, firstName = "Nicole", lastName = "Kean", balance = 41000.00, };
            customerManager.Add(customer4);




            customerManager.List();
            customerManager.Delete(customer2);
            customerManager.List();
        }
    }
}
