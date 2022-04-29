using System;
<<<<<<< HEAD

namespace VendingMachine
{
    class Godis : VendingItems
    {

        public override void Examine()
        {
            info = "Polkagrisar";
            price = 5;          

            Console.WriteLine($"{info}, {price} kr");
        }
        public override void Use()
        {
            Console.WriteLine($"Du har köpt polkagrisar från gränna, de är mycket goda, smaka på dem.");
        }
    }
}


=======
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Godis :VendingItems
    {



        

        public override void Examine()
        {
            Console.WriteLine($"{Info} {Price} kr");
        }
        public override void Use()
        {
            Console.WriteLine($"ät den.");
        }
    }
    }

   
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd


