using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;
using Task01.DL;
namespace Task01.UI
{
   public class MenuItemUI
    {
        public static MenuItemBL addItem()
        {
            Console.WriteLine("ENter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("ENter type: ");
            string type = Console.ReadLine();
            Console.WriteLine("ENter price: ");
            int price = int.Parse(Console.ReadLine());
            MenuItemBL s1 = new MenuItemBL(name, type, price);
            return s1;
        }

        public static void printChepestItem()
        {
            string chepest = MenuItemDL.cheapestItem();
            Console.WriteLine(chepest);
        }
        public static void printDueAmount()
        {
            int result = MenuItemDL.dueAmount();
            Console.WriteLine(result);
        }
    }

}
