using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Customer Service Specialist";
        job1._company = "The Home Depot";
        job1._startYear = "2025";
        job1._endYear = "2026";

        Job job2 = new Job();
        job2._jobTitle = "Full Time Missionary";
        job2._company = "The Church of Jesus Christ of Latter-Day Saints";
        job2._startYear = "2023";
        job2._endYear = "2025";

        Resume yourResume = new Resume();
        yourResume._name = "Grady Petersen";
        yourResume._jobs.Add(job1);
        yourResume._jobs.Add(job2);
        yourResume.Display();

    }
}