using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces
{
    public static class InterfaceProgram
    {
        public static void MainMethod()
        {
            var socket = new ThreePinSocket();
            var vacuumCleaner = new VacuumCleaner();
            var radio = new Radio();

            socket.PlugIn(vacuumCleaner);
            socket.PowerOn();
            socket.Unplug();

            socket.PlugIn(radio);
            socket.PowerOn();

        }
    }
}
