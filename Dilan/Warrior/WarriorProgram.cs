using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    public static class WarriorProgram
    {
        public static void MainMethod()
        {
            var grug = new Warrior("Grug", 50, 10, 15, 35, "He is a Big Guy!");
            Console.WriteLine(
            $"Warrior Name: {grug._name} \r\n" +
            $"Health: {grug._hp} \r\n" +
            $"Attack!: {grug._attack} \r\n" +
            $"Speed: {grug._speed} \r\n" +
            $"Description: {grug._description}"
                );

            Console.WriteLine("");

            var uug = new Warrior("UUg", 35, 15, 13, 45, "a Ticking Time Bomb!!");
            Console.WriteLine(
            $"Warrior Name: {uug._name} \r\n" +
            $"Health: {uug._hp} \r\n" +
            $"Attack!: {uug._attack} \r\n" +
            $"Speed: {uug._speed} \r\n" +
            $"Description: {uug._description}"
            );

            Console.WriteLine("");

            Console.WriteLine(grug.Sword_Attack(uug));

            Console.WriteLine("");

            Console.WriteLine(uug.Eat());

            Console.WriteLine("");

            Console.WriteLine("UUg Ready! \r\n" + " \r\n" + uug.Explode(grug));

            Console.WriteLine("");
        }
    }
}
