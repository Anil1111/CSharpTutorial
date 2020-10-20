using System;

namespace _19.InterfaceArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransferable[] transferableAccounts = { new AutoAccount(), new CheckingAccount() };

            foreach(ITransferable account in transferableAccounts)
            {
                account.Transfer();
            }
        }
    }
}
