using System;

Console.WriteLine("Temperature Converter");
Console.WriteLine("Type 'F' to convert from Fahrenheit to Celsius");
Console.WriteLine("Type 'C' to convert from Celsius to Fahrenheit");
Console.Write("Your choice: ");
string choice = Console.ReadLine().ToUpper();

switch (choice)
{
    case "F":
        Console.Write("Enter the temperature in Fahrenheit: ");
        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"The temperature in Celsius is: {celsius:F2}°C");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        break;

    case "C":
        Console.Write("Enter the temperature in Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsiusTemp))
        {
            double fahrenheitTemp = (celsiusTemp * 9 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheitTemp:F2}°F");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        break;

    default:
        Console.WriteLine("Invalid choice. Please enter 'F' or 'C'.");
        break;
}
