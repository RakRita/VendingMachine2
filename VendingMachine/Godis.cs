using System;

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




