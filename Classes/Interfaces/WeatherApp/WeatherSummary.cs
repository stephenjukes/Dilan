using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces.WeatherApp
{
    class WeatherSummary
    {
        public int Temperature { get; set; }
        public int WindSpeed { get; set; }
        public int ChanceOfRain { get; set; }
        public string Description { get; set; }
    }
}
