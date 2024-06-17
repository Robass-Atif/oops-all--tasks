using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.UI
{
   public  class MenuUI
    {
        public static string menu()
        {
            Console.WriteLine("Choose the following option!");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.Doctor");
            Console.WriteLine("3.Patient");
            Console.WriteLine("4.Exit");
            string option = Console.ReadLine();
            return option; 

        }
        public static void clearScreen()
        {
            
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
