using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class ProgramOffer
    {
        public string degreeTitle;
        public string degreeDuration;
        public List<Subject> subjects = new List<Subject>();
        public int seat;
        public ProgramOffer(string degreeTitle, string degreeDuration,int seat)
        {
            this.degreeTitle = degreeTitle;
            this.degreeDuration = degreeDuration;
            this.seat = seat;
        }
        
        public int calculateCreditHour()
        {
            int count = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                count = count + subjects[i].creditHour;
            }
            return count;
        }
        public bool addSubject(Subject s)
        {
            int creditHour = calculateCreditHour();
            if (creditHour + s.creditHour <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }

        }
        public  bool isSubjectExist(Subject sub)
        {
            foreach (Subject x in subjects)
            {
                if (x.subjectType == sub.subjectType)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
