using System;
using System.Collections.Generic;
using System.Text;

namespace _13.HierarchicalInheritance
{
    public class CheckingAccount: Account
    {
        public void Withdraw()
        {
            Console.WriteLine("Withdrawing Money...");
        }
    }
}
