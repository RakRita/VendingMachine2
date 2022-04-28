using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Chips : VendingItems
    {


        public override void Examine()
        {
            Console.WriteLine($"{Info }{Price }kr");
        }
        public override void Use()
        {
            Console.WriteLine($"Smaka på dem, de är saltade.");
        }
    }
}
