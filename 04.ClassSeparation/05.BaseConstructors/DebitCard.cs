using System;
namespace _05.BaseConstructors
{
    public class DebitCard
    {
        private int? pin;
        private int cvc;
        private string cardName;
        private string cardNumber;


        public DebitCard(string cardName, string cardNumber)
        {
            this.CardName = cardName;
            this.CardNumber = cardNumber;

        }


        public DebitCard(string cardName, string cardNumber, int cvc) : this(cardName, cardNumber)
        {
            this.Cvc = cvc;

        }

        public DebitCard(string cardName, string cardNumber, int? pin) : this(cardName, cardNumber)
        {
            this.Pin = pin;

        }

        public DebitCard(string cardName, string cardNumber, int cvc, int? pin) : this(cardName, cardNumber)           

        {
            this.Cvc = cvc;
            this.Pin = pin;

        }

        public string CardNumber
        {
            get { return cardNumber; }
            private set { cardNumber = value; }
        }

        public string CardName
        {
            get { return cardName; }
            private set { cardName = value; }
        }


        public int Cvc
        {
            get { return cvc; }
            private set { cvc = value; }
        }

        public int? Pin
        {
            get { return pin; }
            private set { pin = value; }
        }
    }
}
