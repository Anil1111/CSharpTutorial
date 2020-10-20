using System;
namespace _20.AbstractClasses
{
    public abstract class Account
    {
        public abstract void Display();

        public abstract void Withdraw(double amount);

        public virtual void Deposit(double amount)
        {
            Console.WriteLine($"Depositing {amount} dollars into Account...");
        }
    }
}
