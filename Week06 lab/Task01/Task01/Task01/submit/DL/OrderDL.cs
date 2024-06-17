using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;
using Task01.DL;
namespace Task01.DL
{
   public class OrderDL
    {
        public static List<string> order = new List<string>();


        public static bool addOrder(string name)
        {
            bool flag = MenuItemDL.isItemExist(name);
            if (flag == true)
            {
                order.Add(name);
                return true;
                
            }
            else
            {
                return false;
            }
        }
        public List<string> listOrder()
        {
            if (order.Count > 0)
            {
                return order;
            }
            else
            {
                return null;
            }
        }
        public static string fullfillOrder()
        {
            if (order.Count > 0)
            {
                string fullfill = order[0];
                order.RemoveAt(0);
                return fullfill;
            }
            else
            {
                return null;
            }
        }
    }
}
