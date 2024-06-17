using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public  class Circle:Shape
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return 2 * Math.PI * radius * radius;
        }
        public override string type()
        {
            return "Circle";
        }
        public override string toString()
        {
            return "The shape is: " + type() + " the area is: " + getArea();
        }
    }
}
