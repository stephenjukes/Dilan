using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dilan
{
     //Task:
     //Create a class called 'Missile' with
     //    2 state members(launchCode and isArmed)
     //    1 method(Launch)
     //launchCode GET should return an encryption of the launchcode
     //    (Your main method will also require a way of decrypting if it is to do anything useful with it)
     //launchCode SET should only allowed if the code is more than 8 characters
     //isArmed GET may be accessed without condition
     //isArmed SET should only be allowed if the correct launchcode is provided
     //Launch: what conditions do you think should be met in order to launch the missile?

     //Many of these conditions can be met in a number of ways.Use the most appropriate in each case.

    class Missile
    {
        private string _launchCode;
        
        public Missile(string launchCode)
        {
            _launchCode = launchCode;
        }

        public bool Armed { get; private set; } = false;

        public string LaunchCode
        {
            get
            {
                return Encrypt(_launchCode);
            }

            set
            {
                if (value.Length > 8) _launchCode = value;
            }
        }

        public void Arm(string launchCode)
        {
            ExecuteWithLaunchCode(() => Armed = true, launchCode);
        }

        public void DisArm(string launchCode)
        {
            ExecuteWithLaunchCode(() => Armed = false, launchCode);
        }

        public void Launch(string launchCode)
        {
            ExecuteWithLaunchCode(() => Console.WriteLine("KABOOOM!!!"), launchCode);
        }

        private void ExecuteWithLaunchCode(Action action, string launchCode)
        {
            if (launchCode == _launchCode) action();
        }

        private string Encrypt(string message)
        {
            var encrypted = message.ToCharArray().Select(character => (int)character).ToArray();
            return String.Join('-', encrypted);
        }   
    }
}
