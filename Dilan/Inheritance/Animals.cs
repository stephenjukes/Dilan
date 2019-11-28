using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{

    public class Person
    {
        public Animal Pet { get; set; }

        public Person(Animal pet)
        {
            Pet = pet;
        }
    }

    public abstract class Animal
    {
        public virtual string Species { get; set; } = "an animal";

        public abstract string Sound { get; set; }

        public abstract void Sing();
      

    }
    
    public class Pig : Animal
    {
        public override string Species { get; set; } = "Pig";

        public override string Sound { get; set; } = "oink";

        public override void Sing()
        {
            Console.WriteLine("Oink");
        }
    }

    public class Donkey : Animal
    {
        public override string Species { get; set; } = "Donkey";

        public override string Sound { get; set; } = "eyore";

        public override void Sing()
        {
            Console.WriteLine("Eyore");
        }
    }
    
}


