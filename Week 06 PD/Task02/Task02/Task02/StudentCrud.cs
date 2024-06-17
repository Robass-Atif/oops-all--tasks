using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task02
{
     public class StudentCrud
    {
        public static List<Student> studentList = new List<Student>();
        public static void addStudentList(Student s1)
        {
            studentList.Add(s1);
        }
        public static Student studentPresent( string name)
        {
                foreach(Student x in studentList)
            {
                if(name==x.name && x.regDegree!=null)
                {
                    return x;
                }
            }
            return null;
        }
        public static void calculateFeeForAll()
        {
            foreach( Student y in studentList)
            {
                if(y.regDegree!=null)
                {
                    Console.WriteLine(y.name + "  has" + y.calculatefee() + " fee.");
                }
            }
        }
        
        public static void storeIntoFile( string path,Student s1)
        {
            StreamWriter file = new StreamWriter(path,true);
            string degreeName = "";
            for(int i=0;i<s1.preference.Count-1; i++)
            {
                degreeName = degreeName + s1.preference[i].degreeTitle + ";";
            }
            degreeName = degreeName + s1.preference[s1.preference.Count - 1].degreeTitle;
            file.WriteLine(s1.name + "," + s1.age + "," + s1.FscMark + "," + s1.EcatMark + degreeName);
            file.Flush();
            file.Close();
        }
        public static bool readFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            if(File.Exists(path))
            {
                while((line=file.ReadLine())!=null)
                {
                    string[] lineSpilt = line.Split(',');
                    string name = lineSpilt[0];
                    int age =int.Parse( lineSpilt[1]);
                    float FscMark = float.Parse(lineSpilt[2]);
                    float EcatMark = float.Parse(lineSpilt[3]);
                    string[] spiltProgram = lineSpilt[4].Split(';');
                    
                        List<ProgramOffer> preference = new List<ProgramOffer>();
                    for(int i=0;i<spiltProgram.Length;i++)
                    {
                        ProgramOffer d = ProgramCrud.isSubjectExist(spiltProgram[i]);
                        if(d!=null)
                        {
                            if(!(preference.Contains(d)))
                            {
                                preference.Add(d);
                            }
                        }
                    }
                    Student s1 = new Student(name, age, FscMark, EcatMark, preference);
                    studentList.Add(s1);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
