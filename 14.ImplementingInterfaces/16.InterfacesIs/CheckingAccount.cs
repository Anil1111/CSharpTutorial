using System;
using System.Collections.Generic;
using System.Text;

namespace _16.InterfacesIs
{
    public class CheckingAccount : Account, IAccount
    {
        public void Display()
        {
            Console.WriteLine("Displaying Checking Account Info...");
        }
    }
}
