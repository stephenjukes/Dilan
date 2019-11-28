using System;

namespace StructsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var valerie = new PersonStruct(10);
            var reggie = new PersonClass(10);

            Vegas(valerie);
            Vegas(reggie);

            Console.WriteLine($"Valeries reputation is: {valerie.Reputation}");
            Console.WriteLine($"Reggie's reputations is: {reggie.Reputation}");
        }

        private static void Vegas(IPerson person)
        {
            person.Reputation = 0;
        }
    }
}
