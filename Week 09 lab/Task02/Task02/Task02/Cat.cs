using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class Cat:Mammal
    {
        public Cat(string name) : base(name)
        {

        }
        public override string toString()
        {
            string s1 = "Cat[Mammal[Animal[name: " + name + "]";
            return s1;
        }
        public void greets()
        {
            Console.WriteLine("Meow");
        }
    }
}
