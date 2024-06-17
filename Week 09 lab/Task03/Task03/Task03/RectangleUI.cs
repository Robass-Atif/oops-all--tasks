using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class RectangleUI
    {
        public static Rectangle input()
        {
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());
            Rectangle c1 = new Rectangle(width,height);
            return c1;
        }
    }
}
