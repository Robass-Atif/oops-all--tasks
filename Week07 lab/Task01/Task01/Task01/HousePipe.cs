using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
   public class HousePipe
    {
        private bool isRubber;
        private bool isCircular;
        private int diameter;
        private int rate;
        public HousePipe(bool isRubber,bool isCircular,int diameter,int rate)
        {
            this.isCircular = isCircular;
            this.isRubber = isRubber;
            this.diameter = diameter;
            this.rate = rate;
        }
        public bool getIsRubber()
        {
            return isRubber;
        }
        public void setIsRubber(bool s1)
        {
            isRubber = s1;
        }
        public bool getIsCircular()
        {
            return isCircular;
        }
        public void setIsCircular(bool s1)
        {
            isCircular = s1;
        }
        public int getDiameter()
        {
            return diameter;
        }
        public void setdiameter(int s1)
        {
            diameter = s1;
        }
        public int getRate()
        {
            return rate;
        }
        public void setRate(int s1)
        {
            rate = s1;
        }

    }
}
