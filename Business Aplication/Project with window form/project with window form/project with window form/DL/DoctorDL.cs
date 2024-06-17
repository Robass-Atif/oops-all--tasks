using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project_with_window_form
{
 public    class DoctorDL
    {
        public static List<DoctorBL> doctors = new List<DoctorBL>();
        public static void addIntolist(DoctorBL d1)
        {
            doctors.Add(d1);
        }
        public static DoctorBL checkDoctor(DoctorBL d1)
        {

            
            foreach(DoctorBL x in doctors)
            {
                if(x.getName()==d1.getName() && x.getPassword()==d1.getPassword() )
                {
                    return x;
                }
            }
            return null;
        }
        public static bool sameDoctor(DoctorBL d)
        {

            foreach (DoctorBL x in doctors)
            {
                if (x.getName() == d.getName() )
                {
                    return false;
                }
            }
            return true;
        }
        public static void storeData(DoctorBL d)
        {
            string path = "doctor.txt";
            StreamWriter file = new StreamWriter(path, true);
            string patient = "";
            if (d.getList().Count==0)
            {
                file.WriteLine(d.getName() + "," + d.getPassword() + "," + d.getSalary() + "," + d.getFee());

            }
            else if( d.getList().Count==1)
            {
                patient = patient + d.getList()[d.getList().Count-1].getName();
                file.WriteLine(d.getName() + "," + d.getPassword() + "," + d.getSalary() + "," + d.getFee()+","+patient);

            }
            else
            {
                for (int i = 0; i<d.getList().Count-1; i++)
                {
                    patient = patient + d.getList()[i].getName()+";";
                }
                patient = patient + d.getList()[d.getList().Count-1].getName();
                file.WriteLine(d.getName() + "," + d.getPassword() + "," + d.getSalary() + "," + d.getFee()+","+patient);
            }
            
            
            file.Flush();
            file.Close();
        }
        public static void rewriteData()
        {
            string path = "doctor.txt";
            StreamWriter file = new StreamWriter(path, false);
            for(int x=0;x<doctors.Count;x++)
            {
                DoctorBL d = doctors[x];
                string patient = "";
                if (d.getList().Count==0)
                {
                    file.WriteLine(d.getName() + "," + d.getPassword() + "," + d.getSalary() + "," + d.getFee());

                }
                else if (d.getList().Count==1)
                {
                    patient = patient + d.getList()[d.getList().Count-1].getName();
                    file.WriteLine(d.getName() + "," + d.getPassword() + "," + d.getSalary() + "," + d.getFee()+","+patient);

                }
                else
                {
                    for (int i = 0; i<d.getList().Count-1; i++)
                    {
                        patient = patient + d.getList()[i].getName()+";";
                    }
                    patient = patient + d.getList()[d.getList().Count-1].getName();
                    file.WriteLine(d.getName() + "," + d.getPassword() + "," + d.getSalary() + "," + d.getFee()+","+patient);
                }

                //PatientDL.readData(path);
                //storeData(doctors[i]);
                //file.WriteLine(doctors[i].getName() + "," + doctors[i].getPassword() + "," + doctors[i].getSalary() + "," + doctors[i].getFee());
            }
            file.Flush();
            file.Close();
        }
        public static void readData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] spitlData = record.Split(',');
                    string name, password,patient;
                    int salary, fee;
                    if (spitlData.Length==4)
                    {
                        name = spitlData[0];
                        password = spitlData[1];
                        salary = int.Parse(spitlData[2]);
                        fee = int.Parse(spitlData[3]);
                        DoctorBL d = new DoctorBL(name, password, salary, fee);
                        DoctorDL.addIntolist(d);

                    }
                    else 
                    {
                        name = spitlData[0];
                        password = spitlData[1];
                        salary = int.Parse(spitlData[2]);
                        fee = int.Parse(spitlData[3]);
                        patient=spitlData[4];
                        string[] patientSpilt = patient.Split(';');
                        List<PatientBL> p1 = new List<PatientBL>();
                        for(int i=0;i<patientSpilt.Length;i++)
                        {
                            PatientBL p = PatientDL.isPatientExist(patientSpilt[i]);
                            if(p!=null)
                            {
                                p1.Add(p);
                            }

                        }
                        DoctorBL d = new DoctorBL(name, password, salary, fee);
                        d.setList(p1);
                        DoctorDL.addIntolist(d);

                    }

                    //DoctorBL d = new DoctorBL(name, password, salary, fee);

                    //DoctorDL.addIntolist(d);
                }
                file.Close();
            }
        }

        public static bool deleteDoctor(string name)
        {
           
            foreach(DoctorBL x in doctors)
            {
                if(x.getName()==name)
                {
                    doctors.Remove(x);
                    return true;
                    
                }
            }
            return false;
         

        }
        public static bool updateDoctor(string name,string fee)
        {
            
            foreach(DoctorBL x in doctors)
            {
                if(x.getName()==name)
                {
                    x.setFee(int.Parse(fee));
                    return true;
                }
            }
            return false;
        }
        public static bool updateSalary(string name, string salary)
        {

            foreach (DoctorBL x in doctors)
            {
                if (x.getName() == name)
                {
                    x.setSalary(int.Parse(salary));
                    return true;
                }
            }
            return false;
        }
        public static bool addappointmemt(string name,AppointmentBL a1,DoctorBL d1)
        {
            foreach(PatientBL y in d1.getList())
            {
                if(y.getName()==name)
                {
                    //foreach(AppointmentBL x in y.getAppointment())
                    //{
                    //    if(x.getDay()==a1.getDay() && x.getDay()==a1.getDay())
                    //    {
                    //        return false; 
                    //    }

                    y.setAppointmnet(a1);
                    
                    return true;

                }
            }
            return false;

        }
        public static PatientBL  deleteAppointment(DoctorBL d1, string name)
        {
            foreach(PatientBL y in d1.getList())
            {
                if(y.getName()==name)
                {
                    return y;
                }
            }
            return null;
        }
        public static bool deletePatientAppointment(PatientBL p1)
        {
            if (p1.getAppointment().getDay()!="" && p1.getAppointment().getTime()!="")
            {
                AppointmentBL a = new AppointmentBL("", "");
                p1.setAppointmnet(a);
                return true;
            }

                
            return false;
        }
    }
}
