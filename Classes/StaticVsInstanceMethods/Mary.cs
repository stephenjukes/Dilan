using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Mary
    {
        // static field
        public static int _numberOfChildren;
        public static string _surname = "Tayler";   // instance methods can access static fields, static methods cannot access instance fields

        // instance fields
        public string _name;
        public int _fullness = 50;
        public int _iq = 100;
        public int _happiness = 50;
        public int _childNumber = 0;

        public Mary(string name)
        {
            _name = name;
            _numberOfChildren++;
            _childNumber = _numberOfChildren;

            Console.WriteLine($"{name} { _surname}, child number {_childNumber}, is born " +
                $"(fullness: {_fullness}, iq: {_iq}, happiness: {_happiness}).");
        }

        // static methods
        public static void Feed(Mary child)
        {
            Action("feeds", child);

            child._fullness += 20;

            Report(child, "fullness");
        }

        public static void Teach(Mary child)
        {
            Action("teaches", child);

            child._iq += 20;

            Report(child, "iq");
        }

        public static void PlayWith(Mary child)
        {
            Action("plays with", child);

            child._happiness += 20;

            Report(child, "happiness");
        }

        // instance methods
        public void Eat()
        {
            Action("eats");

            _fullness += 10;

            Report(this, "fullness");
        }

        public void Learn()
        {
            Action("learns");

            _iq += 10;

            Report(this, "iq");
        }

        public void Play()
        {
            Action("plays");

            _happiness += 10;

            Report(this, "happiness");
        }

        // private helper methods.
        private static void Action(string action, Mary child) => Console.WriteLine($"Mary {action} {child._name}");
        private void Action(string action) => Console.WriteLine($"{this._name} {_surname}");

        // instance methods can use a static method, a static method cannot use an instance method
        private static void Report(Mary child, string state)    
        {
            var stateValue = typeof(Mary).GetField($"_{state}").GetValue(child);
            Console.WriteLine($"{child._name}'s {state} is now {stateValue}");
            Console.WriteLine();
        }
    }
}
