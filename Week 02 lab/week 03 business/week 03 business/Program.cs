using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task01
{
    class user
    {
        public string name;
        public string password;
        public user()
        {
            name = "";
            password = "";
        }
        public user( string name )
        {
            this.name = name;
        }
        public user(string name,string password)
        {
            this.name = name;
            this.password = password;
        }



        public bool validationOfSameAdmin( List<user> userData)
        {
            bool check = false;
            for (int i = 0; i < userData.Count; i++)
            {
                if (name == userData[i].name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public bool signIn( List<user> userData)
        {
            for (int index = 0; index < userData.Count; index++)
            {
                if ((userData[index].name == name) && (userData[index].password == password))
                {
                    return true;
                }
            }
            return false;
        }


    }
    class Doctor
    {
        public string name;
        public string password;
        public int salary;
        public string fee;
        public Doctor()
        {
            name = "";
            password = "";
            salary = 0;
            fee = "";
        }
        public Doctor(string name, string password,int salary,string fee)
        {
            this.name = name;
            this.password = password;
            this.salary = salary;
            this.fee = fee;
        }

        public bool validationOfSameDoctor( List<Doctor> doctorData)
        {
            bool check = false;
            for (int i = 0; i < doctorData.Count; i++)
            {
                if (name == doctorData[i].name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public bool addFee( List<Doctor> doctorData)
        {
            for (int index = 0; index < doctorData.Count; index++)
            {
                if (doctorData[index].name == name)
                {
                    doctorData[index].fee = fee;
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {


        static void Main(string[] args)
        {

            Console.Clear();
            string menuOption = "0";
            List<user> userData = new List<user>();

            List<Doctor> doctorData = new List<Doctor>();
            loadUserData(userData);
            loadDoctorData(doctorData);
            while (menuOption != "4")
            {
                menuOption = mainMenu();
                if (menuOption == "1")
                {
                    loginInterface(userData, doctorData);

                }
                else if (menuOption == "2")
                {

                }
                else if (menuOption == "3")
                {

                }
                else if (menuOption == "4")
                {
                    break;
                }
                clearScreen();


            }
        }
        static string mainMenu()
        {
            string option;
            Console.WriteLine("Select one of the following:");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.Doctor");
            Console.WriteLine("3.Patient");
            Console.WriteLine("4.Exit");
            Console.Write("option:");
            option = Console.ReadLine();


            return option;
        }
        static void clearScreen()
        {
            Console.WriteLine("Press Any Key To Continue . . . ");
            Console.ReadKey();
            Console.Clear();

        }
        static void loginInterface(List<user> userData, List<Doctor> doctorData)
        {
            string loginoption = "0";
            while (loginoption != "3")
            {
                Console.Clear();

                loginoption = adminLogin();
                if (loginoption == "2")
                {
                    Console.Clear();
                    bool satisfy;
                    
                    
                    user s1 = inputOfUser();
                    
                    if (s1.name != "" && s1.password!="")
                    {
                        bool check = s1.validationOfSameAdmin( userData);

                        if (check == false)
                            { 
                            satisfy = signUp(s1, userData);
                            if (satisfy == true)
                            {
                                storeUserData(s1);
                                Console.WriteLine("sucessfully signup");
                            }
                            else
                            {

                                Console.WriteLine("Users in the System have exceeded the Capacity");

                            }
                        }
                        else
                        {

                            Console.WriteLine("Already exist");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid User");
                    }
                    clearScreen();
                }

                else if (loginoption == "1")
                {
                    Console.Clear();
                                       user s2 = inputOfUser();
                    
                    if (s2.name != "" && s2.password!="")
                    {
                        bool option = s2.signIn( userData);
                        if (option == true)
                        {
                            Console.Clear();
                            adminInterface(doctorData);
                        }
                        else if (option == false)
                        {

                            Console.WriteLine("you enter wrong credential.");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid User");
                    }
                    clearScreen();
                }
                else if (loginoption == "3")
                {
                    break;
                }
            }



        }
        static user inputOfUser()
        {
            string name;
            string password;
            Console.WriteLine("enter id name: ");
            name = Console.ReadLine();
            Console.WriteLine("enter password: ");
            password = Console.ReadLine();
            if(name!=null && password !=null)
            {
                user s1 = new user(name, password);
                return s1;
            }
            return null;
        }

        static string adminLogin()
        {
            string option;

            Console.WriteLine("Login menu!");
            Console.WriteLine("1.signin");
            Console.WriteLine("2.signup");
            Console.WriteLine("3.exit");

            Console.WriteLine("option: ");
            option = Console.ReadLine();


            return option;
        }
       
        static bool signUp(user s2, List<user> userData)
        {
            // bool check1 = validationofalphabets(name);
            //   bool check2 = validationOfPassword(password);

            //if (check1 == true && check2 == true)

            user s1 = new user();
            s1.name = s2.name;
            s1.password = s2.password;
            userData.Add(s1);
            return true;
        }
        
        static Doctor inputOfDoctor()
        {
            string name;
            string password;
            string salary;
            string fee;

            Console.WriteLine("enter doctor id:");
            name = Console.ReadLine();
            Console.WriteLine("enter password: ");
            password = Console.ReadLine();
            Console.WriteLine("enter salary: ");
            salary = Console.ReadLine();
            Console.WriteLine("enter fee: ");
            fee = Console.ReadLine();
            if(name!=null && password !=null  && fee!=null && salary!=string.Empty)
            {
                int sa = int.Parse(salary);
                Doctor s1 = new Doctor(name, password, sa, fee);
                return s1;
            }
            return null;

        }

        static void adminInterface(List<Doctor> doctorData)
        {
            string adminoption = "0";
            while (adminoption != "9")
            {
                adminoption = adminMenu();
                if (adminoption == "3")
                {
                    Console.Clear();
                    
                    Doctor s2 = inputOfDoctor();
                    if (s2!=null)
                    {
                        Console.WriteLine(s2.name);
                        bool check = s2.validationOfSameDoctor( doctorData);
                        if (check == false)
                        {
                            bool option = doctorAdd(s2, doctorData);

                            if (option == true)
                            {
                                storeDoctorData(s2);
                                Console.WriteLine("sucessfully added");
                            }
                            else
                            {

                                Console.WriteLine("you exceed the limit! So try again");

                            }
                        }
                        else
                        {

                            Console.WriteLine("Already exist.");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Doctor");
                    }

                    clearScreen();
                }
                if (adminoption == "5")
                {
                    Console.Clear();



                    Console.WriteLine("Reviews by patient: ");

                    clearScreen();
                }

                if (adminoption == "1")
                {
                    Console.Clear();



                    //sortingofarraydoctor();
                    Console.WriteLine(" Decending sorting salary: ");
                    Console.WriteLine("Name\t\t passwords\t\t salary\t\t fee ");
                    for (int i = 0; i < doctorData.Count; i++)
                    {
                        Console.WriteLine(doctorData[i].name + "\t\t" + doctorData[i].password + "\t\t" + doctorData[i].salary + "\t\t" + doctorData[i].fee);
                    }

                    clearScreen();
                }

                if (adminoption == "2")
                {
                    Console.Clear();



                    //string name, fee;
                    //Console.WriteLine("enter doctor name: ");
                    //name = Console.ReadLine();
                    //Console.WriteLine("enter fee: ");
                    //fee = Console.ReadLine();

                    Doctor s1 = new Doctor();
                    Console.WriteLine("Enter doctor name");
                    s1.name = Console.ReadLine();

                    Console.WriteLine("Enter doctor fee");
                    s1.fee = Console.ReadLine();

                    bool check = s1.addFee( doctorData);


                    if (check == true)
                    {
                        rewriteDoctorData(doctorData);
                        Console.WriteLine("Doctor  fee update sucessfully");
                    }
                    else
                    {

                        Console.WriteLine("you enter wrong credential");

                    }
                    clearScreen();
                }

                if (adminoption == "8")
                {
                    Console.Clear();



                    string name, salary;
                    Console.WriteLine("enter doctor name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("enter doctor salary: ");
                    salary = Console.ReadLine();
                    bool check = salaryCheck(name, salary, doctorData);

                    if (check == true)
                    {
                        rewriteDoctorData(doctorData);
                        Console.WriteLine("doctor salary update!");
                    }
                    else
                    {

                        Console.WriteLine("you enter wrong credential!");

                    }
                    clearScreen();
                }

                if (adminoption == "4")
                {
                    Console.Clear();

                    Console.WriteLine("Name\t\t passwords\t\t salary\t\t fee ");
                    for (int i = 0; i < doctorData.Count; i++)
                    {
                        Console.WriteLine(doctorData[i].name + "\t\t" + doctorData[i].password + "\t\t" + doctorData[i].salary + "\t\t" + doctorData[i].fee);
                    }


                    Console.WriteLine("\n\n");
                    string name;
                    Console.WriteLine("enter doctor name which you want to delete: ");
                    name = Console.ReadLine();
                    bool check = doctorDelete(name, doctorData);

                    if (check == true)
                    {
                        rewriteDoctorData(doctorData);
                        Console.WriteLine("doctor deleted.");
                    }
                    else
                    {

                        Console.WriteLine("you enter wrong credential");

                    }
                    clearScreen();
                }

                if (adminoption == "6")
                {
                    Console.Clear();



                    clearScreen();
                }

                if (adminoption == "7")
                {
                    Console.Clear();




                    clearScreen();
                }
            }


        }
        static string adminMenu()
        {

            Console.WriteLine("Select one of the following!");

            Console.WriteLine("1.view record");
            Console.WriteLine("2.update fee");
            Console.WriteLine("3.add doctor");
            Console.WriteLine("4.delete doctor");
            Console.WriteLine("5.view reviews");
            Console.WriteLine("6.view patient");
            Console.WriteLine("7.view bill payments");
            Console.WriteLine("8.update salary");
            Console.WriteLine("9.exit");

            string option;
            Console.Write("Option: ");
            option = Console.ReadLine();

            return option;
        }
        static void storeUserData(user s1)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\user Data.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(s1.name + "," + s1.password);
            file.Flush();
            file.Close();
        }
        static bool doctorAdd(Doctor s2, List<Doctor> doctorData)
        {
            Doctor s1 = new Doctor();
            s1.name = s2.name;
            s1.password = s2.password;
            s1.salary = s2.salary;
            s1.fee = s2.fee;
            doctorData.Add(s1);
            return true;


        }
        static bool salaryCheck(string name, string salary, List<Doctor> doctorData)
        {
            for (int index = 0; index < doctorData.Count; index++)
            {
                if ((doctorData[index].name == name))
                {
                    doctorData[index].salary = int.Parse(salary);
                    return true;
                }
            }
            return false;
        }

        static string getFieldData(string line, int num)
        {
            string item = "";
            int count = 1;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    count++;
                }
                else if (count == num)
                {
                    item = item + line[i];
                }
            }
            return item;
        }
        
        
        static void loadUserData(List<user> userData)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\user Data.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    user s1 = new user();
                    s1.name = getFieldData(line, 1);
                    s1.password = getFieldData(line, 2);
                    userData.Add(s1);
                }
                file.Close();
            }

        }
        static bool doctorDelete(string name, List<Doctor> doctorData)
        {
            bool recordnew = false;
            int j = 0;
            for (int index = 0; index < doctorData.Count; index++)
            {
                if ((doctorData[index].name == name))
                {
                    j = index;
                    recordnew = true;
                    break;
                }
            }

            if (recordnew == true)
            {
                doctorData.RemoveAt(j);
            }

            return recordnew;

        }
        static void storeDoctorData(Doctor s2)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\doctor data.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(s2.name + "," + s2.password + ","  +s2.salary + "," + s2.fee);
            file.Flush();
            file.Close();
        }
        static void loadDoctorData(List<Doctor> doctorData)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\doctor data.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Doctor s1 = new Doctor();
                    s1.name = getFieldData(line, 1);
                    s1.password = getFieldData(line, 2);
                    s1.salary = int.Parse((getFieldData(line, 3)));
                    s1.fee = getFieldData(line, 4);
                    doctorData.Add(s1);
                }
                file.Close();
            }
        }
        static void rewriteDoctorData(List<Doctor> doctorData)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\doctor data.txt";
            StreamWriter file = new StreamWriter(path, false);
            string salary = "";
            for (int i = 0; i < doctorData.Count; i++)
            {
                salary = (doctorData[i].salary).ToString();
                file.WriteLine(doctorData[i].name + "," + doctorData[i].password + "," + salary + "," + doctorData[i].fee);

            }
            file.Flush();
            file.Close();
        }
    }
}
