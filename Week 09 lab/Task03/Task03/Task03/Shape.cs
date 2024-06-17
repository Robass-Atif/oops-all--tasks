using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public class Shape
    {
        public virtual double getArea()
        {
            return 0;
        }
        public virtual string type()
        {
            return " ";
        }
        public virtual string toString()
        {
            return "The shape is: " + type() + " the area is: " + getArea();
        }
    }
}
