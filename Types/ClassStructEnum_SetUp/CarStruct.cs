﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public struct CarStruct
    {
        string color;
        int doors;

        void Drive()
        {
            Console.WriteLine("Vroom vroom!");
        }

        void Brake()
        {
            Console.WriteLine("Screeeeccchh!");
        }
    }
}
