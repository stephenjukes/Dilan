using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces
{
    class Radio : ThreePinPlugDevice
    {
        public string Behaviour { get; } = "All we hear is radio gaga ...";
    }
}
