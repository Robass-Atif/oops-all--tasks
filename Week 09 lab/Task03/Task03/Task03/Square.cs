using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public class Square:Shape
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }
        public override double getArea()
        {
            return side * side;
        }
        public override string type()
        {
            return "Square";
        }
        public override string toString()
        {
            return "The shape is: " + type() + " the area is: " + getArea();
        }

    }
}
