using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public partial class ValueVsReferenceTypes
    {
        public ValueVsReferenceTypes()
        {

        }
        public void ValueReferenceDefaultValues()
        {
            Console.WriteLine("### Default Values of Each Datatype\n");
            Display(new int[3]);
            Display(new double[3]);
            Display(new bool[3]);
            Display(new CarStruct[3]);
            Display(new CarClass[3]);
            Display(new string[3]);
            Display(new Suit[3]);
        }

        private void Display(IEnumerable enumerable)
        {
            Console.Write($"{enumerable}: ");

            foreach (var item in enumerable)
            {
                Console.Write($"{item ?? "null"}, ");
            }

            Console.WriteLine();
        }
    }
}
