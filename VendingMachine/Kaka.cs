using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Kaka :VendingItems
    {

        
        public override void Examine()
        {
            Console.WriteLine($"{Info}, {Price} kr");
        }
        public override void Use()
        {
            Console.WriteLine($"Ät den nu när den är färsk");
        }
    }
    }

