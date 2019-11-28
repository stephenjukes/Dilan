using System;

namespace ControlFlow
{
    class Exercises
    {
        static void Main(string[] args)
        {
            // A. CONDITIONALS

            // 1. Create an algorithm that asks the user for his speed. If that speed exceeds 30, log 'Please slow down!'

            // 2. Extend the previous algorithm by logging 'Thank you for driving carefully' if the speed is equal or under 30

            // 3. Extend the previous algorithm further by loggin according to the following speeds:
            // 0 < s <= 30:     "Thank you for driving carefully"
            // 30 < s <= 40:    "Please slow down!"
            // 40 < s <= 50:    "Points removed"
            // s > 50:          "License revoked"

            // 4. What is the difference between using 'if, else if and else' as opposed to multiple 'if' statements?

            // 5. Create an algorithm that asks the user for a grade (A - E) and uses a switch statement to log according to the following grades:
            // A:                   "Congratulations!"
            // B, C & D:            "Could have done better."
            // E:                   "You're grounded"
            // (none of the above): (a suitable response)

            // 6. Create an algorithm that asks the user who he is. Use the ternary operator to log "I'm Batman" if the answer is "Batman", otherwise log "I don't know you".


            // (From C# Basics by Mosh)

            // Write a program and ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            // Write a program which takes two numbers from the console and displays the maximum of the two.

            // Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.


            // B. ITERATORS

            // 1. Create a string array with 6 or more elements, (this will be referred to as 'your array').

            // 2. Use a 'for' loop to log numbers 1 - 10 to the console.

            // 3.  Use a 'for' loop to log each element or your array to the console.

            // 4. Use a 'foreach' loop to log the elements of your array to the console.

            // 5. Have the computer generate a random target number between 0 and 10
            // Use a 'while' loop to have the computer guess random numbers until it matches the target

            // 6. Although each of the above loops can be used to solve any situation, each of them are beset suited to their own particular situation
            // For each of the three loops, describe what kind of situation is best suited for that particular loop.

            // 7. Use a 'while' loop to do the same as the 'for' loop in exercise B3.

            // 8. Use a 'for' loop to do the same as the 'while' loop in exercise B5.

            // 9a. How does a 'do while' loop differ from a standard 'while' loop?

            // b. Demonstrate the behaviour of each by logging 'element logged' for each element in your array
            // Now do the same for an empty array.

            // 10. Use 'continue' in a suitable loop to find all strings in your array that are of a length <defined by you>

            // 11. Use 'break' to in a suitable loop to find the first string in your array of a length <defined by you>


            // (From C# Basics by Mosh)

            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            // Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            // Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            // Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            // Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            var answers = new Answers();
            answers.Demonstrate(Iterators.Break);
        }
    }

    public enum Conditionals
    {
        If,
        IfElse,
        IfElseIfElse,
        IfElseVsMultipleIfs,
        Switch,
        TernaryOperator
    }

    public enum Iterators
    {
        For,
        ForThroughArray,
        ForEach,
        While,
        WhileUsedAsFor,
        ForUsedAsWhile,
        DoWhile,
        Continue,
        Break
    }
}
