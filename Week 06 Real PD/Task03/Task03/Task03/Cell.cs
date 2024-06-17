using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public class Cell
    {
        public char value;
        public int x;
        public int y;
        public Cell( int x,int y, char value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }
        public char getValue()
        {
            return this.value;
        }
        public void setValue( char value)
        {
            this.value = value;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public bool isPacmanPresent()
        {
            if(value=='p'|| value=='P')
            {
                return true;
            }
            return false;
        }
        public bool isGhostPresent(char ghostCahracter)
        {
            if(value==ghostCahracter)
            {
                return true;
            }
            return false;
        }
    }
}
