using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Classes.Interfaces.WeatherApp.InputOutput
{
    class FileUserInterface : IUserInterface
    {
        private string _inputFilePath;

        public FileUserInterface(string inputFilePath)
        {
            _inputFilePath = inputFilePath;
        }

        public WeatherSummary GetWeatherSummary()
        {
            var fileContent = File.ReadAllText(_inputFilePath);

            var temperature = new Regex(@"temperature.+?(\d+)", RegexOptions.IgnoreCase).Match(fileContent).Groups[1].Value;
            var windSpeed = new Regex(@"wind\s?speed.+?(\d+)", RegexOptions.IgnoreCase).Match(fileContent).Groups[1].Value;
            var chanceOfRain = new Regex(@"(\d+)%", RegexOptions.IgnoreCase).Match(fileContent).Groups[1].Value;

            return new WeatherSummary
            {
                Temperature = int.Parse(temperature),
                WindSpeed = int.Parse(windSpeed),
                ChanceOfRain = int.Parse(chanceOfRain)
            };
        }

        private string GetMatch(string regex)
        {
            return new Regex(@"").ToString();
        }

        public void DisplayWeatherSummary(WeatherSummary weatherSummary)
        {
            var inputFilePathParts = _inputFilePath.Split('/');
            var outputFilePathParts = inputFilePathParts.Take(inputFilePathParts.Length - 1);
            var outputFilePath = String.Join('/', outputFilePathParts) + "/WeatherOutput.txt";

            using (File.Create(outputFilePath)) { };
            File.AppendAllLines(outputFilePath, new string[]
                {
                    "Weather Summary:\n",
                    $"Temperature: {weatherSummary.Temperature}",
                    $"Wind speed: {weatherSummary.WindSpeed}",
                    $"Chance of rain: {weatherSummary.ChanceOfRain}"
                });
        }
    }
}
