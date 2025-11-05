using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = Add(num1, num2);
        int difference = Subtract(num1, num2);
        int product = Multiply(num1, num2);
        double quotient = Divide(num1, num2);
        Console.WriteLine($"\nResults:");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        if (num2 != 0)
        {
            Console.WriteLine($"Quotient: {quotient}");
        }
        else
        {
            Console.WriteLine($"Cannot divide by zero!");
        }
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Subtract(int a, int b)
    {
        return a - b;
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static double Divide(int a, int b)
    {
        if (b == 0)
        {
            return 0;
        }
        return (double)a / b;
    }
}