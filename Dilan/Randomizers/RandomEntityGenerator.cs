using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Randomizers
{
    public class RandomEntityGenerator
    {
        private IRandomizer _randomizer;

        public RandomEntityGenerator(IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }

        public void GetMyRandomEntity()
        {
            _randomizer.GetRandomEntity();
        }
    }
}

