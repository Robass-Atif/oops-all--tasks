using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public  class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;

        }
        public virtual string toString()
        {
            string s1 = "Animal[name: " + name + "]";
            return s1;
        }
        public virtual void greets()
        {

        }

    }
}
