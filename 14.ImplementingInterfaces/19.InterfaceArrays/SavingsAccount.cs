using System;
using System.Collections.Generic;
using System.Text;

namespace _19.InterfaceArrays
{
    public class SavingsAccount : Account, IAccount
    {
        public void Display()
        {
            Console.WriteLine("Displaying Savings Account Info...");
        }
    }
}

