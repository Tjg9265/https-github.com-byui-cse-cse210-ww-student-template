using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        {
            Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "TechCorp";
            job1._startYear = 2021;
            job1._endYear = 2024;

            Job job2 = new Job();
            job2._jobTitle = "Web Developer";
            job2._company = "WebWorks";
            job2._startYear = 2019;
            job2._endYear = 2021;

            Resume myResume = new Resume();
            myResume._name = "Thomas Garcia";
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            myResume.Display();
        }
    }
}