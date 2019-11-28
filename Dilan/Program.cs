using System;
using System.Linq;
using Types;
using System.Collections.Generic;
using Dilan.Animals;
using Dilan.Randomizers;
using System.Threading;

namespace Dilan
{
    class Program
    {  
        public static void Main()
        {
            GenericMethod();
        } 
        
        private static void Print(string line)
        {
            foreach(var letter in line)
            {
                Console.Write(letter);
                Thread.Sleep(50);
            }

            Console.WriteLine();
        }
    }
}