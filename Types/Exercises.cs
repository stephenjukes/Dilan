using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Types
{
    class Exercises
    {
        static void Main(string[] args)
        {
            // DATATYPES

            // Declare the seven numberial types and assign a value for each

            // How are floats and doubles different from a decimal?

            // What advantage does a float have over a decimal?

            // When should a decimal be used in place of a float or double?

            // Demonstrate the difference in precision (number of decimal places) for a float, double and decimal

            // Demonstrate how repeated calculations on floats and doubles can result in inaccuracies

            // Declare a bool, char(acter), string, array, list and dictionary (the last three can be a collection of any type) and assign values for each.

            // Create an enum set. Declare that enum and assign a value

            // Create the shell of a class and struct. Instantiate and store each in a variable


            // CONVERSION

            // Give an example of implicit type conversion

            // Give an example of explicit type conversion, (casting)

            // Why is casting necessary for the second example and not for the first?

            // Give two examples of converting non compatible types.

            // How do these differ?


            // VALUE AND REFERENCE TYPES

            // What is the difference between a value and reference type with regard to ...

            // Their being null

            // Where they are allocated

            // How copies are made

            // How behaviour is affected by this difference in copying

            // Give an example of how behaviour differs ...

            // when assigning a value to a variable, and then assigning that variable to another variable

            // when passing that value as an argument to a method

            // What is the difference between a class and a struct?


            // REFERENCE AND DEMONSTRATION

            var sections = new object[] 
            {
                typeof(DataType),
                typeof(TypeConversion),
                typeof(ValueVsReferenceTypes)
            };

            var answers = new Answers();
            answers.Show(Section.ValueReferenceDefaultValues);
        }
    }
}
