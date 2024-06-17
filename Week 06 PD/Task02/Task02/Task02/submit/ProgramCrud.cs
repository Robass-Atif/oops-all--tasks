using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task02
{
   public class ProgramCrud
    {
        public static List<ProgramOffer> degreeList = new List<ProgramOffer>();
        public static void addProgramOffer( ProgramOffer s1)
        {
            degreeList.Add(s1);
        }
        public static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student x in sortedStudentList)
            {
                foreach (ProgramOffer d in x.preference)
                {
                    if (x.regDegree == null && d.seat > 0)
                    {
                        x.regDegree = d;
                        d.seat--;
                        break;
                    }
                }
            }

        }
        public static List<Student> sortStudentByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student x in StudentCrud.studentList)
            {
                x.calculateMerit();
            }
            sortedStudentList =StudentCrud.studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        public static ProgramOffer isSubjectExist(string name)
        {
            foreach (ProgramOffer x in degreeList)
            {
                if (x.degreeTitle == name)
                {
                    return x;
                }

            }
            return null;
        }
        public static void storeIntoFile(string path,ProgramOffer d)
        {
            StreamWriter file = new StreamWriter(path, true);
            string subjectName = "";
            for(int i=0;i<d.subjects.Count-1;i++)
            {
                subjectName = subjectName + d.subjects[i].subjectType+";";
            }
            subjectName = subjectName + d.subjects[d.subjects.Count-1].subjectType;
            file.WriteLine(d.degreeTitle + "," + d.degreeDuration + "," + d.seat + "," + subjectName);
            file.Flush();
            file.Close();
        }
        public static bool readFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string record;
            if(File.Exists(path))
            {
                while((record=file.ReadLine())!=null)
                {
                    string[] spiltRecord = record.Split(',');
                    string degreeName = spiltRecord[0];
                    string degreeDuration =( spiltRecord[1]);
                    int seat =int.Parse( spiltRecord[2]);
                    string[] spiltSubject = spiltRecord[3].Split(';');
                    ProgramOffer d = new ProgramOffer(degreeName, degreeDuration, seat);
                    for(int i=0;i<spiltSubject.Length;i++)
                    {
                        Subject d1 = SubjectCrud.isSubjectExist(spiltSubject[i]);
                        if(d1!=null)
                        {
                            d.addSubject(d1);
                        }
                    }
                    addProgramOffer(d);


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
