using System;
namespace _04.ClassSeparation
{
    public class Transaction
    {

        private double amount;
        private DateTime timestamp;

        public Transaction(double amount, DateTime timestamp)
        {
            this.Amount = amount;
            this.Timestamp = timestamp;
        }

        public double Amount
        {
            get { return amount; }
            private set { amount = value; }
        }

        public DateTime Timestamp
        {
            get { return timestamp; }
            private set { timestamp = value; }

        }
        
     }
}