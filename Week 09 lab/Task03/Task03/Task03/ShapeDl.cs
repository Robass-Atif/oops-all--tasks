using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public  class ShapeDl
    {
        private static List<Shape> shapes = new List<Shape>();
        public static List<Shape> getList()
        {
            return shapes;
        }
        public static void addIntoList(Shape s1)
        {
            shapes.Add(s1);
        }
        public static void printInfo()
        {
            foreach(Shape x in shapes)
            {
                string y = x.toString();
                Console.WriteLine(y);
            }
        }
    }
}
