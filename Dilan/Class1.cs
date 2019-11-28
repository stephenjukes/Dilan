using System;
using System.Linq;


namespace Dilan
{
    class Class1
    {
        // Types
        // Operators
        // Control Flow
        // Classes
        // Scope
        // Collections
        // Dates And Times

        static void MainMethod(string[] args)
        {
            // Note how you can split out each exercise into their own method, (actually, I saw you did do something like this).
            // You can comment out any excercise calls that you don't want to make.
            Greet();
            Quiz();
            Funcs();
        }

        // GREET

        private static void Greet()
        {
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            // Note the easiest syntax to mix strings and variables.
            Console.WriteLine($"Hello {userName}");
        }

        // QUIZ

        private static void Quiz()
        {
            // One best practice is to keep your code DRY, (ie: Do Not Repeat yourself).
            // Notice how you can put each conntry into an array and ask about each one in a loop.
            var countries = new string[] { "Italy", "France", "Japan", "Russia", "America" };
            var answerArray = new string[] { "rome", "paris", "tokyo", "moscow", "new york" };

            // The counter would be the more obvious way to keep a count of score
            // However, this array would keep track of which answers were correct, which the counter could not.
            bool[] correctAnswers = new bool[5];

            Console.WriteLine("Hello, this is a Quiz to test your knowledge on Capital Cities all around the world");

            // Can you see how this asks questions in the same way as your original code?
            for (var i = 0; i < countries.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: What is the capital city of {countries[i]}");
                var response = Console.ReadLine().ToLower();

                correctAnswers[i] = response == answerArray[i];
            }

            // This is your Linq expression. (You will need to import it at the top)
            // Now you know what a lambda expression is (see below), see how it is used as an argument to the 'Where' method
            var score = correctAnswers.Where(answer => answer == true);

            // The \n inside a string means line break
            Console.WriteLine($"\nYour score is: {score.Count()}\n");
        }

        // FUNCS

        private static void Funcs()
        {
            // Funcs are just methods
            // This func 'myFunc' has been assigned to the method 'Add' (lower down)
            // The last generic parameter is the Func's return value, the previous generic parameters are the arguments
            // (the first 2 'ints' represent Add's arguments 'a' and 'b', the last 'int' is the returned sum int)
            Func<int, int, int> myFunc = Add;

            // Methods can be used as arguments to other methods
            // This 'Add' method is used as an argument to the 'MyLogger' method. 
            // Note you don't call it or add arguments here.
            MyLogger(Add);

            // Methods can also be used as an argument in the form of a lambda function
            // This lambda function does the same as the 'Add' method below
            MyLogger((a, b) => a + b);
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        // Funcs are just methods that are passed as a parameter to other methods.
        private static void MyLogger(Func<int, int, int> myParameterFunc)
        {
            // This is where arguments are added to the func
            var sum = myParameterFunc(5, 5);
            Console.WriteLine(sum);
        }
    }
}
