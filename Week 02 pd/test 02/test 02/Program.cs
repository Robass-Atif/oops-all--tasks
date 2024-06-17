using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] c = new Product[100];
            string option = "0";
            int count = 0;
            while(option!="4")
            {
                Console.Clear();
                option = menu();
                if(option=="1")
                {
                    c[count] = addProduct();
                    count++;
                }
                else if(option=="2")
                {
                    viewData(c, count);
                }
                else if(option=="3")
                {
                    int total = totalPrice(c, count);
                    Console.WriteLine("Total price: " + total);
                    clearScreen();
                }
                else if(option=="4")
                {
                    break;
                }


            }
            clearScreen();
        }
        static string menu()
        {
            Console.WriteLine("1.Add product");
            Console.WriteLine("2.View product");
            Console.WriteLine("3.Total price of product");
            Console.WriteLine("4.Exist");
            Console.Write("Option:");
            string option=Console.ReadLine();
            return option;

        }
        static void clearScreen()
        {
            Console.WriteLine("Press Any key to Continue . . .");
            Console.ReadKey();
        }
        static Product addProduct()
        {
            Console.Clear();
            Product c = new Product();
            Console.WriteLine("Enter your id: ");
            c.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Name: ");
            c.name = (Console.ReadLine());
            Console.WriteLine("Enter your Price: ");
            c.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Catagory: ");
            c.catagory = (Console.ReadLine());
            Console.WriteLine("Enter your Brand: ");
            c.brand = (Console.ReadLine());
            Console.WriteLine("Enter your Country: ");
            c.country = (Console.ReadLine());
            return c;
        }
        static void viewData(Product[] c,int count)
        {
            Console.Clear();
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Id: {0} Name:{1} price: {2} Catagory: {3} brand: {4} Country:{5}", c[i].id, c[i].name, c[i].price, c[i].catagory, c[i].brand, c[i].country);
                if(c[i].price==c[i+1].price)
                {
                    Console.WriteLine("COut");
                }

            }
            clearScreen();
        }
        static int totalPrice(Product[] c,int count)
        {
            Console.Clear();
            int total=0;
            for(int i=0;i<count;i++)
            {
                total = total + c[i].price;
            }
            return total;
        }

    }
}
