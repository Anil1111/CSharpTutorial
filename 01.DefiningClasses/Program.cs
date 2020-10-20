using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.Name = "A1";
            account1.Balance = 10.00;

        }

        Account account2 = new Account
        {
            Name = "A2",
            Balance = 20.00
        };

        Account account3 = new Account
        {
            Name = "A3",
            Balance = 30.00
        };
    }
}
