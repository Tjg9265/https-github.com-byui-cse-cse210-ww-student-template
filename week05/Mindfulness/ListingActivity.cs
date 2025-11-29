using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you reflect on the good things in your life by listing as many items as you can.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                items.Add(response);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}
