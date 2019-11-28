using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Time
{
    public class TimeProgram
    {
        public static void MainMethod()
        {
            Time t = new Time(9, 30);
            Console.WriteLine(t + new Time(1, 15));
            Console.WriteLine(t - new Time(1, 15));

            Time t1 = new Time(9, 30);
            Time t2 = 120; // Two hours
            int m1 = (int)t1;
            Console.WriteLine("t1={0} and t2={1} and m1={2}", t1, t2, m1);
            Time t3 = t1 + 45;

        }
    }
}
