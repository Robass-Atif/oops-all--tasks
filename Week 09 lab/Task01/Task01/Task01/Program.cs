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
            Student s1 = new Student("ard", "ad", "dsa", 12, 2.2);
            Student s2 = new Student("afd", "vd", "dewa", 123, 12.2);
            Staff p1 = new Staff("asd", "ad", "ada", 9.8);
            Staff p2 = new Staff("asd", "adaslkdj", "adaf", 19.8);
            Console.WriteLine(s1.toString());
            Console.WriteLine(s2.toString());
            Console.WriteLine(p1.toString());
            Console.WriteLine(p2.toString());
            Console.ReadKey();


        }
    }
}
