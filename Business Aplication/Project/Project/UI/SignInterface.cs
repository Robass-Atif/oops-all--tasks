using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;

namespace Project.UI
{
   public  class SignInterface
    {
        public static void sign()
        {
            string option = "0";
            while(option!="3")
            {
                Console.Clear();
                option = optionOFSign();
                if(option=="1")
                {
                    Console.Clear();
                    AdminBL b1 =  AdminUI.inputOfAdmin();
                    if (b1!=null)
                    {
                        bool flag = AdminDL.checkAdmin(b1);
                        if (flag==true)
                        {
                            AdminUI.AdminInterFace();

                        }

                        else
                        {
                            Console.WriteLine("You enter wrong input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please write correctly");
                    }
                    MenuUI.clearScreen();

                }
                else if(option=="2")
                {
                    Console.Clear();
                    AdminBL b1 = AdminUI.inputOfAdmin();
                    if (b1!=null)
                    {
                        bool flag = AdminDL.sameAdmin(b1);
                        if (flag)
                        {
                            AdminDL.storeData(b1);
                            AdminDL.addIntoList(b1);
                        }
                        else
                        {
                            Console.WriteLine("You enter same doctor!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("you enter wrong input!");
                    }
                    MenuUI.clearScreen();
                }
                else if(option=="3")
                {
                    break;

                }
               
            }
                
        }
        public static string optionOFSign()
        {
            Console.WriteLine("Choose one of the following option!");
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("3.Exit");
            string option = Console.ReadLine();
            return option;
        }
        
        
    }
}
