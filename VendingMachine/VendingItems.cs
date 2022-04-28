using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace VendingMachine
{
    public abstract class VendingItems
    {
        protected VendingItems()
        {}
        public string info;
        public int price;

        public abstract void Examine();
        
           
        

        public abstract void Use();
        
            
        }

    }


