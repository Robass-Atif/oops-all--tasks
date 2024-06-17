using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;
namespace Project.UI
{
   public class PatientUI
    {
        public static PatientBL inputOfLogin()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            PatientBL p1 = new PatientBL(name, password);
            return p1;

        }
        public static string PatientOption()
        {
            Console.WriteLine( "select the following option!");
            Console.WriteLine("1.view prescription");
            Console.WriteLine("2.bill payment");
            Console.WriteLine( "3.checkup fee");
            Console.WriteLine("4.view appointment") ;
            Console.WriteLine( "5.give review");
            Console.WriteLine("6.view test reports.");
            Console.WriteLine( "7.exit");
            Console.WriteLine("Option: ");
            string option = Console.ReadLine();
            return option;

        }
       public static void patientInterface(PatientBL p)
        {
            DoctorBL patientDoctor = PatientDL.patientDoctor(p);
            string option = "0";
            while(option!="7")
            {
                Console.Clear();
                option = PatientOption();
                if(option=="1")
                {
                    Console.Clear();
                    printPrescription(p);

                    MenuUI.clearScreen();
                }
                else if(option=="2")
                {
                    Console.Clear();
                    if (p.getBill()!=0)
                    {
                        printBill(p);
                    }
                    else
                    {
                        Console.WriteLine("you have no dues!");
                    }
                    MenuUI.clearScreen();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Fee of your Doctor: "+patientDoctor.getFee());
                    
                    MenuUI.clearScreen();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    printAppointmentForPatient(p, patientDoctor);
                    MenuUI.clearScreen();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    if (string.IsNullOrEmpty(p.getReview()))
                    {
                        Console.WriteLine("Enter review about your visit in hospital: ");
                        string review1 = Console.ReadLine();
                        p.setReview(review1);
                        PatientDL.reWriteData();
                    }
                    else
                    {
                        Console.WriteLine("You already given your review!");
                    }
                    MenuUI.clearScreen();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    TestReportUI.printTestReport(p);

                    MenuUI.clearScreen();
                }
            }
        }

        public static PatientBL  takeInput()
        {
            Console.WriteLine("Enter name :");
            string name = Console.ReadLine();
          //  bool checkName = AdminDL.validationOfAlphabet(name);
            Console.WriteLine("Enter password :");
            string password = Console.ReadLine();
           // bool checkPassword = AdminDL.validationOfPassword(password);
            Console.WriteLine("Enter age :");
            string age = Console.ReadLine();
            bool checkAge = AdminDL.validationOfNumber(age);
            Console.WriteLine("Enter disease :");
            string disease = Console.ReadLine();
            Console.WriteLine("Enter medicine :");
            string medicine = Console.ReadLine();
            Console.WriteLine("Enter contact :");
            string contact = Console.ReadLine();
            bool checkContact = AdminDL.validationOfNumber(contact);
         // bool contactLength = PatientDL.validationOfContactLength(contact);
            if ( checkAge && checkContact)
            {
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(age) && !string.IsNullOrEmpty(disease) && !string.IsNullOrEmpty(medicine) && !string.IsNullOrEmpty(contact))
                {
                    PatientBL p1;
                    p1= new PatientBL(name, password, age, disease, medicine, contact);
                    return p1;
                }
            }
            return null;
        }
        public static void printPatientData()
        {
            foreach(DoctorBL y in DoctorDL.doctors)
            {
                Console.Write(y.getName());
                foreach(PatientBL x in y.getList())
                {
                    Console.Write(x.getName()+"\t");
                }
                Console.WriteLine();
            }
        }
        public static void printPatientOfDoctor(DoctorBL d)
        {
            Console.WriteLine("Patients:");
            Console.WriteLine("Name \t password \t age \t disease\t Medicine \t contact");
            foreach( PatientBL x in d.getList())
            {
                Console.WriteLine(x.getName() + "\t" + x.getPassword() + "\t\t" + x.getAge() + "\t" + x.getDisease() + "\t\t" + x.getMedicine() + "\t\t" + x.getContact());
            }

        }
        public static void printPrescription(PatientBL p)
        {
            Console.WriteLine("Prescription: ");
            Console.WriteLine(p.getPrescription());
        }
        public static void printReview()
        {
            
                foreach(PatientBL x in PatientDL.patient)
                {
                    Console.WriteLine(x.getName() + " give this review {" + x.getReview() + "}");
                }
            
            
            
        }

        public static void printAppointmentForPatient( PatientBL p,DoctorBL d)
        {
           if(p.getAppointment().getDay()!="" && p.getAppointment().getTime()!="" )
            {
                Console.WriteLine(p.getAppointment().getDay()+" day and time "+p.getAppointment().getTime()+" and the doctor name is : "+d.getName());

            }
            
        }
        public static void printBill(PatientBL p)
        {
            Console.WriteLine("Total bill  you have to given : "+p.getBill());
            
        }
        
    }
}
