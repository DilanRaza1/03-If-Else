using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the total amount of your purchase: $");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal totalAmount))
        {
            if (totalAmount > 1000)
            {
                decimal discount = totalAmount * 0.10m;
                totalAmount -= discount; 
                Console.WriteLine($"A 10% discount has been applied. Discounted amount: ${discount:F2}");
            }

 
            Console.WriteLine($"Final amount to be paid: ${totalAmount:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
