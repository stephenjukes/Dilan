using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    public abstract class Carnivore1

    {

        protected string Colour { get; set; }

        private int age;

        public int Age
        {
            get { return age; }

            set { if (age < 30) age = value;  }
        }

        public abstract string Species { get; set; }

        public virtual string Name { get; set; }

        public virtual int NoOfTeeth { get; set; }

        public virtual float SuccessfulHunts { get; set; }

        public readonly string[] Prey = new string[] { "Giraffe", "Zebra", "Boar", "Cow", "Chicken", "Gazelle", "Salmon" };

        public State State { get; set; }


        public virtual string Hunt()
        {

            Random successVariable = new Random();

            if (successVariable.Next(1,6) <= 3)
            {
                SuccessfulHunts++;
                State = State.Excited;
                return $"The {Name} Animal has successfully Hunted a yet again";
            }

            else
            {
                State = State.Unhappy;
                return $"The {Name} has not been successful this time around.";
            }   
        }


        public virtual float Reset()
        {
           return SuccessfulHunts = 0;
        }

        

        public virtual string Eat()
        {
            if (SuccessfulHunts != 0)
            {
                State = State.Satisfied;
                return $"{Name} is Eating and is {State}";
            }
            else
            {
                State = State.Hungry;
                return $"{Name} hasn't eaten and is {State}";
            }
        }
    }

    public enum State
    {
        Excited,
        Unhappy,
        Satisfied,
        Hungry
    }
}
