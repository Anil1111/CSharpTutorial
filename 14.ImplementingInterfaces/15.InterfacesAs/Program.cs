using System;

namespace _15.InterfacesAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            IAccount account2 = account as IAccount;

            if (account2 != null)
            {
                account2.Display();
            }
            else
            {
                Console.WriteLine("Unable to display account info!");
            }
            CheckingAccount checkingAccount = new CheckingAccount();
            IAccount account3 = checkingAccount as IAccount;

            if (account3 != null)
            {
                account3.Display();
            }
            else
            {
                Console.WriteLine("Unable to display checking account info!");
            }
        }
    }
}
