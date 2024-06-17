using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public class SquareUI
    {
        public static Square input()
        {
            Console.Write("Enter width: ");
            int side = int.Parse(Console.ReadLine());
            
            Square c1 = new Square(side);
            return c1;
        }
    }
}
