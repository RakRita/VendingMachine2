using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Choklad:VendingItems
    {
       
        public override void Examine()
        {
<<<<<<< HEAD
            info = "Chokladkaka";
            price = 10;
            
            Console.WriteLine($"{info}, {price} kr");
        }
        public override void Use()
        {
            Console.WriteLine($"De har köpte en ekologisk chokladkaka som innehåller 80%, smaka på den.");
=======
            Console.WriteLine($"{Info }{Price }kr");
        }
        public override void Use()
        {
            Console.WriteLine($"ät en ruta om dagen, så vara den hela veckan.");
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd
        }

    }
}

        
