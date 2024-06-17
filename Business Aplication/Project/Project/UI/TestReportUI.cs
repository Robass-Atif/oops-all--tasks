using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;
namespace Project.UI
{
   public class TestReportUI
    {
        public static TestReport inputOfTestReport()
        {
            Console.WriteLine("Enter Test name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter test result: ");
            string result = Console.ReadLine();
            TestReport t1 = new TestReport(name, result);
            return t1;
        }
        public static void printTestReport(PatientBL p)
        {
            foreach(TestReport t in p.getTestReport())
            {
                Console.WriteLine("Name: "+t.getTestName()+" and result: "+t.getResult());

            }
           
        }
    }
}
