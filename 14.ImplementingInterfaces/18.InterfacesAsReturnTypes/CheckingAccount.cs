using System;
using System.Collections.Generic;
using System.Text;

namespace _18.InterfacesAsReturnTypes
{
    public class CheckingAccount : Account, IAccount, ITransferable
    {
        public void Display()
        {
            Console.WriteLine("Displaying Checking Account Info...");
        }

        public void Transfer()
        {
            Console.WriteLine("Checking Transfer Completed...");
        }
    }
}
