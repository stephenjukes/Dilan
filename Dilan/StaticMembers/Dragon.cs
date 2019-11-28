using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    class Dragon
    {
        public static string animal = "Dragon";
        public float weight = 20.54f;
        public string breath = "red";
        public float breathHeat = 235f;
        public string horns;
        public bool isClean = false;
        public string name;

        public void Angry(float heatIncrease) => breathHeat += heatIncrease;
        public void Feed(float foodAmount) => weight += foodAmount;

        public static void Wash(Dragon dragon)
        {
            Console.WriteLine($"lets clean {dragon.name}, you dirty boy");
            dragon.isClean = true;

            Console.WriteLine($"{dragon.name} is now clean: {dragon.isClean}");
        }

    }
}
