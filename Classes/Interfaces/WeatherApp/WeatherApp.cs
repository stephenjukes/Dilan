using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces.WeatherApp
{
    class WeatherApp
    {
        private IUserInterface _userInterface { get; set; }

        public WeatherApp(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public void Run()
        {
            var weatherSummary = _userInterface.GetWeatherSummary();
            _userInterface.DisplayWeatherSummary(weatherSummary);
        }
    }
}
