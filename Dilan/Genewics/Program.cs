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
            var grades = new Pair<String, int>[5];
            
            grades[0] = new Pair<string, int>("Jonathan", 5);
            grades[1] = new Pair<string, int>("Test", 2);
            grades[2] = new Pair<string, int>("Langley", 100);

       

            Generics.WriteElements<Pair<String, int>>(grades);

            /*var newPair = new Pair<string, char>("test", 't');
            Console.WriteLine(newPair);*/
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