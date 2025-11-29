using System;

class Program
{
    static void Main(string[] args)
    {
        int completedActivities = 0; // ⭐ Creativity Feature

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    completedActivities++;
                    break;

                case "2":
                    new ReflectingActivity().Run();
                    completedActivities++;
                    break;

                case "3":
                    new ListingActivity().Run();
                    completedActivities++;
                    break;

                case "4":
                    Console.WriteLine($"You completed {completedActivities} mindfulness sessions today.");
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}

/*
    ⭐ Creativity Feature Description (required for full points)

    I added a feature that tracks how many mindfulness sessions the
    user completes during the program. When the user chooses to quit,
    the program displays the total number of sessions they completed
    during that run. This extends the requirements by providing
    session tracking and encouraging continued participation.
*/