using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public static class Arrays
    {
        static void MainMethod(string[] args)
        {
            // Simple Array
            int[] simpleArray = new int[5];

            simpleArray[1] = 1;
            Display(simpleArray, "simpleArray");

            // MultiDimensional Array
            int[,] multiDimensionalArray = new int[2, 5];

            multiDimensionalArray[1, 1] = 1;
            Display(multiDimensionalArray, "multiDimensionalArray");

            // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[5];
            Display(jaggedArray, "jaggedArray");

            // In preparation of learning arrays, refer to Classes.StaticVsInstanceMethods for an introduction on ...
            //  - static and instance methods
            //  - side effects and returned values
            // Classes.StaticVsInstanceMethods.Program.MainMethod();

            // Use intellisense to show that 
            // - Length and Clone (among others) are instance methods   (array object [dot] ...)
            // - IndexOf, Contains, Count, Clear, LastIndexOf and Sort are static methods (Array [dot] ...)
            // An explanation of why arrays have so many static methods can be found at: https://stackoverflow.com/questions/6713932/why-is-list-sort-an-instance-method-but-array-sort-static 

            var pi = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 };


            // INSTANCE METHODS:

            // Length
            Console.WriteLine($"pi Length: {pi.Length}");

            // Clone 
            //  - a demonstration how this occupies a different space on the stack
            var pi2 = (int[])pi.Clone();
            var pi3 = pi;

            var piDisplays = new Action[] { () => Display(pi, "pi"), () => Display(pi2, "pi2"), () => Display(pi3, "pi3") };
            DisplayMultiple<int>(piDisplays, "pi2 = (int[])pi.Clone() \npi3 = pi");

            pi2[0] = 0;
            DisplayMultiple<int>(piDisplays, "cloned pi2[0] set to '0' \npi unchaged");

            pi3[0] = 1;
            DisplayMultiple<int>(piDisplays, "copied pi3[0] set to '0' \npi also changed");


            // STATIC METHODS:

            var selectedValue = 4;

            // IndexOf
            var selectedValueIndex = Array.IndexOf(pi, selectedValue);
            Console.WriteLine($"Index of '{selectedValue}': {selectedValueIndex}");

            // Sort
            Array.Sort(pi);
            Display(pi, "sorted pi");

            // Reverse
            Array.Reverse(pi);
            Display(pi, "reversed pi");

            // Copy
            var newPi = new int[9];
            var threePi = new int[3];

            Array.Copy(pi, newPi, 9);
            Display(newPi, "newPi", "Array.Copy(pi, newPi, 9)");

            Array.Copy(pi, 3, threePi, 0, 3);   // Copying an array section
            Display(threePi, "threePi", "Array.Copy(pi, 3, threePi, 0, 3)");

            newPi[0] = 3;                       // showing that copying produces a new value on the stack
            DisplayMultiple<int>(new Action[] { () => Display(pi, "pi"), () => Display(newPi, "newPi") }, "newPi[0] = 3, \npi unchanged");

            // Clear
            Array.Clear(pi, 0, 5);
            Display(pi, "pi", "Array.Clear(pi, 0, 5)");



            //  - instatiating if type is not known at compile time.
            Type intType = typeof(int);
            Type stringType = typeof(string);
            Type selectedType = stringType;

            var array = Array.CreateInstance(selectedType, 5);

            SetValues(array, selectedType);
            DisplayValues(array, "array");
        }

        private static void Display<T>(T[] simpleArray, string name) => Display(simpleArray, name, "");

        private static void Display<T>(T[] simpleArray, string name, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine($"var {name} = {typeof(T).Name}[{simpleArray.Length}]");
            Console.WriteLine(String.Format("{{ {0} }}", string.Join(", ", simpleArray)));
            Console.WriteLine();
        }

        private static void Display<T>(T[,] twoDimensionalArray, string name)
        {
            Console.WriteLine($"var {name} = {typeof(T).Name}[{twoDimensionalArray.GetLength(0)},{twoDimensionalArray.GetLength(1)}]");
            Console.WriteLine("{");

            for (var subArray = 0; subArray < twoDimensionalArray.GetLength(0); subArray++)
            {
                Console.Write("  { ");

                for (var item = 0; item < twoDimensionalArray.GetLength(1); item++)
                {
                    Console.Write($"{twoDimensionalArray[subArray, item]} ");
                }

                Console.Write("}\n");
            }
            Console.WriteLine("}");
            Console.WriteLine();
        }

        private static void Display<T>(T[][] jaggedArray, string name)
        {
            var arrayType = typeof(T).Name;
            Console.WriteLine($"var {name} = {arrayType}[{jaggedArray.Length}][]\n");

            for (var i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"jaggedArray[{i}] = new {arrayType}[{jaggedArray[i].Length}]");
            }

            Console.WriteLine("\n{");

            foreach (var subArray in jaggedArray)
            {
                Console.WriteLine($"  {{ {string.Join(", ", subArray)} }}");
            }

            Console.WriteLine("}");
            Console.WriteLine();
        }

        private static void DisplayMultiple<T>(Action[] actions, string description)
        {
            var separator = ("-----------------------------");

            Console.WriteLine(separator);
            Console.WriteLine($"{description.ToUpper()}\n");

            foreach (var action in actions)
            {
                action();
            }

            Console.WriteLine(separator);
            Console.WriteLine();
        }

        private static void SetValues(Array array, Type selectedType)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (selectedType == typeof(int)) array.SetValue(i + 1, i);
                if (selectedType == typeof(string)) array.SetValue((i + 1).ToString(), i);
            }
        }

        private static void DisplayValues(Array array, string name)
        {
            Console.WriteLine($"{name}:");
            foreach (var item in array)
            {
                Console.WriteLine($"{item.GetType()}: {item} ");
            }

            Console.WriteLine("\n");
        }
    }
}
