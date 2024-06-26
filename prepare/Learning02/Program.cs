using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Rindegastos";
        job1._jobTitle = "Developer";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Yapp";
        job2._jobTitle = "Junior Web Developer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Joaquin Morales";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}