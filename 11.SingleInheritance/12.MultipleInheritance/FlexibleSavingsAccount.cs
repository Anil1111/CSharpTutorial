using System;
using System.Collections.Generic;
using System.Text;

namespace _12.MultipleInheritance
{
    public class FlexibleSavingsAccount : SavingsAccount
    {
        public void PayHealthCareCosts()
        {
            Console.WriteLine("Paying Health Care Costs...");
        }
    }
}
