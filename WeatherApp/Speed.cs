using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public struct Speed
    {
        public double WrittenValue { get; set; }

        public string FormattedValue
        {
            get => FormattedValue = $"{FormattedValue}mph";

            set { FormattedValue = value; }
        }

        public Speed(double writtenValue)
        {
            WrittenValue = writtenValue;
        }
    }
}
