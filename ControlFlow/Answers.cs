using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow
{
    class Answers
    {
        int speed;
        string grade;

        Random randomGenerator = new Random();
        string[] yourArray = new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

        public void Demonstrate(Conditionals section) => Demonstrate(section.ToString());
        public void Demonstrate(Iterators section) => Demonstrate(section.ToString());

           

        private void Demonstrate(string section)
        {
            var method = typeof(Answers).GetMethod(section);

            Console.WriteLine($"{method.Name}:\n");
            method.Invoke(this, null);

            Console.WriteLine();
        }

        // A. CONDITIONALS

        // 1. Create an algorithm that asks the user for his speed. If that speed exceeds 30, log 'Please slow down!'
        public void If()
        {
            GetSpeed();

            if (speed > 30)
            {
                Console.WriteLine("Please slow down!");
            }
        }

        // 2. Extend the previous algorithm by logging 'Thank you for driving carefully' if the speed is equal or under 30
        public void IfElse()
        {
            GetSpeed();

            if (speed > 30)
            {
                Console.WriteLine("Please slow down!");
            }
            else
            {
                Console.WriteLine("Thank you for driving carefully.");
            }
        }

        // 3. Extend the previous algorithm further by loggin according to the following speeds:
        // 0 < s <= 30:     "Thank you for driving carefully"
        // 30 < s <= 40:    "Please slow down!"
        // 40 < s <= 50:    "Points removed"
        // s > 50:          "License revoked"
        public void IfElseIfElse()
        {
            GetSpeed();

            if (speed < 30)
            {
                Console.WriteLine("Thank you for driving carefully");
            }
            else if (speed < 40)
            {
                Console.WriteLine("Please slow down!");
            }
            else if (speed < 50)
            {
                Console.WriteLine("Points removed");
            }
            else
            {
                Console.WriteLine("License revoked.");
            }
        }

        // 4. What is the difference between using 'if, else if and else' as opposed to multiple 'if' statements?
        public void IfElseVsMultipleIfs()
        {
            GetSpeed();

            if (speed < 30)
            {
                Console.WriteLine("Thank you for driving carefully");
            }

            if (speed < 40)
            {
                Console.WriteLine("Please slow down!");
            }

            if (speed < 50)
            {
                Console.WriteLine("Points removed");
            }

            if (speed >= 50)
            {
                Console.WriteLine("License revoked.");
            }
        }

        // 5. Create an algorithm that asks the user for a grade (A - E) and uses a switch statement to log according to the following grades:
        // A:                   "Congratulations!"
        // B, C & D:            "Could have done better."
        // E:                   "You're grounded"
        // (none of the above): (a suitable response)
        public void Switch()
        {
            GetGrade();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Congratulations!");
                    break;
                case "B":
                case "C":
                case "D":
                    Console.WriteLine("Could have done better");
                    break;
                case "E":
                    Console.WriteLine("You're grounded!");
                    break;
                default:
                    Console.WriteLine("I had asked you what your grade was");
                    break;
            }
        }

        // 6. Create an algorithm that asks the user who he is. Use the ternary operator to log "I'm Batman" if the answer is "Batman", otherwise log "I don't know you".
        public void TernaryOperator()
        {
            Console.WriteLine("Who are you?");
            var identity = Console.ReadLine().ToLower();

            var response = identity == "batman" ? "I'm batman!" : "I don't know you.";
            Console.WriteLine(response);

            // The ternary operator returns a value which must be handled by assignment or being returned.
            // The following will not compile:
            // identity == "batman" ? Console.WriteLine("I'm batman") : Console.WriteLine("I don't know you");
        }

        // B. ITERATORS

        // 1. Create a string array with 6 or more elements, (this will be referred to as 'your array').
        // - declared as field above

        // 2. Use a 'for' loop to log numbers 1 - 10 to the console.
        public void For()
        {
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 3.  Use a 'for' loop to log each element or your array to the console.
        public void ForThroughArray()
        {
            Display(yourArray);

            for (var i = 0; i < yourArray.Length; i++)
            {
                Console.WriteLine(yourArray[i]);
            }
        }

        // 4. Use a 'foreach' loop to log the elements of your array to the console.
        public void ForEach()
        {
            Display(yourArray);

            foreach (var word in yourArray)
            {
                Console.WriteLine(word);
            }
        }

        // 5. Have the computer generate a random target number between 0 and 10
        // Use a 'while' loop to have the computer guess random numbers until it matches the target
        public void While()
        {
            var target = randomGenerator.Next(0, 10);
            int trial = 100;

            Console.WriteLine($"Target = {target}");
            Console.WriteLine("\nTrials:\n");

            while (trial != target)
            {
                trial = randomGenerator.Next(0, 10);
                Console.WriteLine(trial);
            }

            Console.WriteLine("\nTarget reached!\n");
        }

        // Q6. Although each of the above loops can be used to solve any situation, each of them are beset suited to their own particular situation
        // For each of the three loops, describe what kind of situation is best suited for that particular loop.
        // A. 
        // FOREACH  - iterates over all elements of an enumerable
        // FOR      - iterates over consectuive integers where the number of iterations is known
        // WHILE    - continues to do something where the number of iterations is unknown

        // 7. Use a 'while' loop to do the same as the 'for' loop in exercise B3.
        public void WhileUsedAsFor()
        {
            var i = 0;
            var maximum = 10;

            while (i <= maximum)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // 8. Use a 'for' loop to do the same as the 'while' loop in exercise B5.
        public void ForUsedAsWhile()
        {
            var target = randomGenerator.Next(0, 10);
            int trial = 100;

            Console.WriteLine($"Target = {target}");
            Console.WriteLine("\nTrials:\n");

            for (trial = 100; trial != target; trial = randomGenerator.Next(0, 10))
            {
                Console.WriteLine(trial);
            }

            Console.WriteLine(trial);   // required since the corret trial will not be logged
            Console.WriteLine("\nTarget reached!\n");
        }

        // Q. 9a. How does a 'do while' loop differ from a standard 'while' loop?
        // A. A 'do while' loop will always loop through the block once, even if its 'while' condition is false.

        // b. Demonstrate the behaviour of each by logging 'element logged' for each element in your array
        // Now do the same for an empty array.
        public void DoWhile()
        {
            var array = new string[0];
            int i;

            Console.WriteLine($"Array:\n[{string.Join(", ", array)}]\n");

            // Normal While

            Console.WriteLine("Normal While:");

            i = 0;
            while (i < array.Length)
            {
                Console.WriteLine($"{i}: Logging");
                i++;
            }
            Console.WriteLine("Normal While Finished\n");

            // Do While

            Console.WriteLine("Do While:");

            i = 0;
            do
            {
                Console.WriteLine($"{i}: Logging regardless");
                i++;
            } while (i < array.Length);

            Console.WriteLine("Do While Finished\n");
        }

        // 10. Use 'continue' in a suitable loop to find all strings in your array that are of a length <defined by you>
        public void Continue()
        {
            Display(yourArray);

            var targetLength = 3;
            foreach (var word in yourArray)
            {
                if (word.Length != targetLength) continue;

                Console.WriteLine(word);
            }
        }

        // 11. Use 'break' to in a suitable loop to find the first string in your array of a length <defined by you>
        public void Break()
        {
            Display(yourArray);

            var targetLength = 3;
            for (var i = 0; i < yourArray.Length; i++)
            {
                var word = yourArray[i];
                if (word.Length == targetLength)
                {
                    Console.WriteLine(word);
                    break;
                }
            }
        }

        private void GetSpeed()
        {
            Console.WriteLine("What is your speed?");
            speed = Convert.ToInt16(Console.ReadLine());
        }

        private void GetGrade()
        {
            Console.WriteLine("What was your grade, (A - E)");
            grade = Console.ReadLine().ToUpper();
        }

        private void Display(string[] yourArray)
        {
            Console.WriteLine($"Your Array:");
            Console.WriteLine(string.Join(", ", yourArray));
            Console.WriteLine();
        }
    }


}
