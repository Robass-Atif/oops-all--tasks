using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
   public  class Ladder
    {
        private int length;
        private string color;

        public Ladder()
        {
            this.length = 0;
            this.color = "";
        }

        public Ladder(int length,string color)
        {
            this.length = length;
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public int getlength()
        {
            return length;
        }
        public void setlength(int length)
        {
            this.length = length;
        }
    }
}
