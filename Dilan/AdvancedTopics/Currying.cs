using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    // Uses

    // map, filter, reduce, eg ...
    //let array1 = [1, 4, 9, 16];
    //let add = x => y => x + y;
    //array2 = array1.map(foo? add(10) : add(20));
    class Currying
    {
        public static void MainMethod()
        {
            Func<int, int, int, int, int> addFourThings = (a, b, c, d) => a + b + c + d;

            var curriedAddFourThings = Curry(addFourThings);

            int result = curriedAddFourThings(1)(2)(3)(4);  // result = 10

            var addOne = curriedAddFourThings(1);
            var addOneAndTwo = addOne(2);
            var addOneAndTwoAndThree = addOneAndTwo(3);

            int result2 = addOneAndTwoAndThree(4); // result2 = 10
        }


        public static Func<T1, Func<T2, Func<T3, Func<T4, T5>>>> Curry<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5> function)
        {
            return a => b => c => d => function(a, b, c, d);
        }
    }

}
