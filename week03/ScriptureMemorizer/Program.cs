using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Scripture Memorizer Program\n");

        // *** CREATIVE ENHANCEMENT ***
        // Instead of using only ONE scripture,
        // the program now selects a RANDOM scripture from a library.
        // This helps users practice multiple scriptures.
        List<Scripture> library = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life."),

            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him and he shall direct thy paths."),

            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be and men are that they might have joy.")
        };

        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("\nProgram ended by user.");
                break;
            }

            scripture.HideRandomWords(3); // Hides a few words at a time

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program complete!");
                break;
            }
        }
    }
}
