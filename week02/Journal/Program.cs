using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Your Personal Journal!");
        Journal myJournal = new Journal();
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("\nJournal Options:");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Show all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    myJournal.ShowJournal();
                    break;
                case "3":
                    myJournal.SaveToFile();
                    break;
                case "4":
                    myJournal.LoadFromFile();
                    break;
                case "5":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
