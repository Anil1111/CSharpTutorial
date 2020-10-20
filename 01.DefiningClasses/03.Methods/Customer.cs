using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Methods
{
    public class Customer
    {
        private List<Account> accounts;

        public Customer()
        {
            this.accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public Account GetLargestAccount()
        {
            return this.accounts
                .OrderByDescending(p => p.Balance)
                .First();
        }
    }
}
