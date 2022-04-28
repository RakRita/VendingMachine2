using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VMachine : IVending
    {
        int user;
        int val;
        bool harProdukt = true;
        bool harPengar = true;
        int total;
        int result;


        private List<VendingItems> vendingItems = new List<VendingItems>();

        public readonly int[] moneyValues = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public int[] MoneyDemoninations { get { return moneyValues; } }

        public List<int> moneyPool = new List<int>();





        public VMachine()
        {
            MakeProductsList();


        }
        private void MakeProductsList()
        {



            Godis candy = new Godis() { info = "Polkagrisar", price = 5 };
            Kaka cake = new Kaka() { info = "Kanelbulle", price = 10 };
            Choklad choklad = new Choklad() { info = "Chokladkaka", price = 15 };
            Dricka dricka = new Dricka() { info = "Fanta", price = 10 };
            Chips chips = new Chips() { info = "Potatischips", price = 10 };

            vendingItems.Add(candy);
            vendingItems.Add(cake);
            vendingItems.Add(choklad);
            vendingItems.Add(dricka);
            vendingItems.Add(chips);


        }

        public void ShowAllProducts()
        {
            if (vendingItems.Count > 0)
            {
                for (int i = 0; i < vendingItems.Count; i++)
                {
                    Console.WriteLine("" + (i + 1) + ":" + vendingItems[i].info + " " + vendingItems[i].price + " kr");
                }
            }
        }


        public void Buy()



        {
            if (total > 0)
            {
                Console.WriteLine($"Du har följande belopp att handla för {total} kr");

                do
                {
                    int i = 1;

                    foreach (var item in vendingItems)
                    {
                        Console.Write(i++ + " ");
                        item.Examine();

                    }

                    Console.WriteLine("Välj 0 för att avsluta och få växel");



                    val = Convert.ToInt32(Console.ReadLine());


                    switch (val)
                    {
                        case 1:
                            ByMoreProduct(vendingItems[0]);
                            break;
                        case 2:
                            ByMoreProduct(vendingItems[1]);
                            break;
                        case 3:
                            ByMoreProduct(vendingItems[2]);
                            break;
                        case 4:
                            ByMoreProduct(vendingItems[3]);
                            break;
                        case 5:
                            ByMoreProduct(vendingItems[4]);
                            break;
                        case 0:
                            EndTransaction();

                            harPengar = false;
                            break;
                        default:
                            break;
                    }
                } while (harPengar);
            }
            else
            {
                Console.WriteLine("Du har inte tillräckligt med pengar för att handla");
                InsertMoney();
            }
        }




        public void ByMoreProduct(VendingItems vendingItems)
        {
            if (total >= vendingItems.price)
            {

                total = UpdateTotalValue(vendingItems);
                vendingItems.Use();
                Console.WriteLine();
                Console.WriteLine($"Du har följande belopp att handla för: { total} kr");

                /*
                do
                {

                    Console.WriteLine("1. För att fortsätta köpa ");
                    Console.WriteLine("2. För att lägga i pengar");
                    Console.WriteLine("3. För att avsluta och få växel ");
                    val = Convert.ToInt32(Console.ReadLine());

                    switch (val)
                    {
                        case 1:
                            Buy();

                            break;

                        case 2:
                            InsertMoney();
                            break;
                        case 3:
                            EndTransaction();

                            break;


                        default:

                            break;
                    }
                } while (harProdukt);*/


            }
            else
            {
                Console.WriteLine("Du har inte tillräckligt med pengar");
                harPengar = false;
                harProdukt = false;
            }
        }

        public int UpdateTotalValue(VendingItems vendingItems)
        {


            if (total > 0)
            {
                int result = total - vendingItems.price;
                return result;
            }

            else
            {
                return 0;

            }

        }

        public void InsertMoney()
        {
            Console.WriteLine("Du kan lägga i 1,5,10, 20, 50, 100, 500, 1000 kr");
            Console.WriteLine("Vänligen lägg i pengar");
            user = Convert.ToInt32(Console.ReadLine());

            if (UserInsertMoney(user))
            {

                total = TotalAmountInMachine(user);
                Console.WriteLine($"Du har följande belopp att handla för {moneyPool.Sum()} kr");
            }
            else
            {
                Console.WriteLine("fel valör");
            }
        }




        public int TotalAmountInMachine(int userCoin)
        {
            if (total > 0)
            {
                moneyPool.Clear();
                moneyPool.Add(total);

            }
            moneyPool.Add(userCoin);
            total = moneyPool.Sum();
            return total;
        }

        public void EndTransaction()
        {
            bool buy = true;

            do
            {


                int howManyOfThis;
                if (total == 0)
                {
                    Console.WriteLine("Inget att returnera");
                    break;
                }
                else
                {
                    Console.WriteLine($"Du får tillbaka {total} kr.");
                    for (int i = MoneyDemoninations.Length - 1; i >= 0; i--)
                    {
                        if (total >= MoneyDemoninations[i])
                        {
                            howManyOfThis = total / MoneyDemoninations[i];
                            Console.WriteLine($"{howManyOfThis} st x {MoneyDemoninations[i]} kr");
                            total = total % MoneyDemoninations[i];

                        }

                    }


                    Console.WriteLine($"Välkommen åter");

                    moneyPool.Clear();

                    total = Reset(total);
                    buy = false;
                    

                }
            } while (buy);
            
            Console.ReadLine();
           
           

        }


        public int Reset(int amount)
        {
            amount = 0;
            return amount;
        }





        public bool UserInsertMoney(int userCoin)
        {
            if (MoneyDemoninations.Contains(userCoin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
