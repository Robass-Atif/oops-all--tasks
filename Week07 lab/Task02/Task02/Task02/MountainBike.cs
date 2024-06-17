using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class MountainBike:Bicycle
    {
        private int seatHeight;
        public MountainBike(int cadence,int gear,int speed, int seat):base(cadence,gear,speed)
        {
            this.seatHeight = seat;
        }
        public void setSeatHeight(int s1)
        {
            seatHeight = s1;
        }
    }
}
