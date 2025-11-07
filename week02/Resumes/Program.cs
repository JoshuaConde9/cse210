using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "Teleperformance";
        job1._jobTitle = "Customer Expert";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._companyName = "Concentrix";
        job2._jobTitle = "Sales Representative";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Joshua Conde";
        myResume._jobs = [job1, job2];
        myResume.DisplayResume();
    }
}