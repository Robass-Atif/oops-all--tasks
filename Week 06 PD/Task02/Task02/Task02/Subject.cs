using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public class Subject
    {
        public string code;
        public int creditHour;
        public  string subjectType;
        public int subjectFee;
        public Subject(string code,int creditHour,string subjectType,int subjectFee)
        {
            this.code = code;
            this.creditHour = creditHour;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }

    }
}
