using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    class Weather
    {
        public Percentage Precipitation { get; set; }
        public Percentage Humidity { get; set; }
        public Speed Wind { get; set; }
        
        public Weather(Percentage precipitation, Percentage humidity, Speed wind)
        {
            Precipitation = precipitation;
            Humidity = humidity;
            Wind = wind;
        }

        public void DisplayWeather()
        {
            var output = 
                $"Today we have Weather with a Humidity level of {Humidity.FormattedValue}, " +
                $"Wind Speeds of {Wind.FormattedValue} " +
                $"and a Precipitation of {Precipitation}";

            Console.WriteLine(output);
        }
    }
}
