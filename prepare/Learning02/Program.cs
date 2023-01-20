using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2022;
        job1._endYear = 2025;
        job1.DisplayJob();
        
        Job job2 = new Job();
        job2._jobTitle = "Designer";
        job2._company = "Vouge";
        job2._startYear = 2023;
        job2._endYear = 2025;
        job2.DisplayJob();

        Resume resume1 = new Resume();
        resume1._name = "Jim Carter";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

    }
}