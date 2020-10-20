using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BaseConstructors
{
    public class Account
    {
        private string name;
        private double balance;
        private DebitCard debitCard;
        private bool isPaperless;
        private DateTime dateOpened;


        public Account(string name, double balance, DebitCard debitCard)
        {
            this.Name = name;
            this.Balance = balance;
            this.DebitCard = debitCard;
        }


        public Account(string name, double balance, DebitCard debitCard, bool isPaperless) : this(name, balance, debitCard)
        {
            this.IsPaperless = isPaperless;
        }

        public Account(string name, double balance, DebitCard debitCard, DateTime dateOpened) : this(name, balance, debitCard)
        {
            this.DateOpened = dateOpened;
        }

        public Account(string name, double balance, DebitCard debitCard, bool isPaperless, DateTime dateOpened) : this(name, balance, debitCard)
        {
            this.IsPaperless = isPaperless;
            this.DateOpened = dateOpened;
        }

        public DateTime DateOpened
        {
            get { return dateOpened; }
            private set { dateOpened = value; }
        }

        public bool IsPaperless
        {
            get { return isPaperless; }
            private set { isPaperless = value; }
        }


        public DebitCard DebitCard
        {
            get { return debitCard; }
            private set { debitCard = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

      

    }

}
   