using System;

string password = "Bananfisk123";
string inputPassword;
Console.WriteLine("input a password: ");
inputPassword = Console.ReadLine();

if (inputPassword == password)
{
    Console.WriteLine("Access granted, Welcome!");
}
else
{
    Console.WriteLine("Wrong password, try again.");
}