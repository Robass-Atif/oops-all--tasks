using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.Clear();
                string option = menu();
                if(option=="1")
                {
                    Console.Clear();
                    Student s1 = StudentUI.addStudent();
                    StudentCrud.addStudentList(s1);

                    clearScreen();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    ProgramOffer s1 = DegreeUI.addProgram();
                    ProgramCrud.addProgramOffer(s1);
                    clearScreen();
                }
               else if (option == "3")
                {
                    Console.Clear();
                    List<Student> sortedStudentList = ProgramCrud.sortStudentByMerit();
                    ProgramCrud.giveAdmission(sortedStudentList);
                    StudentUI.printStudent();
                    clearScreen();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    StudentUI.viewRegisterStudent();
                    clearScreen();
                }
                if (option == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Enter degree Name :");
                    string name = Console.ReadLine();
                    StudentUI.viewStudentInDegree(name);
                    clearScreen();
                }
               else if (option == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Enter Student name: ");
                    string name = Console.ReadLine();
                    Student s = StudentCrud.studentPresent(name);
                    if(s!=null)
                    {
                        SubjectUI.viewSubject(s);
                        SubjectUI.registerSubject(s);
                    }
                    clearScreen();
                }
               else  if (option == "7")
                {
                    Console.Clear();
                    StudentCrud.calculateFeeForAll();
                    clearScreen();
                }
               else  if (option == "8")
                {
                    break;
                }
               
            }
            Console.WriteLine("ThankYou For Visit!");
        }
        static string menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View register Student");
            Console.WriteLine("5.View Student of Specific Program");
            Console.WriteLine("6.Register Subject for a specific Student");
            Console.WriteLine("7.CalCulate Fee of All Register Student");
            Console.WriteLine("8.Exit");
            Console.WriteLine("Option: ");
            string option = Console.ReadLine();
            return option;
        }
        static void clearScreen()
        {
            Console.WriteLine("Press any key to contiue . . .");
            Console.ReadKey();
        }
        static void header()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-------------------  UAMS  --------------------");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
