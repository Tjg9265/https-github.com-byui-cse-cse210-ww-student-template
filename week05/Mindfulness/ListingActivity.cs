public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "List the things you are grateful for.",
        "List the people who inspire you.",
        "List your personal strengths."
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you list positive things in your life.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        var rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.WriteLine("Begin listing:");
        ShowSpinner(3);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        DisplayEndingMessage();
    }
}
