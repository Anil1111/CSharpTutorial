using System;

namespace _10.EncapsulateLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AccountGood account1 = new AccountGood("A1", 200.00);
                Console.WriteLine(account1.AccountLevel);

                AccountGood account2 = new AccountGood("A2", 400.00);
                Console.WriteLine(account2.AccountLevel);

                AccountGood account3 = new AccountGood("A3", 600.00);
                Console.WriteLine(account3.AccountLevel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
}
