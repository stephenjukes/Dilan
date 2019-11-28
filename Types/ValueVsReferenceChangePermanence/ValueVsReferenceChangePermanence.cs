using StructsAndClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public partial class ValueVsReferenceTypes
    {
        public void ValueReferenceCopyAndChangeValue()
        {
            Console.WriteLine("### Copy And Change Value Type\n");

            int int1 = 10;
            int int2 = int1;
            Console.WriteLine("Before:");
            Console.WriteLine($"int1 = {int1}, int2 = {int2}");
            Console.WriteLine();

            int2 = 5;
            Console.WriteLine("After:");
            Console.WriteLine($"int1 = {int1}, int2 = {int2}");
            Console.WriteLine();
        }

        public void ValueReferenceCopyAndChangeReference()
        {
            Console.WriteLine("### Copy And Change Reference Type\n");

            int[] ints1 = new int[] { 1, 2, 3 };
            int[] ints2 = ints1;

            Console.WriteLine("Before:");
            Display(ints1);
            Display(ints2);
            Console.WriteLine();

            ints2[0] = 0;

            Console.WriteLine("After:");
            Display(ints1);
            Display(ints2);
            Console.WriteLine();
        }


        public void ValueReferenceChangingClassesVsStructs()
        {
            Console.WriteLine("### Permanence of Change - Value Vs Reference Types\n");

            var valerie = new PersonStruct("Valerie", 10);
            var reggie = new PersonClass("Reggie", 10);

            DisplayReputation("Before Vegas", valerie, reggie);
            InVegas(valerie, reggie);
            DisplayReputation("After Vegas", valerie, reggie);
        }

        private void InVegas(params IPerson[] people)
        {
            foreach(var person in people)
            {
                person.Reputation = 0;
                DisplayReputation("In Vegas", person);
            }
        }

        private void DisplayReputation(string situation, params IPerson[] people)
        {
            Console.WriteLine($"{situation}:");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name}\t- Reputation: {person.Reputation}");
            }

            Console.WriteLine();
        }
    }
}
