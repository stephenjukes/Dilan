using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DatesAndTimes
{
    class Answers
    {
        DateTime now1 = DateTime.Now;
        TimeSpan timeSpan = new TimeSpan(23, 59, 59);

        public void Demonstrate(Section section)
            => typeof(Answers).GetMethod(section.ToString()).Invoke(this, null);


        // DATETIME

        // Have a look through the datetime class
        DateTime datetime;

        // Q. Does it make sense for any of DateTime's static methods to be converted to an instance method? Explain your answer.
        // A. The only static method would make sense to be an instance method would be 'Compare', of the form dateTime.Compare(anotherDateTime)
        //    All other static methods return a value that is related to a condition completely that has nothing to do with an DateTime instance.

        // Q. How many constructors does the DateTime class have?
        // A. 11

        public void DateTimeCreation()
        {
            // Choose 2 to construct a datetime with each
            var date = new DateTime(2019, 04, 28);
            var dateAndTime = new DateTime(2019, 4, 28, 19, 29, 30);

            Display("Date:", date);
            Display("Date and Time:", dateAndTime);


            // Try to approximate today's date as best you can using ticks
            var ticks = 636929999999999999;
            var dateFromTicks = new DateTime(ticks);
            var localDateFromTicks = new DateTime(ticks, DateTimeKind.Local);

            Display("DateTime from Ticks:", dateFromTicks);
            Display("Local DateTimeKind:", localDateFromTicks);

            // Use the simplest way to create the current date
            var today = DateTime.Today;
            Display("Today:", today);

            // Use the simplest way to create the current time and date. Assign it to the variable now1.
            var now = DateTime.Now;
            Display("Now:", now);
        }

        public void DateTimeProperties()
        {
            // Use one of your created dates to find ...
            DisplayTitle("Using the DateTime:", now1);

            // the month component
            var monthComponent = now1.Month;
            Display("Month Component:", monthComponent);

            // the minute component
            var minuteComponent = now1.Minute;
            Display("Minute Component:", minuteComponent);

            // the day of the week
            var dayOfWeek = now1.DayOfWeek;
            Display("Day of Week:", dayOfWeek);

            // the day of the year 
            var dayOfYear = now1.DayOfYear;
            Display("Day of Year:", dayOfYear);
        }

        public void DateTimeMethods()
        {
            DisplayTitle("Using the DateTime:", now1);

            // the number of days for this month
            var daysThisMonth = DateTime.DaysInMonth(now1.Year, now1.Month);
            Display("Days this Month:", daysThisMonth);

            // whether this year is a leap year
            var isLeapYear = DateTime.IsLeapYear(now1.Year);
            Display("Leap Year?", isLeapYear);

            // find a year with the opposite result
            var is2020LeapYear = DateTime.IsLeapYear(2020);
            Display("2020 Leap Year?:", is2020LeapYear);

            // the DateTime for the next day at the same time
            var nextDay = now1.AddDays(1);
            Display("Next Day:", nextDay);

            // the DateTime for the previous year at the same time
            var lastYear = now1.AddYears(-1);
            Display("Last Year:", lastYear);
        }

        public void DateTimeFormats()
        {
            // Display a list of all possible DateTime formats
            var dateTimeFormats = now1.GetDateTimeFormats();
            DisplayEnumerable("DateTime Formats:", dateTimeFormats);

            // Display a list of DateTime formats that show time and date in full
            // use https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings?view=netframework-4.8
            var fullDateFormats = now1.GetDateTimeFormats('F');
            DisplayEnumerable("FullDate Formats", fullDateFormats);
        }

        public void DateTimeConvertingToAndFromString()
        {
            // Convert this DateTime to string
            var dateTimeToString = now1.ToString();
            Display($"DateTime as {dateTimeToString.GetType()}:", dateTimeToString);

            // Create your own date and time as a string and convert this to a DateTime
            var dateTimeFromString = DateTime.Parse("28-4-2019 20:06:03");
            Display($"String as {dateTimeFromString.GetType()}:", dateTimeFromString);
        }


        // TIMESPAN
        TimeSpan timespan;

        // How many constructors does the Timespan class have?

        public void TimeSpanCreation()
        {
            // Choose 3 to construct a timespan with each
            var ticks = new TimeSpan(99999999999);
            var hours = new TimeSpan(23, 59, 59);
            var days = new TimeSpan(6, 23, 59, 59);

            Display("From Ticks:", ticks);
            Display("Up to Hours:", hours);
            Display("Up to Days:", days);

            // How else can timespans be created?
            // Create a timespan of 23 hours, 59 minutes and 59 seconds without instantiating with the keyword 'new'
            var day = TimeSpan.FromDays(1);
            var second = TimeSpan.FromSeconds(1);
            var answer = day - second;

            Display("TimeSpan without using 'new'", answer);
        }

        public void TimeSpanProperties()
        {
            DisplayTitle($"Using TimeSpan:", timeSpan);

            // Find the minutes component of this timespan (you should already know this)
            var minuteComponent = timeSpan.Minutes;
            Display("Minute Component:", minuteComponent);

            // Find the 'total' number of minutes in this timespan
            var totalMinutes = timeSpan.TotalMinutes;
            Display("Total Minutes:", totalMinutes);
        }

        public void TimeSpanMethods()
        {
            DisplayTitle($"Using TimeSpan:", timeSpan);
            // (also featuring)
            var ticks = new TimeSpan(99999999999);
            var hours = new TimeSpan(23, 59, 59);

            // Add a day to this timespan
            var day = TimeSpan.FromDays(1);
            var nextDay = timeSpan.Add(day);

            Display("Next Day:", nextDay);

            // Subtract a minute from this timespan
            var minute = TimeSpan.FromMinutes(1);
            var lastMinute = timeSpan.Subtract(minute);

            Display("Previous Minute:", lastMinute);

            // Do the same with the operation overloads (+ -)
            var nextDayWithOperationOverload = timeSpan + day;
            Display("Next Day (with operation overload", nextDayWithOperationOverload);

            var previouMinuteWithOperationOverload = timeSpan - minute;
            Display("Previous minute (with operation overload)", previouMinuteWithOperationOverload);

            // Convert your timespan to a string
            var timespanToString = ticks.ToString();
            Display($"TimeSpan as {timespanToString.GetType()}:", timespanToString);

            // Convert a timespan as a string and convert to a TimeSpan
            var timespanFromString = TimeSpan.Parse("1.2:3:4");
            Display($"String as {timespanFromString.GetType()}:", timespanFromString);

            // Take two of the timespans you have already created
            // Show that they are not equal
            DisplayTitle($"Using TimeSpans:\n{ticks}\n{hours}", "");

            var isEqual = ticks == hours;
            Display("TimeSpans are equal:", isEqual);
        }


        // THE DIFFERENCE BETWEEN 2 DATETIMES
        public void DifferenceBetween2DateTimes()
        {
            // Assign the current time to the variable now1
            var now1 = DateTime.Now;

            // Create a DateTime a minute later
            var now2 = now1.AddMinutes(1);
            DisplayTitle($"now1:\n{now1}\n\nnow2:\n{now2}", "");

            // Show that now2 is not equal to the variable now1.
            var isEqual = now1 == now2;
            Display("DateTimes are equal?", isEqual);

            // Show that now2 is greater than the variable now1.
            var isNow2Greater = now2 > now1;
            Display("now2 is greater", isNow2Greater);

            // Find the time that has elapsed between assigning to now1 and now2
            var timeDifference = now2 - now1;
            Display("Time Difference", timeDifference);

            // Push now1 ahead 40 seconds
            now1 += TimeSpan.FromSeconds(40);
            Display("now1 + 30 seconds", now1);

            // Subtract a timespan of one month from the DateTime now2.
            now2 -= TimeSpan.FromSeconds(40);
            Display("now2 - 30 seconds", now2);

            // Show that now2 is now less than now1
            isNow2Greater = now2 > now1;
            Display("now2 is greater", isNow2Greater);
        }


        private void DisplayEnumerable<T>(string description, IEnumerable<T> enumerable)
        {
            Console.WriteLine($"### {description}\n");

            foreach(var item in enumerable)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        private void Display<T>(string description, T result, bool addLine = true)
        {
            Console.WriteLine($"{description}\n{result}");
            if (addLine) Console.WriteLine();
        }

        private void DisplayTitle<T>(string title, T result)
        {
            var delimiter = "---------------------------";

            Console.WriteLine(delimiter);
            Display(title, result, false);
            Console.WriteLine(delimiter);
            Console.WriteLine();
        }
    }
}
