using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Choklad:VendingItems
    {
       
        public override void Examine()
        {
            info = "Chokladkaka";
            price = 10;
            
            Console.WriteLine($"{info}, {price} kr");
        }
        public override void Use()
        {
            Console.WriteLine($"De har köpte en ekologisk chokladkaka som innehåller 80%, smaka på den.");
        }

    }
}

        
