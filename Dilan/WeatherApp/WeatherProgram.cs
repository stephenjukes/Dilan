using System;
using System.Linq;
using System.Collections.Generic;

namespace Dilan
{
    class WeatherProgram
    {
        public static void MainMethod()
        {
            Weather todaysWeather = new Weather(new Percentage("27.5"), new Percentage("28"), new Speed("37.5"));
            todaysWeather.ConsoleOutput();
        }
    }
}