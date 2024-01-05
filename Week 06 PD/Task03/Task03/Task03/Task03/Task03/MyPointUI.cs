using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
   public class MyPointUI
    {
       public static int getX()
        {
            Console.WriteLine("Enter X coordinate : ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
      public  static int getY()
        {
            Console.WriteLine("Enter Y coordinate : ");
            int y = int.Parse(Console.ReadLine());
            return y;
        }
    }
}
