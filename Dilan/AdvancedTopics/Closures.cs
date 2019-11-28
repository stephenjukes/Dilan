using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    // Exercises
    // AddFive
    // Counter
    // Lazy Repeater (see CodeWars)

    public static class Closures
    {
        public static void MainMethod()
        {
            var addSix = CreateBase(6);
            var result1 = addSix(10);
            var result2 = addSix(21);

            var addTen = CreateBase(10);
            var result3 = addTen(10);
            var result4 = addTen(21);

            Console.WriteLine();
        }

        private static Func<int, int> CreateBase(int baseNumber)
        {
            return toAdd => baseNumber + toAdd;
        }
    }
}
