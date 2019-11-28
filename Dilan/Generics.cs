using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    static class Generics
    {
        public static void GenericMethod()
        {
            string string1 = "Quick Brown Fox";
            var strarray = string1.Split(" ");
            var intarray = new List<int>() { 1, 2, 3, 4, 5, 6 };
            intarray.Pop();
            WriteElements(intarray);
            intarray.Pop();
            WriteElements(intarray);
        }

        private static void WriteElements<T>(List<T> I)
        {
            foreach (T i in I)
            {
                Console.WriteLine(i);
            }
        }

        private static Type Pop<Type>(this List<Type> list)
        {
            list.RemoveAt(list.Count - 1);
            return list[0];
        }
    }
}
