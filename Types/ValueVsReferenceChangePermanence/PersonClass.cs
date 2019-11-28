using System;
using System.Collections.Generic;
using System.Text;

namespace StructsAndClasses
{
    public class PersonClass : IPerson
    {
        public string Name { get; }
        public int Reputation { get; set; }

        public PersonClass(string name, int reputation)
        {
            Name = name;
            Reputation = reputation;
        }
    }
}
