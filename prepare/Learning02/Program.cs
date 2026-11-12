using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new Resume();
        resume1.name = "Warren Yorgesen";
        resume1.jobs.Add(new Job());
        resume1.jobs[0]._company = "Microsoft";
        resume1.jobs[0]._jobTitle = "Software Engineer";
        resume1.jobs[0]._startYear = 2019;
        resume1.jobs[0]._endYear = 2022;

        resume1.jobs.Add(new Job());
        resume1.jobs[1]._company = "Apple";
        resume1.jobs[1]._jobTitle = "Manager";
        resume1.jobs[1]._startYear = 2022;
        resume1.jobs[1]._endYear = 2023;

    resume1.Display();
    }
}