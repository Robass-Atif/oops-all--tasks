using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task02
{
   public class SubjectCrud
    {
        public static List<Subject> totalSubject = new List<Subject>();


        public static Subject isSubjectExist(string name)
        {
            foreach (Subject x in totalSubject)
            {
                if (x.subjectType == name)
                {
                    return x;
                }

            }
            return null;
        }
        public static void storeIntoFile(string path,Subject sub)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(sub.code+","+sub.subjectType+","+sub.subjectFee);
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
                    string code = spiltRecord[0];
                    string type = spiltRecord[1];
                    int creditHour = int.Parse(spiltRecord[2]);
                    int subjectFee = int.Parse(spiltRecord[3]);
                    Subject s1 = new Subject(code, creditHour, type, subjectFee);
                    totalSubject.Add(s1);
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
