using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace project_with_window_form
{
   public class PatientDL
    {
     public static List<PatientBL> patient = new List<PatientBL>();  

       public static void addIntoList(PatientBL p1)
        {
            patient.Add(p1);
        }
        public static bool deletePatient(string name)
        {

            foreach (PatientBL x in patient)
            {
                if (x.getName() == name)
                {
                    patient.Remove(x);
                    return true;

                }
            }
            return false;
        }
        public static PatientBL isPatientExist(string name)
        {
            foreach (PatientBL x in PatientDL.patient)
            {
                if (x.getName()==name)
                {
                    return x;
                }
            }
           
            return null;
        }

        public static bool checkPatient(PatientBL b1)
        {

            foreach (DoctorBL y in DoctorDL.doctors)
            {
                
                foreach (PatientBL x in y.getList())
                {
                    if (DoctorDL.doctors != null && DoctorDL.doctors.Count > 0)
                    {


                        if (b1.getName() == x.getName() && b1.getPassword() == x.getPassword())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static bool samePatient(PatientBL d,DoctorBL d1)
        {

            foreach (PatientBL x in d1.getList())
            {
                if (x.getName() == d.getName() )
                {
                    return false;
                }
            }
            return true;
        }

        public static PatientBL isPatientExist(PatientBL p)
        {
            foreach(DoctorBL y in DoctorDL.doctors)
            {
                foreach(PatientBL x in y.getList())
                {
                    if(p.getName()==x.getName())
                    {
                        return x;
                    }
                }
            }
            return null;
        }
        public static bool samePatient(PatientBL p)
        {
            foreach(DoctorBL y in DoctorDL.doctors)
            {
                foreach(PatientBL x in y.getList())
                {
                    if(x.getName()==p.getName())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static DoctorBL patientDoctor(PatientBL p1)
        {
            foreach(DoctorBL y in DoctorDL.doctors)
            {
                foreach(PatientBL x in y.getList())
                {
                    if(p1.getName()==x.getName())
                    {
                        return y;
                    }
                }
            }
            return null;
        }
        public static bool checkTestReport(TestReport t1,string name,DoctorBL doctor)
        {
            foreach(PatientBL y in doctor.getList())
            {
                if(y.getName()==name)
                {
                    y.getTestReport().Add(t1);
                    return true;
                }
            }
            return false;
        }
        public static int addBillPayment(string name, DoctorBL d1)
        {
            foreach(PatientBL p in d1.getList())
            {
                if(name==p.getName())
                {
                    return p.getBill();
                }
            }
            return 0;
        }
        public static void reWriteData()
        {
            string path = "patient.txt";
            StreamWriter file = new StreamWriter(path, false) ;
            foreach(PatientBL p in patient )
            {
                string test = "";
                if (p.getTestReport().Count==0)
                {
                    file.WriteLine(p.getName()+","+p.getPassword()+","+p.getAge()+","+p.getDisease()+","+p.getMedicine()+","+p.getContact()+","+p.getReview()+","+p.getPrescription()+","+p.getBill()+","+p.getAppointment().getDay()+"!"+p.getAppointment().getTime());
                }
                else if (p.getTestReport().Count==1)
                {

                    test=test+p.getTestReport()[p.getTestReport().Count-1].getTestName()+"*"+p.getTestReport()[p.getTestReport().Count-1].getResult();
                    file.WriteLine(p.getName()+","+p.getPassword()+","+p.getAge()+","+p.getDisease()+","+p.getMedicine()+","+p.getContact()+","+p.getReview()+","+p.getPrescription()+","+p.getBill()+","+p.getAppointment().getDay()+"!"+p.getAppointment().getTime()+test);

                }
                else
                {
                    for (int i = 0; i<p.getTestReport().Count; i++)
                    {
                        test=test+p.getTestReport()[p.getTestReport().Count-1].getTestName()+"*"+p.getTestReport()[p.getTestReport().Count-1].getResult()+"*";

                    }
                    test=test+p.getTestReport()[p.getTestReport().Count-1].getTestName()+"*"+p.getTestReport()[p.getTestReport().Count-1].getResult();
                    file.WriteLine(p.getName()+","+p.getPassword()+","+p.getAge()+","+p.getDisease()+","+p.getMedicine()+","+p.getContact()+","+p.getReview()+","+p.getPrescription()+","+p.getBill()+","+p.getAppointment().getDay()+"!"+p.getAppointment().getTime()+test);
                }

            }
            file.Flush();
            file.Close();
         }

        public static void storeData(PatientBL p)
        {
            
            string path = "patient.txt";
            string test="";

            StreamWriter file = new StreamWriter(path, true);
            if (p.getTestReport().Count==0)
            {
                file.WriteLine(p.getName()+","+p.getPassword()+","+p.getAge()+","+p.getDisease()+","+p.getMedicine()+","+p.getContact()+","+p.getReview()+","+p.getPrescription()+","+p.getBill()+","+p.getAppointment().getDay()+"!"+p.getAppointment().getTime());
            }
            else if (p.getTestReport().Count==1)
            {

                test=test+p.getTestReport()[p.getTestReport().Count-1].getTestName()+"*"+p.getTestReport()[p.getTestReport().Count-1].getResult();
                file.WriteLine(p.getName()+","+p.getPassword()+","+p.getAge()+","+p.getDisease()+","+p.getMedicine()+","+p.getContact()+","+p.getReview()+","+p.getPrescription()+","+p.getBill()+","+p.getAppointment().getDay()+"!"+p.getAppointment().getTime()+test);

            }
            else
            {
                for(int i=0;i<p.getTestReport().Count;i++)
                {
                    test=test+p.getTestReport()[p.getTestReport().Count-1].getTestName()+"*"+p.getTestReport()[p.getTestReport().Count-1].getResult()+"*";

                }
                test=test+p.getTestReport()[p.getTestReport().Count-1].getTestName()+"*"+p.getTestReport()[p.getTestReport().Count-1].getResult();
                file.WriteLine(p.getName()+","+p.getPassword()+","+p.getAge()+","+p.getDisease()+","+p.getMedicine()+","+p.getContact()+","+p.getReview()+","+p.getPrescription()+","+p.getBill()+","+p.getAppointment().getDay()+"!"+p.getAppointment().getTime()+test);
            }

            file.Flush();
            file.Close();
        }
        public static void readData(string path)
        {
            
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record=file.ReadLine())!=null)
                {
                    
                    string[] spiltRecord = record.Split(',');
                    if (spiltRecord.Length==10)
                    {
                        string name = spiltRecord[0];
                        string password = spiltRecord[1];
                        string age = spiltRecord[2];
                        string disease = spiltRecord[3];
                        string medicine = spiltRecord[4];
                        string contact = spiltRecord[5];
                        PatientBL p = new PatientBL(name, password, age, disease, medicine, contact);
                        p.setBill(int.Parse(spiltRecord[8]));
                        p.setReview(spiltRecord[6]);
                        p.setPrescription(spiltRecord[7]);
                        string appointment = spiltRecord[9];
                        string[] appointmentdata = appointment.Split('!');
                        string day = appointmentdata[0];
                        string time;
                       
                        try
                        {
                             time = appointmentdata[1];

                        }
                        catch
                        {
                            time = "";
                        }
                        AppointmentBL a = new AppointmentBL(day, time);
                        p.setAppointmnet(a);
                        
                        PatientDL.addIntoList(p);
                    }
                    else if(spiltRecord.Length==11)
                    {
                        string name = spiltRecord[0];
                        string password = spiltRecord[1];
                        string age = spiltRecord[2];
                        string disease = spiltRecord[3];
                        string medicine = spiltRecord[4];
                        string contact = spiltRecord[5];
                        PatientBL p = new PatientBL(name, password, age, disease, medicine, contact);
                        p.setBill(int.Parse(spiltRecord[8]));
                        p.setReview(spiltRecord[6]);
                        p.setPrescription(spiltRecord[7]);
                        string appointment = spiltRecord[9];
                        string[] appointmentdata = appointment.Split('!');
                        string day = appointmentdata[0];
                        string time = appointmentdata[10];
                        string test = spiltRecord[9];

                        string[] testSpilt = test.Split('%');
                        List<TestReport> t = new List<TestReport>();
                        for(int y=0;y<testSpilt.Length;y++)
                        {
                            string[] f = testSpilt[y].Split('*');
                            string name1 = f[0];
                            string result = f[1];
                            TestReport t1 = new TestReport(name1, result);
                            t.Add(t1);

                        }
                        p.setTestReport(t);
                        PatientDL.addIntoList(p);
                    }
                }
                file.Close();
                //printPatient();
            }
        }
        public static PatientBL Patient(string name,DoctorBL doctor)
        {
            foreach(PatientBL x in doctor.getList())
            {
                if(x.getName()==name)
                {
                    return x;
                }
            }
            return null;
        }

        public static bool validationOfContactLength(string contact)
        {
            if(contact.Length==11)
            {
                return true;
            }
            return false;
        }
        public static bool validationOfBill(string bill)
        {
            if(!string.IsNullOrEmpty(bill))
            {
                bool falg = AdminDL.validationOfNumber(bill);
                if(falg)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
