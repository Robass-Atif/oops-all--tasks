using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public class MyLineCRUD
    {
        static MyLine s1=new MyLine();
        public static void setBegin(MyPoint s2)
        {
            s1.begin = s2;
        }
        public static void setEnd(MyPoint s2)
        {
            s1.end = s2;
        }
        public static MyPoint getBeginPoint()
        {
            return s1.begin;
        }
        public static MyPoint getEndPoint()
        {
            return s1.end;
        }
        public static double getLength()
        {
            double length = Math.Sqrt((s1.end.x - s1.begin.x)^2  + (s1.end.y - s1.begin.y)^2);

            return length;
        }
        public static double getGradient()
        {
            double gradient= (s1.end.y - s1.begin.y) / (s1.end.x - s1.begin.y);
            return gradient; 
        }
        public static MyPoint getBegin()
        {

            MyPoint s1 = new MyPoint(MyLineCRUD.s1.begin.x, MyLineCRUD.s1.begin.y);
            return s1;
        }
        public static MyPoint getEnd()
        {
           
            MyPoint s1 = new MyPoint(MyLineCRUD.s1.end.x, MyLineCRUD.s1.end.y);

            return s1;
        }
        

    }
}
