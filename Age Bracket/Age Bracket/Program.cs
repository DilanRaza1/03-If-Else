using System;
using System.Reflection.Metadata;

int userAge;

Console.WriteLine("input your age: ");
userAge = Convert.ToInt32(Console.ReadLine()); ;
if (userAge < 13)
{
    Console.WriteLine("You are a child");
}
if (userAge >= 13 && userAge <= 19)
{
    Console.WriteLine("You are a teenager");
}
else if (userAge > 19)
{
    Console.WriteLine("You are an adult");
}