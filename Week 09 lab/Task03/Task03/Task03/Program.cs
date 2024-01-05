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
            Circle c1 = CircleUI.input();
            Rectangle r1 = RectangleUI.input();
            Square s1 = SquareUI.input();
            ShapeDl.addIntoList(s1);
            ShapeDl.addIntoList(c1);
            ShapeDl.addIntoList(r1);
            ShapeDl.printInfo();
            Console.ReadKey();
        }
    }
}
