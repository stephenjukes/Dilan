using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.EncapsulationAtm
{
    class Session
    {
        private Card _card;
        private int _pin;

        public Session(Card card, int pin)
        {
            _card = card;
            _pin = pin;
            CheckCard();
        }

        private void CheckCard()
        {
            var pinMatch = _card.IsPinMatch(_pin);         
        }

        public void GetBalance()
        {
            var balance = _card.GetBalance();
            Console.WriteLine(balance); 
        }

        public void Withdraw(int value)
        {
            var withdrawal = _card.Withdraw(value);
            Console.WriteLine(withdrawal);
        }

        public void Deposit(int value)
        {
            var deposit = _card.Deposit(value);
            Console.WriteLine(deposit);
        }
    }
}
