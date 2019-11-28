using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    class Audi
    {
        private static string metalUsed = "Aluminum";
        public static string company = "Audi";
        public string engine;
        public string colour = "Blue";
        public float engineTemp_Celsius = 22;
        public DateTime manufactureDate = DateTime.Now;
        public float CarWeight;
        public static int carCount = 0;

        public static string test = "test";

        public Audi()
        {
            carCount++;
        }

        public Audi(string _colour, string _engine, DateTime _manufactureDate)
        {
            colour = _colour;
            engine = _engine;
            manufactureDate = _manufactureDate;
            carCount++;
        }


        public string carInfo
        {
            get
            {
                return $"This Cars Engine is a {engine}, and the colour is {colour}, and the Manufacturer is {company}";
            }
        }


        public static Audi CreateCar() => new Audi("Green", "Audi 2000 Engine Version 3", DateTime.Now);

        public static Audi CreateCar(string engine, string colour) => new Audi("Green", "Audi 2000 Engine Version 3", DateTime.Now);

        public void TurnEngineOn(){engineTemp_Celsius = 95; manufactureDate = DateTime.Now; Console.WriteLine("The Car is now on");}

    }
}
