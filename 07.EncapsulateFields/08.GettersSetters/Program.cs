using System;

namespace _08.GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountGood account = new AccountGood("A1", 10.00);
            Console.WriteLine($"{account.Name} - {account.Balance}");

            account.Name = "A1 Modified";
            account.Balance = 20.00;
            Console.WriteLine($"{account.Name} - {account.Balance}");
        }
    }
}
