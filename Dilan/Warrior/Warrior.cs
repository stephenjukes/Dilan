using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    class Warrior : Fighter
    {
        Random _uniqueWarriorid = new Random();

        public int _warriorid { get; }

        public Warrior( string name, int hp, int attack, int defence, int speed, string description)
        {
            _name = name;

            _hp = hp;

            _attack = attack;

            _defence = defence;

            _speed = speed;

            _warriorid = _uniqueWarriorid.Next(0, 5000);

            _description = description;

        }

        public string Sword_Attack(Warrior warrior)
        {
            //remember
            warrior._hp =- (2 * _attack);
            
            return $"{_name} has done {10*_attack} Damage, and {warrior._name} now has {warrior._hp} Health points";
        }

        public string Eat()
        {
            return $"{_name} has eaten and has gained 10 HP";
        }

        public string Explode(Warrior warrior)
        {
            warrior._hp = 0;
            this._hp = 0;

            return $"{_name} has Exploded!!! and took {warrior._name} out with him!!";
        }
    }
}
