using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class Answers
    {
        string fox = "The Quick Brown Fox Jumps Over The Lazy Dog ";

        // Strings are immutable
        //fox[0] = 'j';   // Does not compile

        public void Demonstrate(Method method)
        {
            Console.WriteLine($"Using {fox.GetType()}:\n{fox}\n");
            typeof(Answers).GetMethod(method.ToString()).Invoke(this, null);
        }

        public void ToUpper()
        {
            var toUpper = fox.ToUpper();
            Display("To uppercase:", toUpper);
        }

        public void ToLower()
        {
            var toLower = fox.ToLower();
            Display("To lowercase:", toLower);
        }

        public void Trim()
        {
            Display("Untrimmed:", $"{fox}|end");

            fox = fox.Trim();
            Display("Trimmed:", $"{fox}|end");
        }

        public void GetIndex()
        {
            var target = 'e';
            var indexOfTarget = fox.IndexOf(target);
            Display($"Index of '{target}':", indexOfTarget);

            var lastIndexOfTarget = fox.LastIndexOf(target);
            Display($"Last index of '{target}':", lastIndexOfTarget);
        }

        public void Substring()
        {
            var startIndex = 20;
            var length = 10;
            Display($"Substring from {startIndex} and of length {length}:", fox.Substring(startIndex, length));
            Display($"Substring from {startIndex}:", fox.Substring(startIndex));
        }

        public void Replace()
        {
            var replaced = "The";
            var replacer = "My";
            var replacedSubstring = fox.Replace(replaced, replacer);
            Display($"Replace {replaced} with {replacer}:", replacedSubstring);
        }

        public void NullTest()
        {
            var nullTest = " ";
            Console.WriteLine($"Using: \"{nullTest}\"\n");

            var isNullOrEmpty = String.IsNullOrEmpty(nullTest);
            Display("Null or Empty:", isNullOrEmpty);

            var isNullOrWhitespace = String.IsNullOrWhiteSpace(nullTest);
            Display("Null or Whitespace:", isNullOrWhitespace);
        }

        public void SplitAndJoin()
        {
            fox = fox.Trim();

            var foxArray = fox.Split(" ");
            DisplayRange("Fox Array", foxArray);

            var delimiter = "-";
            var foxJoined = String.Join(delimiter, foxArray);
            Display($"Fox Array joined with '{delimiter}':", foxJoined);
        }

        public void ToString()
        {
            var number = 1324;
            var defaultToString = number.ToString();
            Display($"{number.GetType()} {number} to string:", $"{defaultToString.GetType()} {defaultToString}");

            var charParameter = "C";
            var toStringWithCharParameter = number.ToString(charParameter);
            Display($"To string with char parameter '{charParameter}':", toStringWithCharParameter);
            // C: Currency
            // D: Decimal
            // E: Exponential
            // F: Fixed Point
            // X: Hexidecimal
        }

        private void DisplayRange(string description, IEnumerable enumerable)
        {
            Console.WriteLine(description);

            Console.Write("{ ");
            foreach (var item in enumerable)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("}\n");
        }

        private void Display<T>(string description, T result)
        {
            Console.WriteLine(description);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
