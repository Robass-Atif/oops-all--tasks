using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DL;
using Project.UI;
using Project.BL;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "admin.txt";
            string path1 = "doctor.txt";
            string path3 ="patient.txt";
            PatientDL.readData(path3);

            DoctorDL.readData(path1);
            AdminDL.readData(path);
            //PatientDL.readData(path3);
            string option = "0";
            while (option!="4")
            {
                Console.Clear();
                option = MenuUI.menu();
                if(option=="1")
                {
                    Console.Clear();
                    SignInterface.sign();
                    MenuUI.clearScreen();

                }
                else if(option=="2")
                {
                    Console.Clear();
                    DoctorBL d1=DoctorUI.inputOfLogin();
                    d1 = DoctorDL.checkDoctor(d1);
                    if(d1!=null)
                    {
                        
                        DoctorUI.DoctorInterface(d1);
                    }
                    else
                    {
                        Console.WriteLine("You enter wrong crendential!");
                    }
                    MenuUI.clearScreen();

                }
                else if(option=="3")
                {
                    Console.Clear();
                    PatientBL d1 = PatientUI.inputOfLogin();
                    d1 = PatientDL.isPatientExist(d1);
                    if (d1!=null)
                    {
                        bool flag = PatientDL.checkPatient(d1);
                        if (flag)
                        {
                            PatientUI.patientInterface(d1);
                        }
                        else
                        {
                            Console.WriteLine("You enter wrong crendential!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You enter wrong credential!");
                    }
                    MenuUI.clearScreen();

                }
            }
            Console.WriteLine("Thank you for visiting!");
            Console.ReadKey();   
        }
    }
}
