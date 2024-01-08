using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> amount = new List<Product>();

            string option = "0";
                while(option!="6")
                {
                Console.Clear();
                option = menu();
                if (option == "1")
                {
                    addProduct(amount); 

                }
                else if (option == "2")
                {
                    viewProduct(amount);

                }
                else if (option == "3")
                {
                    highPrice(amount);
                }
                else if(option=="4")
                {
                    saleTax(amount);
                }
                else if(option=="5")
                {
                    threshold(amount);
                }
                
            }

            Console.ReadKey();


        }
        static string menu()
        {
            Console.WriteLine("1.Add product");
            Console.WriteLine("2.View all product");
            Console.WriteLine("3.Product of highest price");
            Console.WriteLine("4.View sales tax for all product");
            Console.WriteLine("5.Product to be ordered");
            Console.WriteLine("Option:");
            string option = Console.ReadLine();
            return option;
        }
        static void addProduct(List<Product> amount)
        {
            Console.Clear();
            Product s1 = new Product();
            Console.WriteLine("Enter name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Category: ");
            s1.category = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            s1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Stock: ");
            s1.stock =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter  minimum Stock: ");
            s1.minStock = int.Parse(Console.ReadLine());
            amount.Add(s1);

        }
        static void viewProduct(List<Product> amount)
        {
            Console.Clear();
            foreach(Product i in amount)
            {
                Console.WriteLine(i.name + "," +i.category+","+i.price+","+i.stock+","+i.minStock);
            }

            Console.ReadKey();
        }
        static void highPrice(List<Product> amount)
        {
            Console.Clear();
            float largest=amount[0].price;
            int index = 0;
            for (int i=1;i<amount.Count;i++)
            {
                if(amount[i].price>largest)
                {
                    largest = amount[i].price;
                    index = i;
                }
            }
            Console.WriteLine(amount[index].name + "," + amount[index].category + "," +amount[index].price + "," + amount[index].stock + "," + amount[index].minStock);
            Console.ReadKey();
        }
        static void saleTax(List<Product> amount)
        {
            Console.Clear();
            double tax;
            for(int i=0;i<amount.Count;i++)
            {
                if (amount[i].category == "fruit")
                {
                    tax = (amount[i].price) * (0.95);
                    Console.WriteLine(amount[i].name + "," + amount[i].category + "," + amount[i].price + "," + amount[i].stock + "," + amount[i].minStock);

                    Console.WriteLine("Tax:" + tax);
                }
                else if (amount[i].category == "grocery")
                {
                    tax = (amount[i].price) * (0.90);
                    Console.WriteLine(amount[i].name + "," + amount[i].category + "," + amount[i].price + "," + amount[i].stock + "," + amount[i].minStock);

                    Console.WriteLine("Tax:" + tax);
                }

                else
                {
                    tax = (amount[i].price) * (0.85);
                    Console.WriteLine(amount[i].name + "," + amount[i].category + "," + amount[i].price + "," + amount[i].stock + "," + amount[i].minStock);

                    Console.WriteLine("Tax:" + tax);
                }
               
            }
            Console.ReadKey();
        }
        static void threshold(List<Product> amount)
        {
            Console.Clear();
            for(int i=0;i<amount.Count;i++)
            {
                Console.WriteLine(amount[i].name + "              threshold value:   " + amount[i].minStock);
            }
            Console.ReadKey();
        }

    }
}
