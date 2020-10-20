using System;

namespace _06.Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Account customerAccount = new Account();
            customerAccount.AddCheckingAccount(new Account("Bobs Checking 1", 20.00)); 
            customerAccount.AddCheckingAccount(new Account("Bobs Checking 2", 30.00));
            customerAccount.AddCheckingAccount(new Account("Bobs Saving 1", 20.00));
            customerAccount.AddCheckingAccount(new Account("Bobs Saving 2", 30.00));

            Console.WriteLine(customerAccount.ToString());
        }
    }
}
