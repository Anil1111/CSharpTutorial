using System;
using System.Collections.Generic;
using System.Text;

namespace _06.Override
{
    public class Account
    {
        private string name;
        private double balance;
        private List<Account> checkingAccounts;
        private List<Account> savingAccounts;

        public Account()
        {
            this.checkingAccounts = new List<Account>();
            this.savingAccounts = new List<Account>();
        }

        public Account(string name, double balance)
        {
            this.Name = name;
            this.Balance = balance;
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

        private List<Account> CheckingAccounts
        {
            get { return checkingAccounts; }
            set { checkingAccounts = value; }
        }

        private List<Account> SavingAccounts
        {
            get { return savingAccounts; }
            set { savingAccounts = value; }
        }

        public void AddCheckingAccount(Account account)
        {
            this.checkingAccounts.Add(account);
        }

        public void AddSavingAccount(Account account)
        {
            this.savingAccounts.Add(account);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{Name} {Balance}");

            builder.AppendLine("Checking Accounts:");

            foreach (var checkingAccount in checkingAccounts)
            {
                builder.AppendLine($"{checkingAccount.name} {checkingAccount.balance}");
            }

            builder.AppendLine("Saving Accounts:");

            foreach (var savingAccount in savingAccounts)
            {
                builder.AppendLine($"{savingAccount.name} {savingAccount.balance}");
            }

            return builder.ToString();




        }

    }
}

