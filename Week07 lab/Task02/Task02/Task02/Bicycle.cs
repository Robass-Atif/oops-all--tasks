using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  public  class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;
        public Bicycle(int cadence,int gear,int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;

        }
        public int getCadence()
        {
            return cadence;
        }
        public void setCadence(int s1)
        {
            this.cadence = s1;
        }

        public int getGear()
        {
            return gear;
        }
        public void setGear(int s1)
        {
            this.gear = s1;
        }
        public int getSpeed()
        {
            return speed;
        }
        public void setSpeed(int s1)
        {
            this.speed = s1;
        }
        public void applyBrake(int decrement)
        {
            speed = speed - decrement;
        }
        public void speedUp(int increment)
        {
            speed = speed - increment;
        }
    }
}
