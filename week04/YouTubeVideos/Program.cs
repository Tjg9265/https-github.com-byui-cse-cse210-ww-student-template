using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create at least 3 Video objects
        Video video1 = new Video("How to Cook the Perfect Steak", "Chef Master", 420);
        Video video2 = new Video("Fix a Flat Tire in 5 Minutes", "AutoPro", 310);
        Video video3 = new Video("Relaxing Nature in 4K", "World Views", 600);

        // Add 3–4 comments to each
        video1.AddComment(new Comment("Alex", "Amazing tutorial!"));
        video1.AddComment(new Comment("Maria", "My steak turned out perfect!"));
        video1.AddComment(new Comment("Tom", "Thanks for this video."));

        video2.AddComment(new Comment("Sophie", "Saved me today—thank you!"));
        video2.AddComment(new Comment("Daniel", "Clear and easy instructions."));
        video2.AddComment(new Comment("Ryan", "Very helpful!"));

        video3.AddComment(new Comment("Julie", "This is so calming."));
        video3.AddComment(new Comment("Mike", "What camera did you use?"));
        video3.AddComment(new Comment("Angela", "Absolutely beautiful!"));

        // Store videos in a list
        List<Video> videos = new List<Video>() { video1, video2, video3 };

        // Display each video's details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($" - {c.GetName()}: {c.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
