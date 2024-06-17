using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;
namespace Project.UI
{
   public  class DoctorUI
    {
        public static DoctorBL inputOfLogin()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            DoctorBL p1 = new DoctorBL(name, password);
            return p1;

        }
        public static string DoctorOption()
        {
            Console.WriteLine("Select the following option!");
            Console.WriteLine("1.add patient") ;
            Console.WriteLine( "2.delete patient");
            Console.WriteLine("3.view appointment") ;
            Console.WriteLine("4.cancel appointment");
            Console.WriteLine( "5.add appointment" );
            Console.WriteLine( "6.add prescription");
            Console.WriteLine("7.add bill payment");
            Console.WriteLine("8.generate test reports");
            Console.WriteLine("9.view record");
            Console.WriteLine("10.exit");
            Console.WriteLine("Option: ");
            string option=Console.ReadLine();
            return option;
        }
        public static void DoctorInterface(DoctorBL doctor)
        {
            string option = "0";
            while (option != "10")
            {
                Console.Clear();
                option = DoctorOption();
                if (option == "1")
                {
                    Console.Clear();
                    PatientBL p1 = PatientUI.takeInput();
                    if (p1!=null)
                    {
                        bool flag = PatientDL.samePatient(p1);
                        if (!flag)
                        {
                            doctor.addPatientList(p1);
                            PatientDL.addIntoList(p1);

                            p1.setBill(doctor.getFee()+100);

                            PatientDL.storeData(p1);
                            DoctorDL.rewriteData();
                            Console.WriteLine("Patient sucessfully login");
                        }
                        else
                        {
                            Console.WriteLine("this patient under another doctor custidiy");
                        }
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong input");
                    }

                    
                    
                    MenuUI.clearScreen();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    PatientUI.printPatientOfDoctor(doctor);
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                   bool flag= doctor.deletePatient(name);
                    bool flag1 = PatientDL.deletePatient(name);
                    if(flag && flag1)
                    {
                        PatientDL.reWriteData();
                        Console.WriteLine("Suceesfully Deleted");
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong input");
                    }
                    MenuUI.clearScreen();
                }
                else if (option=="3")
                {
                    Console.Clear();
                    AppointmentUI.printAppointment(doctor);
                    MenuUI.clearScreen();

                }
                else if (option == "4")
                {
                    Console.Clear();
                    PatientUI.printPatientOfDoctor(doctor);

                    Console.WriteLine("Enter Name of Patient : ");
                    string name = Console.ReadLine();
                    PatientBL p1 = DoctorDL.deleteAppointment(doctor,name);
                    if (p1!=null)
                    {
                        
                        bool flag = DoctorDL.deletePatientAppointment( p1);
                        if(flag)
                        {
                            PatientDL.reWriteData();

                            Console.WriteLine("Appointment delete succesfully!");
                        }
                        else
                        {
                            Console.WriteLine("this patient has no appointment");
                        }
                    }
                    else
                    {
                        Console.WriteLine("sorry there is no such type of patient!");
                    }
                    MenuUI.clearScreen();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    PatientUI.printPatientOfDoctor(doctor);

                    Console.WriteLine("Enter Name of Patient : ");
                    string name = Console.ReadLine();
                   PatientBL p= PatientDL.Patient(name,doctor);
                    if (p!=null)
                    {

                        if (p.getAppointment().getDay()=="" && p.getAppointment().getTime()=="")
                        {

                            AppointmentBL a1 = AppointmentUI.inputAppointment();
                            bool flag = DoctorDL.addappointmemt(name, a1, doctor);
                            if (flag)
                            {
                                PatientDL.reWriteData();
                                Console.WriteLine("Appointment added successfully!");
                            }
                            else
                            {
                                Console.WriteLine("You enter wrong input!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("this patient has already has assignment!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You enter wrong input !");
                    }
                    MenuUI.clearScreen();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Enter name of patient: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter prescription: ");
                    string prescription = Console.ReadLine();
                    bool flag = doctor.addPrescription(name, prescription);
                    if(flag)
                    {
                        PatientDL.reWriteData();
                        Console.WriteLine("SUcessfully added!");

                    }
                    else
                    {
                        Console.WriteLine("Sorry you enter wrong patient!");
                    }
                    

                    MenuUI.clearScreen();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    PatientUI.printPatientOfDoctor(doctor);
                    Console.WriteLine("Enter patient name  :  ");
                    string name = Console.ReadLine();
                    
                    int flag = PatientDL.addBillPayment(name, doctor);
                    Console.WriteLine("Due amount: "+flag);
                    if(flag!=0)
                    {
                        Console.WriteLine("Enter amount which patient given: ");
                        string amount = Console.ReadLine();
                        bool check = PatientDL.validationOfBill(amount);
                        if(check)
                        {
                            if (flag==int.Parse(amount))
                            {
                                doctor.getTransiction().Add(amount.ToString());

                                foreach (PatientBL p in doctor.getList())
                                {
                                    if (name==p.getName())
                                    {


                                        p.setBill(0);
                                        PatientDL.reWriteData();
                                    }
                                }
                                Console.WriteLine("payment transfererd");
                            }
                            else
                            {
                                Console.WriteLine("Please enter correct input");
                            }
                        }
                        else
                        {
                            Console.WriteLine("wrong input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong input");
                    }
                    MenuUI.clearScreen();
                }
                else if (option == "8")
                {
                    Console.Clear();
                    Console.WriteLine("Enter patient name: ");
                    string name = Console.ReadLine();
                    TestReport t = TestReportUI.inputOfTestReport();
                    bool flag = PatientDL.checkTestReport(t, name, doctor);
                    if(flag)
                    {
                        PatientDL.reWriteData();
                        Console.WriteLine("Add sucessFully");
                    }
                    else
                    {
                        Console.WriteLine("You enter wrong input!");
                    }

                    MenuUI.clearScreen();
                }
                else if (option == "9")
                {
                    Console.Clear();
                    PatientUI.printPatientOfDoctor(doctor);

                    MenuUI.clearScreen();
                }
                else if (option == "10")
                {
                    break;
                }

            }
        } 

        public static DoctorBL addDoctor()
        {
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            bool checkName = AdminDL.validationOfAlphabet(name);
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            bool checkPassword = AdminDL.validationOfPassword(password);
            Console.WriteLine("Enter salary:  ");
            string salary = (Console.ReadLine());
            bool checkSalary = AdminDL.validationOfNumber(salary);

            Console.WriteLine("Enter fee: ");
            string fee = (Console.ReadLine());
            bool checkfee = AdminDL.validationOfNumber(fee);

            if (checkName==true && checkSalary==true && checkfee==true && checkPassword==true)
            {
                DoctorBL d;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(salary) && !string.IsNullOrEmpty(fee))
                {
                    int s = int.Parse(salary);
                    int f = int.Parse(fee);
                    d= new DoctorBL(name, password, s, f);
                    return d;
                }
            }
            return null;
        }
        public static void printDoctorRecord()
        {
            Console.WriteLine("Name \t Password \t Salary \t fee");
            foreach (DoctorBL x in DoctorDL.doctors)
            {
                Console.WriteLine(x.getName() + "\t" + x.getPassword() + "\t\t" + x.getSalary() + "\t\t" + x.getFee());
            }
        }
    }
}
