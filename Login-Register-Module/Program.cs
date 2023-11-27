// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
 
Console.WriteLine("Hello, World!");
 
 
//Directory.CreateDirectory(@"C:\Register");
Console.WriteLine("A Directory Created Succesfully....");
 
var path = @"C:\Register\reg.txt";
 
//using (File.Create(path))
 
{
    Console.WriteLine("File Added Successfully....");
}
 
 
Console.WriteLine("enter your username");
string userName = Console.ReadLine();
 
Console.WriteLine("Enter your Password");
string password = Console.ReadLine();
 
 
File.WriteAllText(path,userName);
File.AppendAllText(path,"\n");
File.AppendAllText(path,password);
Console.WriteLine("User Registered successfully..");
 
var details = File.ReadAllText(path);
 
Console.WriteLine("User details");
 
Console.WriteLine(details);
 
 
Directory.CreateDirectory(@"C:\Login");
Console.WriteLine("A Directory Created Succesfully....");
 
var path2 = @"C:\Login\log.txt";
 
using (File.Create(path2))
 
{
    Console.WriteLine("File Added Successfully....");
}
 
 
Console.WriteLine("enter your username");
string userName2 = Console.ReadLine();
 
Console.WriteLine("Enter your Password");
string password2 = Console.ReadLine();
 
 
File.WriteAllText(path, userName2);
File.AppendAllText(path, "\n");
File.AppendAllText(path, password2);
Console.WriteLine("User LoggedIn successfully..");
 
var details2 = File.ReadAllText(path);
 
Console.WriteLine("User details");
 
Console.WriteLine(details2);
 
if (details == details2)
{
    Console.WriteLine($"loged in successfully  {userName}");
} 
else
{
    Console.WriteLine("check details");
}
 
 
//register register = new register();
//register.reg();
 
 
 
 
 
