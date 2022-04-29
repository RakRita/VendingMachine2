using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Dricka : VendingItems
    {

       
        public override void Examine()
        {
<<<<<<< HEAD
            info = "Sockerdricka";
            price = 10;

            Console.WriteLine($"{info}, {price} kr");
=======
            Console.WriteLine($"{Info}, {Price} kr");
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd
        }
        public override void Use()
        {
            Console.WriteLine($"Den släcker törsten");
        }
    }

}
