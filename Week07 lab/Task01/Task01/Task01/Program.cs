using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            HousePipe s1 = new HousePipe(true, false, 4, 5);
            FireFighter s2 = new FireFighter("robass", true);
            FireChief s3 = new FireChief("ali", false);
            FireTruck s4 = new FireTruck(s1, s2, s3);

        }
    }
}
