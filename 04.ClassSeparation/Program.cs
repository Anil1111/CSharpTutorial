using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ClassSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            string name = "myAccount";
            double balance = 10.00;
            int pin = 1234;
            int cvc = 456;
            int pages = 12;
            string format = "pdf";

            List<Transaction> transactions = new List<Transaction>();
            for (int i = 0; i < 10; i++)
            {
                double amount = Math.Round(10.00 * (new Random().NextDouble()), 2);
                DateTime timestamp = DateTime.Now;
                transactions.Add(new Transaction(amount, timestamp));

            }

            DebitCard debitCard = new DebitCard(pin, cvc);
            Statement statement = new Statement(pages, format);

            accounts.Add(new Account(name, balance, debitCard, statement, transactions));

            string documentFormat = "pdf";

            if (documentFormat == "pdf")
            {
                accounts
                    .Where(c => c.Statement.Format == "pdf")
                    .Select(c => c.Balance)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
            else if (documentFormat == "txt")
            {
                accounts
                    .Where(c => c.Statement.Format == "txt")
                    .Select(c => c.Name)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }

        }
        private static void ToList()
        {
            throw new NotImplementedException();
        }

        private static void Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}

  
  