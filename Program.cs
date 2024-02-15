// See https://aka.ms/new-console-template for more information
using WelcomeApp;

Console.WriteLine("welcome to Authentication App");
Signin obj = new Signin();
Console.WriteLine(obj.Authentication("admin","admin@123"));