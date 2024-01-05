using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class DegreeUI
    {
        public static  ProgramOffer addProgram()
        {
            Console.WriteLine("Enter degree Title:");
            string degreeTitle = Console.ReadLine();
            Console.WriteLine("Enter degree Duration: ");
            string degreeDuration = Console.ReadLine();
            Console.WriteLine("Enter degree Seats:");
            int seat = int.Parse(Console.ReadLine());

            ProgramOffer s1 = new ProgramOffer(degreeTitle, degreeDuration,seat);
            Console.WriteLine("How many subject you want to register?");
            int count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("\n\tSubject {0}\n ", (i+1));

                s1.addSubject(SubjectUI.takeInputForSubject());
            }
            return s1;

        }
        public static void viewDegreeProgram()
        {
            foreach(ProgramOffer x in ProgramCrud.degreeList )
            {
                Console.WriteLine(x.degreeTitle);
            }

        }
    }
}
