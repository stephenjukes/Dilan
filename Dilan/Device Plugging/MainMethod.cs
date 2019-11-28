using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan.Device_Plugging
{
    class MainMethod
    {
        public static void PlugMain()
        {
            WashingMachine washy = new WashingMachine(10,20);
            Toaster toasty = new Toaster();

            Socket socket = new Socket(toasty);
            socket.ProvidePower();

            
        }
    }
}
