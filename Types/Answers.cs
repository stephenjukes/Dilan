using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Types
{
    public class Answers
    {
        public void Show(Section section)
        {
            var sectionType = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                    .Where(type => type.GetMethod(section.ToString()) != null)
                    .First();

            var sectionMethod = sectionType.GetMethod(section.ToString());

            var instance = Activator.CreateInstance(sectionType);
            sectionMethod.Invoke(instance, null);
        }

        // DATATYPES

        // Declare the seven numberial types and assign a value for each
        public byte aByte = 255;
        public short aShort = 32767;
        public int anInt = 2147483647;
        public long aLong = 9223372036854775807;
        public float aFloat = 3.14f;        // System.Single (4 byte binary) 10001.1001011...
        public double aDouble = 3.14;       // System.Double (8 byte binary) 10001.1001011...
        public decimal aDecimal = 3.14m;    // Decimal (16 byte decimal)     1234.56789...

        // Q. How are floats and doubles different from a decimal?
        // A. Floats and doubles initially of binary format, while decimals are true decimals

        // Q. What advantage does a float have over a decimal?
        // A. Floats are faster to compute

        // Q. When should a decimal be used in place of a float or double?
        // A. When handling numbers that are naturally of a decimal format. These are usually human inventions, (eg. money, metric measurements)

        // Q. Demonstrate the difference in precision (number of decimal places) for a float, double and decimal

        // Demonstrate how repeated calculations on floats and doubles can result in inaccuracies
        private void CompareNonIntegerPrecision()
        {
            Console.WriteLine("### Compare Non Integer representation of 1/3\n");
            DisplayNonIntegerResults(
                1f / 3,
                1d / 3,
                1m / 3
            );
        }

        // Declare a bool, char(acter), string, array, list and dictionary (the last three can be a collection of any type) and assign values for each.
        public char aChar = 'a';
        public bool aBool = true;
        
        // Reference Types
        public string aString = "I'm a string";
        public string[] anArray = new string[] { "I'm", "an", "array" };
        public List<string> aList = new List<string>() { "I'm", "a", "list" };
        public Dictionary<string, long> aDictionary = new Dictionary<string, long>()
            {
                { "Dilan", 45893457894 },
                { "Stephen", 49347938493 }
            };
        // Create an enum set. Declare that enum and assign a value
        enum Bear
        {
            DaddyBear,
            MummyBear,
            BabyBear
        }

        Bear pookie = Bear.BabyBear;

        // Create the shell of a class and struct. Instantiate and store each in a variable
        class CarClass
        { }

        struct CarStruct
        { }

        CarStruct carValue = new CarStruct();
        CarClass carObject = new CarClass();


        // CONVERSION

        // Give an example of implicit type conversion
        public void ImplicitTypeConversion()
        {
            byte aByte = 1;
            int anInt = aByte;
            float aFloat = anInt;
        }

        // Give an example of explicit type conversion, (casting)
        public void ExplicitConversionByCasting()
        {
            float aFloat = 1f;
            int anInt = (int)aFloat;
            byte aByte = (byte)anInt;        // cast to show awareness of potential data loss
        }

        // Q. Why is casting necessary for the second example and not for the first?
        // A. In the second example there is a danger of losing information - the cast shows that you are aware of this.
        // In the first example, there is no danger of information loss.

        // Show two ways of converting a string to an int.
        // Describe and demonstrate how these ways differ?
        public void NonCompatibleTypeConversion()
        {
            string aString = null;
            int intParsed = int.Parse(aString);
            int convertedToInt = Convert.ToInt32(aString);

            Console.WriteLine(intParsed);
            Console.WriteLine(convertedToInt);
        }

        // VALUE AND REFERENCE TYPES

        // What is the difference between a value and reference type with regard to ...

        // Q. Their being null, (demonstrate this)
        // A. Reference types can be null while value types cannot. Value types have default values instead.
        public void DemonstrateDefaultValues()
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

        // Q. Where they are allocated
        // A. Value types are allocated to the stack while Reference types are allocated to the heap.

        // Q. How copies are made
        // A. For value types, a new copy is made on the stack with a new memory address
        //    For reference types, a new reference is made which points to the same memory address on the heap

        // Q. How behaviour is affected by this difference in copying
        // A. For a reference type, after changing the object with one reference, all other refrences will refer to the same changed object
        //    Value types are independent - changing one will have no impact on any of the others.

        // Demonstrate how behaviour differs ...

        // when assigning a value to a variable, and then assigning that variable to another variable
        public void ValueVsReferenceTypesCopiedToVariable()
        {
            // value types
            int int1 = 1;
            int int2 = int1;
            int2 = 10;
            Console.WriteLine(int1);

            // reference types
            int[] ints1 = new int[] { 1, 2, 3 };
            int[] ints2 = ints1;
            ints2[0] = 0;
            Display(ints1);
        }

        // when passing that value as an argument to a method
        // (Uniting a class and struct under an interface and passing each into the same method is a nice demonstration)
        public void ValueVsReferenceTypesAsArgument()
        {
            int anInt = 1;
            int[] ints = new int[] { 1, 1, 1 };

            ChangeValueType(anInt);
            ChangeReferenceType(ints);

            Console.WriteLine($"anInt: {anInt}");
            Display(ints);
        }

        private void ChangeValueType(int number)
        {
            number++;
        }

        private void ChangeReferenceType(int[] numbers)
        {
            numbers[0]++;
        }

        // Q. What is the difference between a class and a struct?
        // A. A struct is a value type and a class is a reference type.


                    
                //ValueVsReferenceDefaultValues.DemonstratePermanenceOfChange();
                // |--------------------------------|-------------------------------|
                // | PRIMITIVE                      | NON PRIMITIVE                 |
                // | -------------------------------|-------------------------------|
                // | Value Type                     | Reference Type                |
                // | Default Value                  | Null                          |
                // | Allocated on Stack             | Allocated on Heap             |
                // | Smaller Types (< 8 bytes)      | Larger Types                  |
                // | Memory allocated automatically | Memory allocated with 'new'   |
                // | Removed when out of scope      | Garbage collected by CLR      |
                // |--------------------------------|-------------------------------|

        private void DisplayNonIntegerResults(float f, double d, decimal m)
        {
            Console.WriteLine($"Float: {f}");
            Console.WriteLine($"Double: {d}");
            Console.WriteLine($"Decimal: {m}");
            Console.WriteLine();
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
