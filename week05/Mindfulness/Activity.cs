using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long (in seconds) would you like the activity to last? ");

        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You completed {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        int total = seconds * 10;

        for (int i = 0; i < total; i++)
        {
            Console.Write(frames[i % 4]);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
