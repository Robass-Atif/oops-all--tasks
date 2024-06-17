using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_with_window_form
{
   public class DoctorBL:Person
    {
        private int salary;
        private int fee;
        private List<string> transiction=new List<string>();
        public List<PatientBL> pat = new List<PatientBL>();
        public void setTransiction(List<string> s1)
        {
            transiction = s1;
        }
        public List<string> getTransiction()
        {
            return transiction;
        }
        public void setList(List<PatientBL> s1)
        {
            pat = s1;
        }
        public List<PatientBL> getList()
        {
            return pat;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public void setFee(int fee)
        {
            this.fee = fee;
        }
        public int getSalary()
        {
            return salary;
        }
        public int getFee()
        {
            return fee;
        }
        public void addPatientList(PatientBL s1)
        {
            pat.Add(s1);
        }

         public DoctorBL(string name,string password): base (name,password)
        {

        }
        public DoctorBL(string name, string password,int salary,int fee) : base(name, password)
        {
            this.salary = salary;
            this.fee = fee;
        }
        public  bool deletePatient(string name)
        {

            foreach (PatientBL x in pat)
            {
                if (x.getName() == name)
                {
                    pat.Remove(x);
                    return true;

                }
            }
            return false;


        }
        public bool addPrescription(string name, string prescription)
        {
            foreach (PatientBL x in pat)
            {
                if (x.getName() == name && x.getPrescription()=="")
                {
                    x.setPrescription(prescription);
                    return true;
                }
            }
            return false;
        }
        public override string toStirng()
        {
            
            return base.toStirng()+"\t"+salary+"\t"+"fee";
        }
    }
}
