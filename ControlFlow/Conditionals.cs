//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ControlFlow
//{
//    class Conditionals
//    {
//        int speed;
//        string grade;

//        public void MainMethod()
//        {
            
//        }

//        private void If()
//        {
//            GetSpeed();

//            if (speed > 30)
//            {
//                Console.WriteLine("Please slow down!");
//            }
//        }

//        private void IfElse()
//        {
//            GetSpeed();

//            if (speed > 30)
//            {
//                Console.WriteLine("Please slow down!");
//            }
//            else
//            {
//                Console.WriteLine("Thank you for driving carefully.");
//            }
//        }

//        private void IfElseIfElse()
//        {
//            GetSpeed();

//            if (speed < 30)
//            {
//                Console.WriteLine("Thank you for driving carefully");
//            }
//            else if (speed < 40)
//            {
//                Console.WriteLine("Please slow down!");
//            }
//            else if (speed < 50)
//            {
//                Console.WriteLine("Points removed");
//            }
//            else
//            {
//                Console.WriteLine("License revoked.");
//            }
//        }

//        private void IfElseVsMultipleIfs()
//        {
//            GetSpeed();

//            if (speed < 30)
//            {
//                Console.WriteLine("Thank you for driving carefully");
//            }

//            if (speed < 40)
//            {
//                Console.WriteLine("Please slow down!");
//            }

//            if (speed < 50)
//            {
//                Console.WriteLine("Points removed");
//            }
            
//            if (speed >= 50)
//            {
//                Console.WriteLine("License revoked.");
//            }
//        }

//        private void Switch()
//        {
//            GetGrade();

//            switch(grade)
//            {
//                case "A":
//                    Console.WriteLine("Congratulations!");
//                    break;
//                case "B":
//                case "C":
//                case "D":
//                    Console.WriteLine("Could have done better");
//                    break;
//                case "E":
//                    Console.WriteLine("You're grounded!");
//                    break;
//                default:
//                    Console.WriteLine("I had asked you what your grade was");
//                    break;
//            }
//        }

//        private void TernaryOperator()
//        {
//            Console.WriteLine("Who are you?");
//            var identity = Console.ReadLine().ToLower();

//            var response = identity == "batman" ? "I'm batman!" : "I don't know you.";
//            Console.WriteLine(response);

//            // The ternary operator returns a value which must be handled by assignment or being returned.
//            // The following will not compile:
//            // identity == "batman" ? Console.WriteLine("I'm batman") : Console.WriteLine("I don't know you");
//        }

//        private void GetSpeed()
//        {
//            Console.WriteLine("What is your speed?");
//            speed = Convert.ToInt16(Console.ReadLine());
//        }

//        private void GetGrade()
//        {
//            Console.WriteLine("What was your grade, (A - E)");
//            grade = Console.ReadLine().ToUpper();
//        }
//    }
//}
