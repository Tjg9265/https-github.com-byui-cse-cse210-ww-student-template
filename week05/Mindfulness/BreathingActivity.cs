using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding your breathing. Clear your mind and focus on slow, deep breaths.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);
            elapsed += 6;

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
