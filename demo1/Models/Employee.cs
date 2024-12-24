using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.Models
{
    public class Employee

    {
       public string Name;
       public string Email;
        public string Gender;


        public string GetInfo(string gender, string name, string email)
        {
            string result;
            if(gender =="M")
            {
                result = $"welcom Mr ,{name}, Email is : {email}";

            }
            else
            {
                result = $"welcom Ms ,{name}, Email is : {email}";
            }
        return result ;
        }

        public string GetInfo(string fname, string mname, string lname,int age)
        {
            return "first name" +fname+"" + "mid name"+mname+"" +"last name "+ lname+"age ; " +""+ age;

        }
        public void GetInfo()
        {
            Console.WriteLine("Get Info,no retern taype");

        }




    }
}
