using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Animals
{
    public static class AnimalProgram
    {
        public static void MainMethod()
        {
            
            var piggy = new Pig();
            var donkey = new Donkey();

            var isAnimal = piggy is Animal;
            var isObject = donkey is Object;

            piggy.Sing();
            donkey.Sing();

            var choir = new Animal[] { piggy, donkey};

            foreach (var animal in choir)
            {
                animal.Sing();
            }

            var jerry = new Person(piggy);

            var jenny = new Person(donkey);
            
            Console.WriteLine("");



        }
    }
}
