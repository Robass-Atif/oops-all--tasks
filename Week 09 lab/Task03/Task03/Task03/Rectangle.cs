using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public  class Rectangle:Shape
    {
        private int width;
        private int height;
        public Rectangle(int width,int height)
        {
            this.width=width;
            this.height = height;

        }
        public override double getArea()
        {
            return width * height;
        }
        public override string type()
        {
            return "Rectangle";
        }
        public override string toString()
        {
            return "The shape is: " + type() + " the area is: " + getArea();
        }

    }
}
