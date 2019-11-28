using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public class Kata
    {
        public static long QueueTime(int[] customerTimes, int tillQuantity)
        {
            var customerIndex = 0;
            var timeUnit = 0;
            var customers = customerTimes.Select(t => new Customer { RemainingTime = t });
            var remainingCustomers = true;

            while (remainingCustomers)
            {
                var atCheckout = customers.Where(c => c.AtCheckout);
                var advancingCustomers = customers
                    .Skip(customerIndex)
                    .Take(tillQuantity - atCheckout.Count())
                    .Select(c =>
                        {
                            c.AtCheckout = true;
                            return c;
                        });

                Console.WriteLine("hit");
                timeUnit += 1;
                remainingCustomers = customers.Any(c => c.RemainingTime > 0);
            };

            Console.WriteLine(timeUnit);
            return timeUnit;
        }
    }

    class Customer
    {
        public int RemainingTime { get; set; }
        public bool AtCheckout { get; set; }
    }
}
