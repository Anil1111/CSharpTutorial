using System;

namespace _09.Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AccountGood account1 = new AccountGood("A1", 200.00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AccountGood account2 = new AccountGood("", 200.00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AccountGood account3 = new AccountGood(null, 200.00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                AccountGood account4 = new AccountGood("A1", 90.00);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
