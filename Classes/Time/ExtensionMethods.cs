using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Time
{
    public static class ExtensionMethods
    {
        public static string Pad(this int n)
            => n.ToString().PadLeft(2, '0');


        public static int ToHour(this int minutes)
            => (minutes / 60) % 24;

        public static int ToMinute(this int minutes)
            => minutes % 60;

        //public static Time ToTime (this int minutesSinceMidnight)
        //{
        //    var hh = minutesSinceMidnight.ToHour();
        //    var mm = minutesSinceMidnight.ToMinute();

        //    return new Time(hh, mm);
        //}

        //public static int ToMinutesPastMidnight (this Time time)
        //    => time.Hour * 60 + time.Minute;
    }
}
