using System;
using System.Collections.Generic;
using System.Text;

namespace StructsAndClasses
{
    public class PersonClass : IPerson
    {
        public int Reputation { get; set; }

        public PersonClass(int reputation)
        {
            Reputation = Reputation;
        }
    }
}
