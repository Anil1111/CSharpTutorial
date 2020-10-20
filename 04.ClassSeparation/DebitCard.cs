using System;
using System.Collections.Generic;
using System.Text;

namespace _04.ClassSeparation
{
    public class DebitCard
    {
        private int pin;
        private int cvc;

        public DebitCard(int pin, int cvc)
        {
            this.Pin = pin;
            this.Cvc = cvc;
        }

        public int Pin
        {
            get { return pin; }
            private set { pin = value; }
        }

        public int Cvc
        {
            get { return cvc; }
            private set { cvc = value; }
        }
    }
}
