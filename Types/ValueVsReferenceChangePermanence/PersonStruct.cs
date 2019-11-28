using System;
using System.Collections.Generic;
using System.Text;

namespace StructsAndClasses
{
    public struct PersonStruct : IPerson
    {
        public string Name { get; }
        public int Reputation { get; set; }

        public PersonStruct(string name, int reputation)
        {
            Name = name;
            Reputation = reputation;
        }
    }
}
