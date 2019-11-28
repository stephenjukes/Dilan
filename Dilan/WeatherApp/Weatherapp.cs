using Dilan.WeatherApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    class Weather
    {
        private ConsoleWeatherDisplayer consoleOutput = new ConsoleWeatherDisplayer();
        public Percentage Precipitation { get; set; }
        public Percentage Humidity { get; set; }
        public Speed Wind { get; set; }

        public Weather(Percentage precipitation, Percentage humidity, Speed wind)
        {
            Precipitation = precipitation;
            Humidity = humidity;
            Wind = wind;
        }

        public void ConsoleOutput()
        {
            consoleOutput.DisplayWeather(Humidity , Wind, Precipitation);
        }
    }
}
