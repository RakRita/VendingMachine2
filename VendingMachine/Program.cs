using System;

namespace VendingMachine
{
    class Program
    {

       


            static void Main(string[] args)
            {

                VMachine machine = new VMachine();
           
            int user;

               
                bool handlare = true;
                Console.WriteLine("\nVälkommen till Vending Machine\n");

                do
                {

                    Console.WriteLine();
                    Console.WriteLine("Välj ett av följande alternativ:\n");
                    Console.WriteLine("1 Visa alla varor");
                    Console.WriteLine("2 Lägg i pengar");
                    Console.WriteLine("3 Köpa vara/varor");

                    Console.WriteLine("4 Få växel");


                    user = Convert.ToInt32(Console.ReadLine());





                    switch (user)
                    {

                        case 1:
                            machine.ShowAllProducts();
                            break;
                        case 2:
                            machine.InsertMoney();
                            break;
                        case 3:
                            machine.Buy();
                            break;
                        case 4:
                            machine.EndTransaction();

                            break;

                        default:
                            break;

                    }
                } while (handlare);


                Console.WriteLine("hejdå");
                Console.ReadLine();
            }
        }
    }





    





