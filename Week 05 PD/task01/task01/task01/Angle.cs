using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
     class Angle
    {
        private int degree;
        private  float minute;
        private  char direction;
        public Angle(int degree,float minute)
        {
            this.degree = degree;
            this.minute = minute;
           

        }
        public Angle ()
        {
            degree = 0;
            minute = 0.0F;
            direction =' ';
        }
        public string convertIntoString()
        {
            string value;
            string degree1 = degree.ToString();
            string minute1 = minute.ToString();
            string direction1 = direction.ToString();
            value = degree1 + "\u00b0" + minute1 + "'" + direction1;
            return value;


        }
    }
}
