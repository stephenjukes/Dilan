using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces.WeatherApp
{
    interface IUserInterface
    {
        WeatherSummary GetWeatherSummary();
        void DisplayWeatherSummary(WeatherSummary weatherSummary);
    }
}
