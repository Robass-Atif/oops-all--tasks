using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public  class CircleUI
    {
        public static Circle  input()
        {
            Console.Write("Enter radius: ");
            int radius = int.Parse(Console.ReadLine());
            Circle c1 = new Circle(radius);
            return c1;
        }
    }
}
