using System;
using System.Collections.Generic;
using System.Text;

namespace StructsAndClasses
{
    public struct PersonStruct : IPerson
    {
        public int Reputation { get; set; }

        public PersonStruct(int reputation)
        {
            Reputation = reputation;
        }
    }
}
