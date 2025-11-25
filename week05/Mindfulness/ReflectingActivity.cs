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
        "How can you apply this in your life now?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity helps you reflect on times of strength.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        var rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(5);

        int questionTime = 10;
        int cycles = _duration / questionTime;

        for (int i = 0; i < cycles; i++)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(8);
        }

        DisplayEndingMessage();
    }
}
