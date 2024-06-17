using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Task18();
        }
        static void Task18()
        {
            string path = "C:\\Users\\DELL\\source\\repos\\task01\\abc.txt";
            Credential[] user = new Credential[100];
            int count = 0;
            ReadData(path, user, ref count);
            int option;
            do
            {
                
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("enter name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    string p = Console.ReadLine();
                    SignIn(n, p, user, count);
                }
                else if (option == 2)
                {
                    Console.WriteLine("enter name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    string p = Console.ReadLine();
                    user[count]=SignUp(path, n, p);
                    count++;
                }
            } while (option < 3);
            Console.ReadKey();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void ReadData(string path, Credential[] user,ref int count)
        {
            
            if (File.Exists(path))
            {
                StreamReader load = new StreamReader(path);
                string record;
                while ((record = load.ReadLine()) != null)
                {
                    Credential s1 = new Credential();
                    s1.name = ParseData(record, 1);
                    s1.password = ParseData(record, 2);
                    user[count] = s1;
                    count++;
                    if (count >= 100)
                    {
                        break;
                    }
                }
                load.Close();
            }
            else
            {
                Console.WriteLine("not exist!");
            }

        }
        static void SignIn(string n, string p, Credential[] user, int count)
        {
            bool flag = false;
            for (int i = 0; i < count; i++)
            {
                if (n == user[i].name && p == user[i].password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }

        static Credential SignUp(string path, string n, string p)
        {
            Credential s1 = new Credential();
            s1.name = n;
            s1.password = p;
            StreamWriter file = new StreamWriter(path, true);
            
                file.WriteLine(n + "," + p);
            
            
            file.Flush();
            file.Close();
            return s1;
        }


    }
}


