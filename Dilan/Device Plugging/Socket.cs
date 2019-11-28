using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Device_Plugging
{
    class Socket
    {
        private IDevice _device;

        public Socket(IDevice device)
        {
            _device = device;
        }

        public void ProvidePower()
        {
            _device.PowerOn();
        }
    }
}

