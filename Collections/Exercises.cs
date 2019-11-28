using System;
using System.Collections;
using System.Collections.Generic;
using Classes;

namespace Collections
{
    class Exercises
    {
        static Type goTo;

        static void Main(string[] args)
        {
            // SIMPLE ARRAYS
            goTo = typeof(Answers);

            // Create a simple integer array for 10 elements

            // Set the 5th element to a value of your choice

            // Increment the 5th element by 1

            // Log the 5th element to the console

            // Display each element of the array in a row, separated by a space


            // MULTIDIMENSIONAL ARRAYS
            goTo = typeof(Answers);

            // Create a 2 dimensional integer array with 2 five element sub arrays

            // Set the second element of the second sub array to a value of your choice

            // Increment this value by 1

            // Log this value to the console

            // Display each sub array on a separate line with each of their elements separated by a space


            // JAGGED ARRAYS
            goTo = typeof(Answers);

            // Create a jagged array containing 3 sub arrays

            //Display(jaggedArray, "Empty Jagged Array");

            // Assign each sub array to a different length

            // Set one of these elements to a value of your choice

            // Display each sub array on a separate line with their elements separated by a space


            // STATIC VS INSTANCE METHODS
            goTo = typeof(Answers);

            // How do static methods and fields differ from instance methods and fields?

            // How does syntax differ when invoking static and instance methods?

            // Look at the Ford class below
            var F12onFord = typeof(Ford);

            // Notice that 'Spray' is a static method while 'Drive' and '_color' are not
            // What reasoning can you give for this?

            // What is the difference between a returned value and a side effect?

            // What implications does this have when invoking a method of each type?

            // Which of the 'Ford' methods returns a value, and which one has only a side effect?

            // Instantiate a new car

            // Check what color your car is

            // Spray your car a new color

            // Check that your car is now a new color

            // Drive your car


            // ARRAY METHODS
            goTo = typeof(Answers);

            // Demonstrate the effect of each method either by debugging or logging to the console.

            // Use intellisense to show that 
            // - Length and Clone (among others) are instance methods   (array object [dot] ...)
            // - IndexOf, Contains, Count, Clear, LastIndexOf and Sort are static methods (Array [dot] ...)

            // Create an integer array with values for each element
            // - Already created in field

            // Declare a second variable and assign it to your original variable

            // Change the value of one of the elements in one of your arrays

            // Show that this has also changed your other array

            // Q. Explain why this has happened
            // A. Arrays are reference types


            // INSTANCE METHODS
            goTo = typeof(Answers);

            // Find the length of your array

            // Clone your array to a second variable

            // Change the value of one of the elements in one of your arrays

            // Show that this has not changed the other arrray


            // STATIC METHODS
            goTo = typeof(Answers);

            // Choose a random number and find the index of its first occurrence in your array

            // Sort your array from lowest to highest

            // Reverse your array

            // Use the 'Copy' method to copy your array to another array

            // Change the value of one of the elements in one of your arrays

            // Show that this has not changed the other arrray

            // Copy the middle 3 or 4 elements to another array

            // Clear the first half of your array


            // LISTS
            goTo = typeof(Answers);

            // Create an empty string list
            // - Already created in field

            // Think of a sentence with around 10 words

            // Add the first word to your list

            // Create a second list (or array) with the remaining words as each element

            // Log the length of your list

            // Select one of your words (preferably a repeated word)

            // Check that your list contains your selected word

            // Find the (first) index of your selected word

            // Find the last index of your selected word

            // Sort your list

            // Remove an element from an index of your choice

            // Clear your list


            // QUESTIONS BY MOSH

            // 1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
                // If no one likes your post, it doesn't display anything.
                // If only one person likes your post, it displays: [Friend's Name] likes your post.
                // If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
                // If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
                // Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

            // 2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

            // 3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //  4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.

            // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            var answers = new Answers();
            answers.Demonstrate(Exercise.ListClear);
        }
    }
}

enum Exercise
{
    SimpleArray,
    MultiDimensionalArray,
    JaggedArray,
    PublicVsStaticMethods,
    ArrayAsReferenceType,
    ArrayLength,
    ArrayClone,
    ArrayIndexOf,
    ArraySort,
    ArrayReverse,
    ArrayCopy,
    ArrayClear,
    ListAdd,
    ListAddRange,
    ListCount,
    ListContains,
    ListIndexOf,
    ListLastIndexOf,
    ListSort,
    ListRemoveAt,
    ListClear,
}

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

// Notice that 'Spray' is a static method while 'Drive' and '_color' are not
// What reasoning can you give for this?

// What is the difference between a returned value and a side effect?

// What implications does this have when invoking a method of each type?

// Which of the 'Ford' methods returns a value, and which one has only a side effect?

// Instantiate a new car

// Check what color your car is

// Spray your car a new color

// Check that your car is now a new color

// Drive your car

