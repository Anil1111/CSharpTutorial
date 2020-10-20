using System;

namespace _05.BaseConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            DebitCard card1 = new DebitCard("Bob Smith", "0000 1111 2222 3333"); //cardName, cardNumber
            DebitCard card2 = new DebitCard("Jane Doe", "0000 1111 2222 3333", 123); // cvc
            DebitCard card3 = new DebitCard("Mark Jones", "0000 1111 2222 3333", 1234); //pin
            DebitCard card4 = new DebitCard("Alice Brown", "0000 1111 2222 3333", 1234, 123 ); // allow all

            Account account1 = new Account("Bob Smith", 10.00, card1);
            Account account2 = new Account("Jane Doe", 20.00, card2, true);
            Account account3 = new Account("Mark Jones", 30.00, card3, DateTime.Now);
            Account account4 = new Account("Alice Brown", 40.00, card4, true, new DateTime(2020, 1, 1));

        }
    }
}
