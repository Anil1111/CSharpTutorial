using System;
namespace _14.ImplementingInterfaces
{
    public class Account : IAccount
    {
        public double Balance
        {
            get { return 100.00; }
        }

        public void Display()
        {
            Console.WriteLine("Displaying Account Info...");
            //throw new NotImplementedException();
        }
    }
}

