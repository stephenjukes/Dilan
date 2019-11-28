using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Atm2
{
    class Card
    {
        private decimal _balance = 0m;
        private int _pin;

        public Card(int pin)
        {
            _pin = pin;
        }

        public bool ValidatePin(int pin)
        {
            return pin == _pin;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(int amount)
        {
            _balance -= amount;
        }
    }
}
