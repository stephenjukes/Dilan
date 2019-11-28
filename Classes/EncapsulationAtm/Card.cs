using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.EncapsulationAtm
{
    class Card
    {
        private bool isPinMatch = false;
        private int _pin;
        private Decimal _balance;


        public Card(int pin)
        {
            _pin = pin;
        }

        public bool IsPinMatch(int pin)
        {
            if (pin == _pin) isPinMatch = true;
            return isPinMatch;
        }

        public string GetBalance()
        {
            if (!isPinMatch)
                return "Pin doesn't match";

            return $"Your balance is: {_balance.ToString()}";
        }

        public string Withdraw(int withdrawal)
        {
            if (!isPinMatch)
                return "Pin doesn't match";

            if (withdrawal > _balance)
                return $"Tried to withdraw {withdrawal}. Insufficient funds";

            if (withdrawal % 5 != 0)
                return $"Tried to withdraw {withdrawal}. Withdrawal must be a multiple of 5";

            _balance -= withdrawal;
            return $"{withdrawal} withdrawn. New balance: {_balance}";
        }

        public string Deposit( int value)
        {
            if (value % 5 != 0)
                return $"Tried to deposit {value}. Deposit must be a multiple of 5";

            _balance += value;
            return $"{value} deposited. New balance: {_balance}";
        }
    }
}
