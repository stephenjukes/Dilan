using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public static class Lists
    {
        public static void MainMethod()
        {
            List<string> fox = new List<string>();
            fox.Add("The");
            Display("fox.Add(\"The\");", fox);

            fox.Add("quick");
            Display("fox.Add(\"quick\");", fox);

            fox.AddRange(new string[] { "brown", "fox", "jumps", "over", "the", "lazy", "dog" });
            Display("fox.AddRange(...);", fox);

            var selected = "the";

            // Count
            Display($"Count:", fox.Count);

            // Contains
            Display($"Contains '{selected}'?", fox.Contains(selected));

            // IndexOf
            Display($"Index of '{selected}':", fox.IndexOf(selected));

            // LastIndexOf
            Display($"Last index of '{selected}':", fox.LastIndexOf(selected));
   
            // Sort
            fox.Sort();
            Display("Sorted", fox);

            // RemoveAt
            var indexToRemove = 1;
            fox.RemoveAt(indexToRemove);
            Display($"Removed at {indexToRemove}", fox);

            // Clear
            fox.Clear();
            Display("Cleared", fox);


        }

        private static void Display<T>(string description, T result)
        {
            Console.WriteLine(description);

            //if(result is IEnumerable)
            //{
            //    foreach (var item in result)
            //    {
            //        Console.Write($"{item} ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}
            //Console.WriteLine();
        }

        private static void Display(string description) => Display(description, new string[0]);

        private static void Display(string description, IEnumerable enumerable)
        {
            Console.WriteLine(description);

            foreach(var item in enumerable)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n");
        }


    }
}
