using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    public class Lion : Carnivore1
    {

        public string LionsName { get; set; }
        public string LionColour { get; set; }
        public override sealed string Species { get; set; } = "Lion";

        public Lion(string name, int age)
        {
            Species = "Lion";
            Name = name;
            NoOfTeeth = 32;
            Reset();
        }

        public string Speak()
        {
            return "Roar!!!";
        }

        public void ColourChange()
        {
            LionColour = Colour;
        }

        public void NameChange()
        {
            LionsName = Name;
        }
    }

    public class MaleLion : Lion
    {

        public MaleLion(string name, int age) : base(name, age)
        { }



    }

    public class Carnivore_Main
    {
        public static void MainMethod()

        {
            var Simba = new MaleLion("Simba", 10);
            var hunt1 = Simba.Hunt();
            var hunt2 = Simba.Hunt();
            var hunt3 = Simba.Hunt();
            var hunt4 = Simba.Hunt();

            Console.WriteLine( hunt1 );
            Console.WriteLine(hunt2);
            Console.WriteLine(hunt3);
            Console.WriteLine(hunt4);
            Console.WriteLine(Simba.SuccessfulHunts);

        }
    }


}
