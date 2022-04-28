using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
   public interface IVending
    {
        void Buy();

        void ShowAllProducts();
            
        void InsertMoney();
        void EndTransaction();   //return money



        //by a product
        //show all products
        //Insert money and , add money to the pool
        //end transaction return money in apropriate amount of change
    }
}
