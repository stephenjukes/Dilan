using Classes.Interfaces.WeatherApp.InputOutput;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces.WeatherApp
{
    class WeatherProgram
    {
        public static void MainMethod()
        {
            var consoleUserInterface = new ConsoleUserInterface();
            var fileUserInterface = new FileUserInterface(
                @"C:/Users/Stephen/source/repos/Dilan/Classes/Interfaces/WeatherApp/InputOutput/WeatherInput.txt");

            var app = new WeatherApp(consoleUserInterface);

            app.Run();
        }
    }
}
