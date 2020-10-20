using System;
using System.Collections.Generic;
using System.Text;

namespace _20.AbstractClasses
{
    public class SavingsAccount : Account
    {
        public override void Display()
        {
            Console.WriteLine("Savings Account Info...");
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine($"Savings Account Wkthdrawal for { amount }...");
        }

        public override void Deposit(double amount)
        {
            amount *= 1.02;
            Console.WriteLine($"Depositing {amount} into Savings Account After Interest...");
        }
    }
}


