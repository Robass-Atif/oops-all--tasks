using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
   public class FireFighter
    {
        protected string name;
        protected bool isDriver;
        public FireFighter(string name,bool  driver)
        {
            this.name = name;
            this.isDriver = driver;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public bool  getIsDriver()
        {
            return isDriver;
        }
        public void setIsDriver(bool name)
        {
            this.isDriver = name;
        }

    }
}
