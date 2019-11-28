using System;
using System.Collections.Generic;
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

    class Missile2
    {
        public string launchCode
        {
            get
            {
                var encryptedLaunchCode = encrypt();
                
                return encryptedLaunchCode;
            }

            set
            {
                if (value.Length == 8) launchCode = value; 
            }
        }



        public bool isArmed { get; private set; }

        public string Launch()
        {
            return "BOOM!!!";
        }

        public string encrypt()
        {
            var newLaunchCode = launchCode.ToCharArray();
            Array.Reverse(newLaunchCode);
            return newLaunchCode.ToString();
        }


        public void SetisArmed()
        {

          //launchCode ;
        }
    }
}
