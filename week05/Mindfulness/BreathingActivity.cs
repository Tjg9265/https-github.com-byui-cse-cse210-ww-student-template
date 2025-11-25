public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
               "This activity helps you relax by guiding your breathing.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        int cycleTime = 10;
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
