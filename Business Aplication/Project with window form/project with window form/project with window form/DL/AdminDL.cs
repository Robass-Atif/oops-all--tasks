using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace project_with_window_form
{
  public  class AdminDL
    {
        public static List<AdminBL> admins = new List<AdminBL>();
        public static  void addIntoList(AdminBL p1)
        {
            admins.Add(p1);
        }
        public static bool checkAdmin(AdminBL b1)
        {
            
            foreach (AdminBL x in admins)
            {
                if(b1.getName()==x.getName() && b1.getPassword()==x.getPassword())
                {
                    return true;
                }
            }
            return false;
        }
        public static bool sameAdmin(AdminBL d)
        {

            foreach (AdminBL x in admins)
            {
                if (x.getName() == d.getName() )
                {
                    return false;
                }
            }
            return true;
        }
        public static void storeData(AdminBL a1)
        {
            string path = "admin.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(a1.getName() + "," + a1.getPassword());
            file.Flush();
            file.Close();
        }
        public static void readData(string path)
        {
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record=file.ReadLine())!=null)
                {
                    string[] spiltData = record.Split(',');
                    string name = spiltData[0];
                    string password = spiltData[1];
                    AdminBL a = new AdminBL(name, password);
                    addIntoList(a);
                }
                file.Close();
            }
            
        }

        public static bool validationOfAlphabet(string name)
        {
            bool flag = false;
            for(int i=0;i<name.Length;i++)
            {
                char a = name[i];
                if((name[i]>='A'&& name[i]<='Z')||(name[i]>='a'&& name[i]<='z'))
                {
                    flag=true;
                }
                else
                {
                    return false;
                }
            }
            return flag;
        }
        public static bool validationOfNumber(string number)
        {
            bool flag = false;
            for(int i=0;i<number.Length;i++)
            {
                char n = number[i];
                int ascii = (int)n;
                if(ascii>=48 && ascii<=57 )
                {
                    flag=true;
                }
                else
                {
                    return false;
                }
            }
            return flag;
        }
        public static bool validationOfPassword(string password)
        {
            if(password.Length>=8)
            {
                return true;
            }
            return false;
        }
    }
}
