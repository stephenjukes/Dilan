using System;
using System.Collections.Generic;
using System.Text;

namespace Scope
{
    class Answers
    {
    }

    class ClassA
    {
        public int class1Field = default(int);

        public void Method1()
        {
            int method1Variable = default(int);

            for (var forLoopIterator = 0; forLoopIterator < method1Variable; forLoopIterator++)
            {
                Console.WriteLine(forLoopIterator);
                Console.WriteLine(method1Variable);
                Console.WriteLine(class1Field);
            }

            //Console.WriteLine(forLoopIterator);       // blocked by block level scope
            Console.WriteLine(method1Variable);
            Console.WriteLine(class1Field);
        }

        public void Method2()
        {
            //Console.WriteLine(forLoopIterator);       // blocked by method level scope
            //Console.WriteLine(method1Variable);       
            Console.WriteLine(class1Field);
        }
    }

    class ClassB
    {
        public void Method1()
        {
            //Console.WriteLine(forLoopIterator);       // blocked by class level scope
            //Console.WriteLine(method1Variable);
            //Console.WriteLine(class1Field);                  
        }
    }
}
