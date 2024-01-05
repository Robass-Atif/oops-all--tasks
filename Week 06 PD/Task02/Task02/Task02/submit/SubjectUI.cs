using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  public  class SubjectUI
    {
        public static void registerSubject(Student s)
        {
            Console.WriteLine("Enter the SUbject you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Enter Subject code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subject x in s.regDegree.subjects)
                {
                    if(code==x.code && !(s.regSubject.Contains(x)))
                    {
                        s.regStudentSubject(x);
                        flag = true;
                        break;
                    }
                }
                if(flag==false)
                {
                    Console.WriteLine("Enter valid code");
                }

            }
        }
        public static Subject takeInputForSubject()
        {
            string type, code;
            int creditHours, fee;
            Console.WriteLine("Enter Subject Code :");
            code = Console.ReadLine();
            Console.WriteLine("Enter Subject type :");
            type = Console.ReadLine();
            Console.WriteLine("Enter Subject credit Hour :");
             creditHours= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject fee :");
           fee = int.Parse(Console.ReadLine());
            Subject s1 = new Subject(code, creditHours,type, fee);
            return s1;

        }
        public static void viewSubject( Student s)
        {
            if(s.regDegree!=null)
            {
                Console.WriteLine("sub COde\t Sub type");
                foreach(Subject x in s.regDegree.subjects)
                {
                    Console.WriteLine(x.code + " \t" + x.subjectType);
                }
            }
        }
    }
}
