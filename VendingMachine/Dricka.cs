using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Dricka : VendingItems
    {

       
        public override void Examine()
        {
            Console.WriteLine($"{Info}, {Price} kr");
        }
        public override void Use()
        {
            Console.WriteLine($"Den släcker törsten");
        }
    }

}
