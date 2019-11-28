using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Device_Plugging
{
    class WashingMachine : IDevice
    {
        public int WashDuration { get; set; }
        public int WashTemp { get; set; }

        public WashingMachine(int washDuration, int washTemp)
        {
            WashDuration = washDuration;
            WashTemp = washTemp;
        }
        public void PowerOn()
        {
            Console.WriteLine($"The Clothes have been Washed for {WashDuration}, and at a temperature of {WashTemp}");
        }
    }
}
