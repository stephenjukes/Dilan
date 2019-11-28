using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces
{
    class ThreePinSocket
    {
        private ThreePinPlugDevice _device;

        public void PlugIn(ThreePinPlugDevice device)
        {
            if(_device == null)
            {
                _device = device;
                Console.WriteLine($"{device.Name()} plugged in.");
            }
            else
            {
                Console.WriteLine($"Unable to plug {device.Name()} in, {_device.Name()} already plugged in.");
            }
        }

        public void Unplug()
        {
            if(_device == null)
            {
                Console.WriteLine("There are no devices plugged in.");
            }
            else
            {
                Console.WriteLine($"{_device.Name()} unplugged.\n");
                _device = null;
            }
        }

        public void PowerOn()
        {
            Console.WriteLine($"{_device.Name()} powered on.");

            if(_device == null)
            {
                Console.WriteLine("There are no devices plugged in");
            }
            else
            {
                Console.WriteLine($"{_device.Behaviour}");
            }
        }
    }
}
