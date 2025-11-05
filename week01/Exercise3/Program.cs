using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        {
            int number = -1;
            int sum = 0;
            while (number != 0)
            {
                Console.Write("Enter a number (0 to quit): ");
                string input = Console.ReadLine();
                number = int.Parse(input);
                if (number != 0)
                {
                    sum += number;
                    Console.WriteLine($"You entered: {number}");
                }
            }
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine("Goodbye!");
        }
    }
}