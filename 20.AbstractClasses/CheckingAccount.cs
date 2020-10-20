using System;
using System.Collections.Generic;
using System.Text;

namespace _20.AbstractClasses
{
    public class CheckingAccount : Account
    {
        public override void Display()
        {
            Console.WriteLine("Checking Account Info...");
        }

        public override void Withdraw(double amount)
        {
        Console.WriteLine($"Checking Account Wkthdrawal for { amount }...");
        }
    }
}
