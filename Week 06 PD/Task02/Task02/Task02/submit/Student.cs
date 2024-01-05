using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
   public  class Student
    {
        public string name;
        public int age;
        public float FscMark;
        public float EcatMark;
        public double merit;
        public List<ProgramOffer> preference = new List<ProgramOffer>();
        public List<Subject> regSubject = new List<Subject>();
        public ProgramOffer regDegree;
        public Student(string name,int age,float FscMark,float EcatMark)
        {
            this.name = name;
            this.age = age;
            this.FscMark = FscMark;
            this.EcatMark = EcatMark;
            

        }
        public Student(string name, int age, float FscMark, float EcatMark,List<ProgramOffer> preference)
        {
            this.name = name;
            this.age = age;
            this.FscMark = FscMark;
            this.EcatMark = EcatMark;
            this.preference = preference;

        }
        public void calculateMerit()
        {
            this.merit = (((FscMark / 1000) * 0.45F) + ((EcatMark / 400) * 0.55F)) * 100;
        }
        public bool regStudentSubject(Subject s)
        {
            int STCH = getCreditHours();
            if(regDegree!=null && regDegree.isSubjectExist(s) && STCH+s.creditHour<=9) 
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getCreditHours()
        {
            int count = 0;
            foreach(Subject x in regSubject)
            {
                count = count + x.creditHour;
            }
            return count;
        }
        public float calculatefee()
        {
            float fee = 0;
            if(regDegree!=null)
            {
                foreach(Subject x in regSubject)
                {
                    fee = fee + x.subjectFee;
                }
            }
            return fee;
        }
    }
}
