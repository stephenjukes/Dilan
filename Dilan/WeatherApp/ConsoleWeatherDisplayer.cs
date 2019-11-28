using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.WeatherApp
{
    class ConsoleWeatherDisplayer
    {
        public void DisplayWeather(Percentage humidity, Speed wind, Percentage precipitation)
        {
            var output =
                $"Today we have Weather with a Humidity level of {humidity.FormattedValue}, " +
                $"Wind Speeds of {wind.FormattedValue} " +
                $"and a Precipitation of {precipitation.FormattedValue}";

            Console.WriteLine(output);
        }
    }
}
