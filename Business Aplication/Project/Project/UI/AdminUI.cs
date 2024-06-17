using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;
namespace Project.UI
{
  public   class AdminUI
    {
        public static AdminBL inputOfAdmin()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            bool checkName = AdminDL.validationOfAlphabet(name);
            Console.WriteLine("Enter password: ");

            string password = Console.ReadLine();
            bool checkPassword = AdminDL.validationOfPassword(password);
            if (checkName &&checkPassword)
            {
                AdminBL p1;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
                {
                    p1 = new AdminBL(name, password);
                    return p1;
                }
            }
            return null;

        }
        public static void AdminInterFace()
        {
            string option = "0";
            while(option!="9")
            {
                Console.Clear();
                option = adminOption();
                if(option=="1")
                {
                    Console.Clear();
                    DoctorUI.printDoctorRecord();
                    MenuUI.clearScreen();
                }
                else if(option=="2")
                {
                    Console.Clear();
                    DoctorUI.printDoctorRecord();
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    bool flag1 = AdminDL.validationOfAlphabet(name);
                    Console.WriteLine("Enter fee");
                    string fee = (Console.ReadLine());
                    bool flag2 = AdminDL.validationOfNumber(fee);
                    if (flag1 && flag2)
                    {
                        bool flag = DoctorDL.updateDoctor(name, fee);
                        if (flag==true)
                        {
                            DoctorDL.rewriteData();
                            Console.WriteLine("Fee update sucessfully!");
                        }
                        else
                        {
                            Console.WriteLine("You  enter wrong data");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You  enter wrong data");

                    }
                    MenuUI.clearScreen();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    DoctorBL s1 = DoctorUI.addDoctor();
                    if (s1!=null)
                    {
                        bool flag = DoctorDL.sameDoctor(s1);
                        if (flag)
                        {
                            DoctorDL.addIntolist(s1);
                            DoctorDL.storeData(s1);
                            Console.WriteLine("Doctor login Sucessfully");
                        }
                        else
                        {
                            Console.WriteLine("this Doctor already Exist");
                        }
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong input!");
                    }
                    MenuUI.clearScreen();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    DoctorUI.printDoctorRecord();
                    Console.WriteLine("Enter Name: ");
                    string name = Console.ReadLine();
                    bool flag = DoctorDL.deleteDoctor(name);
                    if(flag)
                    {
                        DoctorDL.rewriteData();

                        Console.WriteLine("Doctor delete sucesfully");
                    }
                    else
                    {
                        Console.WriteLine("sorry you enter wrong data!");
                    }
                    
                    MenuUI.clearScreen();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Reviews: ");
                    PatientUI.printReview();
                    MenuUI.clearScreen();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Name \t \t Patient");

                    PatientUI.printPatientData();
                    MenuUI.clearScreen();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    printBillPayment();
                    MenuUI.clearScreen();
                }
                else if (option == "8")
                {
                    Console.Clear();
                    DoctorUI.printDoctorRecord();
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    bool flag1 = AdminDL.validationOfAlphabet(name);
                    Console.WriteLine("Enter Salary");
                    string salary = (Console.ReadLine());
                    bool flag2 = AdminDL.validationOfNumber(salary);
                    if (flag1 && flag2)
                    {
                        bool flag = DoctorDL.updateSalary(name, salary);
                        if (flag)
                        {
                            DoctorDL.rewriteData();

                            Console.WriteLine("SucessFully updated !");
                        }
                        else
                        {
                            Console.WriteLine("You enter wrong Data");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You enter wrong Data");

                    }
                    MenuUI.clearScreen();
                }
                else if (option == "9")
                {
                    break;
                }
            }

        }
        public static string adminOption()
        {
            Console.WriteLine( "Select one of the following!");        
            Console.WriteLine( "1.view record");
            Console.WriteLine( "2.update fee" );
            Console.WriteLine( "3.add doctor");
            Console.WriteLine("4.delete doctor");
            Console.WriteLine( "5.view reviews");
            Console.WriteLine( "6.view patient");
            Console.WriteLine( "7.view bill payments");
            Console.WriteLine( "8.update salary");
            Console.WriteLine( "9.exit" );
            Console.WriteLine("Option: ");
            string option=Console.ReadLine();
            return option;
          
        }
        public static void printBillPayment()
        {
            foreach(DoctorBL y in DoctorDL.doctors)
            {
              foreach(string x in y.getTransiction())
                {
                    Console.WriteLine(y.getName()+"  \t"+x);
                }
            }
        }
    }
}
