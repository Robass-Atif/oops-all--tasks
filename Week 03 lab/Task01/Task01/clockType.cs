using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class clockType
    {
        public clockType()
        {
            hours = 0;
            seconds = 0;
            minutes = 0;
        }
        public clockType(int h)
        {
            hours = h;
        }
        public clockType(int h ,int m)
        {
            hours = h;
            minutes = m;
        }
        public clockType( int h,int m,int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public int seconds;
        public int hours;
        public int minutes;

        public void incrementSeconds()
        {
            seconds++;
        }
        public void incrementMinutes()
        {
            minutes++;
        }
        public void incrementHours()
        {
            hours++;
        }
        public void printTime()
        {
            Console.WriteLine("hours: " + hours + ", Minutes: " + minutes + ", Second : " + seconds);
        }
        public bool isEqual(int h,int m,int s)
        {
            if (hours == h && minutes == m && seconds==s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType value)
        {

            if(value.hours==hours && value.minutes==minutes && value.seconds==seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int elapseTime(int time)
        {
            int total = time - 0;
            return total;

        }
        public int currentTime(int time)
        {
            int total = (24 * 60 * 60) - time;
            return total;
        }


        public void difference(clockType obj)
        {
            hours = obj.hours - hours;
            minutes = obj.minutes - minutes;
            seconds = obj.seconds - seconds;
        }

      

    }
}
