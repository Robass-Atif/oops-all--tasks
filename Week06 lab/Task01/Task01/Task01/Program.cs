using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;
using Task01.DL;
using Task01.UI;
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItemDL.loadFile();
            string option="0";
            while(option!="9")
            {
                Console.Clear();
                option = menu();
             if(option=="1")
                {
                    Console.Clear();
                    MenuItemBL s1 = MenuItemUI.addItem();
                    MenuItemDL.addMenuItem(s1);
                    clearscreen();
                }
                 
                else if (option == "2")
                {
                    Console.Clear();
                    MenuItemUI.printChepestItem();
                    clearscreen();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    List<string> s1 = MenuItemDL.onlyDrink();
                    foreach(string x in s1)
                    {
                        Console.WriteLine(x);
                    }
                    clearscreen();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    List<string> s1 = MenuItemDL.onlyFood();
                    foreach (string x in s1)
                    {
                        Console.WriteLine(x);
                    }
                    clearscreen();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    OrderUI.inputOrder();
                    clearscreen();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    OrderUI.fulfillOrder();
                    clearscreen();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    OrderUI.viewOrders();
                    clearscreen();
                }
                else if (option == "8")
                {
                    Console.Clear();
                    MenuItemUI.printDueAmount();
                    clearscreen();
                }
                
                else if (option == "9")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
        static string menu()
        {
            Console.WriteLine("1.Add Menu Item");
            Console.WriteLine("2.VIew the cheapest item in the menu");
            Console.WriteLine("3.View the Drink Menu");
            Console.WriteLine("4.View the Food Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fullfill the Order");
            Console.WriteLine("7.View the Order List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.WriteLine("Option: ");
            string option = Console.ReadLine();
            return option;
        }
        static void clearscreen()
        {
            Console.WriteLine("Pres any key to continue . . .");
            Console.ReadKey();
        }
    }
}
