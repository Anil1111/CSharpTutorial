using System;
using System.Collections.Generic;
using System.Text;

namespace _19.InterfaceArrays
{
    public class AutoAccount : Account, ITransferable
    {
        public void Transfer()
        {
            Console.WriteLine("Auto Transfer Completed...");
        }
    }
}
