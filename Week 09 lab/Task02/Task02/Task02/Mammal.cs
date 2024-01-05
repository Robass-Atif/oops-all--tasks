using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class Mammal:Animal
    {
        public Mammal(string name) : base(name)
        {

        }
        public override string toString()
        {
            string s1 = "Mammal[ Animal[name: " + name + "]";
            return s1;
        }
        public virtual void greets()
        {

        }

    }
}
