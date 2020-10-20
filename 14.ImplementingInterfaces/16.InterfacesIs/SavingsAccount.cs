using System;
using System.Collections.Generic;
using System.Text;

namespace _16.InterfacesIs
{
    public class SavingsAccount : Account, IAccount
    {
        public void Display()
        {
            Console.WriteLine("Displaying Savings Account Info...");
        }
    }
}

