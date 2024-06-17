using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task01.BL;

namespace Task01.BL
{
  public class CellBL
    {
        public char value;
        public int x;
        public int y;
        public CellBL(int x,int y, char value)
        {
            this.x = x;
            this.y = y;
            this.value = value;
        }
        public char getValue()
        {
            return value;
        }
        public void setValue(char value)
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
        public bool  isPacmanPresent()
        {

            if(this.value=='p')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isGhostPresent( char ghostCharacter)
        {
            if(this.value==ghostCharacter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
