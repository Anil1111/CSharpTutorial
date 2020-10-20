using System;

namespace _11.SingleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.GetBalance();

            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.GetBalance();
            savingsAccount.GetInterestEarned();

        }
    }
}
