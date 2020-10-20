using System;
using System.Collections.Generic;
using System.Text;

namespace _08.GettersSetters
{
    public class AccountGood
    {
        //private double minimumBalance = 100.00;
        private string name;
        private double balance;

        public AccountGood(string name, double balance)
        {
             this.name = name;
             this.balance = balance;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


    }
}
