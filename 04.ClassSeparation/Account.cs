using System;
using System.Collections.Generic;
using System.Text;

namespace _04.ClassSeparation
{
    public class Account
    {
        private string name;
        private double balance;
        private DebitCard debitCard;
        private Statement statement;
        private List<Transaction> transactions;

        public Account(
            string name,
            double balance,
            DebitCard debitCard,
            Statement statement,
            List<Transaction> transaction
        )
        {
            this.Name = name;
            this.Balance = balance;
            this.DebitCard = debitCard;
            this.Statement = statement;
            this.Transactions = transactions;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public DebitCard DebitCard
        {
            get { return debitCard; }
            private set { debitCard = value; }
        }

        public Statement Statement
        {
            get { return statement; }
            private set { statement = value; }
        }


        public List<Transaction> Transactions
        {
            get { return transactions; }
            private set { transactions = value; }
        }
    }
}
        
