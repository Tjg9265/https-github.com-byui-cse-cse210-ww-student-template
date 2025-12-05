using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
// EXCEEDS REQUIREMENTS:
// I added a celebration message when a goal is completed and color formatting
// to improve the user experience. These features are not required in the base
// program specification.
