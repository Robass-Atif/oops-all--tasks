using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public class MyPointCRUD
    {
      static  MyPoint s1 = new MyPoint();
       
       public static void setX(int x)
        {
            s1.x = x;
        }
        public static void setY(int Y)
        {
            s1.y = Y;
        }
        public static double distanceFromZero(MyPoint s1)
        {
            double distance = Math.Sqrt((s1.x - 0) ^ 2 + (s1.y - 0) ^ 2);
            return distance;
        }
    }
}
