using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Atm2
{
    class Atm
    {
        private Card _card;
        private bool _isPinMatch;

        public void InsertCard(Card card)
        {
          _card = card;
        }

        public void InputPin(int pinInput)
        { 
            _isPinMatch = _card.ValidatePin(pinInput);
        }

        public void CheckBalance()
        {
            if (_isPinMatch)
                Console.WriteLine($"Balance: {_card.GetBalance()}");
            else
                Console.WriteLine(PinMismatch("balance check"));
        }

        //public void Withdraw(int amount)
        //{
        //    if (!_isPinMatch)
        //        Console.WriteLine(PinMismatch("withdrawal"));
        //    else if (amount > )
        //}

        private string PinMismatch(string action)
        {
            return $"Pin mismatch. Cannot complete {action}.";
        }
    }
}
