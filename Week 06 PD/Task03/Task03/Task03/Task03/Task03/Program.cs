using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "0";
            while(option!="10")
            {
                Console.Clear();
                option = menu();
                if(option=="1")
                {
                    Console.Clear();
                   
                   int x = MyPointUI.getX();
                    int y = MyPointUI.getY();
                   int x1  = MyPointUI.getX();
                   int y1= MyPointUI.getY();
                    MyPoint begin = new MyPoint(x, y);
                    MyPoint end = new MyPoint(x1, y1);
                    MyLineCRUD.setBegin(begin);
                    MyLineCRUD.setEnd(end);

                    clearscreen();
                }
                else if(option=="2")
                {
                    Console.Clear();
                    MyPoint begin = new MyPoint();
                    begin.x = MyPointUI.getX();
                    begin.y = MyPointUI.getY();
                    MyLineCRUD.setBegin(begin);
                    clearscreen();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Console.Clear();
                    MyPoint end = new MyPoint();
                    end.x = MyPointUI.getX();
                    end.y = MyPointUI.getY();
                    MyLineCRUD.setEnd(end);
                    clearscreen();
                }
                else if (option == "4")
                {
                    Console.Clear();
                  MyPoint Begin=  MyLineCRUD.getBegin();
                    Console.WriteLine(Begin.x + " and"+Begin.y + " are the begin points");
                    clearscreen();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    MyPoint Begin = MyLineCRUD.getEnd();
                    Console.WriteLine(Begin.x + " and" + Begin.y + " are the begin points");

                    clearscreen();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    double length = MyLineCRUD.getLength();
                    Console.WriteLine(length + " is the lenght of line");
                    clearscreen();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    double gradient = MyLineCRUD.getGradient();
                    Console.WriteLine(gradient + " is the gradient");
                    clearscreen();
                }
                else if (option == "8")
                {
                    Console.Clear();
                  


                    double x = MyPointCRUD.distanceFromZero(MyLineCRUD.getBeginPoint());
                    Console.WriteLine(x + " length from zero");

                    clearscreen();
                }
                else if (option == "9")
                {
                    Console.Clear();
                   
                    double x = MyPointCRUD.distanceFromZero(MyLineCRUD.getEndPoint());
                    Console.WriteLine(x + " length from zero");

                    clearscreen();
                }
                else if (option == "10")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
        static string menu()
        {
            Console.WriteLine("1.make line");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("3.Update the end point");
            Console.WriteLine("4.show the begin point");
            Console.WriteLine("5.show the end point");
            Console.WriteLine("6.Get the length of line");
            Console.WriteLine("7.Get the gradient of  line");
            Console.WriteLine("8.Find the Distance from begin point to zero coordinates");
            Console.WriteLine("9.Find the Distance from end point to zero coordinates");
            Console.WriteLine("10.Exit");
            Console.WriteLine("Option:");
            string option = Console.ReadLine();
            return option;
        }
        static void clearscreen()
        {
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
