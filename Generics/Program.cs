using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new List<int> { 1, 2, 3, 4, 5 };
            var strings = new List<string> { "The", "quick", "brown", "fox" };

            //GenericPrintElements(ints, strings);
            //GenericPop(strings);
            //GenericPair();
            GenericEqualAndAbove(ints);     // EXERCISE 2.2, 2.4: 

            // CONSTRAINT TYPES
            //Where T : class               Type must be reference type.
            //where T: struct               Type must be value type.
            //where T: new()                Type must have public parameterless constructor.
            //where T: <base class name>	Type must be or derive from the specified base class
            //where T: <interface name>	    Type must be or implement the specified interface.
            //where T: U                    Type supplied for T must be or derive from the argument supplied for U.

            // EXERCISE 2.5 (more related to actions than args at a beginning level)
        }

        private static void GenericEqualAndAbove(List<int> ints)
        {
            var equalAndAbove2 = ints.GetNumberEqualOrAbove(2);
            Console.WriteLine($"Equal and above 2: {equalAndAbove2}\n");

            Console.WriteLine("CompareTo:");
            Console.WriteLine($"1.CompareTo(2): {1.CompareTo(2)}");
            Console.WriteLine($"2.CompareTo(1): {2.CompareTo(1)}");
            Console.WriteLine($"1.CompareTo(1): {1.CompareTo(1)}\n");
        }

        private static void GenericPair()
        {
            var stephensAge = new Pair<string, int>("Stephen", 41);
            var todayTemp = new Pair<string, double>("2019-10-23", 20.5);
            var grades = new Pair<string, int>[5];
            grades[0] = new Pair<string, int>("Stephen", 60);
            grades[1] = new Pair<string, int>("Dilan", 70);
            grades[2] = new Pair<string, int>("Mike", 80);
            var appointment = new Pair<Pair<int, int>, string>(new Pair<int, int>(5, 30), "Dentist");

            Console.WriteLine($"Stephen's age: {stephensAge}");
            Console.WriteLine($"Today's temp: {todayTemp}");

            Console.WriteLine("\nGrades:");
            PrintRange(grades);    
            
            Console.WriteLine($"\nAppointment: {appointment}");
            Console.WriteLine($"Stephen's age swap: {stephensAge.Swap()}\n");
        }

        private static void GenericPop<T>(List<T> collection)
        {
            PrintRange(collection);

            Console.WriteLine($"\nPopped: {collection.Pop()}\n");

            PrintRange(collection);
        }

        private static void GenericPrintElements(IEnumerable<int> ints, IEnumerable<string> strings)
        {
            Console.WriteLine("Integers");
            PrintRange(ints);

            Console.WriteLine("Strings");
            PrintRange(strings);
        }

        private static void PrintRange<Type>(IEnumerable<Type> collection)
        {
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }

        private static void Perform<Type>(Action<Type> action, params Type[] array)
        {
            foreach (var element in array)
            {
                action(element);
            }
        }

        


            

    }
}
