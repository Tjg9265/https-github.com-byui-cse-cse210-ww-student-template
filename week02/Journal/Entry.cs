using System;

public class Entry
{
    public string _entryDate;
    public string _question;
    public string _answer;

    public Entry(string entryDate, string question, string answer)
    {
       _entryDate = entryDate;
        _question = question;
        _answer = answer;
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {_entryDate}");
        Console.WriteLine($"Prompt: {_question}");
        Console.WriteLine($"Response: {_answer}");
    }
}
