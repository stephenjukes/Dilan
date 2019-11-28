using System;
using System.Linq;
using System.Collections.Generic;

namespace WeatherApp
{
    class Program
    {
        public static void MainMethod()
        {
            Weather TodaysWeather = new Weather(new Percentage(27.5), new Percentage(28), new Speed(37.5));
            TodaysWeather.DisplayWeather();
        }
    }
}