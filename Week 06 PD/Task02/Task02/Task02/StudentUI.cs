using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class StudentUI
    {
        public static Student addStudent()
        {
            List<ProgramOffer> preference = new List<ProgramOffer>();
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age  =  int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FscMArk: ");
            float FscMark =float.Parse( Console.ReadLine());
            Console.WriteLine("Enter Ecat Mark: ");
            float  EcatMArk =float.Parse( Console.ReadLine());
            Student s1 = new Student(name, age, FscMark, EcatMArk);
            Console.WriteLine("Available Degree Program");
           DegreeUI.viewDegreeProgram();
            Console.WriteLine("How many prefrences you want to enter: ");
            int count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Enter Deg name:");
               string degName = Console.ReadLine();
                bool flag = false;
                foreach(ProgramOffer x in ProgramCrud.degreeList)
                {
                    if(x.degreeTitle==degName && !(preference.Contains(x)))
                    {
                        s1.preference.Add(x);
                        flag = true;
                        break;
                    }
                }
                if(flag==false)
                {
                    Console.WriteLine("Enter valid Program");
                }

            }
            
            return s1;

        }

        public static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            foreach(Student s in StudentCrud.studentList)
            {
                if(s.regDegree!=null)
                {
                    if(s.regDegree.degreeTitle!=null)
                    {
                        Console.WriteLine(s.name + "\t" + s.FscMark + "\t" + s.EcatMark + "\t" + s.age);
                    }
                }
            }
        }
        public static void viewRegisterStudent()
        {
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            foreach (Student s in StudentCrud.studentList)
            {
                if (s.regDegree != null)
                {
                   
                        Console.WriteLine(s.name + "\t" + s.FscMark + "\t" + s.EcatMark + "\t" + s.age);
                    
                }
            }
        }
        public static void printStudent()
        {
            foreach (Student x in StudentCrud.studentList)
            {
                if (x.regDegree != null)
                {
                    Console.WriteLine(x.name + " got admission in " + x.regDegree.degreeTitle);
                }
                else
                {
                    Console.WriteLine(x.name + " not got Admission");
                }

            }
        }
    }
}
