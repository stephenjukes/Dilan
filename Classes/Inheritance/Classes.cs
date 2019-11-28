using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Inheritance
{
    // Create classes: Animal, Cat & Dog with appropriate inheritance
    // Each class should have a property and method
    // Show that each derived class contains its own members plus base class members
    // Show that all objects automatially inherit from Object
    // animal is Object, etc...
    // F12 into Object's methods
    // if conversation about 'protected' arises, demonstrate in class with 'this'.

    // Members
    // Show that the base class' members can be used by derived classes
    // repeated members in base and derive - (which hides the inherited member) - show the 'polymorphic' value
    // override base class members with virtual - now show the polymorphic value
    // sealed - (try with and without overriding)
    // abstract
    // public, private and protected (implications for inheritance)

    // Classes
    // abstract, sealed classes
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed: 
    //To determine whether to seal a class, method, or property, you should generally consider the following two points: (1) The potential benefits that deriving classes might gain through the ability to customize your class. (2)The potential that deriving classes could modify your classes in such a way that they would no longer work correctly or as expected.

    // Constructors
    // derived constructors utilise base constructors
    // the need for a derived class to set up the base class - therefore, for the base class to have all necessary constructors
    // https://www.codewars.com/kata/fun-with-es6-classes-number-2-animals-and-inheritance/train/csharp


    // Re-emphasize the use of polymorphism (inc. with dependency injection)

    // Casting?


    class Animal
    {
        public string Species { get; }

        public void Sing()
        {
            Console.WriteLine("Lalala");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; }

        public void Sing()
        {
            Console.WriteLine("Awoooo");
        }
    }

    class Cat : Animal
    {
        public int Whiskers { get; }

        public void Sing()
        {
            Console.WriteLine("Meeeooow");
        }
    }





















    //class Animal
    //{
    //    public int AnimalProperty { get; set; }

    //    public virtual string Sing()
    //    {
    //        return "...";
    //    }
    //}

    //class Dog : Animal
    //{
    //    public int DogProperty { get; set; }

    //    public sealed override string Sing()
    //    {
    //        return "woof";
    //    }
    //}

    //class Cat: Animal
    //{
    //    public int CatProperty { get; set; }

    //    public override string Sing()
    //    {
    //        return "meow";
    //    }
    //}

    //class Labrador : Dog
    //{
    //    public string Sing()
    //    {
    //        return "Awooooo!";
    //    }
    //}


}
