using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02
{
    class Program
    {
        static void Main(string[] args)
        {
            task02();
        }
        static void task01()
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.name = " robass";
            s1.marks = 12;
            s1.gpa = 1.23F;
            s2.name = "Ahmad";
            s2.marks = 13.4F;
            s2.gpa = 12;
            Console.WriteLine("Name: " + s1.name + ", Marks:" + s1.marks + ", Gpa: " + s1.gpa);
            Console.WriteLine("Name: " + s2.name + ", Marks:" + s2.marks + ", Gpa: " + s2.gpa);
            Console.ReadKey();
        }
        static void task02()
        {
            Student s1 = new Student();
            Console.WriteLine("Enter Name: ");
            s1.name = Console.ReadLine();
             Console.WriteLine("Enter Marks: ");
            s1.marks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter GPA: ");
            s1.gpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name: " + s1.name + ", Marks:" + s1.marks + ", Gpa: " + s1.gpa);
            Console.ReadKey();


        }
            
    }
}
