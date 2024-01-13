using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2018";
        job1._endYear = "2020";

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = "2011";
        job2._endYear = "2023";

        // job1.DisplayJobInformation();
        // job2.DisplayJobInformation();

        Resume resume = new Resume();
        resume._name = "Mauro Isa";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        // Console.WriteLine(resume._jobs[0]._jobTitle);
        resume.DisplayDetails();
    }
}