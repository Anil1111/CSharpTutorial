using System;

namespace _03.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.AddAccount(new Account() { Name = "A1", Balance = 10.00 });
            customer.AddAccount(new Account() { Name = "A2", Balance = 20.00 });
            customer.AddAccount(new Account() { Name = "A3", Balance = 30.00 });

            Account largestAccount = customer.GetLargestAccount();
            Console.WriteLine($"{largestAccount.Name} has a balance of {largestAccount.Balance}");
        }
    }
}
