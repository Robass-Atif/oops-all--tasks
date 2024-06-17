using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.DL;
using Task01.UI;
namespace Task01.BL
{
   public  class OrderUI
    {
        public static void inputOrder()
        {
            Console.WriteLine("Enter order :");
            string name = Console.ReadLine();
            bool flag = OrderDL.addOrder(name);
            if(flag==true)
            {
                Console.WriteLine("Order save Sucessfully!");

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        }
        public static void fulfillOrder()
        {
            string result = OrderDL.fullfillOrder();
            if (result != null)
            {
                Console.WriteLine("the "+result+" is ready");
            }
            else
            {
                Console.WriteLine("All order have been fullfill");
            }
        }
        public static void viewOrders()
        {
            foreach(string x in OrderDL.order)
            {
                Console.WriteLine(x);
            }
        }
    }
}
