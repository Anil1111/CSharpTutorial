using System;
using System.Collections.Generic;
using System.Text;

namespace _07.EncapsulateFields
{
    public class AccountGood
    {
        private const double minimumBalance = 100.00;
        private string name;
        private double balance;

        public AccountGood(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
    }
    
}