﻿using System;

int num;

Console.WriteLine("input a number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("The number is positive");
}
else if (num < 0)
{
    Console.WriteLine("The number is negative");
}
else Console.WriteLine("The number is 0");