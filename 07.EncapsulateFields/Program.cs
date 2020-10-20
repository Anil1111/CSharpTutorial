using System;

namespace _07.EncapsulateFields
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBad accountBad = new AccountBad("A1", 10.00);
            accountBad.balance = 20.00;

            AccountGood accountGood = new AccountGood("A1", 10.00);
            // accountGood.balance not available to clients directly;
        }
    }
}
