using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[10];
            char option;
            int count = 0;
            do
            {
                Console.Clear();
                option = menu();
                if (option == '1')
                {
                    s[count] = addStudent();
                    count++;
                }
                else if (option == '2')
                {
                    viewStudent(s, count);
                }
                else if (option == '3')
                {
                    topStudent(s, count);
                }
                else if (count == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");

                }

            } while (option != '4');
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
        static char menu()
        {
            Console.WriteLine("1.add a student");
            Console.WriteLine("2. to view student");
            Console.WriteLine("3. to view  Top Three student");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Option:");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        static Student addStudent()
        {
            Console.Clear();
            Student s1 = new Student();
            Console.WriteLine("Enter name: ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll no: ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA: ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter department: ");
            s1.department = Console.ReadLine();
            Console.WriteLine("Enter Hostelite (y||n): ");
            s1.isHostelite = char.Parse(Console.ReadLine());
            return s1;
        }
        static void viewStudent(Student[] s, int count)
        {
            Console.Clear();
            for(int i=0;i<count;i++)
            {
            Console.WriteLine("Name: {0} Roll no: {1} CGPA:{2} Department;{3} isHostelite:{4}",s[i].name,s[i].roll_no,s[i].cgpa,s[i].department,s[i].isHostelite);
            }
            Console.WriteLine("Press any key to comtinue!!");
            Console.ReadKey();

        }
        static void topStudent(Student[] s,int count)
        {
            Console.Clear();
            if(count==0)
            {
                Console.WriteLine("NO record Found");
            }
            else if(count==1)
            {
                viewStudent(s, 1);
            }
            else if(count==2)
            {
                for(int x=0;x<2;x++)
                {
                    int index = largest(s, x, count);
                    Student temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 2);
            }
            else if(count==3)
            {
                for (int x = 0; x < 3; x++)
                {
                    int index = largest(s, x, count);
                    Student temp = s[index];
                    s[index] = s[x];
                    s[x] = temp;
                }
                viewStudent(s, 3);
            }
            Console.ReadKey();
        }
        static int largest(Student[] s,int start,int end)
        {
            int index = start;
            float large= s[start].cgpa;
            for(int i=start;i<end;i++)
            {
                if(large<s[i].cgpa)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;
        }


    }
}
