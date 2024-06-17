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
            Cat c1 = new Cat("sda");
            Cat c2 = new Cat("sfa");

            Dog d1 = new Dog("sadad");
            Dog d2 = new Dog("asdadakhdkad");
            c1.greets();
            d1.greets();
            Console.ReadKey();

        }
    }
}
