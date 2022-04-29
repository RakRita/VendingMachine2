using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Kaka :VendingItems
    {



        public override void Examine()
        {
            info = "Kanelbulle";
            price = 10;
            Console.WriteLine($"{info}, {price} kr");
        }
        
        public override void Use()
        {
            Console.WriteLine($"Ät den nu när den är färsk");
        }
    }
    }

