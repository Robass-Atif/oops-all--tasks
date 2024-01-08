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
            Task2(); 
        }
        static void Task1()
        {
            Student s1 = new Student("jack",4);
            Student s2 = new Student("ali", 5);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.rollNo);
            Console.WriteLine(s2.name);
            Console.WriteLine(s2.rollNo);
            Console.ReadKey();
        }
        static void Task2()
        {
            clockType empty = new clockType();
            Console.WriteLine("Empty: ");
            empty.printTime();

            clockType hour = new clockType(8);
            Console.WriteLine("hour: ");
            hour.printTime();

            clockType min = new clockType(8,10);
            Console.WriteLine("Minutes: ");
            min.printTime();

            clockType sec = new clockType(8,10,10);
            Console.WriteLine("Second: ");
            sec.printTime();

            sec.incrementSeconds();
            Console.WriteLine("second increment: ");
            sec.printTime();

            sec.incrementMinutes();
            Console.WriteLine("Minutes increment: ");
            sec.printTime();

            sec.incrementHours();
            Console.WriteLine("Hours increment: ");
            sec.printTime();

            bool check = sec.isEqual(9, 11, 11);
            Console.WriteLine("bool check: "+check);

            clockType hello = new clockType(5, 7, 8);
            bool check1 = sec.isEqual(hello);
            Console.WriteLine("bool check: " + check1);

            int total = (sec.hours * sec.minutes * sec.seconds);
            int amount=sec.elapseTime(total);
            Console.WriteLine("total elapsed time: " + amount);

             total = (sec.hours * sec.minutes * sec.seconds);
             amount = sec.currentTime(total);
            Console.WriteLine("total current time: " + amount);

            clockType s2 = new clockType(5, 7, 8);

            s2.difference(sec);
            Console.WriteLine("hours: " + s2.hours + ", Minutes: " + s2.minutes + ", Second : " + s2.seconds);



            Console.ReadKey();
        }

    }
}
