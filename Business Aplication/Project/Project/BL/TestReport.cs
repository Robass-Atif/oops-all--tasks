using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DL;
using Project.UI;
namespace Project.BL
{
   public  class TestReport
    {
        private string testName;
        private string result;
        public TestReport(string name,string result)
        {
            this.testName=name;
            this.result=result;
        }
        public string getTestName()
        {
            return testName;
        }
        public void setTestName(string testName)
        {
            this.testName=testName;
        }
        public string getResult()
        {
            return result;
        }
        public void setBill(string result)
        {
            this.result=result;
        }
    }
}
