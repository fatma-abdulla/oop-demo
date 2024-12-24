//using Namespace
// object class
//fill and use code by objectName 
// Display data 
//ClassName opName=new className();

//task 1 

using demo1.Models;
using System.Net.Mime;
using System.Runtime.Versioning;
Employee employee = new Employee();
//employee.Name = "fatma";
//employee.Email = "fatma.com";
//employee.Gender = Console.ReadLine().Trim().ToUpper();

//Console.WriteLine("M|F");
//employee.Gender = (Console.ReadLine());

//if (employee.Gender == "f")
//{
//    Console.WriteLine(" welcom Ms " + employee.Name + "  email is :" + employee.Email);

//}
//else
//{
//    Console.WriteLine(" welcom Mr " + employee.Name + "  email is :" + employee.Email);
//}

/////task 2 


////object class
////Employee employee = new Employee();

////para
//string name, gender, email;
//Console.WriteLine("Enter Name");
//name=Console.ReadLine();
//Console.WriteLine("Enter Email");
//email = Console.ReadLine();
//Console.WriteLine("Enter Gender (M|F");
//gender = Console.ReadLine();

///assing value to function 
 //Console.WriteLine(employee.GetInfo(gender,name,email));


string  fname, mname, lname;
int age;
Console.WriteLine("4 per(First name,mname,lnameand age");
fname= Console.ReadLine();
mname= Console.ReadLine(); 
lname = Console.ReadLine();
age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(employee.GetInfo(fname,mname,lname,age));







