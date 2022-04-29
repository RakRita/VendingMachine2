using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{



    public class VMachine : IVending

    {

        public VMachine()
        {
            MakeProductsList();


        }



       
        int val;
        bool harProdukt = true;
        bool harPengar = true;
        int saldo;
        int result;






        public readonly List<int> moneyValues = new List<int>() { 1, 5, 10, 20, 50, 100, 500, 1000 };

       // public int[] moneyValues { get { return moneyValues; } }

        //public List<int> moneyPool = new List<int>();

        public List<VendingItems> vendingItems = new List<VendingItems>();




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


        /*
        public void ByMoreProduct(VendingItems vendingItems)
        {
            if (saldo >= vendingItems.price)
            {
                saldo = UpdateTotalValue(vendingItems);

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
        */
        public void Buy()

        {
            if (saldo > 0)
            {
                Console.WriteLine($"Du har följande belopp att handla för {saldo} kr");

                do
                {

                    int i = 1;

                    foreach (var item in vendingItems)
                    {
                        Console.Write(i++ + " ");
                        item.Examine();

                    }

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




        public void ByMoreProduct(VendingItems vendingItems)
        {
            if (saldo >= vendingItems.price)
            {

                saldo = UpdateTotalValue(vendingItems);
                vendingItems.Use();
                Console.WriteLine();
                Console.WriteLine($"Du har följande belopp att handla för: { saldo} kr");

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

        public int UpdateTotalValue(VendingItems item)
        {


            if (saldo > 0)
            {
                int result = saldo - item.price;

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
           int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput>0 && moneyValues.Contains(userInput))
            {

                saldo += userInput;

                Console.WriteLine($"Du har följande belopp att handla för {saldo} kr");

               

            }
            else
            {
                Console.WriteLine("fel valör");
            }
        }




      /*  public int TotalAmountInMachine(int userCoin)
        {
            if (saldo > 0)
            {
                moneyPool.Clear();
                moneyPool.Add(total);

            }
            moneyPool.Add(userCoin);
            total = moneyPool.Sum();
            return total;
        }*/

        public void EndTransaction()
        {

            bool buy = true;
            int howManyOfThis;
            do
            {



                if (saldo == 0)
                {
                    Console.WriteLine("Inget att returnera");
                    break;
                }
                else
                {
                    Console.WriteLine($"Du får tillbaka {saldo} kr.");
                    for (int i = moneyValues.Count - 1; i >= 0; i--)
                    {
                        if (saldo >= moneyValues[i])
                        {
                            howManyOfThis = saldo / moneyValues[i];
                            Console.WriteLine($"{howManyOfThis} st x {moneyValues[i]} kr");
                            saldo = saldo % moneyValues[i];

                        }

                    }


                    Console.WriteLine($"Välkommen åter");

                  

                   
                    buy = false;


                }
            } while (buy);

            Console.ReadLine();


          

            }


        }


       




       /* public bool UserInsertMoney(int userCoin)
        {
            if (money.Contains(userCoin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }

