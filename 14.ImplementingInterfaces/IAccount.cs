using System;
using System.Collections.Generic;
using System.Text;

namespace _14.ImplementingInterfaces
{
    public interface IAccount
    {
        double Balance { get; }
        void Display();
    }
}
