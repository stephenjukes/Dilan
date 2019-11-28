using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Customer
    {
        public int Age { get; set; }
        public decimal Money { get; set; } = 0m;
        public int FreePopCoupon { get; set; } = 1;
        public Pub VistitedPub { get; set; }

        public void DisplayPurchaseAbility()
        {
            Console.WriteLine($"Can get beer: {Age >= 18 && Money >= VistitedPub.BeerPrice}");
            Console.WriteLine($"Can get pop: { Money > VistitedPub.PopPrice || FreePopCoupon > 0}");
            Console.WriteLine();
        }
    }
}
