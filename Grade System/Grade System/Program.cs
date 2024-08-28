using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter your test score (0-100): ");
        string input = Console.ReadLine();

        
        if (int.TryParse(input, out int score))
        {
            
            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("Grade: C");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("Grade: D");
            }
            else if (score >= 0 && score < 60)
            {
                Console.WriteLine("Grade: F");
            }
            else
            {
                Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
