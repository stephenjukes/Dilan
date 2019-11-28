using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    class Monster : Fighter
    {
        Random _uniquemonsterid = new Random();

        public int _monsterid { get; }

        public int _spAttack { get; set; }

        public int _weight { get; set; }

        public int _height { get; set; }

        //public Monster(string name, int hp, int attack, int spAttack, int defence, int speed, int weight, int height, string description)
        //{
        //    _name = name;

        //    _hp = hp;

        //    _attack = attack;

        //    _spAttack = spAttack;

        //    _defence = defence;

        //    _speed = speed;

        //    _weight = weight;

        //    _height = height;

        //    _description = description;

        //    _monsterid = _uniquemonsterid.Next(0, 5000);

        //}

        public void FlameThrower() { Console.WriteLine("BOOM!");}

        public void EnergyBeam() { }



    }
}
