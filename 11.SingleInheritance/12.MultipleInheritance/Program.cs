using System;

namespace _12.MultipleInheritance
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


            FlexibleSavingsAccount flexibleSavingsAccount = new FlexibleSavingsAccount();
            flexibleSavingsAccount.GetBalance();
            flexibleSavingsAccount.GetInterestEarned();
            flexibleSavingsAccount.PayHealthCareCosts();
        }
    }
}
