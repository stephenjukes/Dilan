using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    public class Answers
    {
        // Declare 2 values
        int value1 = 10;
        int value2 = 20;
        bool isEqual;
        bool isNotEqual;
        bool isMoreThan;
        bool isLessThan;
        bool isMoreOrEqualTo;
        bool isLessOrEqualTo;

        public void Show(Section section)
        {
            Console.WriteLine($"Value1: {value1}");
            Console.WriteLine($"Value2: {value2}");
            Console.WriteLine();

            var sectionAnswers = typeof(Answers).GetMethod(section.ToString());
            sectionAnswers.Invoke(this, null);
        }

        public void ArithmeticOperators()
        {
            // Find answers when Adding, Subtracting, Multiplying and Dividing one value from the other
            Console.WriteLine("ARITHMETIC OPERATORS:");

            Console.WriteLine($"value1 + value2: {value1 + value2}");
            Console.WriteLine($"value1 - value2: {value1 - value2}");
            Console.WriteLine($"value1 * value2: {value1 * value2}");
            Console.WriteLine($"value1 / value2: { value1 / value2}");

            // Find the remainder after dividing one value by another
            Console.WriteLine($"value1 % value2: {value1 % value2}");
            Console.WriteLine();
        }

        public void AssignmentOperators()
        {
            // Increment value 1 using three types of notation
            Console.WriteLine("ASSIGNMENT OPERATORS:");

            Console.WriteLine($"value1 = value1 + 1: {value1 = value1 + 1}");
            Console.WriteLine($"value1 += 1: {value1 += 1}");
            Console.WriteLine($"value1++: {value1++}");

            Console.WriteLine($"value1 -= 1: {value1 -= 1}");

            Console.WriteLine($"value1 --: {--value1}");
            Console.WriteLine();

            // Assign value 1 to the product of itself (using the fewest characters possible)
            Console.WriteLine($"value1 *= value1: {value1 *= value1}");

            // Assign value 2 to itself divided by itself (using the fewest characters possible)
            Console.WriteLine($"value1 /= value1: {value1 /= value1}");
            Console.WriteLine();
        }

        public void ComparisonOperators()
        {
            // Compare value 1 with value 2 with six comparison operators. 
            // For each comparison, assign the result to a suitably descriptive variable name.
            Console.WriteLine("COMPARISON OPERATORS:");

            isEqual = value1 == value2;
            isNotEqual = value1 != value2;
            isMoreThan = value1 > value2;
            isLessThan = value1 < value2;
            isMoreOrEqualTo = value1 >= value2;
            isLessOrEqualTo = value1 <= value2;

            Console.WriteLine($"isEqual: {isEqual}");
            Console.WriteLine($"isNotEqual: {isNotEqual}");
            Console.WriteLine($"isMoreThan: {isMoreThan}");
            Console.WriteLine($"isLessThan: {isLessThan}");
            Console.WriteLine($"isMoreOrEqualTo: {isMoreOrEqualTo}");
            Console.WriteLine($"isLessOrEqualTo: {isLessOrEqualTo}");
            Console.WriteLine();   
        }

        public void LogicalOperators()
        {
            ComparisonOperators();
            Console.WriteLine("LOGICAL OPERATORS:");

            // Determine and prove if any of these comparisons are true
            Console.WriteLine($"Some Comparisons True: {isEqual || isNotEqual || isMoreThan || isLessThan || isMoreOrEqualTo || isLessOrEqualTo}");

            // Determine and provie if all of these comparisons are true
            Console.WriteLine($"All Comparisons True: {isEqual && isNotEqual && isMoreThan && isLessThan && isMoreOrEqualTo && isLessOrEqualTo}");

            Console.WriteLine();
        }

        public void PubChallenge()
        {
            // Declare variables: age, beerPrice, popPrice, money and freePopCoupon (what type should be associated with each?)
            // Respectively, assign them to: 17, 4.50, 3.50, 0 and 1
            var customer = new Customer
            {
                Age = 17,
                Money = 0m,
                FreePopCoupon = 1,
                VistitedPub = new Pub
                {
                    BeerPrice = 4.50m,
                    PopPrice = 3.50m
                }
            };

            Console.WriteLine("INITIAL CONDITIONS:");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"Money: {customer.Money}");
            Console.WriteLine($"FreePopCoupon: {customer.FreePopCoupon}");
            Console.WriteLine($"Price of beer: {customer.VistitedPub.BeerPrice}");
            Console.WriteLine($"Price of pop: {customer.VistitedPub.PopPrice}");
            Console.WriteLine();

            // Provide a statement to check whether a customer with these qualites can get a beer. (check this returns false)
            // - in method

            // Provide a statement to check whether a customer with these qualities can get a pop. (Check this returns true)
            // - in method

            // If you can, add each of these statements to a method which shows the customer's ability to buy beer and pop
            customer.DisplayPurchaseAbility();

            // The customer uses his coupon to get a pop. Decrement the coupon by one.
            Console.WriteLine("DECREMENTING COUPON:");
            customer.FreePopCoupon--;

            // Check that the customer cannot get another pop, (nor beer)
            customer.DisplayPurchaseAbility();

            // Increment the customer's money to £4.50
            Console.WriteLine("INCREMENTING MONEY TO £4.50:");
            customer.Money += 4.50m;

            // Check that the customer can now get another pop, but still can't get a beer
            customer.DisplayPurchaseAbility();

            // Increment the customer's age by 1
            Console.WriteLine("INCREMENTING AGE:");
            customer.Age++;

            // Check that the customer can now choose to get a beer as well as pop).
            customer.DisplayPurchaseAbility();
        }
    }
}
