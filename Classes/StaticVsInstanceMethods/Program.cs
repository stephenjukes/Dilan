using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.StaticVsInstanceMethods
{
    public static class Program
    {
        public static void MainMethod()
        {
            var michael = new Mary("Michael");
            var elliott = new Mary("Elliott");
            var gertie = new Mary("Gertie");

            Console.WriteLine($"\nMary has {Mary._numberOfChildren} children.");
            Console.WriteLine($"Elliot is child number {elliott._childNumber}.\n");

            Mary.Teach(michael);
            michael.Learn();

            Mary.Feed(elliott);
            elliott.Eat();

            Mary.PlayWith(gertie);
            gertie.Play();
        }
    }
}
