﻿using System;

namespace _10.EncapsulateLogic
{
    public class AccountGood
    {
        private double minimumBalance = 100.00;
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
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Account name cannot be empty!");
                }
                this.name = value;
            }

        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if(value < minimumBalance)
                {
                    throw new Exception($"Account balance should have a minimum of {minimumBalance}!");
                }

                this.balance = value;
            }
        }

        public string AccountLevel
        {
            get
            {
                return this.DisplayAccountLevel();
            }
        }

        private string DisplayAccountLevel()
        {
            if(this.Balance < 300.00)
            {
                return "Silver";
            }
            else if(this.Balance < 500.00)
            {
                return "Gold";
            }
            else
            {
                return "Platinum";
            }
        }


    }
}
