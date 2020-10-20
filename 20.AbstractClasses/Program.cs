using System;

namespace _20.AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Account account = new Account(); - Not allowed, as Account is abstract
            CheckingAccount checkingAccount = new CheckingAccount();
            checkingAccount.Display();
            checkingAccount.Withdraw(10.00);
            checkingAccount.Deposit(200000.00);

            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Display();
            savingsAccount.Withdraw(5.00);
            savingsAccount.Deposit(20.00);

        }
    }
}
