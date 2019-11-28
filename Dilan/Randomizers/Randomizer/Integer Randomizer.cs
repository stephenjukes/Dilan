using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dilan.Randomizers
{
    class Integer_Randomizer : IRandomizer
    {
        public void GetRandomEntity()
        {
            Random randint = new Random();
            Console.WriteLine(randint.Next(1, 50));
        }
    }
}
