using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    class Ship
    {
        public int shipNumber;
        public string shipLatitude;
        public string shipLongitude;
        public Ship(int shipNumber,string shipLatitude,string shipLongitude)
        {
            this.shipLatitude = shipLatitude;
            this.shipLongitude = shipLongitude;
            this.shipNumber = shipNumber;
        }
        public Ship()
        {
            shipNumber = 0;
            shipLatitude = "";
            shipLongitude = "";
        }

        public void printPosition( )
        {
            Console.WriteLine("The ship position is " + shipLatitude + " and " + shipLongitude);
        }
    }
}
