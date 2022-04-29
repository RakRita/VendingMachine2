using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd

namespace VendingMachine
{
    class Program
    {
<<<<<<< HEAD

        static void Main(string[] args)
        {
            VMachine machine = new VMachine();
            bool buy = true;
            int user;

=======
      
        static void Main(string[] args)
        {
            List<VendingItems> items = new List<VendingItems>();
            VMachine machine = new VMachine(items);
            int user;
            bool handlare  = true; 
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd
            Console.WriteLine("\nVälkommen till Vending Machine\n");

            do
            {

                Console.WriteLine();
                Console.WriteLine("Välj ett av följande alternativ:\n");
                Console.WriteLine("1 Visa alla varor");
                Console.WriteLine("2 Lägg i pengar");
                Console.WriteLine("3 Köpa vara/varor");
<<<<<<< HEAD
                Console.WriteLine("4 Få växel");
=======
                Console.WriteLine("4 Få växel och avsluta");
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd



                user = Convert.ToInt32(Console.ReadLine());

<<<<<<< HEAD


=======
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd
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
<<<<<<< HEAD
                        buy = false;
                        break;


=======
                        handlare = false;
                        break;
>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd
                    default:
                        break;

                }
<<<<<<< HEAD

            } while (buy);
            Console.WriteLine("hejdå");
            Console.WriteLine(Console.ReadLine());
        }
    }
}



=======
            } while (handlare);

            if (handlare = false)
            {
                Console.WriteLine("Promgrammet stängs");
            }

            Console.ReadLine();

        }
    }



}

>>>>>>> b17dd8e542e2598bda73aed486858b9f899737cd
