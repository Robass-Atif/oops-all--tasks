using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Ship> ship = new List<Ship>();
            string option = "0";
            while(option!="5")
            {
                Console.Clear();
                option = menu();
                if (option == "1")
                {
                    Console.Clear();
                    addShip(ship);
                }
                else if (option == "2")
                {
                    Console.Clear();
                    viewShip(ship);
                }
                else if(option=="3")
                {
                    Console.Clear();
                    Console.WriteLine("Enter SHip lattitude: ");
                    string lattitude = Console.ReadLine();

                    Console.WriteLine("Enter SHip lattitude: ");
                    string longitude = Console.ReadLine();
                    Ship s1=printSerial(lattitude, longitude ,ship);
                    Console.WriteLine("The ship serial no is: " + s1.shipNumber);
                    clearScreen();

                }
                else if(option=="4")
                {
                    Console.Clear();

                    changePosition(ship);
                }

            }
            Console.ReadKey();
        }
        static void changePosition(List<Ship> ship)
        {
            Console.WriteLine("Enter serial no:");
            int serial = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Latitude  Degree:");
            int degree1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude  Minute:");
            float minute1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude  Direction:");
            char direction1 = char.Parse(Console.ReadLine());
            Angle s1 = new Angle(degree1, minute1);
          //string value = convertIntoString(s1);

            Console.WriteLine("Enter Longitude  Degree:");
            int degree2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude  minute:");
            float minute2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude  Direction:");
            char direction2 = char.Parse(Console.ReadLine());
            Angle s2 = new Angle(degree2, minute2);
           // string value1 = convertIntoString(s2);
            Ship p1 = findShip(ship ,serial);
           // p1.shipLatitude = value;
           // p1.shipLongitude = value1;

        }
        static Ship findShip(List<Ship> ship,int serial)
        {
            foreach(Ship x in ship)
            {
                if(serial==x.shipNumber)
                {
                    return x;
                }
            }
            return null;
        }
        static Ship printSerial(string lat,string log ,List<Ship> ship)
        {
            foreach(Ship x in ship)
            {
                if(x.shipLatitude==lat && x.shipLongitude==log)
                {
                    return x;
                }
            }
            return null;

        }
        static void viewShip(List<Ship> ship)
        {
            Console.WriteLine("Enter serial no:");
            int serial = int.Parse(Console.ReadLine());
            Ship s1 = findClass( ship,serial);

            Console.WriteLine("The position is "+ s1.shipLatitude+" and "+s1.shipLongitude);
            Console.ReadKey();
        }
        static string menu()
        {
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change ship Position");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Option: ");
            string option = Console.ReadLine();
            return option;

        }
        static void addShip(List<Ship> ship)
        {
            Console.WriteLine("Enter serial no:");
            int serial = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Latitude  Degree:");
            int degree1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Latitude  Minute:");
            float minute1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude  Direction:");
             char direction1 =char.Parse (Console.ReadLine());
            Angle s1 = new Angle(degree1, minute1);
            string value = s1.convertIntoString();

            Console.WriteLine("Enter Longitude  Degree:");
            int degree2 =int.Parse (Console.ReadLine());
             Console.WriteLine("Enter Longitude  minute:");
            float minute2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude  Direction:");
            char direction2 = char.Parse(Console.ReadLine());
            Angle s2 = new Angle(degree2, minute2);
            string value1 = s2.convertIntoString();
            Ship p1 = new Ship(serial, value, value1);
            ship.Add(p1);
            clearScreen();

        }
        
        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
        static Ship findClass(List<Ship> ship,int serial)
        {
            foreach(Ship x in ship)
            {
                if( x.shipNumber==serial)
                {
                    return x;
                }
            }
            return null;
        }
    }
}
