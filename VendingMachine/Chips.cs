using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Chips : VendingItems
    {


        public override void Examine()
        {

            info = "Potatischips";
            price = 10;
            Console.WriteLine($"{info}, {price} kr");

            

        }
        public override void Use()
        {
            Console.WriteLine($"Smaka på dem, de är saltade.");
        }
    }
}
