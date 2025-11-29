using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone in need.",
        "Think of a moment when you felt proud of yourself.",
        "Think of a time you overcame a big challenge."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "What did you learn from it?",
        "How can you apply this in your life now?",
        "What made this experience stand out?",
        "How did it change you?",
    };

    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity will help you reflect on times of strength and resilience in your life.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions.");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);
        Console.Clear();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("> " + question);
            ShowSpinner(6);
            Console.WriteLine();
            elapsed += 6;
        }

        DisplayEndingMessage();
    }
}
