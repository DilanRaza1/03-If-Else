using System;

int num1;
int num2;
int num3;

Console.WriteLine("Input first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number: ");
num3 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("the maximum number is " + num1);
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("The maxiumum number is " + num2);
}
else Console.WriteLine("The maximum number is " + num3);