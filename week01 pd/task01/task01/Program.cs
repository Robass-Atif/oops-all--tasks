using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task01
{
    class Program
    {
        private static int userCount = 0;
        private static int doctorUserCount = 0;
      
        static void Main(string[] args)
        {

            Console.Clear();
            string menuOption ="0" ;
            string[] users = new string[100];
            string[] passwords = new string[100];
            string[] doctor = new string[100];
            string[] doctor_passwords = new string[100];
            int[] doctorsalary = new int[100];
            string[] doctorfee =new string[100];
            loadUserData(users, passwords);
            loadDoctorData(doctor, doctor_passwords, doctorsalary, doctorfee);
            while (menuOption != "4")
            {
                menuOption = mainMenu();
                if(menuOption=="1")
                {
                    loginInterface(users,passwords,doctor,doctor_passwords,doctorsalary,doctorfee);
                   
                }
                else if(menuOption=="2")
                {
                   
                }
               else if(menuOption=="3")
                {
                    
                }
                else if(menuOption=="4")
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
        static void loginInterface(string[] users,string[] passwords,string[] doctor,string[] doctor_passwords,int[] doctorsalary,string[] doctorfee)
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
                    string name;
                    string password;
                    Console.WriteLine( "enter id name: ");
                     name=Console.ReadLine();
                    Console.WriteLine( "enter password: ");

                     password=Console.ReadLine();
                    bool check = validationOfSameAdmin(name,users);
                    if (check == false)
                    {

                        satisfy = signUp(name, password,users,passwords);
                        if (satisfy == true)
                        {
                            storeUserData(name, password);
                            Console.WriteLine( "sucessfully signup" );
                        }
                        else
                        {
                           
                            Console.WriteLine( "Users in the System have exceeded the Capacity" );
                           
                        }
                    }
                    else
                    {
                        
                        Console.WriteLine( "Already exist");
                        
                    }
                    clearScreen();
                }

                else if (loginoption == "1")
                {
                    Console.Clear();
                    string name;
                    string password;
                    Console.WriteLine("enter id : ");
                     name=(Console.ReadLine());
                    Console.WriteLine( "enter password: ");
                     password=Console.ReadLine();
                    bool option = signIn(name, password,users, passwords);
                    if (option == true)
                    {
                        Console.Clear();
                        adminInterface(doctor,doctor_passwords,doctorsalary,doctorfee);
                    }
                    else if (option == false)
                    {
                       
                        Console.WriteLine("you enter wrong credential.");
                       
                    }
                    clearScreen();
                }
                else if (loginoption == "3")
                {
                    break;
                }
            }
            
            

        }

        static string adminLogin()
        {
            string option;

            Console.WriteLine ("Login menu!");
            Console.WriteLine( "1.signin") ;
            Console.WriteLine("2.signup") ;
            Console.WriteLine( "3.exit" );
         
            Console.WriteLine ("option: ");
             option=Console.ReadLine();

            
            return option;
        }
        static bool validationOfSameAdmin(string name,string[] users)
        {
        bool check = false;
    for (int i = 0; i<userCount; i++)
    {
        if (name == users[i])
        {
            check = true;
            break;
        }
}
return check;
        }
        static bool signUp(string name,string password,string[] users ,string[] passwords)
        {
           // bool check1 = validationofalphabets(name);
         //   bool check2 = validationOfPassword(password);

           //if (check1 == true && check2 == true)
            
                if (userCount < 100)
                {
                    users[userCount] = name;
                    passwords[userCount] = password;
                    userCount++;
                    return true;
                }
                else
                {
                    return false;
                }
            
            
           
        }
        static bool signIn(string name,string password,string[] users,string[] passwords)
        {
            for (int index = 0; index < userCount; index++)
            {
                if ((users[index] == name) && (passwords[index] == password))
                {
                    return true;
                }
            }
            return false;
        }
        static void adminInterface(string[] doctor,string[] doctor_passwords,int[] doctorsalary,string[] doctorfee)
        {
            string adminoption = "0";
            while (adminoption != "9")
            { 
                adminoption = adminMenu();
                if (adminoption == "3")
                {
                    Console.Clear();
                    string name;
                    string password;
                    string salary;
                    string fee;

                    Console.WriteLine( "enter doctor id:");
                    name=Console.ReadLine();
                    Console.WriteLine( "enter password: ");
                    password=Console.ReadLine();
                    Console.WriteLine("enter salary: ");
                    salary=Console.ReadLine();
                    Console.WriteLine("enter fee: ");
                    fee=Console.ReadLine();
                   bool check = validationOfSameDoctor(name,doctor);
                    if (check == false)
                    {
                         bool option = doctorAdd(name, password, salary, fee,doctor,doctor_passwords,doctorsalary,doctorfee);
                      
                        if (option == true)
                        {
                           storeDoctorData(name, password, salary, fee);
                            Console.WriteLine( "sucessfully added") ;
                        }
                        else
                        {
                            
                            Console.WriteLine( "you exceed the limit! So try again") ;
                            
                        }
                    }
                    else
                    {
                        
                        Console.WriteLine( "Already exist.");
                     
                    }

                    clearScreen();
                }
                if (adminoption == "5")
                {
                    Console.Clear();
                   
                    
                   
                    Console.WriteLine( "Reviews by patient: ") ;
                    
                    clearScreen();
                }

                if (adminoption == "1")
                {
                    Console.Clear();
                    
                    
                   
                    //sortingofarraydoctor();
                   Console.WriteLine( " Decending sorting salary: " );
                    Console.WriteLine("Name\t\t passwords\t\t salary\t\t fee ");
                    for(int i=0;i<doctorUserCount;i++)
                    {
                        Console.WriteLine(doctor[i] + "\t\t" + doctor_passwords[i] + "\t\t" + doctorsalary[i] + "\t\t" + doctorfee[i]);
                    }

                    clearScreen();
                }

                if (adminoption == "2")
                {
                    Console.Clear();
                    
                    
                    
                    string name, fee;
                    Console.WriteLine("enter doctor name: ");
                     name=Console.ReadLine();
                    Console.WriteLine( "enter fee: ");
                    fee=Console.ReadLine();
                      bool check = addFee(name, fee,doctor,doctorfee);
                    
                    if (check == true)
                    {
                        rewriteDoctorData(doctor,doctor_passwords,doctorsalary,doctorfee);
                        Console.WriteLine( "Doctor  fee update sucessfully");
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
                     name=Console.ReadLine();
                    Console.WriteLine( "enter doctor salary: ");
                    salary=Console.ReadLine();
                      bool check = salaryCheck(name, salary,doctor,doctorsalary);
                    
                    if (check == true)
                    {
                        rewriteDoctorData(doctor, doctor_passwords, doctorsalary, doctorfee);
                        Console.WriteLine( "doctor salary update!");
                    }
                    else
                    {
                        
                        Console.WriteLine("you enter wrong credential!" );
                        
                    }
                    clearScreen();
                }

                if (adminoption == "4")
                {
                    Console.Clear();

                    Console.WriteLine("Name\t\t passwords\t\t salary\t\t fee ");
                    for (int i = 0; i < doctorUserCount; i++)
                    {
                        Console.WriteLine(doctor[i] + "\t\t" + doctor_passwords[i] + "\t\t" + doctorsalary[i] + "\t\t" + doctorfee[i]);
                    }


                    Console.WriteLine("\n\n");
                    string name;
                    Console.WriteLine( "enter doctor name which you want to delete: ");
                     name=Console.ReadLine();
                    bool check = doctorDelete(name,doctor,doctor_passwords,doctorsalary,doctorfee);

                    if (check == true)
                    {
                        
                        Console.WriteLine("doctor deleted." );
                    }
                    else
                    {
                       
                        Console.WriteLine( "you enter wrong credential");
                        
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
            
            Console.WriteLine( "Select one of the following!");
            
           Console.WriteLine( "1.view record");
           Console.WriteLine( "2.update fee" );
           Console.WriteLine("3.add doctor" );
            Console.WriteLine("4.delete doctor");
            Console.WriteLine("5.view reviews");
            Console.WriteLine("6.view patient" );
            Console.WriteLine("7.view bill payments");
          Console.WriteLine("8.update salary") ;
            Console.WriteLine( "9.exit" );
            
            string option;
            Console.Write("Option: ");
             option=Console.ReadLine();
            
            return option;
        }
        static void storeUserData(string name,string password)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\user Data.txt";
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
        }
        static bool doctorAdd(string name,string password,string salary,string fee,string[] doctor,string[] doctor_passwords,int[] doctorsalary,string[] doctorfee)
        {
            if (doctorUserCount < 100)
            {
                doctor[doctorUserCount] = name;
                doctor_passwords[doctorUserCount] = password;
                doctorsalary[doctorUserCount] = int.Parse(salary);
                doctorfee[doctorUserCount] = fee;
                doctorUserCount++;
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool salaryCheck(string name,string salary,string[] doctor,int[] doctorsalary)
        {
            for (int index = 0; index < doctorUserCount; index++)
            {
                if ((doctor[index] == name))
                {
                    doctorsalary[index] = int.Parse(salary);
                    return true;
                }
            }
            return false;
        }

        static string getFieldData(string line,int num)
        {
            string item="";
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
        static bool addFee(string name,string fee,string[] doctor,string[] doctorfee)
        {
            for (int index = 0; index < doctorUserCount; index++)
            {
                if (doctor[index] == name)
                {
                    doctorfee[index] = fee;
                    return true;
                }
            }
            return false;
        }
        static bool validationOfSameDoctor(string name,string[] doctor)
        {
            bool check = false;
            for (int i = 0; i < doctorUserCount; i++)
            {
                if (name == doctor[i])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        static void loadUserData(string[] users,string[] passwords)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\user Data.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                
                while((line=file.ReadLine())!=null)
                {
                    users[userCount] = getFieldData(line, 1);
                    passwords[userCount] = getFieldData(line, 2);
                    userCount++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("aaljdlad");
            }
        }
        static bool doctorDelete(string name,string[] doctor,string[] doctor_passwords,int[] doctorsalary,string[] doctorfee)
        {
            bool recordnew = false;
            int j = 0;
            for (int index = 0; index < doctorUserCount; index++)
            {
                if ((doctor[index] == name))
                {
                    j = index;
                    recordnew = true;
                    break;
                }
            }

            if (recordnew == true)
            {
                for (int i = j; i < doctorUserCount - 1; i++)
                {
                    doctor[i] = doctor[i + 1];
                    doctor_passwords[i] = doctor_passwords[i + 1];
                    doctorsalary[i] = doctorsalary[i + 1];
                    doctorfee[i] = doctorfee[i + 1];
                }
                doctorUserCount--;
            }

            return recordnew;

        }
        static void storeDoctorData(string name,string password, string salary, string fee)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\doctor data.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(name + "," + password + "," + salary + "," + salary + "," + fee);
            file.Flush();
            file.Close();
        }
        static void loadDoctorData(string[] doctor,string[] doctor_passwords,int[] doctorsalary,string[] doctorfee)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\doctor data.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while((line=file.ReadLine())!=null)
                {
                    doctor[doctorUserCount] = getFieldData(line, 1);
                    doctor_passwords[doctorUserCount] = getFieldData(line, 2);
                    doctorsalary[doctorUserCount] = int.Parse((getFieldData(line, 3)));
                    doctorfee[doctorUserCount] = getFieldData(line, 4);
                    doctorUserCount++;
                }
                file.Close();
            }
        }
        static void rewriteDoctorData(string[] doctor,string[] doctor_passwords,int[]  doctrorsalary,string[] doctorfee)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\week01 pd\\task01\\doctor data.txt";
            StreamWriter file = new StreamWriter(path,false);
            string salary="";
            Console.WriteLine(doctorUserCount);
            for(int i=0;i<doctorUserCount;i++)
            {
                salary = doctrorsalary[i].ToString();
                file.WriteLine(doctor[i] + ","+doctor_passwords[i] + "," + salary + "," + doctorfee[i]);
                file.Flush();
                file.Close();
            }
        }
    }
}
