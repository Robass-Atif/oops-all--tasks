using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Student
    {
        public string name;
        public string password;
        public int role;
        public Student(string name,string password, int role)
        {
            this.name = name; 
            this.password = password;
            this.role = role;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            task03();
            Console.ReadKey();

        }
        static void task01()
        {
            List<string> data = new List<string>() { "hello","body","ali" };
            data.Sort();
            foreach(string x in data)
            {
                Console.WriteLine(x);
            }
            
        }
        static void task02()
        {
            List<float> data = new List<float>() { 0.8F,0.3F, 0.47F };
            data.Sort();
            foreach (float x in data)
            {
                Console.WriteLine(x);
            }
        }

        static void task03()
        {
            Student s1 = new Student("ali", "123", 12);
            Student s2 = new Student("ahmad", "123", 13);
            Student s3 = new Student("saad", "123", 14);
            List<Student> x = new List<Student>() { s1, s2, s3 };
            List<Student> y = x.OrderByDescending(s => s.role).ToList();
            foreach(Student i in y)
            {
                Console.WriteLine(i.name + "  " + i.role + "   " + i.password);
            }
        }
    }
}
