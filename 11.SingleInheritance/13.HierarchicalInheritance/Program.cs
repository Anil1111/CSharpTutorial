using System;

namespace _13.HierarchicalInheritance
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


            CheckingAccount checkingAccount = new CheckingAccount();
            checkingAccount.GetBalance();
            checkingAccount.Withdraw();
        }
    }
}
