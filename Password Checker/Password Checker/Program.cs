using System;

string password = "Bananfisk123";
string inputPassword;
Console.WriteLine("input a password: ");
inputPassword = Console.ReadLine();

Console.WriteLine(inputPassword == password ? "Acess Granted" : "Access Denied");