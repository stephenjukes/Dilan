using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces.WeatherApp
{
    class ConsoleUserInterface : IUserInterface
    {
        public WeatherSummary GetWeatherSummary()
        {
            Console.WriteLine("Collecting today's weather data:\n");

            var description = GetWeatherData("Description");
            var temperature = int.Parse(GetWeatherData("Temperature"));
            var chanceOfRain = int.Parse(GetWeatherData("Chance of rain"));
            var windSpeed = int.Parse(GetWeatherData("Wind speed"));
            Console.WriteLine("\n");

            return new WeatherSummary
            {
                Description = description,
                Temperature = temperature,
                ChanceOfRain = chanceOfRain,
                WindSpeed = windSpeed
            };
        }

        private string GetWeatherData(string data)
        {
            Console.Write($"{data}: ");
            return Console.ReadLine();
        }

        public void DisplayWeatherSummary(WeatherSummary weatherSummary)
        {
            Console.WriteLine("Today's Weather:\n");

            foreach(var prop in typeof(WeatherSummary).GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(weatherSummary)}");
            }
        }
    }
}
