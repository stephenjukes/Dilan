//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ControlFlow
//{
//    class Iterators
//    {
//        Random randomGenerator = new Random();
//        string[] theFox = new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

//        public void MainMethod()
//        {
//            Break();
//        }

//        public void For()
//        {
//            for (var i = 0; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }

//        public void ThroughArrayWithFor()
//        {
//            for (var i = 0; i < theFox.Length; i++)
//            {
//                Console.WriteLine(theFox[i]);
//            }
//        }

//        public void ForEach()
//        {
//            foreach (var word in theFox)
//            {
//                Console.WriteLine(word);
//            }
//        }

//        public void While()
//        {
//            var target = randomGenerator.Next(0, 10);
//            int trial = 100;

//            Console.WriteLine($"Target = {target}");
//            Console.WriteLine("\nTrials:\n");

//            while (trial != target)
//            {
//                trial = randomGenerator.Next(0, 10);
//                Console.WriteLine(trial);
//            }

//            Console.WriteLine("\nTarget reached!\n");
//        }

//        public void WhileUsedAsFor()
//        {
//            var i = 0;
//            var maximum = 10;

//            while(i <= maximum)
//            {
//                Console.WriteLine(i);
//                i++;
//            }
//        }

//        public void ForUsedAsWhile()
//        {
//            var target = randomGenerator.Next(0, 10);
//            int trial = 100;

//            Console.WriteLine($"Target = {target}");
//            Console.WriteLine("\nTrials:\n");

//            for (trial = 100; trial != target; trial = randomGenerator.Next(0, 10))
//            {
//                Console.WriteLine(trial);
//            }

//            Console.WriteLine(trial);   // required since the corret trial will not be logged
//            Console.WriteLine("\nTarget reached!\n");
//        }

//        public void DoWhile()
//        {
//            var array = new string[0];
//            int i;

//            // Normal While

//            Console.WriteLine("Normal While:");

//            i = 0;
//            while (i < array.Length)
//            {
//                Console.WriteLine($"{i}: Logging");
//                i++;
//            }
//            Console.WriteLine("Normal While Finished\n");

//            // Do While

//            Console.WriteLine("Do While:");

//            i = 0;
//            do
//            {
//                Console.WriteLine($"{i}: Logging regardless");
//                i++;
//            } while (i < array.Length);

//            Console.WriteLine("Do While Finished\n");
//        }

//        public void Continue()
//        {
//            var targetLength = 3;
//            foreach (var word in theFox)
//            {
//                if (word.Length != targetLength) continue;

//                Console.WriteLine(word);
//            }   
//        }

//        public void Break()
//        {
//            // Finds the first even number
//            var targetLength = 3;
//            for (var i = 0; i < theFox.Length; i++)
//            {
//                var word = theFox[i];
//                if (word.Length == targetLength)
//                {
//                    Console.WriteLine(word);
//                    break;
//                }
//            }
//        }
//    }
//} 
