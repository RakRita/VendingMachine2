using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Dricka : VendingItems
    {

       
        public override void Examine()
        {
            info = "Sockerdricka";
            price = 10;

            Console.WriteLine($"{info}, {price} kr");
            Console.WriteLine($"{info}, {price} kr");
        }
        public override void Use()
        {
            Console.WriteLine($"Den släcker törsten");
        }
    }

}
