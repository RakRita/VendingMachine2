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


        List<VendingItems> vendingItems = new List<VendingItems>();

        public readonly int[] moneyValues = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public int[] MoneyDemoninations { get { return moneyValues; } }

        public List<int> moneyPool = new List<int>();

        public VMachine(List<VendingItems> nyaVaror)
        {
            vendingItems = MakeProducts(nyaVaror);

        }
        public List<VendingItems> MakeProducts(List<VendingItems> nyaVaror)
        {



            Godis candy = new Godis() { Info = "Polkagrisar", Price = 5 };
            Kaka cake = new Kaka() { Info = "Kanelbulle", Price = 10 };
            Choklad choklad = new Choklad() { Info = "Chokladkaka", Price = 15 };
            Dricka dricka = new Dricka() { Info = "Fanta", Price = 10 };
            Chips chips = new Chips() { Info = "Potatischips", Price = 10 };

            nyaVaror.Add(candy);
            nyaVaror.Add(cake);
            nyaVaror.Add(choklad);
            nyaVaror.Add(dricka);
            nyaVaror.Add(chips);

            return nyaVaror;
        }

        public void ShowAllProducts()
        {
            if (vendingItems.Count > 0)
            {
                for (int i = 0; i < vendingItems.Count; i++)
                {
                    Console.WriteLine("" + (i + 1) + ":" + vendingItems[i].Info + " " + vendingItems[i].Price + " kr");
                }
            }
        }
        public void ByMoreProduct(VendingItems vendingItems)
        {
            if (total >= vendingItems.Price)
            {
                total = UpdateTotalValue(vendingItems);

                Console.WriteLine($"Du har följande belopp att handla för: { total} kr");
                vendingItems.Use();

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
                            harProdukt = true;
                            break;

                        case 2:
                            InsertMoney();
                            break;
                        case 3:
                            EndTransaction();
                            harProdukt = false;
                            break;
                        case 0:
                            harProdukt = false;
                            break;
                        default:
                            Console.WriteLine("---------------");
                            break;
                    }
                } while (harProdukt);

            }
            else
            {
                Console.WriteLine("Du har inte tillräckligt med pengar");
                harPengar = false;
                harProdukt = false;
            }
        }

        public void Buy()
        {
            if (total > 0)
            {
                Console.WriteLine($"Du har följande belopp att handla för {total} kr");

                do
                {
                    ShowAllProducts();

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


        public int UpdateTotalValue(VendingItems vendingItems)
        {


            if (total > 0)
            {
                int result = total - vendingItems.Price;
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
                Console.WriteLine($"Du har följande belopp att handla för {moneyPool.Sum()}");
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

            int howManyOfThis;
            if (total == 0)
            {
                Console.WriteLine("Inget att returnera");
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
               
            }
           
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
