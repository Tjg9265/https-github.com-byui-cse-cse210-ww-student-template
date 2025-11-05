using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        int grade = 0;
        bool validInput = false;
        while(!validInput)
            {
            Console.Write("Enter your grade percentage");
                string input = Console.ReadLine();
                if (int.TryParse(input, out grade))
                {
                    if (grade >= 0 && grade <= 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a grade between 0 and 100. ");
                    }
                }
                else
                {
                Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        
        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        string sign = "";
        if (letterGrade != "A" && letterGrade != "F")
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letterGrade == "A" && grade < 100)
        {
            int lastDigit = grade % 10;
            if(lastDigit < 3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}{sign}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}