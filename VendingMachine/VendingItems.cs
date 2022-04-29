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




        private int price = 10;
        private string info = "produkt";

        public virtual string Info { get{ return info; }set { info = value; } }
      public virtual int Price { get { return price; } set { price = value; } }


        public virtual void Examine()
        {
            Console.WriteLine($"Produkt beskrivning{info} och pris{price}");
        }

        public virtual void Use()
        {
            Console.WriteLine($"Smaka på den,  {info}");
        }

    }
}
