using System;

namespace Scope
{
    class Exercises
    {
        static void Main(string[] args)
        {
            // For each of the 12 marked lines of code below, try to predict which are in scope and which are not
            // - (those that are out of scope will not compile - be underlined in red).

            // Once finished, uncomment all lines and see how well you did.

            // Write an explanation as to why each line compiled or not. 
            // Explanations may be one of:
            // - within or out of class scope
            // - within or out of method scope
            // - within or out of block scope
            // (strictly speaking, classes and methods are also blocks).

            Answers here;
        }
    }

    class Class1
    {
        public int class1Field = default(int);

        public void Method1()
        {
            int method1Variable = default(int);

            for (var forLoopIterator = 0; forLoopIterator < method1Variable; forLoopIterator++)
            {
                //Console.WriteLine(forLoopIterator);   // 1.
                //Console.WriteLine(method1Variable);   // 2.
                //Console.WriteLine(class1Field);       // 3.
            }

            //Console.WriteLine(forLoopIterator);       // 4.
            //Console.WriteLine(method1Variable);       // 5.
            //Console.WriteLine(class1Field);           // 6.
        }

        public void Method2()
        {
            //Console.WriteLine(forLoopIterator);       // 7.
            //Console.WriteLine(method1Variable);       // 8.
            //Console.WriteLine(class1Field);           // 9.
        }
    }

    class Class2
    {
        public void Method1()
        {
            //Console.WriteLine(forLoopIterator);       // 10.
            //Console.WriteLine(method1Variable);       // 11.
            //Console.WriteLine(class1Field);           // 12.
        }
    }
}
