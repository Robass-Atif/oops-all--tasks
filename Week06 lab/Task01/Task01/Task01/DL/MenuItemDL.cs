using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task01.BL;
namespace Task01.DL
{
   public class MenuItemDL
    {
        public static List<MenuItemBL> menu = new List<MenuItemBL>();
        public static void loadFile()
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\Week06 lab\\Task01\\Task01\\Task01\\def.txt";
            StreamReader file = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] spiltLine = line.Split(',');
              
                    string name = spiltLine[0];
                    string type = spiltLine[1];
                    int price = int.Parse(spiltLine[2]);


                    MenuItemBL s1 = new MenuItemBL(name, type, price);
                    menu.Add(s1);
                }
            }
            file.Close();


        }
        public static void addMenuItem(MenuItemBL s1)
        {
            menu.Add(s1);
        }
        public static bool isItemExist(string name)
        {
            bool flag = false;
            foreach (MenuItemBL x in menu)
            {
                if (x.name == name)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static int dueAmount()
        {
            int amount = 0;
            foreach (string x in OrderDL.order)
            {
                foreach (MenuItemBL y in menu)
                {
                    if (x == y.name)
                    {
                        amount = amount + y.price;
                        
                        break;
                    }
                }
            }
            return amount;
        }
        public static string cheapestItem()
        {
            string name = "";
            int largest = 0;
            foreach (MenuItemBL x in menu)
            {
                
                if (largest < x.price)
                {
                    name = x.name;
                }

            }
            return name;
        }
        public static List<string> onlyDrink()
        {
            List<string> s1 = new List<string>();
            foreach (MenuItemBL x in menu)
            {
                if (x.type == "Drink")
                {
                    s1.Add(x.name);
                }
            }
            return s1;
        }
        public static List<string> onlyFood()
        {
            List<string> s1 = new List<string>();
            foreach (MenuItemBL x in menu)
            {
                if (x.type == "Food")
                {
                    s1.Add(x.name);
                }
            }
            return s1;
        }
    }
}
