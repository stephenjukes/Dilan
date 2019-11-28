using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Time
{
    public class Time
    {
        private int _minutes;
        public int Hour { get; }
        public int Minute { get; }

        public Time(int hh, int mm)
        {
            _minutes = hh * 60 + mm;
            Hour = hh;
            Minute = mm;        
        }

        public Time(int minutes)
        {
            _minutes = minutes;
            Hour = minutes.ToHour();
            Minute = minutes.ToMinute();         
        }

        public override string ToString()
        {
            return $"{Hour.Pad()}:{Minute.Pad()}";
        }

        public static Time operator +(Time a, Time b)
        {
            return new Time(a._minutes + b._minutes);
        }

        public static Time operator -(Time a, Time b)
        {
            var totalMinutes = a._minutes - b._minutes;
            var hh = ((totalMinutes / 60) % 24 + 24 - (totalMinutes > 0 ? 0 : 1)) % 24;
            var mm = (totalMinutes % 60 + 60) % 60;

            return new Time(hh, mm);
        }

        public static implicit operator Time(int minutesSinceMidnight)
        {
            return new Time(minutesSinceMidnight);
        }

        public static explicit operator int(Time time)
        {
            return time._minutes;
        }


    }
}
