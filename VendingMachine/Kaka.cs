using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Kaka :VendingItems
    {

        
        public override void Examine()
        {
        }
        public override void Use()
        {
            Console.WriteLine($"Ät den nu när den är färsk");
        }
    }
    }

