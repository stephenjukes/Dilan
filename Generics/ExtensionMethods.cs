using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    static class ExtensionMethods
    {
        public static Type Pop<Type>(this List<Type> list)
        {
            var lastIndex = list.Count - 1;
            var lastElement = list[lastIndex];
            list.RemoveAt(lastIndex);

            return lastElement;
        }

        public static int GetNumberEqualOrAbove<Type>(this List<Type> list, Type min) where Type : IComparable, new()
        {
            // highlighting the need for constraints
            // obj can only be instantiated because of the 'new()' constraint
            // obj only has a 'CompareTo()' method because of the 'IComparable' constraint
            var obj = new Type();

            return list.Where(e => e.CompareTo(min) > 0).Count();
        }
    }
}
