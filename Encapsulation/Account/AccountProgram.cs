using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation.Account
{
    public static class AccountProgram
    {
        public static void MainMethod()
        {
            var myAccount = new MyAccount("Stephen", "Hell0!", "What is your first school?", "St Michaels");
            var password = myAccount.Password;


            Console.WriteLine("hello");
        }
    }
}
