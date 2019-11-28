using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Answers
    {
        int[] pi = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
        List<string> fox = new List<string>() { "The", "quick", "brown", "fox" ,"jumps", "over", "the", "lazy", "dog"};
        string selected = "the";

        public void Demonstrate(Exercise exercise)
        {
            typeof(Answers)
                .GetMethod(exercise.ToString())
                .Invoke(this, null);
        }

        // SIMPLE ARRAYS
        public void SimpleArray()
        {
            // Create a simple integer array for 10 elements
            int[] simpleArray = new int[10];
            Display(simpleArray, "simpleArray");

            // Set the 5th element to a value of your choice
            var element = 5;
            var index = element - 1;
            var newValue = 1;

            simpleArray[index] = newValue;
            Display(simpleArray, $"Setting the index {index} to {newValue}");

            // Increment the 5th element by 1
            simpleArray[5]++;
            Display(simpleArray, $"Incrementing index {index}");

            // Log the 5th element to the console
            Console.WriteLine($"Index {index}:\n{simpleArray[index]}\n");

            // Display each element of the array in a row, separated by a space
            Display(simpleArray, "Array displayed to the console");
        }

        // MULTIDIMENSIONAL ARRAYS
        public void MultiDimensionalArray()
        {
            // Create a 2 dimensional integer array with 2 five element sub arrays
            int[,] multiDimensionalArray = new int[2, 5];
            Display(multiDimensionalArray, "MultiDimensional Array");

            // Set the second element of the second sub array to a value of your choice
            var element = 2;
            var index = element - 1;
            var newValue = 5;

            multiDimensionalArray[index, index] = newValue;
            Display(multiDimensionalArray, $"Setting index {index} of index {index} to {newValue}");

            // Increment this value by 1
            multiDimensionalArray[index, index]++;
            Display(multiDimensionalArray, "Incrementing this value");

            // Log this value to the console
            Console.WriteLine($"Logging this value to the console:\n{multiDimensionalArray[index, index]}\n");

            // Display each sub array on a separate line with each of their elements separated by a space
            Display(multiDimensionalArray, "Array displayed to the console");
        }

        // JAGGED ARRAYS
        public void JaggedArray()
        {
            // Create a jagged array containing 3 sub arrays
            int[][] jaggedArray = new int[3][];
            //Display(jaggedArray, "Empty Jagged Array");

            // Assign each sub array to a different length
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[5];
            Display(jaggedArray, "Jagged Array with Sub Arrays");

            // Set one of these elements to a value of your choice
            jaggedArray[1][1] = 1;
            Display(jaggedArray, "Setting the value of a chosen element");

            // Display each sub array on a separate line with their elements separated by a space
            Display(jaggedArray, "Array displayed to the console");
        }

        // STATIC VS INSTANCE METHODS

        class Ford
        {
            public string _color = "none";

            public static void Spray(Ford car, string color)
            {
                car._color = color;
            }

            public string Drive()
            {
                return "Vroom vroom!";
            }
        }

        public void PublicVsStaticMethods()
        {
            // How do static methods and fields differ from instance methods and fields?

            // How does syntax differ when invoking static and instance methods?

            // Look at the Ford class above
            // Notice that 'Spray' is a static method while 'Drive' and '_color' are not
            // What reasoning can you give for this?

            // What is the difference between a returned value and a side effect?

            // What implications does this have when invoking a method of each type?

            // Which of the 'Ford' methods returns a value, and which one has only a side effect?

            // Instantiate a new car
            var myCar = new Ford();

            // Check what color your car is
            Console.WriteLine($"myCar color: {myCar._color}\n");

            // Spray your car a new color
            Console.WriteLine("Ford.Spray(myCar, \"red\");");
            Ford.Spray(myCar, "red");

            // Check that your car is now a new color
            Console.WriteLine($"myCar._color: {myCar._color}\n");

            // Drive your car
            Console.WriteLine($"myCar.Drive();");
            Console.WriteLine(myCar.Drive());

            Console.WriteLine();
        }

        // ARRAY METHODS

        // Demonstrate the effect of each method either by debugging or logging to the console.

        // Use intellisense to show that 
        // - Length and Clone (among others) are instance methods   (array object [dot] ...)
        // - IndexOf, Contains, Count, Clear, LastIndexOf and Sort are static methods (Array [dot] ...)

        // Create an integer array with values for each element
        // - Already created in field

        public void ArrayAsReferenceType()
        {
            // Declare a second variable and assign it to your original variable
            var pi1 = pi;

            var piDisplays = new Action[] { () => Display(pi, "pi"), () => Display(pi1, "pi1") };
            DisplayMultiple<int>(piDisplays, "Variable assigned to another");

            // Change the value of one of the elements in one of your arrays
            pi1[0] = 1;

            // Show that this has also changed your other array
            DisplayMultiple<int>(new Action[] { () => Display(pi, "pi"), () => Display(pi1, "pi1") }, "Element changed in one array");

            // Q. Explain why this has happened
            // A. Arrays are reference types
        }

        // INSTANCE METHODS

        public void ArrayLength()
        {
            // Find the length of your array
            Console.WriteLine($"pi Length: {pi.Length}");
        }

        public void ArrayClone()
        {
            // Clone your array to a second variable
            var pi1 = (int[])pi.Clone();

            var piDisplays = new Action[] { () => Display(pi, "pi"), () => Display(pi1, "pi1") };
            DisplayMultiple<int>(piDisplays, "Pi cloned;");

            // Change the value of one of the elements in one of your arrays
            pi1[0] = 2;

            // Show that this has not changed the other arrray
            DisplayMultiple<int>(piDisplays, "Element changed");
        }


        // STATIC METHODS

        public void ArrayIndexOf()
        {
            // Choose a random number and find the index of its first occurrence in your array
            var selectedValue = 4;
            var selectedValueIndex = Array.IndexOf(pi, selectedValue);

            Display(pi, "pi");
            Console.WriteLine($"Index of '{selectedValue}': {selectedValueIndex}");
        }

        public void ArraySort()
        {
            Display(pi, "pi");

            // Sort your array from lowest to highest
            Array.Sort(pi);
            Display(pi, "Sorted pi");
        }

        public void ArrayReverse()
        {
            Display(pi, "pi");

            // Reverse your array
            Array.Reverse(pi);
            Display(pi, "Reversed pi");
        }

        public void ArrayCopy()
        {
            // Use the 'Copy' method to copy your array to another array
            var pi1 = new int[9];
            Array.Copy(pi, pi1, 9);

            var piDisplays = new Action[] { () => Display(pi, "pi"), () => Display(pi1, "pi1") };
            DisplayMultiple<int>(piDisplays, "Copied");

            // Change the value of one of the elements in one of your arrays
            pi1[0] = 2;

            // Show that this has not changed the other arrray
            
            DisplayMultiple<int>(piDisplays, "Element changed");

            // Copy the middle 3 or 4 elements to another array
            var middleFourPi = new int[4];
            Array.Copy(pi, 4, middleFourPi, 0, 4);

            Display(middleFourPi, "MiddleFourPi");
        }

        public void ArrayClear()
        {
            Display(pi, "pi");

            // Clear the first half of your array
            Array.Clear(pi, 0, 4);
            Display(pi, "First half cleared");
        }

        // LISTS

        // Create an empty string list
        // - Already created in field

        // Think of a sentence with around 10 words

        public void ListAdd()
        {
            // Add the first word to your list
            fox.Add("fish");
            Display(fox, "Adding \"fish\":");
        }


        public void ListAddRange()
        {
            Display(fox, "Fox");

            // Create a second list (or array) with the remaining words as each element
            var remainder = new string[] { "and", "the", "cow", "jumped", "over", "the", "moon" };
            fox.AddRange(remainder);

            Display(fox, "Adding the rest");
        }

        public void ListCount()
        {
            Display(fox, "Fox");

            // Log the length of your list
            Console.WriteLine($"Length: {fox.Count}\n");
        }

        // Select one of your words (preferably a repeated word)

        public void ListContains()
        {
            Display(fox, "Fox");

            // Check that your list contains your selected word
            Console.WriteLine($"List contains \"{selected}\": {fox.Contains(selected)}\n");
        }

        public void ListIndexOf()
        {
            Display(fox, "Fox");

            // Find the (first) index of your selected word
            Console.WriteLine($"(First) index of selected word: {fox.IndexOf(selected)}\n");
        }

        public void ListLastIndexOf()
        {
            Display(fox, "Fox");

            // Find the last index of your selected word
            Console.WriteLine($"Last index of selected word: {fox.LastIndexOf(selected)}\n");
        }

        public void ListSort()
        {
            Display(fox, "Fox");

            // Sort your list
            fox.Sort();
            Console.WriteLine($"Sorted: {fox}\n");
        }

        public void ListRemoveAt()
        {
            Display(fox, "Fox");

            // Remove an element from an index of your choice
            var indexToRemoveFrom = 1;
            fox.RemoveAt(indexToRemoveFrom);

            Display(fox, $"Removing from index {indexToRemoveFrom}");
        }

        public void ListClear()
        {
            Display(fox, "Fox");

            // Clear your list
            fox.Clear();
            Display(fox, "Cleared");
        }

        private void Display<T>(IEnumerable<T> simpleArray, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine(String.Format("{{ {0} }}", string.Join(", ", simpleArray)));
            Console.WriteLine();
        }

        private void Display<T>(T[,] twoDimensionalArray, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine("{");

            for (var subArray = 0; subArray < twoDimensionalArray.GetLength(0); subArray++)
            {
                Console.Write("  { ");

                for (var item = 0; item < twoDimensionalArray.GetLength(1); item++)
                {
                    Console.Write($"{twoDimensionalArray[subArray, item]} ");
                }

                Console.Write("}\n");
            }
            Console.WriteLine("}");
            Console.WriteLine();
        }

        private void Display<T>(T[][] jaggedArray, string description)
        {
            Console.WriteLine(description);
            Console.WriteLine("\n{");

            foreach (var subArray in jaggedArray)
            {
                Console.WriteLine($"  {{ {string.Join(", ", subArray)} }}");
            }

            Console.WriteLine("}");
            Console.WriteLine();
        }

        private void DisplayMultiple<T>(Action[] actions, string description)
        {
            var separator = ("-----------------------------");

            Console.WriteLine(separator);
            Console.WriteLine($"{description.ToUpper()}\n");

            foreach (var action in actions)
            {
                action();
            }

            Console.WriteLine(separator);
            Console.WriteLine();
        }

        private void SetValues(Array array, Type selectedType)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (selectedType == typeof(int)) array.SetValue(i + 1, i);
                if (selectedType == typeof(string)) array.SetValue((i + 1).ToString(), i);
            }
        }

        private void DisplayValues(Array array, string name)
        {
            Console.WriteLine($"{name}:");
            foreach (var item in array)
            {
                Console.WriteLine($"{item.GetType()}: {item} ");
            }

            Console.WriteLine("\n");
        }
    }

}
