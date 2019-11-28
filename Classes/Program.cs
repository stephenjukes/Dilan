using Classes.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            //EncapsulationMissile.MissileClass.MainMethod();
            //Inheritance.InheritanceProgram.MainMethod();
            //Interfaces.WeatherApp.WeatherProgram.MainMethod();


            //StaticVsInstanceMethods.Program.MainMethod();

            // ARRAY METHODS.

            // Static
            // void         Clear
            // TOutput[]    ConvertAll
            // void         Copy
            // T[]          Empty
            // Array        CreateInstance
            // T            Find
            // T[]          FindAll
            // void         ForEach
            // int          IndexOf
            // void         Reverse
            // void         Sort


            // Instance
            // int          Length
            // T[]          Clone (notice how this makes new space on the stack)
            // int          GetLength
            // void         SetValue

            Time.TimeProgram.MainMethod();
        }
    }
}
