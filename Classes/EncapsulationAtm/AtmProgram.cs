using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.EncapsulationAtm
{
    class AtmProgram
    {
        public static void MainMethod()
        {
            var card = new Card(1234);
            var session = new Session(card, 1233);

            session.GetBalance();
            session.Withdraw(5);
            session.Deposit(100);
            session.Deposit(50);
            session.Withdraw(200);
            session.Withdraw(1);
            session.Withdraw(10);
        }
    }
}
