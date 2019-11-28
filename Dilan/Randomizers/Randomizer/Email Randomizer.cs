using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Randomizers
{
    class Email_Randomizer : IRandomizer
    {
        public void GetRandomEntity()
            => Console.WriteLine($"{Guid.NewGuid()}@{Guid.NewGuid()}.com");
    }
}
