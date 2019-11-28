using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class DataType
    {
        public DataType()
        {

        }
        // Value Types
        public byte aByte = 255;
        public short aShort = 32767;
        public int anInt = 2147483647;
        public long aLong = 9223372036854775807;
        public float aFloat = 3.14f;        // System.Single (4 byte binary) 10001.1001011...
        public double aDouble = 3.14;       // System.Double (8 byte binary) 10001.1001011...
        public decimal aDecimal = 3.14m;    // Decimal (16 byte decimal)     1234.56789...
        public char aChar = 'a';
        public bool aBool = true;
        public Suit suit = Suit.Clubs;
        public CarStruct carStruct = new CarStruct();

        // Refer
        public string aString = "I'm a string";
        public string[] anArray = new string[] { "I'm", "an", "array" };
        public List<string> aList = new List<string>() { "I'm", "a", "list" };
        public Dictionary<string, long> aDictionary = new Dictionary<string, long>()
            {
                { "Dilan", 45893457894 },
                { "Stephen", 49347938493 }
            };
        public CarClass car = new CarClass();

        public void DataTypeComparisonOfNonIntegerPrecision()
        {
            // Binary representations (float / double) are faster
            // Use floats and doubles to represent things of nature
            // Use decimals when representing things that are 'naturally exact decimals' - usually human concepts (eg: money, metric measurements, etc...)

            // Using Float, Double Instead of BigDecimal Could Be Fatal for Military
            // On February 25, 1991, a loss of significance in a MIM-104 Patriot missile battery prevented it from intercepting an incoming Scud missile in Dhahran, Saudi Arabia, contributing to the death of 28 soldiers from the U.S.Army’s 14th Quartermaster Detachment.

            Console.WriteLine("### Compare Non Integer representation of 1/3\n");
            DisplayNonIntegerResults(
                1f / 3, 
                1d / 3, 
                1m / 3
            );
        }

        public void DataTypeComparisonOfNonIntegerAccuracy()
        {
            aFloat = 0.1f;
            aDouble = 0.1d;
            aDecimal = 0.1m;
            int repeat = 1000;

            for (var i = 0; i < repeat; i++)
            {
                aFloat += 0.1f;
                aDouble += 0.1d;
                aDecimal += 0.1m;
            }

            Console.WriteLine($"### Compare Non Integer representation of 0.1 added {repeat} times\n");
            DisplayNonIntegerResults(aFloat, aDouble, aDecimal);
        }

        private void DisplayNonIntegerResults(float f, double d, decimal m)
        {
            Console.WriteLine($"Float: {f}");
            Console.WriteLine($"Double: {d}");
            Console.WriteLine($"Decimal: {m}");
            Console.WriteLine();
        }
    }
}
