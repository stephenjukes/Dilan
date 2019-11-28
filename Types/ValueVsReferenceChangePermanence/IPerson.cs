using System;
using System.Collections.Generic;
using System.Text;

namespace StructsAndClasses
{
    public interface IPerson
    {
        string Name { get; }
        int Reputation { get; set; }
    }
}
