using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATETIME

            // Have a look through the datetime class
            var toView = typeof(DateTime);

            // Q. Does it make sense for any of DateTime's static methods to be converted to an instance method? Explain your answer.
            // A. The only static method would make sense to be an instance method would be 'Compare', of the form dateTime.Compare(anotherDateTime)
            //    All other static methods return a value that is related to a condition completely that has nothing to do with an DateTime instance.

            // Q. How many constructors does the DateTime class have?
            // A. 11

            // Choose 3 to construct a datetime with each

            // Try to approximate today's date as best you can using ticks

            // Use the simplest way to create the current date

            // Use the simplest way to create the current time and date. Assign it to the variable now1.

            // Use one of your created dates to find ...

            // the day of the week

            // the day of the year 

            // the number of days in this month

            // the number of days in Feburary

            // whether this year is a leap year

            // find a year with the opposite result

            // the DateTime for the next day

            // the DateTime for the previous year

            // Display a list of all possible DateTime formats

            // Display a list of DateTime formats that show time and date in full
            // use https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings?view=netframework-4.8

            // Convert this DateTime to string

            // Create your own date and time as a string and convert this to a DateTime


            // TIMESPAN

            // How many constructors does the DateTime class have?

            // Choose 3 to construct a timespan with each

            // How else can timespans be created?

            // Create a timespan of 23 hours, 59 minutes and 59 seconds without instantiating with the keyword 'new'

            // Find the minutes component of this timespan (you should already know this)

            // Find the total number of minutes in this timespan

            // Add a day to this timespan

            // Subtract a minute from this timespan

            // Do the same with the operation overloads (+ -)

            // Convert your timespan to a string

            // Take two of the timespans you have already created
            // Show that they are not equal




            // USING DATETIME AND TIMESPAN TOGETHER

            // Find the current time and date and assign it to the variable now2.

            // Show that now2 is not equal to the variable now1.

            // Show that now2 is greater than the variable now1.

            // Find the time that has elapsed between assigning to now1 and now2

            // Add a timespan of one month to the DateTime now1.

            // Subtract a timespan of one month from the DateTime now2.

            // Show that now2 is now less than now1

            var answers = new Answers();
            answers.Demonstrate(Section.DifferenceBetween2DateTimes);
        }
    }

    enum Section
    {
        DateTimeCreation,
        DateTimeProperties,
        DateTimeMethods,
        DateTimeFormats,
        DateTimeConvertingToAndFromString,
        TimeSpanCreation,
        TimeSpanProperties,
        TimeSpanMethods,
        DifferenceBetween2DateTimes

    }

}
