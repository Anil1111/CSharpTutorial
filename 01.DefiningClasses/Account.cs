using System;
using System.Collections.Generic;
using System.Text;

namespace _01.DefiningClasses
{
    public class Account
    {
        // Fields
        private string name;
        private double balance;

        // construtor
        public Account()
        {
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Balance
        {
            get { return this.balance;  }
            set { this.balance = value; }
        }

    }
}
