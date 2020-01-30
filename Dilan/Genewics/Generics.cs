using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Dilan
{
    static class Generics
    {
        public static void GenericMethod()
        {
            string string1 = "Quick Brown Fox";
            var strarray = string1.Split(" ");
            var intarray = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var chararray = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f'};
            Console.WriteLine(intarray.Pop<int>());
            Break();
            WriteElements(intarray);
            Break();
            Console.WriteLine(chararray.Pop<char>());
            Break();
            WriteElements(chararray);
        }

        public static void WriteElements<T>(IEnumerable<T> I)
        {
            foreach (T i in I)
            {
                Console.WriteLine(i);
            }
        }

        private static Type Pop<Type>(this List<Type> list)
        {
            var popIndex = (list.Count - 1);
            var finalitem = list[popIndex];
            list.RemoveAt(popIndex);
            return finalitem;
        }
        private static void Break()
        {
            Console.WriteLine(" ");
        }


    }
}
