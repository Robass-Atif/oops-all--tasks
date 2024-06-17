using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_with_window_form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = "admin.txt";
            string path1 = "doctor.txt";
            string path3 = "patient.txt";
            PatientDL.readData(path3);

            AdminDL.readData(path);
            DoctorDL.readData(path1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainMenu());
        }
    }
}
