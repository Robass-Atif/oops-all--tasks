using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
   public class FireTruck
    {
        protected Ladder part;
        protected HousePipe pipe;
        protected FireFighter driver;
        protected FireChief chief;
        
        public FireTruck(HousePipe pipe,FireFighter s1,FireChief s2)
        {
            this.pipe = pipe;
            this.driver = s1;
            this.chief = s2;
            part = new Ladder();
            
        }


    }
}
