using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;
namespace Project.UI
{
  public   class AppointmentUI
    {
        public static AppointmentBL inputAppointment()
        {
            Console.WriteLine("Enter Day of appointment: ");
            string day = Console.ReadLine();
            Console.WriteLine("Enter time of appointment : ");
            string time = Console.ReadLine();
            AppointmentBL a1 = new AppointmentBL(day,time);
            return a1;
        }
        public static void printAppointment(DoctorBL d1)
        {
            foreach(PatientBL y in d1.getList())
            {
                if (y.getAppointment().getDay()!="" && y.getAppointment().getDay()!="")
                {


                    Console.WriteLine(y.getName()+" has appointment with you at that "+y.getAppointment().getDay()+" and "+y.getAppointment().getTime());
                }

                }
            }
        public static void printPatientAppoinment(PatientBL p1)
        {
            Console.WriteLine(p1.getName()+" has the appointent: ");

           
                Console.WriteLine(p1.getAppointment().getDay()+" day and time is: "+p1.getAppointment().getTime());
            
        }
    }
}
