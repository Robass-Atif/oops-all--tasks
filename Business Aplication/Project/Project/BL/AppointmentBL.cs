﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DL;
using Project.UI;
namespace Project.BL
{
  public   class AppointmentBL
    {
        private string day;
        private string time;
        public AppointmentBL(string day,string time)
        {
            this.day=day;
            this.time=time;
        }
        public string getDay()
        {
            return day;
        }
        public void setDay(string day)
        {
            this.day = day;
        }
        public string getTime()
        {
            return time;
        }
        public void setTime(string time)
        {
            this.time = time;
        }
    }
}
