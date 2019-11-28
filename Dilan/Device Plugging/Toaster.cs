using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Device_Plugging
{
    class Toaster : IDevice
    {
        public string Bread { get; set; }
        public void PowerOn()
        {
            Console.WriteLine($"The Bread has been Toasted."); 
        }
    }
}
