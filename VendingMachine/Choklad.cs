using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Choklad:VendingItems
    {
       
        public override void Examine()
        {
            Console.WriteLine($"{Info }{Price }kr");
        }
        public override void Use()
        {
            Console.WriteLine($"ät en ruta om dagen, så vara den hela veckan.");
        }

    }
}

        
