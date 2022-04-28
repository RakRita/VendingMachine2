using System;
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

   


