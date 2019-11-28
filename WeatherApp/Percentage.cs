using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public struct Percentage
    {

        public double WrittenValue { get; set; }

        public string FormattedValue
        {
            get => FormattedValue = $"{FormattedValue}%";

            set { if (FormattedValue.Equals(0 > 100))
                    FormattedValue = value;
                        else
                            throw new System.ArgumentException($"{FormattedValue} must be between 0% and 100%"); }
        }

        public Percentage(double writtenvalue)
        {
            WrittenValue = writtenvalue;
        }

    }
}
