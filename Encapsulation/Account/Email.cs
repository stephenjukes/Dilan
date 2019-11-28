using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Account
{
    class Email
    {
        public string _message { get; }

        public Email(string message)
        {
            _message = message;
        }
    }
}
