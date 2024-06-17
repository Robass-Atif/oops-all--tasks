using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_with_window_form
{
   public class PatientBL:Person
    {
        private string age;
        private string disease;
        private string medicine;
        private string contact;
        private string review;
        private string prescription;
        private int billPayment;
        private AppointmentBL appointment;
        private List<TestReport> test;
        public PatientBL(string name,string password ): base(name,password)
        {

        }
        public PatientBL(string name, string password,string age,string disease,string medicine,string contact) : base(name, password)
        {
            this.age = age;
            this.disease = disease;
            this.medicine = medicine;
            this.contact = contact;
            this.appointment=new AppointmentBL("","");
            this.test=new List<TestReport>();
            prescription = "";
        }
        public int getBill()
        {
            return billPayment;
        }
        public void setBill(int bill)
        {
            this.billPayment=bill;
        }
        public List<TestReport> getTestReport()
        {
            return test;
        }

        public void setTestReport(List<TestReport> test)
        {
            this.test=test;
        }
        public AppointmentBL getAppointment()
        {
            return appointment;
        }
        public void setAppointmnet(AppointmentBL appointment)
        {
            this.appointment =appointment;
        }
        public string getPrescription()
        {
            return prescription;
        }
        public void setPrescription(string prescription)
        {
            this.prescription = prescription;
        }
        public string getReview()
        {
            return review;
        }
        public void setReview(string review)
        {
            this.review = review;
        }
        public string getAge()
        {
            return age;
        }
        public string getDisease()
        {
            return disease;
        }
        public string getMedicine()
        {
            return medicine;
        }
        public string getContact()
        {
            return contact;
        }
        public void setAge(string age)
        {
            this.age = age;
        }
        public void setDisease(string disease)
        {
            this.disease = disease;
        }
        public void setMedicine(string medicine)
        {
            this.medicine = medicine;
        }
        public void setContact(string contact)
        {
            this.contact = contact;
        }
        public override string toStirng()
        {
            return base.toStirng()+"\t"+age+"\t"+disease+"\t"+medicine+"\t"+contact;
        }
    }
}
