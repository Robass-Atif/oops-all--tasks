using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> client = new List<Customer>();
            List<Product> p = new List<Product>();
            string option = "0";
            while(option!="4")
            {
                Console.Clear();
                option = menu();
                if(option=="1")
                {
                    Product p1 = getProduct();
                    p.Add(p1);
                    clearScreen();

                }
                if (option == "2")
                {
                    Customer p1 = addCustomer();
                    client.Add(p1);
                    clearScreen();
                }
                if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Enter Cutomer name:");
                    string name = Console.ReadLine();
                    clearScreen();
                    Product p1 = getProduct();
                    Customer s1=new Customer(); 
                    s1= findCutomer(name,client);
                    if (s1 != null)
                    {
                        Console.WriteLine(s1.name);
                        s1.addProduct(p1);
                    }
                    clearScreen();
                    
                }
                if (option == "4")
                {
                    Console.Clear();
                    foreach(Customer data in client )
                    {
                        Console.WriteLine(data.name + " " + data.address + " " + data.contact);
                    }
                    
                    for(int i=0;i<client.Count;i++)
                    {
                        for(int j=0;j<client[i].purchase.Count;j++)
                        {
                            Console.WriteLine(client[i].purchase[j].name);
                        }
                    }
                    clearScreen();
                }
                if (option == "5")
                {
                    break;
                }

            }
            Console.ReadKey();

        }
        static string menu()
        {
            Console.WriteLine("1.Add product");
            Console.WriteLine("2.Add Customer");
            Console.WriteLine("3.Purchase product ");
            Console.WriteLine("4.See tax of all terms");
            Console.WriteLine("5.Exit");

            Console.WriteLine("Option:");
            string option = Console.ReadLine();
            return option;
        }
        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
        static Product getProduct()
        {
            Console.Clear();
            Product p1 = new Product();
            Console.WriteLine("Enter Product name: ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter category: ");
            p1.category = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            p1.price =float.Parse (Console.ReadLine());
            return p1;
        }
        static Customer addCustomer()
        {
            Console.Clear();
            Customer p1 = new Customer();
            Console.WriteLine("Enter name: ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter adress: ");
            p1.address = Console.ReadLine();
            Console.WriteLine("Enter contact: ");
            p1.contact = (Console.ReadLine());
            return p1;
        }
        static Customer findCutomer(string n, List<Customer> client)
        {
            foreach (Customer data in client)
            {
                if (data.name == n)
                {

                    return data;
                }
            }
            return null;
        }

    }
}
