using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            // SAFE INPUT CHECK
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number 1–6.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoals();
                    break;

                case 3:
                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;

                case 5:
                    if (_goals.Count == 0)
                    {
                        Console.WriteLine("\nNo goals to record yet.");
                    }
                    else
                    {
                        RecordEvent();
                    }
                    break;

                case 6:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please enter a valid option from 1–6.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description? ");
        string desc = Console.ReadLine();

        Console.Write("How many points is this goal worth? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int i = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        ListGoals();

        Console.Write("Enter the number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

       // Color and celebration feature (beyond requirements)
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"You earned {pointsEarned} points!");

        if (_goals[index].IsComplete())
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("🎉 Congratulations! You completed this goal!");
        }

        Console.ResetColor();

    }

    public void SaveGoals()
    {
        Console.Write("What filename would you like to use? ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("What filename would you like to load? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, desc, points, complete));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus, completed));
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}
