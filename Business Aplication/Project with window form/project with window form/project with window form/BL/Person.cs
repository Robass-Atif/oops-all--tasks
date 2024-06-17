using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_with_window_form
{
  public   class Person
    {
        protected string name;
        protected string password;
        public Person(string name,string password)
        {
            this.name = name;
            this.password = password;

        }
        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public void setName(string name)
        {
            this.name= name;
        }
        public void setPassword(string password)
        {
            this. password=password;
        }
        public virtual string toStirng()
        {
            return name+"\t"+password;
        }

    }
}
